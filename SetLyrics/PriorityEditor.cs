using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace SetLyrics
{
    public partial class PriorityEditor : Form
    {
        private string PriorityPath = "";

        public PriorityEditor(string _path)
        {
            PriorityPath = _path;
            InitializeComponent();
        }

        private void PriorityEditor_Load(object sender, EventArgs e)
        {
            ReadList(PriorityPath);
        }

        private void BTN_Complete_Click(object sender, EventArgs e)
        {
            SaveList(PriorityPath);
            this.DialogResult = DialogResult.OK;
        }

        private void BTN_Cancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void BTN_Add_Click(object sender, EventArgs e)
        {
            ListViewItem lvi = new ListViewItem("例");
            lvi.SubItems.Add("li");
            LV_PriorityList.Items.Insert(0, lvi);
            LV_PriorityList.SelectedItems.Clear();
            lvi.Selected = true;
        }

        private void BTN_Delete_Click(object sender, EventArgs e)
        {
            if (LV_PriorityList.SelectedItems.Count == 1)
            {
                ListViewItem lvi = LV_PriorityList.SelectedItems[0];
                LV_PriorityList.Items.Remove(lvi);
                LV_PriorityList.SelectedItems.Clear();
            }
        }

        private void LV_PriorityList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (LV_PriorityList.SelectedItems.Count == 1)
            {
                ListViewItem lvi = LV_PriorityList.SelectedItems[0];
                LoadToTextBox(lvi.SubItems[0].Text, lvi.SubItems[1].Text);
            }
        }

        private void TB_Key_TextChanged(object sender, EventArgs e)
        {
            if (LV_PriorityList.SelectedItems.Count == 1)
            {
                ListViewItem lvi = LV_PriorityList.SelectedItems[0];
                lvi.SubItems[0].Text = TB_Key.Text;
            }
        }

        private void TB_Value_TextChanged(object sender, EventArgs e)
        {
            if (LV_PriorityList.SelectedItems.Count == 1)
            {
                ListViewItem lvi = LV_PriorityList.SelectedItems[0];
                lvi.SubItems[1].Text = TB_Value.Text;
            }
        }

        /// <summary>
        /// 將優先字典檔讀入並放入 ListView
        /// </summary>
        /// <param name="_path">優先字典檔位置</param>
        private void ReadList(string _path)
        {
            if (!File.Exists(_path))
            {
                FileStream fs = new FileStream(_path, FileMode.Create);
                fs.Close();
            }
            string[] priorityList = File.ReadAllLines(_path, Encoding.Unicode);
            string[] afterSplit = null;
            int i, end = priorityList.Length;
            for (i = 0; i < end; i++)
            {
                afterSplit = priorityList[i].Split(new char[] { '=' });
                if (afterSplit.Length == 2)
                {
                    ListViewItem lvi = new ListViewItem(afterSplit[0]);
                    lvi.SubItems.Add(afterSplit[1]);
                    LV_PriorityList.Items.Add(lvi);
                }
            }
        }

        /// <summary>
        /// 將存放在 ListView 中的字典列表儲存
        /// </summary>
        /// <param name="_path">優先字典檔位置</param>
        private void SaveList(string _path)
        {
            List<string> tmpList = new List<string>();
            foreach (ListViewItem tmpLvi in LV_PriorityList.Items)
            {
                tmpList.Add(tmpLvi.Text + "=" + tmpLvi.SubItems[1].Text);
            }
            File.WriteAllLines(_path, tmpList.ToArray(), Encoding.Unicode);
        }

        /// <summary>
        /// 將列表某一欄放入 TextBox 中以利編輯
        /// </summary>
        /// <param name="_key">Key</param>
        /// <param name="_value">Value</param>
        private void LoadToTextBox(string _key, string _value)
        {
            TB_Key.Text = _key;
            TB_Value.Text = _value;
        }

        /// <summary>
        /// 將優先轉換檔案讀入並轉為字典類別
        /// </summary>
        /// <param name="_path">優先字典檔位置</param>
        /// <returns></returns>
        public static Dictionary<string, string> GetList(string _path)
        {
            string[] allLines = File.ReadAllLines(_path, Encoding.Unicode);
            string[] afterSplit = null;
            Dictionary<string, string> tmpList = new Dictionary<string, string>();
            int i, end = allLines.Length;
            for (i = 0; i < end; i++)
            {
                afterSplit = allLines[i].Split(new char[] { '=' });
                if (afterSplit.Length == 2)
                {
                    if (!tmpList.ContainsKey(afterSplit[0]))
                    {
                        tmpList.Add(afterSplit[0], afterSplit[1]);
                    }
                }
            }
            return tmpList;
        }
    }
}
