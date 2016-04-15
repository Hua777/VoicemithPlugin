using System;
using System.Windows.Forms;

namespace UtauPlugins
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length != 1)
                {
                    MessageBox.Show("Please open this plugin in UTAU.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Index(args[0]));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
