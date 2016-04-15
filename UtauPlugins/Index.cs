using System;
using System.Windows.Forms;
using HUtau;
using System.Drawing;

namespace UtauPlugins
{
    public partial class Index : Form
    {
        private HTmpFile ust = null;
        private HMainEditor ustEditor = null;

        public Index(string filePath)
        {
            ust = new HTmpFile(filePath);
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            ustEditor = new HMainEditor(ust);
            ustEditor.Location = new Point(0, 0);
            ustEditor.Dock = DockStyle.Fill;
            Controls.Add(ustEditor);
        }
    }
}
