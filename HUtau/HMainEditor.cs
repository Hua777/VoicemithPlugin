using System.Drawing;
using System.Windows.Forms;

namespace HUtau
{
    public partial class HMainEditor : UserControl
    {
        public HMainEditor(HTmpFile ust)
        {
            Ust = ust;
            InitializeComponent();
        }

        public HMainEditor(string filePath)
        {
            Ust = new HTmpFile(filePath);
            InitializeComponent();
        }

        private void HMainEditor_Load(object sender, System.EventArgs e)
        {
            InitCrontrols();
            SetScroller();
            DrawMain();
            DrawNotes();
            DrawLeft();
            DrawTop();
        }

        private void HMainEditor_SizeChanged(object sender, System.EventArgs e)
        {
            SetScroller();
            DrawMain();
            DrawNotes();
            DrawLeft();
            DrawTop();
        }

        private void InitCrontrols()
        {
            PB_MainNotes.Parent = PB_Main;
            PB_MainSelectLines.Parent = PB_MainNotes;
            PB_MainNotesMove.Parent = PB_MainSelectLines;
            PB_MainControl.Parent = PB_MainNotesMove;

            PB_LeftControl.Parent = PB_Left;

            PB_MainControl.MouseWheel += PB_MainControl_MouseWheel;
            LB_VoiceBank.Text = Ust.VoiceBankName;
        }

        private HTmpFile Ust = null;

        private float _XSmaller = 0.2F;
        private float _YSmaller = 0.6F;

        Bitmap MainBitmap = null;
        Bitmap MainNotesBitmap = null;
        Bitmap MainSelectLinesBitmap = null;

        Bitmap LeftBitmap = null;
        Bitmap LeftControlBitmap = null;

        Bitmap TopBitmap = null;

        private Point MouseDownPoint;
        private Point MouseUpPoint;

        private int SelectedNotesStartId = -1;
        private int SelectedNotesEndId = -1;
        private int MouseDownOnNoteId = -1;

        public int SelectedNotesCount
        {
            get
            {
                if (SelectedNotesStartId >= 0 && SelectedNotesEndId >= 0)
                {
                    return SelectedNotesEndId - SelectedNotesStartId + 1;
                }
                return 0;
            }
        }

        public MouseCursor MyTool = MouseCursor.Arrow;

        private MouseOn MouseDownOnWhat = MouseOn.Space;
        private NotesSelection NotesSelectionType = NotesSelection.UnChange;

        private void DetectMouseDownOn()
        {
            int i, end = Ust.Notes.Count;
            MouseDownOnWhat = MouseOn.Space;
            for (i = 0; i < end; i++)
            {
                if (HFunction.ObjectContainsPoint(Ust[i].Brick, MouseDownPoint))
                {
                    if (SelectedNotesStartId <= i && i <= SelectedNotesEndId)
                    {
                        MouseDownOnWhat = MouseOn.SelectedNotes;
                    }
                    else
                    {
                        SelectedNotesStartId = SelectedNotesEndId = i;
                        DrawNotes();
                        MouseDownOnWhat = MouseOn.UnSelectedNotes;
                    }
                    MouseDownOnNoteId = i;
                    return;
                }
            }
            MouseDownOnWhat = MouseOn.Space;
        }

        private void DetectNotesBetweenTwoPoints()
        {
            int i, end = Ust.Notes.Count;
            bool isStart = false;
            bool inner;
            NotesSelectionType = NotesSelection.UnChange;
            for (i = 0; i < end; i++)
            {
                inner = HFunction.ObjectBetweenTwoPoint(Ust[i].Brick, MouseDownPoint, MouseUpPoint);
                if (!isStart && inner)
                {
                    if (SelectedNotesStartId != i)
                    {
                        NotesSelectionType = NotesSelection.Changed;
                        SelectedNotesStartId = i;
                    }
                    isStart = true;
                }
                else if (isStart && !inner)
                {
                    break;
                }
            }
            if (isStart)
            {
                if (SelectedNotesEndId != i - 1)
                {
                    NotesSelectionType = NotesSelection.Changed;
                    SelectedNotesEndId = i - 1;
                }
            }
            else if (!isStart && SelectedNotesStartId != -1 && SelectedNotesEndId != -1)
            {
                SelectedNotesStartId = -1;
                SelectedNotesEndId = -1;
                NotesSelectionType = NotesSelection.Changed;
                return;
            }
        }

