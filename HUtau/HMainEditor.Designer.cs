namespace HUtau
{
    partial class HMainEditor
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

        #region 元件設計工具產生的程式碼

        /// <summary> 
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.VSB = new System.Windows.Forms.VScrollBar();
            this.HSB = new System.Windows.Forms.HScrollBar();
            this.PB_Top = new System.Windows.Forms.PictureBox();
            this.PN_Main = new System.Windows.Forms.Panel();
            this.PB_MainSelectLines = new System.Windows.Forms.PictureBox();
            this.PB_MainNotes = new System.Windows.Forms.PictureBox();
            this.PB_MainControl = new System.Windows.Forms.PictureBox();
            this.PB_Main = new System.Windows.Forms.PictureBox();
            this.PN_Left = new System.Windows.Forms.Panel();
            this.PB_Left = new System.Windows.Forms.PictureBox();
            this.PB_LeftControl = new System.Windows.Forms.PictureBox();
            this.LB_VoiceBank = new System.Windows.Forms.Label();
            this.PB_MainNotesMove = new System.Windows.Forms.PictureBox();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top)).BeginInit();
            this.PN_Main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainSelectLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainNotes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main)).BeginInit();
            this.PN_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LeftControl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainNotesMove)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 3;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.TLP.Controls.Add(this.VSB, 2, 1);
            this.TLP.Controls.Add(this.HSB, 1, 2);
            this.TLP.Controls.Add(this.PB_Top, 1, 0);
            this.TLP.Controls.Add(this.PN_Main, 1, 1);
            this.TLP.Controls.Add(this.PN_Left, 0, 1);
            this.TLP.Controls.Add(this.LB_VoiceBank, 0, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 3;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 25F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.TLP.Size = new System.Drawing.Size(800, 600);
            this.TLP.TabIndex = 0;
            // 
            // VSB
            // 
            this.VSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.VSB.LargeChange = 1;
            this.VSB.Location = new System.Drawing.Point(780, 25);
            this.VSB.Maximum = 84;
            this.VSB.Name = "VSB";
            this.VSB.Size = new System.Drawing.Size(20, 555);
            this.VSB.TabIndex = 0;
            this.VSB.ValueChanged += new System.EventHandler(this.VSB_ValueChanged);
            // 
            // HSB
            // 
            this.HSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HSB.LargeChange = 1;
            this.HSB.Location = new System.Drawing.Point(100, 580);
            this.HSB.Name = "HSB";
            this.HSB.Size = new System.Drawing.Size(680, 20);
            this.HSB.TabIndex = 1;
            this.HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // PB_Top
            // 
            this.PB_Top.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Top.Location = new System.Drawing.Point(100, 0);
            this.PB_Top.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Top.Name = "PB_Top";
            this.PB_Top.Size = new System.Drawing.Size(680, 25);
            this.PB_Top.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Top.TabIndex = 2;
            this.PB_Top.TabStop = false;
            // 
            // PN_Main
            // 
            this.PN_Main.Controls.Add(this.PB_MainNotesMove);
            this.PN_Main.Controls.Add(this.PB_MainSelectLines);
            this.PN_Main.Controls.Add(this.PB_MainNotes);
            this.PN_Main.Controls.Add(this.PB_MainControl);
            this.PN_Main.Controls.Add(this.PB_Main);
            this.PN_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Main.Location = new System.Drawing.Point(100, 25);
            this.PN_Main.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Main.Name = "PN_Main";
            this.PN_Main.Size = new System.Drawing.Size(680, 555);
            this.PN_Main.TabIndex = 5;
            // 
            // PB_MainSelectLines
            // 
            this.PB_MainSelectLines.BackColor = System.Drawing.Color.Transparent;
            this.PB_MainSelectLines.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MainSelectLines.Location = new System.Drawing.Point(0, 0);
            this.PB_MainSelectLines.Margin = new System.Windows.Forms.Padding(0);
            this.PB_MainSelectLines.Name = "PB_MainSelectLines";
            this.PB_MainSelectLines.Size = new System.Drawing.Size(680, 555);
            this.PB_MainSelectLines.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MainSelectLines.TabIndex = 7;
            this.PB_MainSelectLines.TabStop = false;
            // 
            // PB_MainNotes
            // 
            this.PB_MainNotes.BackColor = System.Drawing.Color.Transparent;
            this.PB_MainNotes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MainNotes.Location = new System.Drawing.Point(0, 0);
            this.PB_MainNotes.Margin = new System.Windows.Forms.Padding(0);
            this.PB_MainNotes.Name = "PB_MainNotes";
            this.PB_MainNotes.Size = new System.Drawing.Size(680, 555);
            this.PB_MainNotes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MainNotes.TabIndex = 6;
            this.PB_MainNotes.TabStop = false;
            // 
            // PB_MainControl
            // 
            this.PB_MainControl.BackColor = System.Drawing.Color.Transparent;
            this.PB_MainControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MainControl.Location = new System.Drawing.Point(0, 0);
            this.PB_MainControl.Margin = new System.Windows.Forms.Padding(0);
            this.PB_MainControl.Name = "PB_MainControl";
            this.PB_MainControl.Size = new System.Drawing.Size(680, 555);
            this.PB_MainControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MainControl.TabIndex = 5;
            this.PB_MainControl.TabStop = false;
            this.PB_MainControl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PB_MainControl_MouseDown);
            this.PB_MainControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_MainControl_MouseMove);
            this.PB_MainControl.MouseUp += new System.Windows.Forms.MouseEventHandler(this.PB_MainControl_MouseUp);
            // 
            // PB_Main
            // 
            this.PB_Main.BackColor = System.Drawing.Color.Transparent;
            this.PB_Main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Main.Location = new System.Drawing.Point(0, 0);
            this.PB_Main.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Main.Name = "PB_Main";
            this.PB_Main.Size = new System.Drawing.Size(680, 555);
            this.PB_Main.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Main.TabIndex = 4;
            this.PB_Main.TabStop = false;
            // 
            // PN_Left
            // 
            this.PN_Left.Controls.Add(this.PB_Left);
            this.PN_Left.Controls.Add(this.PB_LeftControl);
            this.PN_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PN_Left.Location = new System.Drawing.Point(0, 25);
            this.PN_Left.Margin = new System.Windows.Forms.Padding(0);
            this.PN_Left.Name = "PN_Left";
            this.PN_Left.Size = new System.Drawing.Size(100, 555);
            this.PN_Left.TabIndex = 6;
            // 
            // PB_Left
            // 
            this.PB_Left.BackColor = System.Drawing.Color.Transparent;
            this.PB_Left.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Left.Location = new System.Drawing.Point(0, 0);
            this.PB_Left.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Left.Name = "PB_Left";
            this.PB_Left.Size = new System.Drawing.Size(100, 555);
            this.PB_Left.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_Left.TabIndex = 3;
            this.PB_Left.TabStop = false;
            // 
            // PB_LeftControl
            // 
            this.PB_LeftControl.BackColor = System.Drawing.Color.Transparent;
            this.PB_LeftControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_LeftControl.Location = new System.Drawing.Point(0, 0);
            this.PB_LeftControl.Margin = new System.Windows.Forms.Padding(0);
            this.PB_LeftControl.Name = "PB_LeftControl";
            this.PB_LeftControl.Size = new System.Drawing.Size(100, 555);
            this.PB_LeftControl.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_LeftControl.TabIndex = 7;
            this.PB_LeftControl.TabStop = false;
            this.PB_LeftControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_LeftControl_MouseMove);
            // 
            // LB_VoiceBank
            // 
            this.LB_VoiceBank.AutoSize = true;
            this.LB_VoiceBank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_VoiceBank.Font = new System.Drawing.Font("微軟正黑體", 8F);
            this.LB_VoiceBank.Location = new System.Drawing.Point(3, 0);
            this.LB_VoiceBank.Name = "LB_VoiceBank";
            this.LB_VoiceBank.Size = new System.Drawing.Size(94, 25);
            this.LB_VoiceBank.TabIndex = 7;
            // 
            // PB_MainNotesMove
            // 
            this.PB_MainNotesMove.BackColor = System.Drawing.Color.Transparent;
            this.PB_MainNotesMove.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_MainNotesMove.Location = new System.Drawing.Point(0, 0);
            this.PB_MainNotesMove.Margin = new System.Windows.Forms.Padding(0);
            this.PB_MainNotesMove.Name = "PB_MainNotesMove";
            this.PB_MainNotesMove.Size = new System.Drawing.Size(680, 555);
            this.PB_MainNotesMove.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PB_MainNotesMove.TabIndex = 8;
            this.PB_MainNotesMove.TabStop = false;
            // 
            // HMainEditor
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.Controls.Add(this.TLP);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HMainEditor";
            this.Size = new System.Drawing.Size(800, 600);
            this.Load += new System.EventHandler(this.HMainEditor_Load);
            this.SizeChanged += new System.EventHandler(this.HMainEditor_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HMainEditor_KeyDown);
            this.TLP.ResumeLayout(false);
            this.TLP.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Top)).EndInit();
            this.PN_Main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainSelectLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainNotes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Main)).EndInit();
            this.PN_Left.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Left)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_LeftControl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PB_MainNotesMove)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.VScrollBar VSB;
        private System.Windows.Forms.HScrollBar HSB;
        private System.Windows.Forms.PictureBox PB_Top;
        private System.Windows.Forms.PictureBox PB_Left;
        private System.Windows.Forms.PictureBox PB_Main;
        private System.Windows.Forms.Panel PN_Main;
        private System.Windows.Forms.PictureBox PB_MainControl;
        private System.Windows.Forms.Panel PN_Left;
        private System.Windows.Forms.PictureBox PB_LeftControl;
        private System.Windows.Forms.Label LB_VoiceBank;
        private System.Windows.Forms.PictureBox PB_MainSelectLines;
        private System.Windows.Forms.PictureBox PB_MainNotes;
        private System.Windows.Forms.PictureBox PB_MainNotesMove;
    }
}
