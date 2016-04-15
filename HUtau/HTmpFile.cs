using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;

namespace HUtau
{
    public class HTmpFile
    {
        public HTmpFile(string filePath)
        {
            Init();
            FilePath = filePath;
            Read();
            ReadCharacter();
        }

        public HNote this[int index]
        {
            get
            {
                if (index < Notes.Count)
                {
                    return Notes[index];
                }
                return null;
            }
            set
            {
                if (index < Notes.Count)
                {
                    Notes[index] = value;
                }
            }
        }

        public string Version;
        public string Charset;
        public float Tempo;
        public int Tracks;
        public string ProjectName;
        public string VoiceDir;
        public string OutFile;
        public string CacheDir;
        public string Tool1;
        public string Tool2;
        public bool Mode2;
        public string Flags;

        public string VoiceBankName;
        public Bitmap VoiceBankIcon;

        private string FilePath;
        public List<HNote> Notes;

        public bool HavePrev
        {
            get
            {
                if (Notes.Count > 0 && Notes[0].IsPrev)
                {
                    return true;
                }
                return false;
            }
        }
        public bool HaveNext
        {
            get
            {
                if (Notes.Count > 0 && Notes[Notes.Count - 1].IsNext)
                {
                    return true;
                }
                return false;
            }
        }

        public float Length
        {
            get
            {
                int i, end = Count;
                float result = 0;
                for (i = 0; i < end; i++)
                {
                    result += Notes[i].Length;
                }
                return result;
            }
        }
        public int Count
        {
            get
            {
                return Notes.Count;
            }
        }

        private void Init()
        {
            Version = "UST Version1.2";
            Charset = "";
            Tempo = 120.0F;
            Tracks = 1;
            ProjectName = "New Project";
            VoiceDir = "";
            OutFile = "";
            CacheDir = "";
            Tool1 = "wavtool.exe";
            Tool2 = "resampler.exe";
            Mode2 = true;
            Flags = "";

            VoiceBankName = "";
            VoiceBankIcon = null;

            FilePath = "";
            Notes = new List<HNote>();
        }

