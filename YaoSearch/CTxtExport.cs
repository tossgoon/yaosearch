using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
namespace YaoSearch
{
   public class CTxtExport
    {
        /// <summary>
        /// 导出数据
        /// </summary>
        /// <param name="FullFileName"></param>
        /// <param name="TextAll"></param>
        /// <returns></returns>
        public static Boolean TxtExport(string FullFileName, string TextAll)
        {
            if (!CreatFile(FullFileName))
            {
                return false;
            }

            StreamWriter sw = new StreamWriter(FullFileName, true, Encoding.Default);   //该编码类型不会改变已有文件的编码类型
            sw.WriteLine(TextAll);
            sw.Close();
            return true;
        }
        /// <summary>
        /// 创建文件（文件存在则跳过）
        /// </summary>
        /// <param name="FullFileName">带路径的文件名</param>
        /// <returns></returns>
        public static Boolean CreatFile(string FullFileName)
        {
            if (File.Exists(FullFileName))
            {
                return true;
            }
            else
            {
                try
                {
                    FileStream fs = new FileStream(FullFileName, FileMode.CreateNew);
                    fs.Close();
                    return true;
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message.ToString());
                    return false;
                }
            }
        }
       public static string GetTxtFromDgv(DataGridView dgv)
        {
            string str = "";
            //1.导出标题行
            foreach(DataGridViewColumn dgvc in dgv.Columns)
            {
                str += dgvc.HeaderText + ",";
            }
            str += "\r\n";
            //2.导出内容
            foreach(DataGridViewRow row in dgv.Rows)
            {
                foreach(DataGridViewCell cell in row.Cells)
                {
                    str += cell.Value.ToString() + ",";
                }
                str += "\r\n";
            }
            return str;
        }
    }
}
