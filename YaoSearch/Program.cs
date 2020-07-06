using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace YaoSearch
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form form = new FormMain();
            if (form != null && !form.IsDisposed)
            {
                Application.Run(form);
            }
            else
            {
                MessageBox.Show("数据库连接错误，请检查配置文件.");
            }
        }
    }
}
