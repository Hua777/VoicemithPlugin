using System;
using System.Drawing;
using System.Windows.Forms;

namespace HUtau
{
    public partial class HLineEditor : UserControl
    {
        private HTmpFile TmpFile = null;
        private float XSmaller = 0.2F;
        private bool IsInit = false;

        private Pen P_Border = new Pen(Color.Black);

        private SolidBrush SB_Lyrics = new SolidBrush(Color.Black);

        private Font F_Lyrics = new Font(DefaultFont.FontFamily, 12);

        private SolidBrush SB_Outside = new SolidBrush(Color.White);
        private SolidBrush SB_Peace = new SolidBrush(Color.White);
        private SolidBrush SB_Canto = new SolidBrush(Color.White);
        private SolidBrush SB_Muffle = new SolidBrush(Color.White);

        private SolidBrush SB_Rest = new SolidBrush(Color.Gray);

        private SolidBrush SB_Default = new SolidBrush(Color.White);

        private int ScrollValue
        {
            get
            {
                return HSB.Value;
            }
            set
            {
                if (value < 0)
                {
                    HSB.Value = 0;
                }
                else if (value > HSB.Maximum)
                {
                    HSB.Value = HSB.Maximum;
                }
                else
                {
                    HSB.Value = value;
                }
            }
        }
        private int ScrollMax
        {
            set
            {
                HSB.Maximum = value;
            }
        }

        private HNote _MouseOnNote = null;

        public HNote MouseOnNote
        {
            get
            {
                return _MouseOnNote;
            }
        }



        public HLineEditor()
        {
            InitializeComponent();
        }

        private void HLineEditor_Load(object sender, EventArgs e)
        {
            PB_Notes.MouseWheel += PB_Notes_MouseWheel;

            DetectFont();
        }

        private void HLineEditor_Resize(object sender, EventArgs e)
        {
            DetectFont();
            DetectNotesBricks();
            DetectScrollMax();
            DrawNotes();
        }

        private void HSB_ValueChanged(object sender, EventArgs e)
        {
            DetectNotesBricks();
            DrawNotes();
        }

        private void PB_Notes_MouseMove(object sender, MouseEventArgs e)
        {
            int i, end = TmpFile.Count;
            for (i = 0; i < end; i++)
            {
                if (HFunction.ObjectContainsPoint(TmpFile[i].Brick, e.Location))
                {
                    _MouseOnNote = TmpFile[i];
                    this.OnMouseMove(e);
                    return;
                }
            }
            _MouseOnNote = null;
        }

        private void PB_Notes_MouseWheel(object sender, MouseEventArgs e)
        {
            int x = e.Delta;
            if (ModifierKeys == Keys.Control)
            {
                if (x > 0)
                {
                    Smaller(false);
                }
                else if (x < 0)
                {
                    Smaller(true);
                }
            }
            else if (ModifierKeys == Keys.None)
            {
                if (x > 0)
                {
                    ScrollValue -= (int)(HData.DefaultNoteLength * XSmaller);
                }
                else if (x < 0)
                {
                    ScrollValue += (int)(HData.DefaultNoteLength * XSmaller);
                }
            }
        }

        /// <summary>
        /// 初始化此控制項 Important
        /// </summary>
        /// <param name="_tmpFile">UTAU Tmp 檔案</param>
        public void Init(HTmpFile _tmpFile)
        {
            IsInit = true;
            TmpFile = _tmpFile;
            DetectNotesBricks();
            DetectScrollMax();
            DrawNotes();
        }

        /// <summary>
        /// 初始化 Notes 的顏色
        /// </summary>
        /// <param name="_outside">Outside 顏色</param>
        /// <param name="_peace">Peace 顏色</param>
        /// <param name="_canto">Canto 顏色</param>
        /// <param name="_muffle">Muffle 顏色</param>
        /// <param name="_rest">Rest 顏色</param>
        public void InitNotesColor(Color _outside, Color _peace, Color _canto, Color _muffle, Color _rest)
        {
            SB_Outside = new SolidBrush(_outside);
            SB_Peace = new SolidBrush(_peace);
            SB_Canto = new SolidBrush(_canto);
            SB_Muffle = new SolidBrush(_muffle);
            SB_Rest = new SolidBrush(_rest);
            DrawNotes();
        }

        /// <summary>
        /// 初始化 Notes 邊框顏色
        /// </summary>
        /// <param name="_border">邊框顏色</param>
        public void InitBorderColor(Color _border)
        {
            P_Border = new Pen(_border);
            DrawNotes();
        }