        private void SetScroller()
        {
            VSB.Maximum = 84 - (int)(PB_Main.Height / (HData.DefaultBrickHeight * _YSmaller));
            HSB.Maximum = HFunction.EditorWidthBricks(Ust);
        }

        private void DrawMain()
        {
            if (MainBitmap != null)
            {
                MainBitmap.Dispose();
            }
            MainBitmap = new Bitmap(PB_Main.Width, PB_Main.Height);
            Graphics mainGraphics = Graphics.FromImage(MainBitmap);

            Pen linesPenH = new Pen(Color.Gray);
            Pen linesPenH12 = new Pen(Color.DarkGray);
            Pen linesPenV = new Pen(Color.CadetBlue);
            Pen linesPenV4 = new Pen(Color.Purple);

            SolidBrush linesBricksBrush = new SolidBrush(Color.LightGray);
            Rectangle linesBricksRectangle = new Rectangle(0, 0, PB_Main.Width, (int)(HData.DefaultBrickHeight * _YSmaller));

            mainGraphics.Clear(Color.White);

            int i, tmpi;

            Point tmpLineStart = new Point(0, 0);
            Point tmpLineEnd = new Point(0, 0);

            /*
            Draw H Lines
            */
            tmpLineStart.X = 0;
            tmpLineEnd.X = PB_Main.Width;
            for (i = 0; ; i++)
            {
                tmpi = i % 12;

                tmpLineStart.Y = tmpLineEnd.Y = (int)((i - VSB.Value) * HData.DefaultBrickHeight * _YSmaller);
                if (tmpLineStart.Y >= PB_Main.Height)
                {
                    break;
                }

                if(tmpi == 1 || tmpi == 3 || tmpi == 5 || tmpi == 8 || tmpi == 10)
                {
                    linesBricksRectangle.Y = tmpLineStart.Y;
                    mainGraphics.FillRectangle(linesBricksBrush, linesBricksRectangle);
                }

                if (tmpi == 0)
                {
                    mainGraphics.DrawLine(linesPenH12, tmpLineStart, tmpLineEnd);
                }
                else
                {
                    mainGraphics.DrawLine(linesPenH, tmpLineStart, tmpLineEnd);
                }
            }

            /*
            Draw V Lines
            */
            tmpLineStart.Y = 0;
            tmpLineEnd.Y = PB_Main.Height;
            for (i = 0; ; i++)
            {
                tmpLineStart.X = tmpLineEnd.X = (int)((i - HSB.Value) * HData.DefaultNoteLength * _XSmaller);
                if (tmpLineStart.X >= PB_Main.Width)
                {
                    break;
                }
                if (i % 4 == 0)
                {
                    mainGraphics.DrawLine(linesPenV4, tmpLineStart, tmpLineEnd);
                }
                else
                {
                    mainGraphics.DrawLine(linesPenV, tmpLineStart, tmpLineEnd);
                }
            }

            mainGraphics.Dispose();
            PB_Main.Image = MainBitmap;
        }

        private void DrawNotes()
        {
            if (MainNotesBitmap != null)
            {
                MainNotesBitmap.Dispose();
            }
            MainNotesBitmap = new Bitmap(PB_Main.Width, PB_Main.Height);
            Graphics mainNotesGraphics = Graphics.FromImage(MainNotesBitmap);

            mainNotesGraphics.Clear(Color.Transparent);

            SolidBrush notesSelectedBrush = new SolidBrush(Color.Pink);
            SolidBrush notesBrush = new SolidBrush(Color.CadetBlue);
            SolidBrush notesRestSelectedBrush = new SolidBrush(Color.DarkGray);
            SolidBrush notesRestBrush = new SolidBrush(Color.White);
            Pen notesPen = new Pen(Color.Black);
            SolidBrush notesLyricBrush = new SolidBrush(Color.Black);
            Font notesLyricFont = HFunction.DetectFontFromHeight(Font.FontFamily, (int)(HData.DefaultBrickHeight * _YSmaller));

            int i, end = Ust.Notes.Count;
            int tmpLocationXAdder = 0;
            for (i = 0; i < end; i++)
            {
                Ust[i].Brick.X = (int)(tmpLocationXAdder - HSB.Value * HData.DefaultNoteLength * _XSmaller);
                Ust[i].Brick.Y = HFunction.EditorNoteLocationY(Ust[i], _YSmaller, VSB.Value);
                Ust[i].Brick.Width = (int)(Ust[i].Length * _XSmaller);
                Ust[i].Brick.Height = HFunction.EditorNoteSizeY(Ust[i], _YSmaller);

                if (HFunction.ObjectInRange(Ust[i].Brick, PB_Main.Width, PB_Main.Height))
                {
                    if (SelectedNotesStartId <= i && i <= SelectedNotesEndId)
                    {
                        if (Ust[i].IsRest)
                        {
                            mainNotesGraphics.FillRectangle(notesRestSelectedBrush, Ust[i].Brick);
                        }
                        else
                        {
                            mainNotesGraphics.FillRectangle(notesSelectedBrush, Ust[i].Brick);
                        }
                    }
                    else
                    {
                        if (Ust[i].IsRest)
                        {
                            mainNotesGraphics.FillRectangle(notesRestBrush, Ust[i].Brick);
                        }
                        else
                        {
                            mainNotesGraphics.FillRectangle(notesBrush, Ust[i].Brick);
                        }
                    }
                    mainNotesGraphics.DrawRectangle(notesPen, Ust[i].Brick);
                    mainNotesGraphics.DrawString(Ust[i].Lyric, notesLyricFont, notesLyricBrush, Ust[i].Brick.Location);
                }

                tmpLocationXAdder += Ust[i].Brick.Width;
            }

            mainNotesGraphics.Dispose();
            PB_MainNotes.Image = MainNotesBitmap;
        }

