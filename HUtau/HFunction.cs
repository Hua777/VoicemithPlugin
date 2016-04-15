using System;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.International.Converters.PinYinConverter;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace HUtau
{
    public class HFunction
    {
        static public string GetLyricPrefix(string lyric)
        {
            if (lyric.Length >= 2 && lyric.Substring(0, 2) == "- ")
            {
                return "- ";
            }
            else
            {
                return "";
            }
        }

        static public string GetLyricPostfix(string lyric)
        {
            char[] detect = { '+', '_', '0', '-', '1' };
            int i, j, oriLength = lyric.Length;
            bool find = false;
            for (i = 1; i < oriLength; i++)
            {
                for (j = 0; j < detect.Length; j++)
                {
                    if (lyric[i] == detect[j])
                    {
                        find = true;
                        break;
                    }
                }
                if (find)
                {
                    break;
                }
            }
            if (find)
            {
                return lyric.Substring(i);
            }
            return "";
        }

        static public PPFixName GetLyricPPFixName(string lyricPrefix, string lyricPostfix)
        {
            if (lyricPrefix == "- " && lyricPostfix == "")
            {
                return PPFixName.XYYV3OutsideUniqueStrongVowel;
            }
            else if (lyricPrefix == "" && lyricPostfix == "")
            {
                return PPFixName.XYYV3OutsideUniqueObscureSound;
            }
            else if (lyricPrefix == "" && lyricPostfix == "+")
            {
                return PPFixName.XYYV3OutsideUniqueFullSound;
            }
            else if (lyricPrefix == "- " && lyricPostfix == "_i")
            {
                return PPFixName.XYYV3InsidePeaceStrongVowel;
            }
            else if (lyricPrefix == "" && lyricPostfix == "_i")
            {
                return PPFixName.XYYV3InsidePeaceObscureSound;
            }
            else if (lyricPrefix == "" && lyricPostfix == "+_i")
            {
                return PPFixName.XYYV3InsidePeaceFullSound;
            }
            else if (lyricPrefix == "- " && lyricPostfix == "0_iH")
            {
                return PPFixName.XYYV3InsideCantoStrongVowel;
            }
            else if (lyricPrefix == "" && lyricPostfix == "0_iH")
            {
                return PPFixName.XYYV3InsideCantoObscureSound;
            }
            else if (lyricPrefix == "" && lyricPostfix == "+0_iH")
            {
                return PPFixName.XYYV3InsideCantoFullSound;
            }
            else if (lyricPrefix == "- " && lyricPostfix == "-")
            {
                return PPFixName.XYYV3OtherMuffle;
            }
            else if (lyricPrefix == "- " && lyricPostfix == "1")
            {
                return PPFixName.XYYV3OtherSpecialDearStrongVowel;
            }
            else if (lyricPrefix == "" && lyricPostfix == "1")
            {
                return PPFixName.XYYV3OtherSpecialDearFullSound;
            }
            return PPFixName.NULL;
        }

        static public string GetLyricPrefix(PPFixName ppfn)
        {
            switch (ppfn)
            {
                case PPFixName.XYYV3OutsideUniqueStrongVowel:
                case PPFixName.XYYV3InsidePeaceStrongVowel:
                case PPFixName.XYYV3InsideCantoStrongVowel:
                case PPFixName.XYYV3OtherMuffle:
                case PPFixName.XYYV3OtherSpecialDearStrongVowel:
                    return "- ";
            }
            return "";
        }

        static public string GetLyricPostfix(PPFixName ppfn)
        {
            switch (ppfn)
            {
                case PPFixName.XYYV3OutsideUniqueStrongVowel:
                case PPFixName.XYYV3OutsideUniqueObscureSound:
                    return "";
                case PPFixName.XYYV3OutsideUniqueFullSound:
                    return "+";
                case PPFixName.XYYV3InsidePeaceStrongVowel:
                case PPFixName.XYYV3InsidePeaceObscureSound:
                    return "_i";
                case PPFixName.XYYV3InsidePeaceFullSound:
                    return "+_i";
                case PPFixName.XYYV3InsideCantoStrongVowel:
                case PPFixName.XYYV3InsideCantoObscureSound:
                    return "0_iH";
                case PPFixName.XYYV3InsideCantoFullSound:
                    return "+0_iH";
                case PPFixName.XYYV3OtherMuffle:
                    return "-";
                case PPFixName.XYYV3OtherSpecialDearStrongVowel:
                case PPFixName.XYYV3OtherSpecialDearFullSound:
                    return "1";
            }
            return "";
        }

        static public PPFixName GetChildPPFixName(PPFixName ppfn)
        {
            switch (ppfn)
            {
                case PPFixName.XYYV3OutsideUniqueStrongVowel:
                case PPFixName.XYYV3OutsideUniqueObscureSound:
                case PPFixName.XYYV3OutsideUniqueFullSound:
                    return PPFixName.XYYV3OutsideUniqueObscureSound;
                case PPFixName.XYYV3InsidePeaceStrongVowel:
                case PPFixName.XYYV3InsidePeaceObscureSound:
                case PPFixName.XYYV3InsidePeaceFullSound:
                    return PPFixName.XYYV3InsidePeaceObscureSound;
                case PPFixName.XYYV3InsideCantoStrongVowel:
                case PPFixName.XYYV3InsideCantoObscureSound:
                case PPFixName.XYYV3InsideCantoFullSound:
                    return PPFixName.XYYV3InsideCantoObscureSound;
                case PPFixName.XYYV3OtherMuffle:
                    return PPFixName.XYYV3OtherMuffle;
                case PPFixName.XYYV3OtherSpecialDearStrongVowel:
                case PPFixName.XYYV3OtherSpecialDearFullSound:
                    return PPFixName.XYYV3OtherSpecialDearFullSound;
            }
            return PPFixName.NULL;
        }

        static public string ToString(NoteTypeInTmpFile ntitf)
        {
            switch (ntitf)
            {
                case NoteTypeInTmpFile.Original:
                    return "[#0000]";
                case NoteTypeInTmpFile.Insert:
                    return "[#INSERT]";
                case NoteTypeInTmpFile.Delete:
                    return "[#DELETE]";
                case NoteTypeInTmpFile.Next:
                    return "[#NEXT]";
                case NoteTypeInTmpFile.Prev:
                    return "[#PREV]";
            }
            return "[#0000]";
        }

        static public bool MatchStringFromScratch(string origin, string want)
        {
            if (origin.Length >= want.Length)
            {
                if (origin.Substring(0, want.Length) == want)
                {
                    return true;
                }
            }
            return false;
        }

        static public int EditorHeight(float smaller)
        {
            return (int)(HData.NoteNumCountInUtau * HData.DefaultBrickHeight * smaller);
        }

        static public int EditorWidth(HTmpFile htf, float smaller)
        {
            int i, end = htf.Notes.Count;
            float adder = 0;
            for (i = 0; i < end; i++)
            {
                adder += htf[i].Length;
            }
            adder += HData.EditorAdditionWidth;
            return (int)(adder * smaller);
        }

        static public int EditorWidthBricks(HTmpFile htf)
        {
            int i, end = htf.Notes.Count;
            float adder = 0;
            for (i = 0; i < end; i++)
            {
                adder += htf[i].Length;
            }
            adder += HData.EditorAdditionWidth;
            return Convert.ToInt16(Math.Ceiling(adder / 480));
        }

        static public int EditorNoteLocationY(HNote hn, float smaller, int top)
        {
            return (int)(HData.DefaultBrickHeight * smaller * (HData.MaxNoteNumInUtau - hn.NoteNum - top));
        }

        static public int EditorNoteSizeY(HNote gn, float smaller)
        {
            return (int)(HData.DefaultBrickHeight * smaller);
        }

        static public int EditorNoteNoteNum(Point p, int scrolltop, float smaller)
        {
            p.Y += (int)(scrolltop * HData.DefaultBrickHeight * smaller);
            int num = (int)(p.Y / (HData.DefaultBrickHeight * smaller));
            num *= -1;
            num += 107;
            return num;
        }

        static public bool ObjectInRange(Rectangle rectangle, int x, int y)
        {
            Point endLocation = new Point(rectangle.X + rectangle.Width, rectangle.Y + rectangle.Height);
            if (endLocation.X >= 0 && endLocation.Y >= 0 && rectangle.X < x && rectangle.Y < y)
            {
                return true;
            }
            return false;
        }

        static public bool ObjectBetweenTwoPoint(Rectangle rectangle, Point start, Point end)
        {
            if (start.X > end.X)
            {
                Point tmp = start;
                start = end;
                end = tmp;
            }

            if (start.X <= rectangle.X + rectangle.Width && rectangle.X <= end.X)
            {
                return true;
            }
            return false;
        }

        static public bool ObjectContainsPoint(Rectangle rectangle, Point p)
        {
            if (rectangle.X <= p.X && p.X <= rectangle.X + rectangle.Width && rectangle.Y <= p.Y && p.Y <= rectangle.Y + rectangle.Height)
            {
                return true;
            }
            return false;
        }

        static public Font DetectFontFromHeight(FontFamily fontFamily, int height)
        {
            return new Font(fontFamily, DetectFontSizeFromHeight(fontFamily, height));
        }

        static public int DetectFontSizeFromHeight(FontFamily fontFamily, int height)
        {
            int i = 9;
            for (; ; i++)
            {
                Font textFont = new Font(fontFamily, i);
                Size textSize = TextRenderer.MeasureText("永", textFont);
                if (textSize.Height > height)
                {
                    break;
                }
            }
            return i - 1;
        }

        static public Size DetectSizeFromStringAndFont(string str, Font font)
        {
            return TextRenderer.MeasureText(str, font);
        }

        static public bool IsChinese(char anyChar)
        {
            bool bresult = true;
            int dRange = 0;
            int dstringmax = Convert.ToInt32("9fff", 16);
            int dstringmin = Convert.ToInt32("4e00", 16);
            dRange = Convert.ToInt32(anyChar);
            if (dRange >= dstringmin && dRange < dstringmax)
            {
                bresult = true;
            }
            else
            {
                bresult = false;
            }
            return bresult;
        }

        static public string MaintainChinese(string anyString)
        {
            int i, end = anyString.Length;
            string result = "";
            for (i = 0; i < end; i++)
            {
                if (IsChinese(anyString[i]))
                {
                    result += anyString[i];
                }
            }
            return result;
        }

        static public string HanZi2PinYin(string hanZi, Dictionary<string, string> priorityList)
        {
            string onlyChinese = MaintainChinese(hanZi);
            int i, end = onlyChinese.Length;
            string result = "";
            for (i = 0; i < end; i++)
            {
                if (i != 0)
                {
                    result += " ";
                }
                if (priorityList.ContainsKey(onlyChinese[i].ToString()))
                {
                    result += priorityList[onlyChinese[i].ToString()].ToLower();
                }
                else
                {
                    ChineseChar ch = new ChineseChar(onlyChinese[i]);
                    result += ch.Pinyins[0].Substring(0, ch.Pinyins[0].Length - 1).ToLower();
                }
            }
            return result;
        }

        static public string[] SpSplit(string anyString, char splitChar)
        {
            string[] tmp = anyString.Split(new char[] { splitChar });
            List<string> result = new List<string>();
            int i, end = tmp.Length;
            for(i=0;i< end; i++)
            {
                if (tmp[i] != "")
                {
                    result.Add(tmp[i]);
                }
            }
            return result.ToArray();
        }

        static public Encoding GetFileEncoding(string _path)
        {
            Stream reader = File.Open(_path, FileMode.Open, FileAccess.Read);
            Encoding encoder = null;
            byte[] header = new byte[4];
            reader.Read(header, 0, 4);
            if (header[0] == 0xFF && header[1] == 0xFE)
            {
                reader.Position = 2;
                encoder = Encoding.Unicode;
            }
            else if (header[0] == 0xEF && header[1] == 0xBB && header[2] == 0xBF)
            {
                reader.Position = 3;
                encoder = Encoding.UTF8;
            }
            else
            {
                reader.Position = 0;
                encoder = Encoding.Default;
            }
            byte[] buffer = new byte[1024];
            int source = reader.Read(buffer, 0, 1024);
            string sSource = string.Empty;
            while (source > 0)
            {
                sSource += encoder.GetString(buffer, 0, source);
                source = reader.Read(buffer, 0, 1024);
            }
            reader.Close();
            return encoder;
        }
    }
}
