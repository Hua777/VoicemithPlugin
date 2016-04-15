using System;
using System.IO;
using System.Windows.Forms;
using HUtau;
using System.Collections.Generic;

namespace UstReset
{
    public partial class Simple : Form
    {
        private Dictionary<string, string> VoiceBanks = new Dictionary<string, string>();

        public Simple()
        {
            InitializeComponent();
        }
        
        private void Simple_Load(object sender, EventArgs e)
        {
            LoadProperties();
            if (Properties.Settings.Default.UTAUInstallPath == "")
            {
                SetUTAUInstallPath();
            }
        }
        private void Simple_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveProperties();
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void BTN_Complete_Click(object sender, EventArgs e)
        {
            if (Running())
            {
                Close();
            }
        }

        private void MS_File_Open_Click(object sender, EventArgs e)
        {
            if (OFD.ShowDialog() == DialogResult.OK)
            {
                TSSLB_FilePath.Text = OFD.FileName;
            }
        }
        private void MS_File_EditUTAU_Click(object sender, EventArgs e)
        {
            SetUTAUInstallPath();
        }

        private void CB_VoiceBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedCharacter = CB_VoiceBank.SelectedItem.ToString();
            if (VoiceBanks.ContainsKey(selectedCharacter))
            {
                TB_VoiceBankPath.Text = VoiceBanks[selectedCharacter];
            }
            else
            {
                TB_VoiceBankPath.Text = "";
            }
        }

        private void TB_Tool1_Click(object sender, EventArgs e)
        {
            if (OFD_Tool1.ShowDialog() == DialogResult.OK)
            {
                TB_Tool1.Text = OFD_Tool1.FileName;
            }
        }
        private void TB_Tool2_Click(object sender, EventArgs e)
        {
            if (OFD_Tool2.ShowDialog() == DialogResult.OK)
            {
                TB_Tool2.Text = OFD_Tool2.FileName;
            }
        }

        private void SetUTAUInstallPath()
        {
            if (FBD.ShowDialog() == DialogResult.OK)
            {
                OFD_Tool1.InitialDirectory = FBD.SelectedPath;
                OFD_Tool2.InitialDirectory = FBD.SelectedPath;
                LoadVoiceBanks();
            }
        }

        private void LoadProperties()
        {
            FBD.SelectedPath = Properties.Settings.Default.UTAUInstallPath;

            TB_ProjectName.Text = Properties.Settings.Default.ProjectName;
            TB_WavOutput.Text = Properties.Settings.Default.WavOutputName;
            LoadVoiceBanks();
            TB_Tool1.Text = Properties.Settings.Default.Tool1Path;
            TB_Tool2.Text = Properties.Settings.Default.Tool2Path;
            TB_Flags.Text = Properties.Settings.Default.UTAUFlags;

            NUD_Tempo.Value = Properties.Settings.Default.UTAUTempo;
            CB_Mode.SelectedItem = Properties.Settings.Default.Mode;
            CB_ClearlyLyrics.Checked = Properties.Settings.Default.ClearlyLyrics;

            CB_CutRest.Checked = Properties.Settings.Default.CutRest;
            CB_ClearOverlap.Checked = Properties.Settings.Default.ClearOverlap;
            CB_ClearVibrato.Checked = Properties.Settings.Default.ClearVibrato;
            CB_ClearFlags.Checked = Properties.Settings.Default.ClearFlags;
            CB_ClearSTP.Checked = Properties.Settings.Default.ClearSTP;
            CB_ResetEnvelope.Checked = Properties.Settings.Default.ResetEnvelope;
            CB_ClearPreutterance.Checked = Properties.Settings.Default.ClearPreutterance;
            CB_ClearPitch.Checked = Properties.Settings.Default.ClearPitch;
            CB_ClearModulation.Checked = Properties.Settings.Default.ClearModulation;
        }
        private void SaveProperties()
        {
            Properties.Settings.Default.UTAUInstallPath = FBD.SelectedPath;

            Properties.Settings.Default.ProjectName = TB_ProjectName.Text;
            Properties.Settings.Default.WavOutputName = TB_WavOutput.Text;
            if (CB_VoiceBank.SelectedItem != null)
            {
                Properties.Settings.Default.VoiceBank = CB_VoiceBank.SelectedItem.ToString();
            }
            Properties.Settings.Default.Tool1Path = TB_Tool1.Text;
            Properties.Settings.Default.Tool2Path = TB_Tool2.Text;
            Properties.Settings.Default.UTAUFlags = TB_Flags.Text;

            Properties.Settings.Default.UTAUTempo = NUD_Tempo.Value;
            Properties.Settings.Default.Mode = CB_Mode.SelectedItem.ToString();
            Properties.Settings.Default.ClearlyLyrics = CB_ClearlyLyrics.Checked;

            Properties.Settings.Default.CutRest = CB_CutRest.Checked;
            Properties.Settings.Default.ClearOverlap = CB_ClearOverlap.Checked;
            Properties.Settings.Default.ClearVibrato = CB_ClearVibrato.Checked;
            Properties.Settings.Default.ClearFlags = CB_ClearFlags.Checked;
            Properties.Settings.Default.ClearSTP = CB_ClearSTP.Checked;
            Properties.Settings.Default.ResetEnvelope = CB_ResetEnvelope.Checked;
            Properties.Settings.Default.ClearPreutterance = CB_ClearPreutterance.Checked;
            Properties.Settings.Default.ClearPitch = CB_ClearPitch.Checked;
            Properties.Settings.Default.ClearModulation = CB_ClearModulation.Checked;

            Properties.Settings.Default.Save();
        }

