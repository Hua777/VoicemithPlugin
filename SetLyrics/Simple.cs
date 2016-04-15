using System;
using System.Windows.Forms;
using HUtau;
using System.Drawing;
using System.Collections.Generic;
using System.IO;

namespace SetLyrics
{
    public partial class Simple : Form
    {
        private HTmpFile TmpFile;

        private PPFixName SelectPen = PPFixName.XYYV3OutsideUniqueObscureSound;

        private Dictionary<string, string> PriorityList = PriorityEditor.GetList("Sub.txt");

        public Simple(string _path)
        {
            TmpFile = new HTmpFile(_path);
            InitializeComponent();
        }

        private void Index_Load(object sender, EventArgs e)
        {
            SetPensButton();
            HLE.Init(TmpFile);
            HLE.InitNotesColor(BTN_OutsideUniqueStrongVowel.BackColor,
                BTN_InsidePeaceStrongVowel.BackColor,
                BTN_InsideCantoStrongVowel.BackColor,
                BTN_Muffle.BackColor,
                Color.Gray);
            FocusOnTextarea(ChgTextarea.Before);
        }
        private void Index_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Save();
        }

        private void SetPensButton()
        {
            BTN_OutsideUniqueStrongVowel.Tag = PPFixName.XYYV3OutsideUniqueStrongVowel;
            BTN_OutsideUniqueObscureSound.Tag = PPFixName.XYYV3OutsideUniqueObscureSound;
            BTN_OutsideUniqueFullSound.Tag = PPFixName.XYYV3OutsideUniqueFullSound;

            BTN_InsidePeaceStrongVowel.Tag = PPFixName.XYYV3InsidePeaceStrongVowel;
            BTN_InsidePeaceObscureSound.Tag = PPFixName.XYYV3InsidePeaceObscureSound;
            BTN_InsidePeaceFullSound.Tag = PPFixName.XYYV3InsidePeaceFullSound;

            BTN_InsideCantoStrongVowel.Tag = PPFixName.XYYV3InsideCantoStrongVowel;
            BTN_InsideCantoObscureSound.Tag = PPFixName.XYYV3InsideCantoObscureSound;
            BTN_InsideCantoFullSound.Tag = PPFixName.XYYV3InsideCantoFullSound;

            BTN_Muffle.Tag = PPFixName.XYYV3OtherMuffle;
        }

        private void BTN_Changer_Click(object sender, EventArgs e)
        {
            string output = TB_BeforeChange.Text;
            if (output != "")
            {
                TB_AfterChange.Text = HFunction.HanZi2PinYin(output, PriorityList);
                FocusOnTextarea(ChgTextarea.After);
            }
        }
        private void TB_BeforeChange_MouseClick(object sender, MouseEventArgs e)
        {
            FocusOnTextarea(ChgTextarea.Before);
        }
        private void TB_AfterChange_MouseClick(object sender, MouseEventArgs e)
        {
            FocusOnTextarea(ChgTextarea.After);
        }
        private void FocusOnTextarea(ChgTextarea _ct)
        {
            switch (_ct)
            {
                case ChgTextarea.Before:
                    TLP_TextChanger.ColumnStyles[0].Width = 90F;
                    TLP_TextChanger.ColumnStyles[2].Width = 10F;
                    break;
                case ChgTextarea.After:
                    TLP_TextChanger.ColumnStyles[0].Width = 10F;
                    TLP_TextChanger.ColumnStyles[2].Width = 90F;
                    break;
            }
        }
        private void TB_AfterChange_TextChanged(object sender, EventArgs e)
        {
            string output = TB_AfterChange.Text;
            if (output != "")
            {
                string[] newLyrics = HFunction.SpSplit(output, ' ');
                int i, j, end1 = newLyrics.Length, end2 = TmpFile.Count;
                for (i = 0, j = 0; i < end2 && j < end1; i++)
                {
                    if (TmpFile[i].IsMainNote)
                    {
                        TmpFile[i].ClearlyLyric = newLyrics[j];
                        j++;
                    }
                }
                HLE.Redraw();
            }
        }

        private void TB_BeforeChange_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop, false))
            {
                e.Effect = DragDropEffects.All;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }
        private void TB_BeforeChange_DragDrop(object sender, DragEventArgs e)
        {
            string path = ((string[])e.Data.GetData(DataFormats.FileDrop)).GetValue(0).ToString();
            string readFile = File.ReadAllText(path, HFunction.GetFileEncoding(path));
            readFile = HFunction.MaintainChinese(readFile);
            TB_BeforeChange.Text = readFile;
        }

        private void BTN_Complete_Click(object sender, EventArgs e)
        {
            TmpFile.Save();
            Close();
        }
        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void BTN_Pens_Click(object sender, EventArgs e)
        {
            Button tmpBTN = (Button)sender;
            SelectPen = (PPFixName)tmpBTN.Tag;
            Voice.Talk(SelectPen);
        }

        private void LB_Egg_Click(object sender, EventArgs e)
        {
            Voice.Egg();
        }

        private void HLE_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left && HLE.MouseOnNote != null)
            {
                if (HLE.MouseOnNote.IsMainNote)
                {
                    HLE.MouseOnNote.PPFix = SelectPen;
                    HLE.Redraw();
                }
            }
        }

        private void BTN_Priority_Click(object sender, EventArgs e)
        {
            PriorityEditor pe = new PriorityEditor("Sub.txt");
            if (pe.ShowDialog() == DialogResult.OK)
            {
                PriorityList = PriorityEditor.GetList("Sub.txt");
            }
        }
    }

    enum ChgTextarea
    {
        Before,
        After
    }
}
