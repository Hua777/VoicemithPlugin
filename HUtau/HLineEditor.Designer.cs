namespace HUtau
{
    partial class HLineEditor
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
            this.HSB = new System.Windows.Forms.HScrollBar();
            this.PB_Notes = new System.Windows.Forms.PictureBox();
            this.TLP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PB_Notes)).BeginInit();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 1;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Controls.Add(this.HSB, 0, 1);
            this.TLP.Controls.Add(this.PB_Notes, 0, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(0);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 2;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 18F));
            this.TLP.Size = new System.Drawing.Size(600, 60);
            this.TLP.TabIndex = 0;
            // 
            // HSB
            // 
            this.HSB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.HSB.Location = new System.Drawing.Point(0, 42);
            this.HSB.Name = "HSB";
            this.HSB.Size = new System.Drawing.Size(600, 18);
            this.HSB.TabIndex = 0;
            this.HSB.ValueChanged += new System.EventHandler(this.HSB_ValueChanged);
            // 
            // PB_Notes
            // 
            this.PB_Notes.BackColor = System.Drawing.Color.White;
            this.PB_Notes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PB_Notes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PB_Notes.Location = new System.Drawing.Point(0, 0);
            this.PB_Notes.Margin = new System.Windows.Forms.Padding(0);
            this.PB_Notes.Name = "PB_Notes";
            this.PB_Notes.Size = new System.Drawing.Size(600, 42);
            this.PB_Notes.TabIndex = 1;
            this.PB_Notes.TabStop = false;
            this.PB_Notes.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PB_Notes_MouseMove);
            // 
            // HLineEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HLineEditor";
            this.Size = new System.Drawing.Size(600, 60);
            this.Load += new System.EventHandler(this.HLineEditor_Load);
            this.Resize += new System.EventHandler(this.HLineEditor_Resize);
            this.TLP.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PB_Notes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.HScrollBar HSB;
        private System.Windows.Forms.PictureBox PB_Notes;
    }
}