        private void DrawSelectLines()
        {
            if (MainSelectLinesBitmap != null)
            {
                MainSelectLinesBitmap.Dispose();
            }
            MainSelectLinesBitmap = new Bitmap(PB_Main.Width, PB_Main.Height);
            Graphics mainSelectLinesGraphics = Graphics.FromImage(MainSelectLinesBitmap);

            mainSelectLinesGraphics.Clear(Color.Transparent);

            Pen selectLinePen = new Pen(Color.Red);

            Point startStart = MouseDownPoint;
            Point startEnd = MouseDownPoint;
            Point endStart = MouseUpPoint;
            Point endEnd = MouseUpPoint;

            startStart.Y = endStart.Y = 0;
            startEnd.Y = endEnd.Y = PB_Main.Height;

            mainSelectLinesGraphics.DrawLine(selectLinePen, startStart, startEnd);
            mainSelectLinesGraphics.DrawLine(selectLinePen, endStart, endEnd);

            mainSelectLinesGraphics.Dispose();
            PB_MainSelectLines.Image = MainSelectLinesBitmap;
        }

        private void ClearSelectLines()
        {
            PB_MainSelectLines.Image = null;
        }

        private void DrawMovedNotes()
        {
            int NowCursorNoteNum = HFunction.EditorNoteNoteNum(MouseUpPoint, VSB.Value, _YSmaller);
            HNote[] newNotes = new HNote[SelectedNotesCount];
            int i, j, s = MouseDownOnNoteId - SelectedNotesStartId;
            for (j = 0, i = SelectedNotesStartId; i <= SelectedNotesEndId; j++, i++)
            {
                newNotes[j] = Ust[i].Clone();
            }
        }

        private void DrawLeft()
        {
            if (LeftBitmap != null)
            {
                LeftBitmap.Dispose();
            }
            LeftBitmap = new Bitmap(PB_Left.Width, PB_Left.Height);
            Graphics leftGraphics = Graphics.FromImage(LeftBitmap);

            Pen leftWhiteBricksPen = new Pen(Color.Black);
            SolidBrush leftBlackBricksSolidBrush = new SolidBrush(Color.Black);

            leftGraphics.Clear(Color.White);

            int i, tmpi;

            /*
            Draw Line
            */
            Point tmpLineStart = new Point(0, 0);
            Point tmpLineEnd = new Point(0, 0);

            Rectangle tmpBlackRectangle = new Rectangle(0, 0, PB_Left.Width / 2, (int)(HData.DefaultBrickHeight * _YSmaller));

            int tmpLineLocationYAdder = 0;

            tmpLineStart.X = 0;
            tmpLineEnd.X = PB_Left.Width;

            for (i = 0; ; i++)
            {
                tmpi = i % 7;

                tmpLineStart.Y = tmpLineEnd.Y = (int)((tmpLineLocationYAdder - VSB.Value * HData.DefaultBrickHeight) * _YSmaller);

                if (tmpLineStart.Y >= PB_Left.Height)
                {
                    break;
                }

                leftGraphics.DrawLine(leftWhiteBricksPen, tmpLineStart, tmpLineEnd);

                if (tmpi == 1 || tmpi == 2 || tmpi == 3 || tmpi == 5 || tmpi == 6)
                {
                    tmpBlackRectangle.Y = tmpLineStart.Y - (int)(HData.DefaultBrickHeight * _YSmaller / 2);
                    leftGraphics.FillRectangle(leftBlackBricksSolidBrush, tmpBlackRectangle);
                }

                if (tmpi == 0 || tmpi == 3 || tmpi == 4 || tmpi == 6)
                {
                    tmpLineLocationYAdder += HData.DefaultPiano34Height;
                }
                else
                {
                    tmpLineLocationYAdder += HData.DefaultPianoHeight;
                }
            }

            leftGraphics.Dispose();
            PB_Left.Image = LeftBitmap;
        }