        /// <summary>
        /// 初始化 Notes 的 Lyrics 顏色
        /// </summary>
        /// <param name="_lyrics">Lyrics 顏色</param>
        public void InitLyricsColor(Color _lyrics)
        {
            SB_Lyrics = new SolidBrush(_lyrics);
            DrawNotes();
        }

        /// <summary>
        /// 設置放大倍率
        /// </summary>
        /// <param name="_xSmaller">倍率</param>
        public void Smaller(bool _s)
        {
            if (_s)
            {
                if (XSmaller - HData.SmallerAdder >= HData.MinXSmaller)
                {
                    XSmaller -= HData.SmallerAdder;
                }
            }
            else
            {
                if (XSmaller + HData.SmallerAdder <= HData.MaxXSmaller)
                {
                    XSmaller += HData.SmallerAdder;
                }
            }
            DetectNotesBricks();
            DetectScrollMax();
            DrawNotes();
        }

        /// <summary>
        /// 偵測 Font 需要的大小
        /// </summary>
        private void DetectFont()
        {
            int tmpSize = HFunction.DetectFontSizeFromHeight(DefaultFont.FontFamily, PB_Notes.Height);
            tmpSize -= 20;
            if (tmpSize < 9)
            {
                tmpSize = 9;
            }
            F_Lyrics = new Font(DefaultFont.FontFamily, tmpSize);
        }

        /// <summary>
        /// 取得該 Note 對應的畫筆
        /// </summary>
        /// <param name="_note">Note</param>
        /// <returns></returns>
        private SolidBrush GetNoteBrush(HNote _note)
        {
            if (!_note.IsMainNote)
            {
                return SB_Rest;
            }
            switch (_note.PPFix)
            {
                case PPFixName.XYYV3OutsideUniqueStrongVowel:
                case PPFixName.XYYV3OutsideUniqueObscureSound:
                case PPFixName.XYYV3OutsideUniqueFullSound:
                    return SB_Outside;
                case PPFixName.XYYV3InsidePeaceStrongVowel:
                case PPFixName.XYYV3InsidePeaceObscureSound:
                case PPFixName.XYYV3InsidePeaceFullSound:
                    return SB_Peace;
                case PPFixName.XYYV3InsideCantoStrongVowel:
                case PPFixName.XYYV3InsideCantoObscureSound:
                case PPFixName.XYYV3InsideCantoFullSound:
                    return SB_Canto;
                case PPFixName.XYYV3OtherMuffle:
                    return SB_Muffle;
                case PPFixName.XYYV3OtherSpecialDearStrongVowel:
                case PPFixName.XYYV3OtherSpecialDearFullSound:
                    return SB_Default;
            }
            return SB_Rest;
        }

        /// <summary>
        /// 偵測 Scroll Bar 捲動最大值
        /// </summary>
        private void DetectScrollMax()
        {
            if (IsInit)
            {
                int end = TmpFile.Count;
                int result = (int)(TmpFile.Length * XSmaller - PB_Notes.Width + HData.DefaultNoteLength * XSmaller);
                if(result <= 0)
                {
                    HSB.Visible = false;
                    ScrollMax = 0;
                }
                else
                {
                    HSB.Visible = true;
                    HSB.LargeChange = (int)(PB_Notes.Width / (TmpFile.Length * XSmaller) * 100);
                    ScrollMax = result;
                }
            }
        }

        /// <summary>
        /// 判斷每一個 Notes 的位置
        /// </summary>
        private void DetectNotesBricks()
        {
            if (IsInit)
            {
                int i, end = TmpFile.Count;
                int x = -1 * ScrollValue, y = 0, w = 0, h = PB_Notes.Height - 1;
                for (i = 0; i < end; i++)
                {
                    w = (int)(TmpFile[i].Length * XSmaller) - 1;
                    TmpFile[i].Brick = new Rectangle(x, y, w, h);
                    x += TmpFile[i].Brick.Width;
                }
            }
        }

        /// <summary>
        /// 畫出所有Notes
        /// </summary>
        private void DrawNotes()
        {
            if (IsInit)
            {
                Bitmap bm = new Bitmap(PB_Notes.Width, PB_Notes.Height);
                Graphics g = Graphics.FromImage(bm);

                int i, end = TmpFile.Count;
                for (i = 0; i < end; i++)
                {
                    g.FillRectangle(GetNoteBrush(TmpFile[i]), TmpFile[i].Brick);
                    g.DrawRectangle(P_Border, TmpFile[i].Brick);
                    g.DrawString(TmpFile[i].Lyric, F_Lyrics, SB_Lyrics, TmpFile[i].Brick.Location);
                }

                PB_Notes.Image = bm;
                g.Dispose();
            }
        }

        public void Redraw()
        {
            DrawNotes();
        }
    }
}
