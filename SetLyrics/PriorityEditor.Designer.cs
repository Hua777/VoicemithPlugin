namespace SetLyrics
{
    partial class PriorityEditor
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PriorityEditor));
            this.TLP = new System.Windows.Forms.TableLayoutPanel();
            this.TLP_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Complete = new System.Windows.Forms.Button();
            this.BTN_Cancel = new System.Windows.Forms.Button();
            this.TLP_Editor = new System.Windows.Forms.TableLayoutPanel();
            this.TB_Value = new System.Windows.Forms.TextBox();
            this.TB_Key = new System.Windows.Forms.TextBox();
            this.LB_Tmp = new System.Windows.Forms.Label();
            this.LV_PriorityList = new System.Windows.Forms.ListView();
            this.CH_Key = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CH_Value = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.TLP_Settings = new System.Windows.Forms.TableLayoutPanel();
            this.BTN_Delete = new System.Windows.Forms.Button();
            this.BTN_Add = new System.Windows.Forms.Button();
            this.TLP.SuspendLayout();
            this.TLP_Buttons.SuspendLayout();
            this.TLP_Editor.SuspendLayout();
            this.TLP_Settings.SuspendLayout();
            this.SuspendLayout();
            // 
            // TLP
            // 
            this.TLP.ColumnCount = 1;
            this.TLP.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.Controls.Add(this.TLP_Buttons, 0, 3);
            this.TLP.Controls.Add(this.TLP_Editor, 0, 2);
            this.TLP.Controls.Add(this.LV_PriorityList, 0, 1);
            this.TLP.Controls.Add(this.TLP_Settings, 0, 0);
            this.TLP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP.Location = new System.Drawing.Point(0, 0);
            this.TLP.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TLP.Name = "TLP";
            this.TLP.RowCount = 4;
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.TLP.Size = new System.Drawing.Size(284, 461);
            this.TLP.TabIndex = 0;
            // 
            // TLP_Buttons
            // 
            this.TLP_Buttons.ColumnCount = 2;
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Buttons.Controls.Add(this.BTN_Complete, 0, 0);
            this.TLP_Buttons.Controls.Add(this.BTN_Cancel, 1, 0);
            this.TLP_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Buttons.Location = new System.Drawing.Point(3, 425);
            this.TLP_Buttons.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TLP_Buttons.Name = "TLP_Buttons";
            this.TLP_Buttons.RowCount = 1;
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 32F));
            this.TLP_Buttons.Size = new System.Drawing.Size(278, 32);
            this.TLP_Buttons.TabIndex = 1;
            // 
            // BTN_Complete
            // 
            this.BTN_Complete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Complete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Complete.Location = new System.Drawing.Point(3, 4);
            this.BTN_Complete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Complete.Name = "BTN_Complete";
            this.BTN_Complete.Size = new System.Drawing.Size(133, 24);
            this.BTN_Complete.TabIndex = 1;
            this.BTN_Complete.TabStop = false;
            this.BTN_Complete.Text = "完成";
            this.BTN_Complete.UseVisualStyleBackColor = true;
            this.BTN_Complete.Click += new System.EventHandler(this.BTN_Complete_Click);
            // 
            // BTN_Cancel
            // 
            this.BTN_Cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BTN_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Cancel.Location = new System.Drawing.Point(142, 4);
            this.BTN_Cancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BTN_Cancel.Name = "BTN_Cancel";
            this.BTN_Cancel.Size = new System.Drawing.Size(133, 24);
            this.BTN_Cancel.TabIndex = 0;
            this.BTN_Cancel.TabStop = false;
            this.BTN_Cancel.Text = "取消";
            this.BTN_Cancel.UseVisualStyleBackColor = true;
            this.BTN_Cancel.Click += new System.EventHandler(this.BTN_Cancel_Click);
            // 
            // TLP_Editor
            // 
            this.TLP_Editor.ColumnCount = 3;
            this.TLP_Editor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Editor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLP_Editor.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TLP_Editor.Controls.Add(this.TB_Value, 2, 0);
            this.TLP_Editor.Controls.Add(this.TB_Key, 0, 0);
            this.TLP_Editor.Controls.Add(this.LB_Tmp, 1, 0);
            this.TLP_Editor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Editor.Location = new System.Drawing.Point(3, 385);
            this.TLP_Editor.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TLP_Editor.Name = "TLP_Editor";
            this.TLP_Editor.RowCount = 1;
            this.TLP_Editor.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Editor.Size = new System.Drawing.Size(278, 32);
            this.TLP_Editor.TabIndex = 2;
            // 
            // TB_Value
            // 
            this.TB_Value.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Value.Location = new System.Drawing.Point(157, 4);
            this.TB_Value.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Value.Name = "TB_Value";
            this.TB_Value.Size = new System.Drawing.Size(118, 23);
            this.TB_Value.TabIndex = 2;
            this.TB_Value.TabStop = false;
            this.TB_Value.TextChanged += new System.EventHandler(this.TB_Value_TextChanged);
            // 
            // TB_Key
            // 
            this.TB_Key.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TB_Key.Location = new System.Drawing.Point(3, 4);
            this.TB_Key.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.TB_Key.Name = "TB_Key";
            this.TB_Key.Size = new System.Drawing.Size(118, 23);
            this.TB_Key.TabIndex = 0;
            this.TB_Key.TabStop = false;
            this.TB_Key.TextChanged += new System.EventHandler(this.TB_Key_TextChanged);
            // 
            // LB_Tmp
            // 
            this.LB_Tmp.AutoSize = true;
            this.LB_Tmp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LB_Tmp.Location = new System.Drawing.Point(127, 0);
            this.LB_Tmp.Name = "LB_Tmp";
            this.LB_Tmp.Size = new System.Drawing.Size(24, 32);
            this.LB_Tmp.TabIndex = 3;
            this.LB_Tmp.Text = "=";
            this.LB_Tmp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LV_PriorityList
            // 
            this.LV_PriorityList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LV_PriorityList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CH_Key,
            this.CH_Value});
            this.LV_PriorityList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LV_PriorityList.FullRowSelect = true;
            this.LV_PriorityList.Location = new System.Drawing.Point(3, 43);
            this.LV_PriorityList.MultiSelect = false;
            this.LV_PriorityList.Name = "LV_PriorityList";
            this.LV_PriorityList.Size = new System.Drawing.Size(278, 335);
            this.LV_PriorityList.TabIndex = 3;
            this.LV_PriorityList.TabStop = false;
            this.LV_PriorityList.UseCompatibleStateImageBehavior = false;
            this.LV_PriorityList.View = System.Windows.Forms.View.Details;
            this.LV_PriorityList.SelectedIndexChanged += new System.EventHandler(this.LV_PriorityList_SelectedIndexChanged);
            // 
            // CH_Key
            // 
            this.CH_Key.Text = "漢字";
            this.CH_Key.Width = 120;
            // 
            // CH_Value
            // 
            this.CH_Value.Text = "拼音";
            this.CH_Value.Width = 120;
            // 
            // TLP_Settings
            // 
            this.TLP_Settings.ColumnCount = 3;
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLP_Settings.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.TLP_Settings.Controls.Add(this.BTN_Delete, 1, 0);
            this.TLP_Settings.Controls.Add(this.BTN_Add, 2, 0);
            this.TLP_Settings.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TLP_Settings.Location = new System.Drawing.Point(3, 3);
            this.TLP_Settings.Name = "TLP_Settings";
            this.TLP_Settings.RowCount = 1;
            this.TLP_Settings.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TLP_Settings.Size = new System.Drawing.Size(278, 34);
            this.TLP_Settings.TabIndex = 4;
            // 
            // BTN_Delete
            // 
            this.BTN_Delete.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Delete.Location = new System.Drawing.Point(221, 3);
            this.BTN_Delete.Name = "BTN_Delete";
            this.BTN_Delete.Size = new System.Drawing.Size(24, 28);
            this.BTN_Delete.TabIndex = 2;
            this.BTN_Delete.TabStop = false;
            this.BTN_Delete.Text = "-";
            this.BTN_Delete.UseVisualStyleBackColor = true;
            this.BTN_Delete.Click += new System.EventHandler(this.BTN_Delete_Click);
            // 
            // BTN_Add
            // 
            this.BTN_Add.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BTN_Add.Location = new System.Drawing.Point(251, 3);
            this.BTN_Add.Name = "BTN_Add";
            this.BTN_Add.Size = new System.Drawing.Size(24, 28);
            this.BTN_Add.TabIndex = 0;
            this.BTN_Add.TabStop = false;
            this.BTN_Add.Text = "+";
            this.BTN_Add.UseVisualStyleBackColor = true;
            this.BTN_Add.Click += new System.EventHandler(this.BTN_Add_Click);
            // 
            // PriorityEditor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 461);
            this.Controls.Add(this.TLP);
            this.Font = new System.Drawing.Font("微軟正黑體", 9F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(300, 200);
            this.Name = "PriorityEditor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "優先轉換字典編輯器";
            this.Load += new System.EventHandler(this.PriorityEditor_Load);
            this.TLP.ResumeLayout(false);
            this.TLP_Buttons.ResumeLayout(false);
            this.TLP_Editor.ResumeLayout(false);
            this.TLP_Editor.PerformLayout();
            this.TLP_Settings.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel TLP;
        private System.Windows.Forms.TableLayoutPanel TLP_Buttons;
        private System.Windows.Forms.Button BTN_Complete;
        private System.Windows.Forms.Button BTN_Cancel;
        private System.Windows.Forms.TableLayoutPanel TLP_Editor;
        private System.Windows.Forms.TextBox TB_Key;
        private System.Windows.Forms.TextBox TB_Value;
        private System.Windows.Forms.Label LB_Tmp;
        private System.Windows.Forms.ListView LV_PriorityList;
        private System.Windows.Forms.ColumnHeader CH_Key;
        private System.Windows.Forms.ColumnHeader CH_Value;
        private System.Windows.Forms.TableLayoutPanel TLP_Settings;
        private System.Windows.Forms.Button BTN_Add;
        private System.Windows.Forms.Button BTN_Delete;
    }
}