        private void DrawTop()
        {
            if (TopBitmap != null)
            {
                TopBitmap.Dispose();
            }
            TopBitmap = new Bitmap(PB_Top.Width, PB_Top.Height);
            Graphics topGraphics = Graphics.FromImage(TopBitmap);

            topGraphics.Clear(Color.White);

            SolidBrush sectionBrush = new SolidBrush(Color.Black);
            Font sectionFont = HFunction.DetectFontFromHeight(Font.FontFamily, PB_Top.Height);
            string sectionName;
            Point sectionPoint = new Point(0, 0);

            int i;

            int sectionXAdder = 0;

            for (i = 0; ; i++)
            {
                if (sectionPoint.X >= PB_Top.Width)
                {
                    break;
                }

                if (i % 4 == 0)
                {
                    sectionName = (i / 4).ToString();
                    sectionPoint.X = sectionXAdder - (int)(HSB.Value * HData.DefaultNoteLength * _XSmaller);
                    topGraphics.DrawString(sectionName, sectionFont, sectionBrush, sectionPoint);
                }

                sectionXAdder += (int)(HData.DefaultNoteLength * _XSmaller);
            }

            topGraphics.Dispose();
            PB_Top.Image = TopBitmap;
        }

        private void DrawScale(Point location)
        {
            int y = location.Y;
            y += (int)(VSB.Value * HData.DefaultBrickHeight * _YSmaller);
            int result = y / (int)(HData.DefaultBrickHeight * _YSmaller);

            if (result >= 0 && result < HData.Scale.Length)
            {
                if (LeftControlBitmap != null)
                {
                    LeftControlBitmap.Dispose();
                }
                LeftControlBitmap = new Bitmap(PB_LeftControl.Width, PB_LeftControl.Height);
                Graphics leftControlGraphics = Graphics.FromImage(LeftControlBitmap);

                leftControlGraphics.Clear(Color.Transparent);

                SolidBrush scaleSolidBrush = new SolidBrush(Color.Blue);
                Font scaleFont = HFunction.DetectFontFromHeight(Font.FontFamily, (int)(HData.DefaultBrickHeight * _YSmaller));
                string scale = HData.Scale[result];
                Size scaleSize = HFunction.DetectSizeFromStringAndFont(scale, scaleFont);
                Point scaleLocation = new Point(PB_LeftControl.Width - scaleSize.Width, (int)((result - VSB.Value) * HData.DefaultBrickHeight * _YSmaller));

                leftControlGraphics.DrawString(scale, scaleFont, scaleSolidBrush, scaleLocation);

                leftControlGraphics.Dispose();
                PB_LeftControl.Image = LeftControlBitmap;
            }
        }

        private bool ScrollTo(ScrollDirect sd, int num)
        {
            if (sd == ScrollDirect.Left && HSB.Value - num >= 0 && HSB.Value - num <= HSB.Maximum)
            {
                HSB.Value -= num;
            }
            else if (sd == ScrollDirect.Right && HSB.Value + num >= 0 && HSB.Value + num <= HSB.Maximum)
            {
                HSB.Value += num;
            }
            else if (sd == ScrollDirect.Top && VSB.Value - num >= 0 && VSB.Value - num <= VSB.Maximum)
            {
                VSB.Value -= num;
            }
            else if (sd == ScrollDirect.Bottom && VSB.Value + num >= 0 && VSB.Value + num <= VSB.Maximum)
            {
                VSB.Value += num;
            }
            else
            {
                return false;
            }
            return true;
        }

