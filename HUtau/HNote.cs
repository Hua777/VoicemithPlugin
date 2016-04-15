using System.Drawing;

namespace HUtau
{
    public class HNote
    {
        public HNote()
        {
            Init();
        }

        public float Length;
        public string Lyric;
        public int NoteNum;
        public string Envelope;
        public string PreUtterance;
        public string VoiceOverlap;
        public string StartPoint;
        public string Velocity;
        public float Intensity;
        public string Modulation;
        public string Flags;
        public string Label;
        public float Tempo;
        public string PBS;
        public string PBW;
        public string PBY;
        public string PBM;
        public int PBType;
        public string PitchBend;
        public string VBR;
        public float _preuttr;
        public float _overlap;
        public float _stpoint;
        public string _filename;
        public string _cache;
        public string _alias;

        public Rectangle Brick;

        public NoteTypeInTmpFile NoteType;
        public string NoteTypeName
        {
            get
            {
                return HFunction.ToString(NoteType);
            }
        }

        public bool IsPrev
        {
            get
            {
                return NoteType == NoteTypeInTmpFile.Prev;
            }
        }
        public bool IsNext
        {
            get
            {
                return NoteType == NoteTypeInTmpFile.Next;
            }
        }
        public bool NeitherPrevNorNext
        {
            get
            {
                return !IsPrev && !IsNext;
            }
        }
        public bool EitherPrevOrNext
        {
            get
            {
                return IsPrev || IsNext;
            }
        }

        public bool IsRest
        {
            get
            {
                return ClearlyLyric == "R";
            }
        }
        public bool NotRest
        {
            get
            {
                return !IsRest;
            }
        }

        public bool IsMainNote
        {
            get
            {
                return NotRest && NeitherPrevNorNext;
            }
        }

        public string LyricPrefix
        {
            get
            {
                return HFunction.GetLyricPrefix(Lyric);
            }
        }
        public string LyricPostfix
        {
            get
            {
                return HFunction.GetLyricPostfix(Lyric);
            }
        }
        public string ClearlyLyric
        {
            get
            {
                string result = Lyric;
                if (LyricPrefix != "")
                {
                    result = result.Replace(LyricPrefix, "");
                }
                if (LyricPostfix != "")
                {
                    result = result.Replace(LyricPostfix, "");
                }
                return result;
            }
            set
            {
                Lyric = LyricPrefix + value + LyricPostfix;
            }
        }
        
        public PPFixName PPFix
        {
            get
            {
                return HFunction.GetLyricPPFixName(LyricPrefix, LyricPostfix);
            }
            set
            {
                string tmpPrefix = HFunction.GetLyricPrefix(value);
                string tmpPostfix = HFunction.GetLyricPostfix(value);
                string tmpClearlyLyric = ClearlyLyric;
                Lyric = tmpPrefix + tmpClearlyLyric + tmpPostfix;
            }
        }
        public PPFixName ChildPPFix
        {
            get
            {
                return HFunction.GetChildPPFixName(PPFix);
            }
        }

        private void Init()
        {
            Length = 480;
            Lyric = "a";
            NoteNum = 60;
            Envelope = "0 5 35 0 100 100 0 -1 0 10 100";
            PreUtterance = "";
            VoiceOverlap = "";
            StartPoint = "";
            Velocity = "";
            Intensity = 100;
            Modulation = "";
            Flags = "";
            Label = "";
            Tempo = 0;
            PBS = "";
            PBW = "";
            PBY = "";
            PBM = "";
            PBType = 5;
            PitchBend = "";
            VBR = "";
            _preuttr = 0;
            _overlap = 0;
            _stpoint = 0;
            _filename = "";
            _cache = "";
            _alias = "";

            Brick = new Rectangle(0, 0, 0, 0);

            NoteType = NoteTypeInTmpFile.Original;
        }

        public HNote Clone()
        {
            HNote newNote = new HNote();

            newNote.Length = Length;
            newNote.Lyric = Lyric;
            newNote.NoteNum = NoteNum;
            newNote.Envelope = Envelope;
            newNote.PreUtterance = PreUtterance;
            newNote.VoiceOverlap = VoiceOverlap;
            newNote.StartPoint = StartPoint;
            newNote.Velocity = Velocity;
            newNote.Intensity = Intensity;
            newNote.Modulation = Modulation;
            newNote.Flags = Flags;
            newNote.Label = Label;
            newNote.Tempo = Tempo;
            newNote.PBS = PBS;
            newNote.PBW = PBW;
            newNote.PBY = PBY;
            newNote.PBM = PBM;
            newNote.PBType = PBType;
            newNote.PitchBend = PitchBend;
            newNote.VBR = VBR;
            newNote._preuttr = _preuttr;
            newNote._overlap = _overlap;
            newNote._stpoint = _stpoint;
            newNote._filename = _filename;
            newNote._cache = _cache;
            newNote._alias = _alias;

            newNote.Brick = Brick;

            newNote.NoteType = NoteType;

            return newNote;
        }

        public override string ToString()
        {
            string result = "";
            result += NoteTypeName;
            result += "\r\n";
            result += "Length=" + Length;
            result += "\r\n";
            result += "Lyric=" + Lyric;
            result += "\r\n";
            result += "NoteNum=" + NoteNum;
            result += "\r\n";
            result += "Envelope=" + Envelope;
            result += "\r\n";
            result += "PreUtterance=" + PreUtterance;
            result += "\r\n";
            result += "VoiceOverlap=" + VoiceOverlap;
            result += "\r\n";
            result += "StartPoint=" + StartPoint;
            result += "\r\n";
            result += "Velocity=" + Velocity;
            result += "\r\n";
            result += "Intensity=" + Intensity;
            result += "\r\n";
            result += "Modulation=" + Modulation;
            result += "\r\n";
            result += "Flags=" + Flags;
            result += "\r\n";
            result += "Label=" + Label;
            result += "\r\n";
            if (Tempo > 0)
            {
                result += "Tempo=" + Tempo;
                result += "\r\n";
            }
            result += "PBS=" + PBS;
            result += "\r\n";
            result += "PBW=" + PBW;
            result += "\r\n";
            result += "PBY=" + PBY;
            result += "\r\n";
            result += "PBM=" + PBM;
            result += "\r\n";
            result += "PBType=" + PBType;
            result += "\r\n";
            result += "PitchBend=" + PitchBend;
            result += "\r\n";
            result += "VBR=" + VBR;
            result += "\r\n";
            result += "_preuttr=" + _preuttr;
            result += "\r\n";
            result += "_overlap=" + _overlap;
            result += "\r\n";
            result += "_stpoint=" + _stpoint;
            result += "\r\n";
            result += "_filename=" + _filename;
            result += "\r\n";
            result += "_cache=" + _cache;
            result += "\r\n";
            result += "_alias=" + _alias;
            result += "\r\n";
            return result;
        }
    }
}
