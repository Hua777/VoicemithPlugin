using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SetLyrics
{
    static class Program
    {
        /// <summary>
        /// 應用程式的主要進入點。
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            try
            {
                if (args.Length == 1)
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new Simple(args[0]));
                }
                else
                {
                    MessageBox.Show("請在UTAU中開啟", "警告", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("請使用系統管理員身分開啟UTAU", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch(Exception e)
            {
                MessageBox.Show("未知的錯誤", "錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
                MessageBox.Show(e.Message, "詳細的錯誤", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
