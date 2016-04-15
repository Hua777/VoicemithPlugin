namespace UstReset
{
    partial class Simple
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Simple));
            this.TLP_Main = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Notes = new System.Windows.Forms.GroupBox();
            this.TLP_Notes = new System.Windows.Forms.TableLayoutPanel();
            this.CB_ClearModulation = new System.Windows.Forms.CheckBox();
            this.CB_ClearPitch = new System.Windows.Forms.CheckBox();
            this.CB_ClearPreutterance = new System.Windows.Forms.CheckBox();
            this.CB_ResetEnvelope = new System.Windows.Forms.CheckBox();
            this.CB_ClearVibrato = new System.Windows.Forms.CheckBox();
            this.CB_ClearSTP = new System.Windows.Forms.CheckBox();
            this.CB_ClearOverlap = new System.Windows.Forms.CheckBox();
            this.CB_ClearFlags = new System.Windows.Forms.CheckBox();
            this.CB_CutRest = new System.Windows.Forms.CheckBox();
            this.TLP_Center = new System.Windows.Forms.TableLayoutPanel();
            this.GB_Lyric = new System.Windows.Forms.GroupBox();
            this.CB_ClearlyLyrics = new System.Windows.Forms.CheckBox();
            this.GB_Song = new System.Windows.Forms.GroupBox();
            this.TLP_Song = new System.Windows.Forms.TableLayoutPanel();
            this.CB_Mode = new System.Windows.Forms.ComboBox();
            this.LB_Mode = new System.Windows.Forms.Label();
            this.LB_Tempo = new System.Windows.Forms.Label();
            this.NUD_Tempo = new System.Windows.Forms.NumericUpDown();
            this.GB_Ust = new System.Windows.Forms.GroupBox();
            this.TLP_Properties = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Flags = new System.Windows.Forms.TextBox();
            this.TB_Tool2 = new System.Windows.Forms.TextBox();
            this.TB_WavOutput = new System.Windows.Forms.TextBox();
            this.TB_Tool1 = new System.Windows.Forms.TextBox();
            this.LB_Flags = new System.Windows.Forms.Label();
            this.LB_VoiceBank = new System.Windows.Forms.Label();
            this.LB_Tool2 = new System.Windows.Forms.Label();
            this.LB_WavOutput = new System.Windows.Forms.Label();
            this.LB_Tool1 = new System.Windows.Forms.Label();
            this.LB_ProjectName = new System.Windows.Forms.Label();
            this.TB_ProjectName = new System.Windows.Forms.TextBox();
            this.CB_VoiceBank = new System.Windows.Forms.ComboBox();
            this.TB_VoiceBankPath = new System.Windows.Forms.TextBox();
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Complete = new System.Windows.Forms.Button();
            this.TSC_Main = new System.Windows.Forms.ToolStripContainer();
            this.SS = new System.Windows.Forms.StatusStrip();
            this.TSSLB_FilePathTitle = new System.Windows.Forms.ToolStripStatusLabel();
            this.TSSLB_FilePath = new System.Windows.Forms.ToolStripStatusLabel();
            this.MS = new System.Windows.Forms.MenuStrip();
            this.MS_File = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_File_Open = new System.Windows.Forms.ToolStripMenuItem();
            this.MS_File_L1 = new System.Windows.Forms.ToolStripSeparator();
            this.MS_File_EditUTAU = new System.Windows.Forms.ToolStripMenuItem();
            this.FBD = new System.Windows.Forms.FolderBrowserDialog();
            this.OFD = new System.Windows.Forms.OpenFileDialog();
            this.OFD_Tool1 = new System.Windows.Forms.OpenFileDialog();
            this.OFD_Tool2 = new System.Windows.Forms.OpenFileDialog();
            this.TLP_Main.SuspendLayout();
            this.GB_Notes.SuspendLayout();
            this.TLP_Notes.SuspendLayout();
            this.TLP_Center.SuspendLayout();
            this.GB_Lyric.SuspendLayout();
            this.GB_Song.SuspendLayout();
            this.TLP_Song.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Tempo)).BeginInit();
            this.GB_Ust.SuspendLayout();
            this.TLP_Properties.SuspendLayout();
            this.TLP_Buttons.SuspendLayout();
            this.TSC_Main.BottomToolStripPanel.SuspendLayout();
            this.TSC_Main.ContentPanel.SuspendLayout();
            this.TSC_Main.TopToolStripPanel.SuspendLayout();
            this.TSC_Main.SuspendLayout();
            this.SS.SuspendLayout();
            this.MS.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP_Main
            // 
            this.TLP_Main.ColumnCount = 1;
            this.TLP_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Main.Controls.Add(this.GB_Notes, 0, 2);
            this.TLP_Main.Controls.Add(this.TLP_Center, 0, 1);
            this.TLP_Main.Controls.Add(this.GB_Ust, 0, 0);
            this.TLP_Main.Controls.Add(this.TLP_Buttons, 0, 3);
            this.TLP_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Main.Location = new System.Drawing.Point(0, 0);
            this.TLP_Main.Name = "TLP_Main";
            this.TLP_Main.RowCount = 4;
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35F));
            this.TLP_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP_Main.Size = new System.Drawing.Size(661, 433);
            this.TLP_Main.TabIndex = 0;
            // 
            // GB_Notes
            // 
            this.GB_Notes.Controls.Add(this.TLP_Notes);
            this.GB_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Notes.Location = new System.Drawing.Point(3, 258);
            this.GB_Notes.Name = "GB_Notes";
            this.GB_Notes.Size = new System.Drawing.Size(655, 131);
            this.GB_Notes.TabIndex = 2;
            this.GB_Notes.TabStop = false;
            this.GB_Notes.Text = "音符屬性";
            // 
            // TLP_Notes
            // 
            this.TLP_Notes.ColumnCount = 3;
            this.TLP_Notes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_Notes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TLP_Notes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_Notes.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Notes.Controls.Add(this.CB_ClearModulation, 2, 0);
            this.TLP_Notes.Controls.Add(this.CB_ClearPitch, 2, 2);
            this.TLP_Notes.Controls.Add(this.CB_ClearPreutterance, 2, 1);
            this.TLP_Notes.Controls.Add(this.CB_ResetEnvelope, 1, 2);
            this.TLP_Notes.Controls.Add(this.CB_ClearVibrato, 0, 2);
            this.TLP_Notes.Controls.Add(this.CB_ClearSTP, 1, 1);
            this.TLP_Notes.Controls.Add(this.CB_ClearOverlap, 0, 1);
            this.TLP_Notes.Controls.Add(this.CB_ClearFlags, 1, 0);
            this.TLP_Notes.Controls.Add(this.CB_CutRest, 0, 0);
            this.TLP_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Notes.Location = new System.Drawing.Point(3, 19);
            this.TLP_Notes.Name = "TLP_Notes";
            this.TLP_Notes.RowCount = 4;
            this.TLP_Notes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Notes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Notes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Notes.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Notes.Size = new System.Drawing.Size(649, 109);
            this.TLP_Notes.TabIndex = 0;
            // 
            // CB_ClearModulation
            // 
            this.CB_ClearModulation.AutoSize = true;
            this.CB_ClearModulation.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearModulation.Location = new System.Drawing.Point(435, 3);
            this.CB_ClearModulation.Name = "CB_ClearModulation";
            this.CB_ClearModulation.Size = new System.Drawing.Size(211, 21);
            this.CB_ClearModulation.TabIndex = 13;
            this.CB_ClearModulation.TabStop = false;
            this.CB_ClearModulation.Text = "清空 Modulation";
            this.CB_ClearModulation.UseVisualStyleBackColor = true;
            // 
            // CB_ClearPitch
            // 
            this.CB_ClearPitch.AutoSize = true;
            this.CB_ClearPitch.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearPitch.Location = new System.Drawing.Point(435, 57);
            this.CB_ClearPitch.Name = "CB_ClearPitch";
            this.CB_ClearPitch.Size = new System.Drawing.Size(211, 21);
            this.CB_ClearPitch.TabIndex = 10;
            this.CB_ClearPitch.TabStop = false;
            this.CB_ClearPitch.Text = "清空 Pitch";
            this.CB_ClearPitch.UseVisualStyleBackColor = true;
            // 
            // CB_ClearPreutterance
            // 
            this.CB_ClearPreutterance.AutoSize = true;
            this.CB_ClearPreutterance.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearPreutterance.Location = new System.Drawing.Point(435, 30);
            this.CB_ClearPreutterance.Name = "CB_ClearPreutterance";
            this.CB_ClearPreutterance.Size = new System.Drawing.Size(211, 21);
            this.CB_ClearPreutterance.TabIndex = 9;
            this.CB_ClearPreutterance.TabStop = false;
            this.CB_ClearPreutterance.Text = "清空 Preutterance";
            this.CB_ClearPreutterance.UseVisualStyleBackColor = true;
            // 
            // CB_ResetEnvelope
            // 
            this.CB_ResetEnvelope.AutoSize = true;
            this.CB_ResetEnvelope.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ResetEnvelope.Location = new System.Drawing.Point(219, 57);
            this.CB_ResetEnvelope.Name = "CB_ResetEnvelope";
            this.CB_ResetEnvelope.Size = new System.Drawing.Size(210, 21);
            this.CB_ResetEnvelope.TabIndex = 7;
            this.CB_ResetEnvelope.TabStop = false;
            this.CB_ResetEnvelope.Text = "清空 Envelope";
            this.CB_ResetEnvelope.UseVisualStyleBackColor = true;
            // 
            // CB_ClearVibrato
            // 
            this.CB_ClearVibrato.AutoSize = true;
            this.CB_ClearVibrato.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearVibrato.Location = new System.Drawing.Point(3, 57);
            this.CB_ClearVibrato.Name = "CB_ClearVibrato";
            this.CB_ClearVibrato.Size = new System.Drawing.Size(210, 21);
            this.CB_ClearVibrato.TabIndex = 6;
            this.CB_ClearVibrato.TabStop = false;
            this.CB_ClearVibrato.Text = "清空 Vibrato (顫音)";
            this.CB_ClearVibrato.UseVisualStyleBackColor = true;
            // 
            // CB_ClearSTP
            // 
            this.CB_ClearSTP.AutoSize = true;
            this.CB_ClearSTP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearSTP.Location = new System.Drawing.Point(219, 30);
            this.CB_ClearSTP.Name = "CB_ClearSTP";
            this.CB_ClearSTP.Size = new System.Drawing.Size(210, 21);
            this.CB_ClearSTP.TabIndex = 4;
            this.CB_ClearSTP.TabStop = false;
            this.CB_ClearSTP.Text = "清空 STP";
            this.CB_ClearSTP.UseVisualStyleBackColor = true;
            // 
            // CB_ClearOverlap
            // 
            this.CB_ClearOverlap.AutoSize = true;
            this.CB_ClearOverlap.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearOverlap.Location = new System.Drawing.Point(3, 30);
            this.CB_ClearOverlap.Name = "CB_ClearOverlap";
            this.CB_ClearOverlap.Size = new System.Drawing.Size(210, 21);
            this.CB_ClearOverlap.TabIndex = 3;
            this.CB_ClearOverlap.TabStop = false;
            this.CB_ClearOverlap.Text = "清空 Overlap";
            this.CB_ClearOverlap.UseVisualStyleBackColor = true;
            // 
            // CB_ClearFlags
            // 
            this.CB_ClearFlags.AutoSize = true;
            this.CB_ClearFlags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_ClearFlags.Location = new System.Drawing.Point(219, 3);
            this.CB_ClearFlags.Name = "CB_ClearFlags";
            this.CB_ClearFlags.Size = new System.Drawing.Size(210, 21);
            this.CB_ClearFlags.TabIndex = 1;
            this.CB_ClearFlags.TabStop = false;
            this.CB_ClearFlags.Text = "清空 Flags";
            this.CB_ClearFlags.UseVisualStyleBackColor = true;
            // 
            // CB_CutRest
            // 
            this.CB_CutRest.AutoSize = true;
            this.CB_CutRest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_CutRest.Location = new System.Drawing.Point(3, 3);
            this.CB_CutRest.Name = "CB_CutRest";
            this.CB_CutRest.Size = new System.Drawing.Size(210, 21);
            this.CB_CutRest.TabIndex = 0;
            this.CB_CutRest.TabStop = false;
            this.CB_CutRest.Text = "切割太長的 Rest Note";
            this.CB_CutRest.UseVisualStyleBackColor = true;
            // 
            // TLP_Center
            // 
            this.TLP_Center.ColumnCount = 2;
            this.TLP_Center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Center.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Center.Controls.Add(this.GB_Lyric, 0, 0);
            this.TLP_Center.Controls.Add(this.GB_Song, 0, 0);
            this.TLP_Center.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Center.Location = new System.Drawing.Point(3, 160);
            this.TLP_Center.Name = "TLP_Center";
            this.TLP_Center.RowCount = 1;
            this.TLP_Center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Center.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 92F));
            this.TLP_Center.Size = new System.Drawing.Size(655, 92);
            this.TLP_Center.TabIndex = 0;
            // 
            // GB_Lyric
            // 
            this.GB_Lyric.Controls.Add(this.CB_ClearlyLyrics);
            this.GB_Lyric.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Lyric.Location = new System.Drawing.Point(330, 3);
            this.GB_Lyric.Name = "GB_Lyric";
            this.GB_Lyric.Size = new System.Drawing.Size(322, 86);
            this.GB_Lyric.TabIndex = 3;
            this.GB_Lyric.TabStop = false;
            this.GB_Lyric.Text = "歌詞屬性";
            // 
            // CB_ClearlyLyrics
            // 
            this.CB_ClearlyLyrics.AutoSize = true;
            this.CB_ClearlyLyrics.Location = new System.Drawing.Point(6, 23);
            this.CB_ClearlyLyrics.Name = "CB_ClearlyLyrics";
            this.CB_ClearlyLyrics.Size = new System.Drawing.Size(237, 20);
            this.CB_ClearlyLyrics.TabIndex = 0;
            this.CB_ClearlyLyrics.TabStop = false;
            this.CB_ClearlyLyrics.Text = "清除所有前後綴 - 適用夏語遙 Version 3";
            this.CB_ClearlyLyrics.UseVisualStyleBackColor = true;
            // 
            // GB_Song
            // 
            this.GB_Song.Controls.Add(this.TLP_Song);
            this.GB_Song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Song.Location = new System.Drawing.Point(3, 3);
            this.GB_Song.Name = "GB_Song";
            this.GB_Song.Size = new System.Drawing.Size(321, 86);
            this.GB_Song.TabIndex = 2;
            this.GB_Song.TabStop = false;
            this.GB_Song.Text = "歌曲屬性";
            // 
            // TLP_Song
            // 
            this.TLP_Song.ColumnCount = 2;
            this.TLP_Song.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Song.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Song.Controls.Add(this.CB_Mode, 1, 1);
            this.TLP_Song.Controls.Add(this.LB_Mode, 0, 1);
            this.TLP_Song.Controls.Add(this.LB_Tempo, 0, 0);
            this.TLP_Song.Controls.Add(this.NUD_Tempo, 1, 0);
            this.TLP_Song.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Song.Location = new System.Drawing.Point(3, 19);
            this.TLP_Song.Name = "TLP_Song";
            this.TLP_Song.RowCount = 2;
            this.TLP_Song.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Song.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Song.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP_Song.Size = new System.Drawing.Size(315, 64);
            this.TLP_Song.TabIndex = 0;
            // 
            // CB_Mode
            // 
            this.CB_Mode.BackColor = System.Drawing.Color.White;
            this.CB_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_Mode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_Mode.FormattingEnabled = true;
            this.CB_Mode.Items.AddRange(new object[] {
            "Mode2",
            "Mode1"});
            this.CB_Mode.Location = new System.Drawing.Point(65, 35);
            this.CB_Mode.Name = "CB_Mode";
            this.CB_Mode.Size = new System.Drawing.Size(247, 24);
            this.CB_Mode.TabIndex = 16;
            this.CB_Mode.TabStop = false;
            // 
            // LB_Mode
            // 
            this.LB_Mode.AutoSize = true;
            this.LB_Mode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Mode.Location = new System.Drawing.Point(3, 32);
            this.LB_Mode.Name = "LB_Mode";
            this.LB_Mode.Size = new System.Drawing.Size(56, 32);
            this.LB_Mode.TabIndex = 13;
            this.LB_Mode.Text = "調教模式";
            this.LB_Mode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Tempo
            // 
            this.LB_Tempo.AutoSize = true;
            this.LB_Tempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Tempo.Location = new System.Drawing.Point(3, 0);
            this.LB_Tempo.Name = "LB_Tempo";
            this.LB_Tempo.Size = new System.Drawing.Size(56, 32);
            this.LB_Tempo.TabIndex = 9;
            this.LB_Tempo.Text = "Tempo";
            this.LB_Tempo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // NUD_Tempo
            // 
            this.NUD_Tempo.DecimalPlaces = 2;
            this.NUD_Tempo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NUD_Tempo.Location = new System.Drawing.Point(65, 3);
            this.NUD_Tempo.Maximum = new decimal(new int[] {
            300,
            0,
            0,
            0});
            this.NUD_Tempo.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.NUD_Tempo.Name = "NUD_Tempo";
            this.NUD_Tempo.Size = new System.Drawing.Size(247, 23);
            this.NUD_Tempo.TabIndex = 14;
            this.NUD_Tempo.TabStop = false;
            this.NUD_Tempo.Value = new decimal(new int[] {
            120,
            0,
            0,
            0});
            // 
            // GB_Ust
            // 
            this.GB_Ust.Controls.Add(this.TLP_Properties);
            this.GB_Ust.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GB_Ust.Location = new System.Drawing.Point(3, 3);
            this.GB_Ust.Name = "GB_Ust";
            this.GB_Ust.Size = new System.Drawing.Size(655, 151);
            this.GB_Ust.TabIndex = 1;
            this.GB_Ust.TabStop = false;
            this.GB_Ust.Text = "UST 屬性";
            // 
            // TLP_Properties
            // 
            this.TLP_Properties.ColumnCount = 4;
            this.TLP_Properties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Properties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Properties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_Properties.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Properties.Controls.Add(this.TB_Flags, 3, 2);
            this.TLP_Properties.Controls.Add(this.TB_Tool2, 3, 1);
            this.TLP_Properties.Controls.Add(this.TB_WavOutput, 1, 1);
            this.TLP_Properties.Controls.Add(this.TB_Tool1, 3, 0);
            this.TLP_Properties.Controls.Add(this.LB_Flags, 2, 2);
            this.TLP_Properties.Controls.Add(this.LB_VoiceBank, 0, 2);
            this.TLP_Properties.Controls.Add(this.LB_Tool2, 2, 1);
            this.TLP_Properties.Controls.Add(this.LB_WavOutput, 0, 1);
            this.TLP_Properties.Controls.Add(this.LB_Tool1, 2, 0);
            this.TLP_Properties.Controls.Add(this.LB_ProjectName, 0, 0);
            this.TLP_Properties.Controls.Add(this.TB_ProjectName, 1, 0);
            this.TLP_Properties.Controls.Add(this.CB_VoiceBank, 1, 2);
            this.TLP_Properties.Controls.Add(this.TB_VoiceBankPath, 1, 3);
            this.TLP_Properties.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Properties.Location = new System.Drawing.Point(3, 19);
            this.TLP_Properties.Name = "TLP_Properties";
            this.TLP_Properties.RowCount = 4;
            this.TLP_Properties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Properties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Properties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Properties.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Properties.Size = new System.Drawing.Size(649, 129);
            this.TLP_Properties.TabIndex = 0;
            // 
            // TB_Flags
            // 
            this.TB_Flags.BackColor = System.Drawing.Color.White;
            this.TB_Flags.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Flags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Flags.Location = new System.Drawing.Point(396, 67);
            this.TB_Flags.Name = "TB_Flags";
            this.TB_Flags.Size = new System.Drawing.Size(250, 23);
            this.TB_Flags.TabIndex = 16;
            this.TB_Flags.TabStop = false;
            // 
            // TB_Tool2
            // 
            this.TB_Tool2.BackColor = System.Drawing.Color.White;
            this.TB_Tool2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Tool2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Tool2.Location = new System.Drawing.Point(396, 35);
            this.TB_Tool2.Name = "TB_Tool2";
            this.TB_Tool2.ReadOnly = true;
            this.TB_Tool2.Size = new System.Drawing.Size(250, 23);
            this.TB_Tool2.TabIndex = 14;
            this.TB_Tool2.TabStop = false;
            this.TB_Tool2.Click += new System.EventHandler(this.TB_Tool2_Click);
            // 
            // TB_WavOutput
            // 
            this.TB_WavOutput.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_WavOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_WavOutput.Location = new System.Drawing.Point(90, 35);
            this.TB_WavOutput.Name = "TB_WavOutput";
            this.TB_WavOutput.Size = new System.Drawing.Size(250, 23);
            this.TB_WavOutput.TabIndex = 13;
            this.TB_WavOutput.TabStop = false;
            // 
            // TB_Tool1
            // 
            this.TB_Tool1.BackColor = System.Drawing.Color.White;
            this.TB_Tool1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_Tool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Tool1.Location = new System.Drawing.Point(396, 3);
            this.TB_Tool1.Name = "TB_Tool1";
            this.TB_Tool1.ReadOnly = true;
            this.TB_Tool1.Size = new System.Drawing.Size(250, 23);
            this.TB_Tool1.TabIndex = 12;
            this.TB_Tool1.TabStop = false;
            this.TB_Tool1.Click += new System.EventHandler(this.TB_Tool1_Click);
            // 
            // LB_Flags
            // 
            this.LB_Flags.AutoSize = true;
            this.LB_Flags.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Flags.Location = new System.Drawing.Point(346, 64);
            this.LB_Flags.Name = "LB_Flags";
            this.LB_Flags.Size = new System.Drawing.Size(44, 32);
            this.LB_Flags.TabIndex = 10;
            this.LB_Flags.Text = "Flags";
            this.LB_Flags.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_VoiceBank
            // 
            this.LB_VoiceBank.AutoSize = true;
            this.LB_VoiceBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_VoiceBank.Location = new System.Drawing.Point(3, 64);
            this.LB_VoiceBank.Name = "LB_VoiceBank";
            this.LB_VoiceBank.Size = new System.Drawing.Size(81, 32);
            this.LB_VoiceBank.TabIndex = 8;
            this.LB_VoiceBank.Text = "音源選擇";
            this.LB_VoiceBank.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Tool2
            // 
            this.LB_Tool2.AutoSize = true;
            this.LB_Tool2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Tool2.Location = new System.Drawing.Point(346, 32);
            this.LB_Tool2.Name = "LB_Tool2";
            this.LB_Tool2.Size = new System.Drawing.Size(44, 32);
            this.LB_Tool2.TabIndex = 6;
            this.LB_Tool2.Text = "合成器";
            this.LB_Tool2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_WavOutput
            // 
            this.LB_WavOutput.AutoSize = true;
            this.LB_WavOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_WavOutput.Location = new System.Drawing.Point(3, 32);
            this.LB_WavOutput.Name = "LB_WavOutput";
            this.LB_WavOutput.Size = new System.Drawing.Size(81, 32);
            this.LB_WavOutput.TabIndex = 4;
            this.LB_WavOutput.Text = "wav 輸出名稱";
            this.LB_WavOutput.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_Tool1
            // 
            this.LB_Tool1.AutoSize = true;
            this.LB_Tool1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Tool1.Location = new System.Drawing.Point(346, 0);
            this.LB_Tool1.Name = "LB_Tool1";
            this.LB_Tool1.Size = new System.Drawing.Size(44, 32);
            this.LB_Tool1.TabIndex = 2;
            this.LB_Tool1.Text = "採樣器";
            this.LB_Tool1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LB_ProjectName
            // 
            this.LB_ProjectName.AutoSize = true;
            this.LB_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_ProjectName.Location = new System.Drawing.Point(3, 0);
            this.LB_ProjectName.Name = "LB_ProjectName";
            this.LB_ProjectName.Size = new System.Drawing.Size(81, 32);
            this.LB_ProjectName.TabIndex = 0;
            this.LB_ProjectName.Text = "專案名稱";
            this.LB_ProjectName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TB_ProjectName
            // 
            this.TB_ProjectName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_ProjectName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_ProjectName.Location = new System.Drawing.Point(90, 3);
            this.TB_ProjectName.Name = "TB_ProjectName";
            this.TB_ProjectName.Size = new System.Drawing.Size(250, 23);
            this.TB_ProjectName.TabIndex = 11;
            this.TB_ProjectName.TabStop = false;
            // 
            // CB_VoiceBank
            // 
            this.CB_VoiceBank.BackColor = System.Drawing.Color.White;
            this.CB_VoiceBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CB_VoiceBank.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CB_VoiceBank.FormattingEnabled = true;
            this.CB_VoiceBank.Location = new System.Drawing.Point(90, 67);
            this.CB_VoiceBank.Name = "CB_VoiceBank";
            this.CB_VoiceBank.Size = new System.Drawing.Size(250, 24);
            this.CB_VoiceBank.TabIndex = 15;
            this.CB_VoiceBank.TabStop = false;
            this.CB_VoiceBank.SelectedIndexChanged += new System.EventHandler(this.CB_VoiceBank_SelectedIndexChanged);
            // 
            // TB_VoiceBankPath
            // 
            this.TB_VoiceBankPath.BackColor = System.Drawing.Color.White;
            this.TB_VoiceBankPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TLP_Properties.SetColumnSpan(this.TB_VoiceBankPath, 3);
            this.TB_VoiceBankPath.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_VoiceBankPath.Location = new System.Drawing.Point(90, 99);
            this.TB_VoiceBankPath.Name = "TB_VoiceBankPath";
            this.TB_VoiceBankPath.ReadOnly = true;
            this.TB_VoiceBankPath.Size = new System.Drawing.Size(556, 23);
            this.TB_VoiceBankPath.TabIndex = 17;
            this.TB_VoiceBankPath.TabStop = false;
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.ColumnCount = 3;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Buttons.Controls.Add(this.BTN_Cancel, 2, 0);
            this.TLP_Buttons.Controls.Add(this.BTN_Complete, 1, 0);
            this.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Buttons.Location = new System.Drawing.Point(3, 395);
            this.TLP_Buttons.Name = "TLP_Buttons";
            this.TLP_Buttons.RowCount = 1;
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.TLP_Buttons.Size = new System.Drawing.Size(655, 35);
            this.TLP_Buttons.TabIndex = 3;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Cancel.Location = new System.Drawing.Point(558, 3);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(94, 29);
            this.BTN_Cancel.TabIndex = 2;
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Complete
            // 
            this.BTN_Complete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Complete.Location = new System.Drawing.Point(458, 3);
            this.BTN_Complete.Name = "BTN_Complete";
            this.BTN_Complete.Size = new System.Drawing.Size(94, 29);
            this.BTN_Complete.TabIndex = 0;
            this.BTN_Complete.TabStop = false;
            this.BTN_Complete.Text = "完成";
            this.BTN_Complete.UseVisualStyleBackColor = true;
            this.BTN_Complete.Click += new System.EventHandler(this.BTN_Complete_Click);
            // 
            // TSC_Main
            // 
            // 
            // TSC_Main.BottomToolStripPanel
            // 
            this.TSC_Main.BottomToolStripPanel.Controls.Add(this.SS);
            // 
            // TSC_Main.ContentPanel
            // 
            this.TSC_Main.ContentPanel.Controls.Add(this.TLP_Main);
            this.TSC_Main.ContentPanel.Size = new System.Drawing.Size(661, 433);
            this.TSC_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TSC_Main.LeftToolStripPanelVisible = false;
            this.TSC_Main.Location = new System.Drawing.Point(0, 0);
            this.TSC_Main.Name = "TSC_Main";
            this.TSC_Main.RightToolStripPanelVisible = false;
            this.TSC_Main.Size = new System.Drawing.Size(661, 479);
            this.TSC_Main.TabIndex = 1;
            this.TSC_Main.Text = "功能包裝";
            // 
            // TSC_Main.TopToolStripPanel
            // 
            this.TSC_Main.TopToolStripPanel.Controls.Add(this.MS);
            // 
            // SS
            // 
            this.SS.Dock = System.Windows.Forms.DockStyle.None;
            this.SS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TSSLB_FilePathTitle,
            this.TSSLB_FilePath});
            this.SS.Location = new System.Drawing.Point(0, 0);
            this.SS.Name = "SS";
            this.SS.Size = new System.Drawing.Size(661, 22);
            this.SS.SizingGrip = false;
            this.SS.TabIndex = 0;
            // 
            // TSSLB_FilePathTitle
            // 
            this.TSSLB_FilePathTitle.Name = "TSSLB_FilePathTitle";
            this.TSSLB_FilePathTitle.Size = new System.Drawing.Size(85, 17);
            this.TSSLB_FilePathTitle.Text = "目前載入檔案: ";
            // 
            // TSSLB_FilePath
            // 
            this.TSSLB_FilePath.Name = "TSSLB_FilePath";
            this.TSSLB_FilePath.Size = new System.Drawing.Size(43, 17);
            this.TSSLB_FilePath.Text = "無檔案";
            // 
            // MS
            // 
            this.MS.Dock = System.Windows.Forms.DockStyle.None;
            this.MS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_File});
            this.MS.Location = new System.Drawing.Point(0, 0);
            this.MS.Name = "MS";
            this.MS.Size = new System.Drawing.Size(661, 24);
            this.MS.TabIndex = 0;
            this.MS.Text = "功能表";
            // 
            // MS_File
            // 
            this.MS_File.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MS_File_Open,
            this.MS_File_L1,
            this.MS_File_EditUTAU});
            this.MS_File.Name = "MS_File";
            this.MS_File.Size = new System.Drawing.Size(60, 20);
            this.MS_File.Text = "檔案 (&F)";
            // 
            // MS_File_Open
            // 
            this.MS_File_Open.Name = "MS_File_Open";
            this.MS_File_Open.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.MS_File_Open.Size = new System.Drawing.Size(199, 22);
            this.MS_File_Open.Text = "開啟檔案";
            this.MS_File_Open.Click += new System.EventHandler(this.MS_File_Open_Click);
            // 
            // MS_File_L1
            // 
            this.MS_File_L1.Name = "MS_File_L1";
            this.MS_File_L1.Size = new System.Drawing.Size(196, 6);
            // 
            // MS_File_EditUTAU
            // 
            this.MS_File_EditUTAU.Name = "MS_File_EditUTAU";
            this.MS_File_EditUTAU.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.MS_File_EditUTAU.Size = new System.Drawing.Size(199, 22);
            this.MS_File_EditUTAU.Text = "設定UTAU安裝目錄";
            this.MS_File_EditUTAU.Click += new System.EventHandler(this.MS_File_EditUTAU_Click);
            // 
            // FBD
            // 
            this.FBD.Description = "請選擇您的 UTAU 安裝目錄";
            // 
            // OFD
            // 
            this.OFD.Filter = "UST|*.ust";
            this.OFD.Title = "選擇 ust 檔案";
            // 
            // OFD_Tool1
            // 
            this.OFD_Tool1.Title = "選擇採樣器";
            // 
            // OFD_Tool2
            // 
            this.OFD_Tool2.Title = "選擇合成器";
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 479);
            this.Controls.Add(this.TSC_Main);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MS;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UST 重設工具";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Simple_FormClosing);
            this.Load += new System.EventHandler(this.Simple_Load);
            this.TLP_Main.ResumeLayout(false);
            this.GB_Notes.ResumeLayout(false);
            this.TLP_Notes.ResumeLayout(false);
            this.TLP_Notes.PerformLayout();
            this.TLP_Center.ResumeLayout(false);
            this.GB_Lyric.ResumeLayout(false);
            this.GB_Lyric.PerformLayout();
            this.GB_Song.ResumeLayout(false);
            this.TLP_Song.ResumeLayout(false);
            this.TLP_Song.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUD_Tempo)).EndInit();
            this.GB_Ust.ResumeLayout(false);
            this.TLP_Properties.ResumeLayout(false);
            this.TLP_Properties.PerformLayout();
            this.TLP_Buttons.ResumeLayout(false);
            this.TSC_Main.BottomToolStripPanel.ResumeLayout(false);
            this.TSC_Main.BottomToolStripPanel.PerformLayout();
            this.TSC_Main.ContentPanel.ResumeLayout(false);
            this.TSC_Main.TopToolStripPanel.ResumeLayout(false);
            this.TSC_Main.TopToolStripPanel.PerformLayout();
            this.TSC_Main.ResumeLayout(false);
            this.TSC_Main.PerformLayout();
            this.SS.ResumeLayout(false);
            this.SS.PerformLayout();
            this.MS.ResumeLayout(false);
            this.MS.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP_Main;
        private System.Windows.Forms.TableLayoutPanel TLP_Center;
        private System.Windows.Forms.GroupBox GB_Ust;
        private System.Windows.Forms.GroupBox GB_Notes;
        private System.Windows.Forms.GroupBox GB_Lyric;
        private System.Windows.Forms.GroupBox GB_Song;
        private System.Windows.Forms.ToolStripContainer TSC_Main;
        private System.Windows.Forms.MenuStrip MS;
        private System.Windows.Forms.ToolStripMenuItem MS_File;
        private System.Windows.Forms.ToolStripMenuItem MS_File_Open;
        private System.Windows.Forms.ToolStripSeparator MS_File_L1;
        private System.Windows.Forms.ToolStripMenuItem MS_File_EditUTAU;
        private System.Windows.Forms.StatusStrip SS;
        private System.Windows.Forms.TableLayoutPanel TLP_Properties;
        private System.Windows.Forms.Label LB_ProjectName;
        private System.Windows.Forms.Label LB_Flags;
        private System.Windows.Forms.Label LB_VoiceBank;
        private System.Windows.Forms.Label LB_Tool2;
        private System.Windows.Forms.Label LB_WavOutput;
        private System.Windows.Forms.Label LB_Tool1;
        private System.Windows.Forms.TableLayoutPanel TLP_Song;
        private System.Windows.Forms.Label LB_Tempo;
        private System.Windows.Forms.Label LB_Mode;
        private System.Windows.Forms.CheckBox CB_ClearlyLyrics;
        private System.Windows.Forms.TableLayoutPanel TLP_Notes;
        private System.Windows.Forms.TextBox TB_ProjectName;
        private System.Windows.Forms.TextBox TB_Tool2;
        private System.Windows.Forms.TextBox TB_WavOutput;
        private System.Windows.Forms.TextBox TB_Tool1;
        private System.Windows.Forms.ComboBox CB_VoiceBank;
        private System.Windows.Forms.TextBox TB_Flags;
        private System.Windows.Forms.NumericUpDown NUD_Tempo;
        private System.Windows.Forms.ComboBox CB_Mode;
        private System.Windows.Forms.CheckBox CB_CutRest;
        private System.Windows.Forms.CheckBox CB_ResetEnvelope;
        private System.Windows.Forms.CheckBox CB_ClearVibrato;
        private System.Windows.Forms.CheckBox CB_ClearSTP;
        private System.Windows.Forms.CheckBox CB_ClearOverlap;
        private System.Windows.Forms.CheckBox CB_ClearFlags;
        private System.Windows.Forms.CheckBox CB_ClearPreutterance;
        private System.Windows.Forms.CheckBox CB_ClearPitch;
        private System.Windows.Forms.TableLayoutPanel TLP_Buttons;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Complete;
        private System.Windows.Forms.FolderBrowserDialog FBD;
        private System.Windows.Forms.TextBox TB_VoiceBankPath;
        private System.Windows.Forms.ToolStripStatusLabel TSSLB_FilePathTitle;
        private System.Windows.Forms.ToolStripStatusLabel TSSLB_FilePath;
        private System.Windows.Forms.OpenFileDialog OFD;
        private System.Windows.Forms.OpenFileDialog OFD_Tool1;
        private System.Windows.Forms.OpenFileDialog OFD_Tool2;
        private System.Windows.Forms.CheckBox CB_ClearModulation;
    }
}