        private void LoadVoiceBanks()
        {
            CB_VoiceBank.Items.Clear();
            VoiceBanks.Clear();
            string voiceFolder = Path.Combine(FBD.SelectedPath, "voice");
            if (!Directory.Exists(voiceFolder))
            {
                return;
            }
            string[] voiceBanks = Directory.GetDirectories(voiceFolder);
            int i, end = voiceBanks.Length;
            for (i = 0; i < end; i++)
            {
                string voiceBankCharacter = Path.Combine(voiceBanks[i], "character.txt");
                if (File.Exists(voiceBankCharacter))
                {
                    string characterName = GetCharacterName(voiceBankCharacter);
                    if (!VoiceBanks.ContainsKey(characterName))
                    {
                        VoiceBanks.Add(characterName, voiceBanks[i]);
                        CB_VoiceBank.Items.Add(characterName);
                        CB_VoiceBank.SelectedItem = characterName;
                    }
                }
            }
        }
        private string GetCharacterName(string _path)
        {
            string[] allLines = File.ReadAllLines(_path, HFunction.GetFileEncoding(_path));
            string[] afterSplit = null;
            int i, end = allLines.Length;
            for (i = 0; i < end; i++)
            {
                afterSplit = allLines[i].Split(new char[] { '=' });
                if (afterSplit.Length == 2)
                {
                    if (afterSplit[0].ToLower() == "name")
                    {
                        return afterSplit[1];
                    }
                }
            }
            return "Character";
        }

        private bool Running()
        {
            if (!File.Exists(TSSLB_FilePath.Text))
            {
                MessageBox.Show("檔案不存在", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            HTmpFile htf = new HTmpFile(TSSLB_FilePath.Text);
            htf.ProjectName = TB_ProjectName.Text;
            htf.OutFile = TB_WavOutput.Text;
            htf.VoiceDir = TB_VoiceBankPath.Text;
            htf.Tool1 = TB_Tool1.Text;
            htf.Tool2 = TB_Tool2.Text;
            htf.Flags = TB_Flags.Text;

            htf.Tempo = Convert.ToSingle(NUD_Tempo.Value);
            htf.Mode2 = (CB_Mode.SelectedItem.ToString() == "Mode2" ? true : false);

            int i, end = htf.Count;
            for (i = 0; i < end; i++)
            {
                if (CB_ClearlyLyrics.Checked)
                {
                    htf[i].Lyric = htf[i].ClearlyLyric;
                }
                if (CB_ClearFlags.Checked)
                {
                    htf[i].Flags = "";
                }
                if (CB_ClearModulation.Checked)
                {
                    htf[i].Modulation = "";
                }
                if (CB_ClearOverlap.Checked)
                {
                    htf[i].VoiceOverlap = "";
                }
                if (CB_ClearSTP.Checked)
                {
                    htf[i].StartPoint = "";
                }
                if (CB_ClearPreutterance.Checked)
                {
                    htf[i].PreUtterance = "";
                }
                if (CB_ClearVibrato.Checked)
                {
                    htf[i].VBR = "";
                }
                if (CB_ResetEnvelope.Checked)
                {
                    htf[i].Envelope = "";
                }
                if (CB_ClearPitch.Checked)
                {
                    htf[i].PitchBend = "";
                    htf[i].PBM = "";
                    htf[i].PBS = "";
                    htf[i].PBW = "";
                    htf[i].PBY = "";
                }
                if (CB_CutRest.Checked)
                {
                    if (htf[i].IsRest && htf[i].Length > HData.DefaultNoteLength * 4)
                    {
                        HNote tmpNote = new HNote();
                        tmpNote = htf[i].Clone();
                        tmpNote.Length = htf[i].Length - HData.DefaultNoteLength * 4;
                        htf[i].Length = HData.DefaultNoteLength * 4;
                        htf.Notes.Insert(i + 1, tmpNote);
                        end++;
                    }
                }
            }
            htf.Save();
            return true;
        }
    }
}
