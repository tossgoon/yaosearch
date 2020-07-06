using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
using System.IO;
namespace YaoSearch
{
    public partial class FormUnsale : Form
    {
        private SqlConnection thisConn;//SQL Server数据库连接
        private FormLoading formLoading;//loading窗口
        private DateTime begindate, enddate, buydate;
        private int unsaleNum;
        public FormUnsale()
        {
            InitializeComponent();
        }
        public FormUnsale(SqlConnection thisConn)
        {
            this.thisConn = thisConn;
            InitializeComponent();
        }

        private void dgvDrug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvDrug.SelectedRows[0];
                UpdateCurrentText(row);
            }
        }
        private void UpdateCurrentText(DataGridViewRow row)
        {
            if (row.Cells[1].Value != null)
            {
                txtmc.Text = row.Cells[1].Value.ToString();
            }
            if (row.Cells[2].Value != null)
            {
                txtsccj.Text = row.Cells[2].Value.ToString();
            }
            if (row.Cells[0].Value != null)
            {
                txtgg.Text = row.Cells[0].Value.ToString();
            }
            if (row.Cells[3].Value != null)
            {
                txtpc.Text = row.Cells[3].Value.ToString();
            }
            txt_bz.Text=row.Cells[11].Value.ToString();
            lbtipinfo.Text = "<>";
        }
        private void btnSearchUnsalable_Click(object sender, EventArgs e)
        {
            
        }
        private void SelectUnsalableItems()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                //DataTable dbtable = dbobj.GetUnSalableDrug(thisConn, begindate, enddate, buydate, unsaleNum);
                List<DataTable> dtlist = dbobj.GetUnSalableDrug(thisConn, begindate, enddate, buydate, unsaleNum);//西药
                String info = dbobj.GetUnSalableDrug_ZongDian(thisConn);
                DataTable dtzhongyao = dbobj.GetUnSalableDrug_ZhongYao(thisConn);

                String info2 = dbobj.GetUnSalableDrug_ZongDian_Zhongyao(thisConn);

                this.Invoke((MethodInvoker)delegate()
                {
                    dgvDrug.DataSource = dtlist[0];
                    dgv_yanzhong.DataSource = dtlist[1];
                    this.dgv_zhixiao.DataSource = dtlist[2];
                    this.dgv_jianyi.DataSource = dtlist[3];
                    formLoading.Dispose();
                    for (int i = 0; i < dgvDrug.Columns.Count; i++)
                    {
                        dgvDrug.Columns[i].ReadOnly = true;
                    }
                    if (dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
                    {
                        DataGridViewRow row = dgvDrug.SelectedRows[0];
                        UpdateCurrentText(row);
                    }
                    //总店
                    labelinfo.Text =  info ;
                    //中药
                    dgv_zhongyao.DataSource = dtzhongyao;
                    //总店中药
                    rtxt_zhongyao.Text = info2;
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    formLoading.Dispose();
                });
            }
        }

        private void FormUnsale_Load(object sender, EventArgs e)
        {
            /*SqlCommand thisCommand = thisConn.CreateCommand();
            //0.更新滞销原因
            DataTable dtreason = new DataTable();
            dtreason.Columns.Add("reason");
            thisCommand.CommandText = "SELECT DISTINCT name FROM z_unsale WHERE type = 1";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                String reason = thisReader[0].ToString();
                DataRow dr = dtreason.NewRow();
                dr["reason"] = reason;
                dtreason.Rows.Add(dr);
            }
            thisReader.Close();

            cboxReason.DataSource = dtreason;
            cboxReason.DisplayMember = "reason";
            cboxReason.ValueMember = "reason";
            cboxReason.SelectedIndex = 0;
            //1.更新滞销处理结果
            DataTable dtresult = new DataTable();
            dtresult.Columns.Add("result");
            thisCommand.CommandText = "SELECT DISTINCT name FROM z_unsale WHERE type = 2";
            thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                String result = thisReader[0].ToString();
                DataRow dr = dtresult.NewRow();
                dr["result"] = result;
                dtresult.Rows.Add(dr);
            }
            thisReader.Close();

            cboxResult.DataSource = dtresult;
            cboxResult.DisplayMember = "result";
            cboxResult.ValueMember = "result";
            cboxResult.SelectedIndex = 0;
             * */
        }

        private void btuUpdate_Click(object sender, EventArgs e)
        {
            string reason=txt_bz.Text;
            //string result = cboxResult.SelectedValue.ToString();//结果
            //if (dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
            //{
                string bm = txtgg.Text;//编码
                SqlCommand thisCommand = thisConn.CreateCommand();
                //0.更新滞销原因
                if (bm != null && bm != "")
                {
                    thisCommand.CommandText = string.Format("update p_spjcxx_sz Set bz='{0}' WHERE bm = {1}", reason, bm);
                    thisCommand.ExecuteNonQuery();
                }
                lbtipinfo.Text = "保存完成";

                int index = tabControl1.SelectedIndex;
                if (index == 0 && this.dgvDrug.SelectedRows!=null)
                {
                    this.dgvDrug.SelectedRows[0].Cells[11].Value = reason; 
                }
                else if (index == 1 && this.dgv_yanzhong.SelectedRows != null)
                {
                     this.dgv_yanzhong.SelectedRows[0].Cells[11].Value = reason; 
                }
                else if (index == 2 && this.dgv_zhixiao.SelectedRows != null)
                {
                      this.dgv_zhixiao.SelectedRows[0].Cells[11].Value = reason; 
                }
                else if (index == 3 && this.dgv_jianyi.SelectedRows != null)
                {
                     this.dgv_jianyi.SelectedRows[0].Cells[11].Value = reason; 
                }
                else if (index == 4 && this.dgv_zhongyao.SelectedRows != null)
                {
                    this.dgv_zhongyao.SelectedRows[0].Cells[8].Value = reason;
                }
                //dgvDrug.SelectedRows[0].Cells[11].Value = reason;
            //}
        }
        string fileName = "";
        private void tbtnExportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                ParameterizedThreadStart parStart = new ParameterizedThreadStart(ExportDgv2Txt);
                Thread thread = new Thread(parStart);
                int index = tabControl1.SelectedIndex;
                object o=new object();
                if (index == 0)
                {
                     o = this.dgvDrug;
                }
                else if (index == 1)
                {
                    o = this.dgv_yanzhong;
                }
                else if (index == 2)
                {
                    o = this.dgv_zhixiao;
                }
                else if (index == 3)
                {
                    o = this.dgv_jianyi;
                }
                else if (index == 4)
                {
                    o = this.dgv_zhongyao;
                }
                thread.Start(o);
            }
        }
        private void ExportDgv2Txt(object dgv)
        {
            DataGridView dgvS = dgv as DataGridView;
            int rowscount = dgvS.Rows.Count;
            this.Invoke((MethodInvoker)delegate()
            {
                stripLabelInfo.Text = "准备数据导出...";
                tstripProgress.Maximum = rowscount + 1;
                tstripProgress.Minimum = 1;
                tstripProgress.Value = 1;
            });
            FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);//构建导出文件
            string str = "";
            //标题行 
            foreach (DataGridViewColumn dgvc in dgvS.Columns)
            {
                str += dgvc.HeaderText + ",";
            }
            sw.WriteLine(str);
            //内容
            int i = 1;
            foreach (DataGridViewRow row in dgvS.Rows)
            {
                str = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    if (cell.Value != null)
                    {
                        str += cell.Value.ToString() + ",";
                    }
                    else
                    {
                        str += ",";
                    }
                }
                sw.WriteLine(str);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "正在导出第" + i + "/" + rowscount;
                    tstripProgress.Value++;
                });
            }
            sw.Close();
            sw.Dispose();
            this.Invoke((MethodInvoker)delegate()
            {
                MessageBox.Show("导出完成");
                stripLabelInfo.Text = "导出完成";
            });

        }

        private void tbtnDeleteType_Click(object sender, EventArgs e)
        {

        }

        private void dgv_yanzhong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgv_yanzhong.SelectedRows.Count > 0 && dgv_yanzhong.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgv_yanzhong.SelectedRows[0];
                UpdateCurrentText(row);
            }
        }

        private void dgv_zhixiao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgv_zhixiao.SelectedRows.Count > 0 && dgv_zhixiao.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgv_zhixiao.SelectedRows[0];
                UpdateCurrentText(row);
            }
        }

        private void dgv_jianyi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgv_jianyi.SelectedRows.Count > 0 && dgv_jianyi.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgv_jianyi.SelectedRows[0];
                UpdateCurrentText(row);
            }
        }

        private void dgv_zhongyao_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgv_zhongyao.SelectedRows.Count > 0 && dgv_zhongyao.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgv_zhongyao.SelectedRows[0];
                //UpdateCurrentText(row);
                if (row.Cells[1].Value != null)
                {
                    txtmc.Text = row.Cells[1].Value.ToString();
                }
                if (row.Cells[2].Value != null)
                {
                    txtsccj.Text = row.Cells[2].Value.ToString();
                }
                if (row.Cells[0].Value != null)
                {
                    txtgg.Text = row.Cells[0].Value.ToString();
                }
                if (row.Cells[3].Value != null)
                {
                    txtpc.Text = row.Cells[3].Value.ToString();
                }
                txt_bz.Text = row.Cells[8].Value.ToString();
                lbtipinfo.Text = "<>";
            }
        }

        private void tbtn_search_Click(object sender, EventArgs e)
        {
            if (this.txtUnsaleMonth.Text == "")
            {
                MessageBox.Show("输入数字");
                return;
            }
            //begindate = dtpkBegindate.Value;
            //enddate = dtpkEnddate.Value.AddDays(1).AddSeconds(-1);
            //buydate = dtpkBuyDate.Value;
            /*if (!int.TryParse(txtUnsaleNum.Text, out unsaleNum))
            {
                unsaleNum = 0;
                MessageBox.Show("输入数字");
                return;
            }
             * 
            if (unsaleNum < 1 || unsaleNum > 24)
            {
                MessageBox.Show("月数在1-24之间");
                return;
            }
            */

            dgv_yanzhong.Columns.Clear();
            dgv_zhixiao.Columns.Clear();
            dgv_zhongyao.Columns.Clear();
            dgv_jianyi.Columns.Clear();
            dgvDrug.Columns.Clear();

            Thread thread = new Thread(new ThreadStart(SelectUnsalableItems));
            thread.Start();
            formLoading = new FormLoading("查询药品存销比");
            formLoading.ShowDialog();
        }

    }
}
