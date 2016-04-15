namespace SetLyrics
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
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_TextChanger = new System.Windows.Forms.TableLayoutPanel();
            this.TB_BeforeChange = new System.Windows.Forms.TextBox();
            this.BTN_Changer = new System.Windows.Forms.Button();
            this.TB_AfterChange = new System.Windows.Forms.TextBox();
            this.TLP_Pens = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Muffle = new System.Windows.Forms.Button();
            this.BTN_InsideCantoFullSound = new System.Windows.Forms.Button();
            this.BTN_InsideCantoObscureSound = new System.Windows.Forms.Button();
            this.BTN_InsideCantoStrongVowel = new System.Windows.Forms.Button();
            this.BTN_InsidePeaceFullSound = new System.Windows.Forms.Button();
            this.BTN_InsidePeaceObscureSound = new System.Windows.Forms.Button();
            this.BTN_InsidePeaceStrongVowel = new System.Windows.Forms.Button();
            this.BTN_OutsideUniqueFullSound = new System.Windows.Forms.Button();
            this.BTN_OutsideUniqueObscureSound = new System.Windows.Forms.Button();
            this.BTN_OutsideUniqueStrongVowel = new System.Windows.Forms.Button();
            this.TLP_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.BTN_Complete = new System.Windows.Forms.Button();
            this.BTN_Priority = new System.Windows.Forms.Button();
            this.PB_MSLogo = new System.Windows.Forms.PictureBox();
            this.PB_VMLogo = new System.Windows.Forms.PictureBox();
            this.LB_Egg = new System.Windows.Forms.Label();
            this.HLE = new HUtau.HLineEditor();
            this.TLP.SuspendLayout();
            this.TLP_TextChanger.SuspendLayout();
            this.TLP_Pens.SuspendLayout();
            this.TLP_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MSLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VMLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 1;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Controls.Add(this.TLP_TextChanger, 0, 0);
            this.TLP.Controls.Add(this.TLP_Pens, 0, 1);
            this.TLP.Controls.Add(this.TLP_Settings, 0, 3);
            this.TLP.Controls.Add(this.HLE, 0, 2);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Name = "TLP";
            this.TLP.Padding = new System.Windows.Forms.Padding(10);
            this.TLP.RowCount = 4;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 13F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 7F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.TLP.Size = new System.Drawing.Size(584, 561);
            this.TLP.TabIndex = 0;
            // 
            // TLP_TextChanger
            // 
            this.TLP_TextChanger.ColumnCount = 3;
            this.TLP_TextChanger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_TextChanger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP_TextChanger.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_TextChanger.Controls.Add(this.TB_BeforeChange, 0, 0);
            this.TLP_TextChanger.Controls.Add(this.BTN_Changer, 1, 0);
            this.TLP_TextChanger.Controls.Add(this.TB_AfterChange, 2, 0);
            this.TLP_TextChanger.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_TextChanger.Location = new System.Drawing.Point(13, 13);
            this.TLP_TextChanger.Name = "TLP_TextChanger";
            this.TLP_TextChanger.RowCount = 1;
            this.TLP_TextChanger.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_TextChanger.Size = new System.Drawing.Size(558, 156);
            this.TLP_TextChanger.TabIndex = 0;
            // 
            // TB_BeforeChange
            // 
            this.TB_BeforeChange.AllowDrop = true;
            this.TB_BeforeChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_BeforeChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_BeforeChange.ImeMode = System.Windows.Forms.ImeMode.On;
            this.TB_BeforeChange.Location = new System.Drawing.Point(3, 3);
            this.TB_BeforeChange.Multiline = true;
            this.TB_BeforeChange.Name = "TB_BeforeChange";
            this.TB_BeforeChange.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_BeforeChange.Size = new System.Drawing.Size(257, 150);
            this.TB_BeforeChange.TabIndex = 2;
            this.TB_BeforeChange.TabStop = false;
            this.TB_BeforeChange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TB_BeforeChange_MouseClick);
            this.TB_BeforeChange.DragDrop += new System.Windows.Forms.DragEventHandler(this.TB_BeforeChange_DragDrop);
            this.TB_BeforeChange.DragEnter += new System.Windows.Forms.DragEventHandler(this.TB_BeforeChange_DragEnter);
            // 
            // BTN_Changer
            // 
            this.BTN_Changer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Changer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Changer.Location = new System.Drawing.Point(266, 3);
            this.BTN_Changer.Name = "BTN_Changer";
            this.BTN_Changer.Size = new System.Drawing.Size(26, 150);
            this.BTN_Changer.TabIndex = 0;
            this.BTN_Changer.TabStop = false;
            this.BTN_Changer.Text = ">";
            this.BTN_Changer.UseVisualStyleBackColor = true;
            this.BTN_Changer.Click += new System.EventHandler(this.BTN_Changer_Click);
            // 
            // TB_AfterChange
            // 
            this.TB_AfterChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TB_AfterChange.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_AfterChange.ImeMode = System.Windows.Forms.ImeMode.Off;
            this.TB_AfterChange.Location = new System.Drawing.Point(298, 3);
            this.TB_AfterChange.Multiline = true;
            this.TB_AfterChange.Name = "TB_AfterChange";
            this.TB_AfterChange.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TB_AfterChange.Size = new System.Drawing.Size(257, 150);
            this.TB_AfterChange.TabIndex = 1;
            this.TB_AfterChange.TabStop = false;
            this.TB_AfterChange.MouseClick += new System.Windows.Forms.MouseEventHandler(this.TB_AfterChange_MouseClick);
            this.TB_AfterChange.TextChanged += new System.EventHandler(this.TB_AfterChange_TextChanged);
            // 
            // TLP_Pens
            // 
            this.TLP_Pens.ColumnCount = 3;
            this.TLP_Pens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.TLP_Pens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TLP_Pens.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33334F));
            this.TLP_Pens.Controls.Add(this.PB_MSLogo, 0, 3);
            this.TLP_Pens.Controls.Add(this.BTN_Muffle, 0, 3);
            this.TLP_Pens.Controls.Add(this.BTN_InsideCantoFullSound, 2, 2);
            this.TLP_Pens.Controls.Add(this.BTN_InsideCantoObscureSound, 1, 2);
            this.TLP_Pens.Controls.Add(this.BTN_InsideCantoStrongVowel, 0, 2);
            this.TLP_Pens.Controls.Add(this.BTN_InsidePeaceFullSound, 2, 1);
            this.TLP_Pens.Controls.Add(this.BTN_InsidePeaceObscureSound, 1, 1);
            this.TLP_Pens.Controls.Add(this.BTN_InsidePeaceStrongVowel, 0, 1);
            this.TLP_Pens.Controls.Add(this.BTN_OutsideUniqueFullSound, 2, 0);
            this.TLP_Pens.Controls.Add(this.BTN_OutsideUniqueObscureSound, 1, 0);
            this.TLP_Pens.Controls.Add(this.BTN_OutsideUniqueStrongVowel, 0, 0);
            this.TLP_Pens.Controls.Add(this.PB_VMLogo, 1, 3);
            this.TLP_Pens.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Pens.Location = new System.Drawing.Point(10, 172);
            this.TLP_Pens.Margin = new System.Windows.Forms.Padding(0);
            this.TLP_Pens.Name = "TLP_Pens";
            this.TLP_Pens.Padding = new System.Windows.Forms.Padding(5, 10, 5, 10);
            this.TLP_Pens.RowCount = 4;
            this.TLP_Pens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Pens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Pens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Pens.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.TLP_Pens.Size = new System.Drawing.Size(564, 270);
            this.TLP_Pens.TabIndex = 2;
            // 
            // BTN_Muffle
            // 
            this.BTN_Muffle.BackColor = System.Drawing.Color.Violet;
            this.BTN_Muffle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Muffle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Muffle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_Muffle.Location = new System.Drawing.Point(8, 199);
            this.BTN_Muffle.Name = "BTN_Muffle";
            this.BTN_Muffle.Size = new System.Drawing.Size(178, 58);
            this.BTN_Muffle.TabIndex = 9;
            this.BTN_Muffle.TabStop = false;
            this.BTN_Muffle.Text = "Muffle";
            this.BTN_Muffle.UseVisualStyleBackColor = false;
            this.BTN_Muffle.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_InsideCantoFullSound
            // 
            this.BTN_InsideCantoFullSound.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BTN_InsideCantoFullSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsideCantoFullSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_InsideCantoFullSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsideCantoFullSound.Location = new System.Drawing.Point(376, 137);
            this.BTN_InsideCantoFullSound.Name = "BTN_InsideCantoFullSound";
            this.BTN_InsideCantoFullSound.Size = new System.Drawing.Size(180, 56);
            this.BTN_InsideCantoFullSound.TabIndex = 8;
            this.BTN_InsideCantoFullSound.TabStop = false;
            this.BTN_InsideCantoFullSound.Text = "Canto\r完整音";
            this.BTN_InsideCantoFullSound.UseVisualStyleBackColor = false;
            this.BTN_InsideCantoFullSound.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_InsideCantoObscureSound
            // 
            this.BTN_InsideCantoObscureSound.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BTN_InsideCantoObscureSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsideCantoObscureSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_InsideCantoObscureSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsideCantoObscureSound.Location = new System.Drawing.Point(192, 137);
            this.BTN_InsideCantoObscureSound.Name = "BTN_InsideCantoObscureSound";
            this.BTN_InsideCantoObscureSound.Size = new System.Drawing.Size(178, 56);
            this.BTN_InsideCantoObscureSound.TabIndex = 7;
            this.BTN_InsideCantoObscureSound.TabStop = false;
            this.BTN_InsideCantoObscureSound.Text = "Canto\r\n中間音";
            this.BTN_InsideCantoObscureSound.UseVisualStyleBackColor = false;
            this.BTN_InsideCantoObscureSound.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_InsideCantoStrongVowel
            // 
            this.BTN_InsideCantoStrongVowel.BackColor = System.Drawing.Color.BlanchedAlmond;
            this.BTN_InsideCantoStrongVowel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsideCantoStrongVowel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_InsideCantoStrongVowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsideCantoStrongVowel.Location = new System.Drawing.Point(8, 137);
            this.BTN_InsideCantoStrongVowel.Name = "BTN_InsideCantoStrongVowel";
            this.BTN_InsideCantoStrongVowel.Size = new System.Drawing.Size(178, 56);
            this.BTN_InsideCantoStrongVowel.TabIndex = 6;
            this.BTN_InsideCantoStrongVowel.TabStop = false;
            this.BTN_InsideCantoStrongVowel.Text = "Canto\r\n開頭音";
            this.BTN_InsideCantoStrongVowel.UseVisualStyleBackColor = false;
            this.BTN_InsideCantoStrongVowel.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_InsidePeaceFullSound
            // 
            this.BTN_InsidePeaceFullSound.BackColor = System.Drawing.Color.Pink;
            this.BTN_InsidePeaceFullSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsidePeaceFullSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_InsidePeaceFullSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsidePeaceFullSound.Location = new System.Drawing.Point(376, 75);
            this.BTN_InsidePeaceFullSound.Name = "BTN_InsidePeaceFullSound";
            this.BTN_InsidePeaceFullSound.Size = new System.Drawing.Size(180, 56);
            this.BTN_InsidePeaceFullSound.TabIndex = 5;
            this.BTN_InsidePeaceFullSound.TabStop = false;
            this.BTN_InsidePeaceFullSound.Text = "Peace\r完整音";
            this.BTN_InsidePeaceFullSound.UseVisualStyleBackColor = false;
            this.BTN_InsidePeaceFullSound.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_InsidePeaceObscureSound
            // 
            this.BTN_InsidePeaceObscureSound.BackColor = System.Drawing.Color.Pink;
            this.BTN_InsidePeaceObscureSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsidePeaceObscureSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_InsidePeaceObscureSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsidePeaceObscureSound.Location = new System.Drawing.Point(192, 75);
            this.BTN_InsidePeaceObscureSound.Name = "BTN_InsidePeaceObscureSound";
            this.BTN_InsidePeaceObscureSound.Size = new System.Drawing.Size(178, 56);
            this.BTN_InsidePeaceObscureSound.TabIndex = 4;
            this.BTN_InsidePeaceObscureSound.TabStop = false;
            this.BTN_InsidePeaceObscureSound.Text = "Peace\r\n中間音";
            this.BTN_InsidePeaceObscureSound.UseVisualStyleBackColor = false;
            this.BTN_InsidePeaceObscureSound.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_InsidePeaceStrongVowel
            // 
            this.BTN_InsidePeaceStrongVowel.BackColor = System.Drawing.Color.Pink;
            this.BTN_InsidePeaceStrongVowel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_InsidePeaceStrongVowel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_InsidePeaceStrongVowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_InsidePeaceStrongVowel.Location = new System.Drawing.Point(8, 75);
            this.BTN_InsidePeaceStrongVowel.Name = "BTN_InsidePeaceStrongVowel";
            this.BTN_InsidePeaceStrongVowel.Size = new System.Drawing.Size(178, 56);
            this.BTN_InsidePeaceStrongVowel.TabIndex = 3;
            this.BTN_InsidePeaceStrongVowel.TabStop = false;
            this.BTN_InsidePeaceStrongVowel.Text = "Peace\r\n開頭音";
            this.BTN_InsidePeaceStrongVowel.UseVisualStyleBackColor = false;
            this.BTN_InsidePeaceStrongVowel.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_OutsideUniqueFullSound
            // 
            this.BTN_OutsideUniqueFullSound.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_OutsideUniqueFullSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_OutsideUniqueFullSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OutsideUniqueFullSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OutsideUniqueFullSound.Location = new System.Drawing.Point(376, 13);
            this.BTN_OutsideUniqueFullSound.Name = "BTN_OutsideUniqueFullSound";
            this.BTN_OutsideUniqueFullSound.Size = new System.Drawing.Size(180, 56);
            this.BTN_OutsideUniqueFullSound.TabIndex = 2;
            this.BTN_OutsideUniqueFullSound.TabStop = false;
            this.BTN_OutsideUniqueFullSound.Text = "Outside\r\n完整音";
            this.BTN_OutsideUniqueFullSound.UseVisualStyleBackColor = false;
            this.BTN_OutsideUniqueFullSound.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_OutsideUniqueObscureSound
            // 
            this.BTN_OutsideUniqueObscureSound.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_OutsideUniqueObscureSound.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_OutsideUniqueObscureSound.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OutsideUniqueObscureSound.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OutsideUniqueObscureSound.Location = new System.Drawing.Point(192, 13);
            this.BTN_OutsideUniqueObscureSound.Name = "BTN_OutsideUniqueObscureSound";
            this.BTN_OutsideUniqueObscureSound.Size = new System.Drawing.Size(178, 56);
            this.BTN_OutsideUniqueObscureSound.TabIndex = 1;
            this.BTN_OutsideUniqueObscureSound.TabStop = false;
            this.BTN_OutsideUniqueObscureSound.Text = "Outside\r\n中間音";
            this.BTN_OutsideUniqueObscureSound.UseVisualStyleBackColor = false;
            this.BTN_OutsideUniqueObscureSound.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // BTN_OutsideUniqueStrongVowel
            // 
            this.BTN_OutsideUniqueStrongVowel.BackColor = System.Drawing.Color.PaleGreen;
            this.BTN_OutsideUniqueStrongVowel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_OutsideUniqueStrongVowel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_OutsideUniqueStrongVowel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTN_OutsideUniqueStrongVowel.Location = new System.Drawing.Point(8, 13);
            this.BTN_OutsideUniqueStrongVowel.Name = "BTN_OutsideUniqueStrongVowel";
            this.BTN_OutsideUniqueStrongVowel.Size = new System.Drawing.Size(178, 56);
            this.BTN_OutsideUniqueStrongVowel.TabIndex = 0;
            this.BTN_OutsideUniqueStrongVowel.TabStop = false;
            this.BTN_OutsideUniqueStrongVowel.Text = "Outside\r\n開頭音";
            this.BTN_OutsideUniqueStrongVowel.UseVisualStyleBackColor = false;
            this.BTN_OutsideUniqueStrongVowel.Click += new System.EventHandler(this.BTN_Pens_Click);
            // 
            // TLP_Settings
            // 
            this.TLP_Settings.ColumnCount = 4;
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 200F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP_Settings.Controls.Add(this.BTN_Cancel, 3, 0);
            this.TLP_Settings.Controls.Add(this.BTN_Complete, 2, 0);
            this.TLP_Settings.Controls.Add(this.BTN_Priority, 1, 0);
            this.TLP_Settings.Controls.Add(this.LB_Egg, 0, 0);
            this.TLP_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Settings.Location = new System.Drawing.Point(13, 515);
            this.TLP_Settings.Name = "TLP_Settings";
            this.TLP_Settings.RowCount = 1;
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Settings.Size = new System.Drawing.Size(558, 33);
            this.TLP_Settings.TabIndex = 5;
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Cancel.Location = new System.Drawing.Point(461, 3);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(94, 27);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // BTN_Complete
            // 
            this.BTN_Complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Complete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Complete.Location = new System.Drawing.Point(361, 3);
            this.BTN_Complete.Name = "BTN_Complete";
            this.BTN_Complete.Size = new System.Drawing.Size(94, 27);
            this.BTN_Complete.TabIndex = 1;
            this.BTN_Complete.TabStop = false;
            this.BTN_Complete.Text = "完成";
            this.BTN_Complete.UseVisualStyleBackColor = true;
            this.BTN_Complete.Click += new System.EventHandler(this.BTN_Complete_Click);
            // 
            // BTN_Priority
            // 
            this.BTN_Priority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Priority.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Priority.Location = new System.Drawing.Point(161, 3);
            this.BTN_Priority.Name = "BTN_Priority";
            this.BTN_Priority.Size = new System.Drawing.Size(194, 27);
            this.BTN_Priority.TabIndex = 2;
            this.BTN_Priority.TabStop = false;
            this.BTN_Priority.Text = "優先轉換字典";
            this.BTN_Priority.UseVisualStyleBackColor = true;
            this.BTN_Priority.Click += new System.EventHandler(this.BTN_Priority_Click);
            // 
            // PB_MSLogo
            // 
            this.PB_MSLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_MSLogo.BackColor = System.Drawing.SystemColors.Control;
            this.PB_MSLogo.Cursor = System.Windows.Forms.Cursors.Help;
            this.PB_MSLogo.Image = global::SetLyrics.Properties.Resources.masa;
            this.PB_MSLogo.Location = new System.Drawing.Point(220, 199);
            this.PB_MSLogo.Name = "PB_MSLogo";
            this.PB_MSLogo.Size = new System.Drawing.Size(150, 58);
            this.PB_MSLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MSLogo.TabIndex = 11;
            this.PB_MSLogo.TabStop = false;
            // 
            // PB_VMLogo
            // 
            this.PB_VMLogo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.PB_VMLogo.BackColor = System.Drawing.SystemColors.Control;
            this.PB_VMLogo.Cursor = System.Windows.Forms.Cursors.Help;
            this.PB_VMLogo.Image = global::SetLyrics.Properties.Resources.voicemithsm;
            this.PB_VMLogo.Location = new System.Drawing.Point(406, 199);
            this.PB_VMLogo.Name = "PB_VMLogo";
            this.PB_VMLogo.Size = new System.Drawing.Size(150, 58);
            this.PB_VMLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_VMLogo.TabIndex = 10;
            this.PB_VMLogo.TabStop = false;
            // 
            // LB_Egg
            // 
            this.LB_Egg.AutoSize = true;
            this.LB_Egg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Egg.Location = new System.Drawing.Point(3, 0);
            this.LB_Egg.Name = "LB_Egg";
            this.LB_Egg.Size = new System.Drawing.Size(152, 33);
            this.LB_Egg.TabIndex = 3;
            this.LB_Egg.Click += new System.EventHandler(this.LB_Egg_Click);
            // 
            // HLE
            // 
            this.HLE.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HLE.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.HLE.Location = new System.Drawing.Point(13, 446);
            this.HLE.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.HLE.Name = "HLE";
            this.HLE.Size = new System.Drawing.Size(558, 62);
            this.HLE.TabIndex = 6;
            this.HLE.MouseMove += new System.Windows.Forms.MouseEventHandler(this.HLE_MouseMove);
            // 
            // Simple
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(600, 600);
            this.Name = "Simple";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UTAU 夏語遙 Version 3 歌詞處理 Version 2016";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Index_FormClosing);
            this.Load += new System.EventHandler(this.Index_Load);
            this.TLP.ResumeLayout(false);
            this.TLP_TextChanger.ResumeLayout(false);
            this.TLP_TextChanger.PerformLayout();
            this.TLP_Pens.ResumeLayout(false);
            this.TLP_Settings.ResumeLayout(false);
            this.TLP_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MSLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_VMLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.TableLayoutPanel TLP_TextChanger;
        private System.Windows.Forms.Button BTN_Changer;
        private System.Windows.Forms.TextBox TB_BeforeChange;
        private System.Windows.Forms.TextBox TB_AfterChange;
        private System.Windows.Forms.TableLayoutPanel TLP_Pens;
        private System.Windows.Forms.Button BTN_OutsideUniqueStrongVowel;
        private System.Windows.Forms.Button BTN_OutsideUniqueFullSound;
        private System.Windows.Forms.Button BTN_OutsideUniqueObscureSound;
        private System.Windows.Forms.Button BTN_InsidePeaceStrongVowel;
        private System.Windows.Forms.Button BTN_InsidePeaceFullSound;
        private System.Windows.Forms.Button BTN_InsidePeaceObscureSound;
        private System.Windows.Forms.Button BTN_InsideCantoStrongVowel;
        private System.Windows.Forms.Button BTN_InsideCantoFullSound;
        private System.Windows.Forms.Button BTN_InsideCantoObscureSound;
        private System.Windows.Forms.Button BTN_Muffle;
        private System.Windows.Forms.TableLayoutPanel TLP_Settings;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.Button BTN_Complete;
        private System.Windows.Forms.Button BTN_Priority;
        private HUtau.HLineEditor HLE;
        private System.Windows.Forms.PictureBox PB_MSLogo;
        private System.Windows.Forms.PictureBox PB_VMLogo;
        private System.Windows.Forms.Label LB_Egg;
    }
}