        private void SmallerChange(Smaller smaller, bool bigger)
        {
            if (smaller == Smaller.X)
            {
                if (bigger && _XSmaller + HData.SmallerAdder <= HData.MaxXSmaller)
                {
                    _XSmaller += HData.SmallerAdder;
                    SetScroller();
                    DrawMain();
                    DrawNotes();
                    DrawTop();
                }
                else if (!bigger && _XSmaller - HData.SmallerAdder >= HData.MinXSmaller)
                {
                    _XSmaller -= HData.SmallerAdder;
                    SetScroller();
                    DrawMain();
                    DrawNotes();
                    DrawTop();
                }
            }
            else if (smaller == Smaller.Y)
            {
                if (bigger && _YSmaller + HData.SmallerAdder <= HData.MaxYSmaller)
                {
                    _YSmaller += HData.SmallerAdder;
                    SetScroller();
                    DrawMain();
                    DrawNotes();
                    DrawLeft();
                }
                else if (!bigger && _YSmaller - HData.SmallerAdder >= HData.MinYSmaller)
                {
                    _YSmaller -= HData.SmallerAdder;
                    SetScroller();
                    DrawMain();
                    DrawNotes();
                    DrawLeft();
                }
            }
        }

        private void PB_MainControl_MouseWheel(object sender, MouseEventArgs e)
        {
            if (ModifierKeys == Keys.Control)
            {
                bool bigger = (e.Delta > 0) ? true : false;
                SmallerChange(Smaller.X, bigger);
            }
            else if (ModifierKeys == (Keys.Control | Keys.Shift))
            {
                bool bigger = (e.Delta > 0) ? true : false;
                SmallerChange(Smaller.Y, bigger);
            }
            else if (ModifierKeys == Keys.Shift)
            {
                int sValue = e.Delta / 120;
                sValue *= -1;
                ScrollTo(ScrollDirect.Right, sValue);
            }
            else if (ModifierKeys == Keys.None)
            {
                int sValue = e.Delta / 120;
                sValue *= -1;
                ScrollTo(ScrollDirect.Bottom, sValue);
            }
        }

        private void PB_MainControl_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDownPoint = e.Location;
            DetectMouseDownOn();
        }

        private void PB_MainControl_MouseMove(object sender, MouseEventArgs e)
        {
            MouseUpPoint = e.Location;
            if (MyTool == MouseCursor.Arrow)
            {
                if (e.Button == MouseButtons.Left)
                {
                    if (MouseUpPoint.X < 0 && ScrollTo(ScrollDirect.Left, 1))
                    {
                        MouseDownPoint.X += (int)(HData.DefaultNoteLength * _XSmaller);
                    }
                    else if (MouseUpPoint.X >= PB_Main.Width && ScrollTo(ScrollDirect.Right, 1))
                    {
                        MouseDownPoint.X -= (int)(HData.DefaultNoteLength * _XSmaller);
                    }
                    else if (MouseUpPoint.Y < 0 && ScrollTo(ScrollDirect.Top, 1))
                    {
                        MouseDownPoint.Y += (int)(HData.DefaultBrickHeight * _YSmaller);
                    }
                    else if (MouseUpPoint.Y >= PB_Main.Height && ScrollTo(ScrollDirect.Bottom, 1))
                    {
                        MouseDownPoint.X -= (int)(HData.DefaultBrickHeight * _YSmaller);
                    }
                    else if (NotesSelectionType == NotesSelection.Changed)
                    {
                        DrawNotes();
                    }

                    if (MouseDownOnWhat == MouseOn.Space)
                    {
                        DetectNotesBetweenTwoPoints();
                        DrawSelectLines();
                    }
                    else if (MouseDownOnWhat == MouseOn.SelectedNotes || MouseDownOnWhat == MouseOn.UnSelectedNotes) 
                    {
                        DrawMovedNotes();
                    }
                }
                else if (e.Button == MouseButtons.None)
                {
                    DrawScale(e.Location);
                }
            }
        }

        private void PB_MainControl_MouseUp(object sender, MouseEventArgs e)
        {
            MouseUpPoint = e.Location;
            ClearSelectLines();
        }

        private void PB_LeftControl_MouseMove(object sender, MouseEventArgs e)
        {
            DrawScale(e.Location);
        }

        private void VSB_ValueChanged(object sender, System.EventArgs e)
        {
            DrawMain();
            DrawNotes();
            DrawLeft();
        }

        private void HSB_ValueChanged(object sender, System.EventArgs e)
        {
            DrawMain();
            DrawNotes();
            DrawTop();
        }

        private void HMainEditor_KeyDown(object sender, KeyEventArgs e)
        {
            if (ModifierKeys == Keys.Control && e.KeyCode == Keys.A)
            {
                //Select all notes
            }
        }
    }
}