        private void Read()
        {
            if (!File.Exists(FilePath))
            {
                return;
            }
            Notes.Clear();
            List<string> fileLineToList = File.ReadAllLines(FilePath, Encoding.Default).ToList();
            fileLineToList.Add("[#TRACKEND]");
            int i, end = fileLineToList.Count, readType = 0;
            string[] afterSplit;
            HNote newNote = null;
            for (i = 0; i < end; i++)
            {
                //---Read---
                afterSplit = fileLineToList[i].Split(new char[] { '=' });
                if (HFunction.MatchStringFromScratch(fileLineToList[i], "[#VERSION]"))
                {
                    readType = 1;
                }
                else if (HFunction.MatchStringFromScratch(fileLineToList[i], "[#SETTING]"))
                {
                    readType = 2;
                }
                else if (HFunction.MatchStringFromScratch(fileLineToList[i], "[#"))
                {
                    if (newNote != null)
                    {
                        Notes.Add(newNote);
                        newNote = null;
                    }
                    if (fileLineToList[i] != "[#TRACKEND]")
                    {
                        newNote = new HNote();
                        if (HFunction.MatchStringFromScratch(fileLineToList[i], "[#P"))
                        {
                            newNote.NoteType = NoteTypeInTmpFile.Prev;
                        }
                        else if (HFunction.MatchStringFromScratch(fileLineToList[i], "[#N"))
                        {
                            newNote.NoteType = NoteTypeInTmpFile.Next;
                        }
                        else
                        {
                            newNote.NoteType = NoteTypeInTmpFile.Original;
                        }
                    }
                    readType = 3;
                }
                else if (readType == 1 && HFunction.MatchStringFromScratch(fileLineToList[i], "UST"))
                {
                    Version = fileLineToList[i];
                }
                else if (readType == 1 && HFunction.MatchStringFromScratch(fileLineToList[i], "Charset"))
                {
                    Charset = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "Tempo"))
                {
                    Tempo = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "Tracks"))
                {
                    Tracks = Convert.ToInt16(afterSplit[1]);
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "ProjectName"))
                {
                    ProjectName = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "VoiceDir"))
                {
                    VoiceDir = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "OutFile"))
                {
                    OutFile = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "CacheDir"))
                {
                    CacheDir = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "Tool1"))
                {
                    Tool1 = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "Tool2"))
                {
                    Tool2 = afterSplit[1];
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "Mode2"))
                {
                    Mode2 = Convert.ToBoolean(afterSplit[1]);
                }
                else if (readType == 2 && HFunction.MatchStringFromScratch(fileLineToList[i], "Flags"))
                {
                    Flags = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Length"))
                {
                    newNote.Length = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Lyric"))
                {
                    newNote.Lyric = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "NoteNum"))
                {
                    newNote.NoteNum = Convert.ToInt16(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Envelope"))
                {
                    newNote.Envelope = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PreUtterance"))
                {
                    newNote.PreUtterance = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "VoiceOverlap"))
                {
                    newNote.VoiceOverlap = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "StartPoint"))
                {
                    newNote.StartPoint = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Velocity"))
                {
                    newNote.Velocity = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Intensity"))
                {
                    newNote.Intensity = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Modulation"))
                {
                    newNote.Modulation = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Flags"))
                {
                    newNote.Flags = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Label"))
                {
                    newNote.Label = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "Tempo"))
                {
                    newNote.Tempo = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PBS"))
                {
                    newNote.PBS = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PBW"))
                {
                    newNote.PBW = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PBY"))
                {
                    newNote.PBY = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PBM"))
                {
                    newNote.PBM = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PBType"))
                {
                    newNote.PBType = Convert.ToInt16(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "PitchBend"))
                {
                    newNote.PitchBend = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "VBR"))
                {
                    newNote.VBR = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "@preuttr"))
                {
                    newNote._preuttr = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "@overlap"))
                {
                    newNote._overlap = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "@stpoint"))
                {
                    newNote._stpoint = Convert.ToSingle(afterSplit[1]);
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "@filename"))
                {
                    newNote._filename = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "@cache"))
                {
                    newNote._cache = afterSplit[1];
                }
                else if (readType == 3 && HFunction.MatchStringFromScratch(fileLineToList[i], "@alias"))
                {
                    newNote._alias = afterSplit[1];
                }
                //---End---
            }
        }

        private void ReadCharacter()
        {
            string characterPath = VoiceDir + "\\character.txt";
            if (File.Exists(characterPath))
            {
                string[] readAllLines = File.ReadAllLines(characterPath);
                string[] afterSplit = null;
                int i, end = readAllLines.Length;
                for (i = 0; i < end; i++)
                {
                    afterSplit = readAllLines[i].Split(new char[] { '=' });
                    if (afterSplit.Length == 2)
                    {
                        if (afterSplit[0] == "name")
                        {
                            VoiceBankName = afterSplit[1];
                        }
                        else if (afterSplit[0] == "image")
                        {
                            string iconPath = VoiceDir + "\\" + afterSplit[i];
                            if (File.Exists(iconPath))
                            {
                                VoiceBankIcon = new Bitmap(iconPath);
                            }
                        }
                    }
                }
            }
        }

        public void Save()
        {
            FileStream fs = new FileStream(FilePath, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs, Encoding.Default);
            sw.Write(ToString());
            sw.Close();
            fs.Close();
        }

        public override string ToString()
        {
            string result = "";
            result += "[#VERSION]";
            result += "\r\n";
            result += Version;
            result += "\r\n";
            result += "Charset=" + Charset;
            result += "\r\n";
            result += "[#SETTING]";
            result += "\r\n";
            result += "Tempo=" + Tempo;
            result += "\r\n";
            result += "Tracks=" + Tracks;
            result += "\r\n";
            result += "ProjectName=" + ProjectName;
            result += "\r\n";
            result += "VoiceDir=" + VoiceDir;
            result += "\r\n";
            result += "OutFile=" + OutFile;
            result += "\r\n";
            result += "CacheDir=" + CacheDir;
            result += "\r\n";
            result += "Tool1=" + Tool1;
            result += "\r\n";
            result += "Tool2=" + Tool2;
            result += "\r\n";
            result += "Mode2=" + Mode2;
            result += "\r\n";
            result += "Flags=" + Flags;
            result += "\r\n";
            int i, end = Notes.Count;
            for (i = 0; i < end; i++)
            {
                result += Notes[i].ToString();
            }
            result += "[#TRACKEND]";
            return result;
        }
    }
}
