using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Threading;
namespace YaoSearch
{
    public partial class FormCaiGou : Form
    {
        private SqlConnection thisConn; //本地数据库
        private SqlConnection remoteConn;//远程数据库 
        private string dm;
        private FormLoading formLoading;
        public FormCaiGou()
        {
            InitializeComponent();
        }
        public FormCaiGou(SqlConnection thisConn,string dm)
        {
            this.thisConn = thisConn;
            this.dm = dm;
            InitializeComponent();
        }
        private void dgvPur_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            //dgvPur.Rows[e.RowIndex].Cells[7].Value = "选择";

        }

        private void dgvPur_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void linkTestConn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TestRemoteConn();
        }
        private void TestRemoteConn()
        {
            bool isConntected = false;
            SqlConnection testRemoteConn = new SqlConnection(txtDbConn.Text);
            try
            {
                testRemoteConn.Open();
            }
            catch
            {
                isConntected = false;
            }
            finally
            {
                if (testRemoteConn.State == ConnectionState.Open)
                {
                    isConntected = true;
                    testRemoteConn.Close();
                    testRemoteConn.Dispose();
                }
            }
            if (isConntected)
            {
                lbresult.Text = "√连接正常.";
            }
            else
            {
                lbresult.Text = "×数据库连接错误.";
            }
        }
        private void InitRemoteConnection()
        {
            bool isConntected = false;
            remoteConn = new SqlConnection(txtDbConn.Text);
            try
            {
                remoteConn.Open();
            }
            catch
            {
                isConntected = false;
            }
            finally
            {
                if (remoteConn.State == ConnectionState.Open)
                {
                    isConntected = true;
                }
            }
            if (isConntected)
            {
                lbresult.Text = "√连接正常.";
            }
            else
            {
                lbresult.Text = "×数据库连接错误.";
            }
        }

        private void FormCaiGou_Load(object sender, EventArgs e)
        {
            string str = CDBOperate.GetDBConnectFromTxt();
            this.txtDbConn.Text = str;
            InitRemoteConnection();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FormSelectPur form = new FormSelectPur(thisConn);
            form.pursSelectEvent += form_pursSelectEvent;
            form.ShowDialog();
        }

        void form_pursSelectEvent(List<CSpxx> splist)
        {
            foreach (CSpxx sp in splist)
            {
               int index= dgvPur.Rows.Add();
               dgvPur.Rows[index].Cells[2].Value = sp.Bm;
               dgvPur.Rows[index].Cells[3].Value = sp.Mc;
               dgvPur.Rows[index].Cells[4].Value = sp.Sccj;
               dgvPur.Rows[index].Cells[5].Value = sp.Gg;
               dgvPur.Rows[index].Cells[6].Value = sp.Jhdw;
            }
        }

        private void btnSelectAll_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < this.dgvPur.Rows.Count; i++)
            {
                //设置设置每一行的选择框为选中，第一列为checkbox
                dgvPur.Rows[i].Cells[1].Value = true;
            }
        }

        private void btnUnSelect_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dgvPur.Rows.Count; i++)
            {
                //判断当前行是否被选中
                if ((bool)dgvPur.Rows[i].Cells[1].EditedFormattedValue == true)
                //设置每一行的选择框为未选中
                { dgvPur.Rows[i].Cells[1].Value = false; }
                else
                //设置每一行的选择框为选中
                { dgvPur.Rows[i].Cells[1].Value = true; }
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            //循环dataGridView
            for (int i = 0; i < dgvPur.Rows.Count; i++)
            {
                //判断当前行是否被选中
                if ((bool)dgvPur.Rows[i].Cells[1].EditedFormattedValue == true)
                //设置每一行的选择框为未选中
                {
                    dgvPur.Rows.RemoveAt(i);
                    i--;
                }
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            //1.判断采购单数据
            foreach (DataGridViewRow r in dgvPur.Rows)
            {
                if (r.Cells[7].Value == null)
                {
                    MessageBox.Show("第"+(r.Index+1).ToString()+"行数量为空");
                    return;
                }
                double num = 0;
                if (!double.TryParse(r.Cells[7].Value.ToString(), out num))
                {
                    MessageBox.Show("第" + (r.Index + 1).ToString() + "行数量错误");
                    return;
                }
                if (num <= 0)
                {
                    MessageBox.Show("第" + (r.Index + 1).ToString() + "行数量必须>=0");
                    return;
                }
                
            }
            //2.上传到远程服务器
            Thread thread = new Thread(new ParameterizedThreadStart(UploadPur));
            thread.Start(dgvPur.Rows);
            formLoading = new FormLoading("正在上传...");
            formLoading.ShowDialog();
        }
        private void UploadPur(Object rows)
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataGridViewRowCollection dgvrows = rows as DataGridViewRowCollection;
                foreach (DataGridViewRow r in dgvrows)
                {
                    string bm = r.Cells[2].Value == null ? "" : r.Cells[2].Value.ToString();
                    string mc = r.Cells[3].Value == null ? "" : r.Cells[3].Value.ToString();
                    string sccj = r.Cells[4].Value == null ? "" : r.Cells[4].Value.ToString();
                    string gg = r.Cells[5].Value == null ? "" : r.Cells[5].Value.ToString();
                    string jhdw = r.Cells[6].Value == null ? "" : r.Cells[6].Value.ToString();
                    double yssl = 0;
                    if (Double.TryParse(r.Cells[7].Value.ToString(), out yssl))
                    {
                        dbobj.UploadPur(remoteConn, bm, mc, sccj, gg, jhdw, yssl, dm);
                    }
                }
                this.Invoke((MethodInvoker)delegate()
                {
                    btnLoadPur.Enabled = false;
                    MessageBox.Show("上传完成");
                    formLoading.Dispose();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    
                });
            }
        }

        private void btnLoadPur_Click(object sender, EventArgs e)
        {
            //2.从数据库中选择需要采购的数据，自动生成
            if (MessageBox.Show("将会进行初始化，是否继续","是否删除",MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (dgvPur.Rows.Count > 0)
                {
                    dgvPur.Rows.Clear();
                }
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectNeedBuy(thisConn);
                foreach (DataRow r in dbtable.Rows)
                {
                    DataGridViewRow nrow = new DataGridViewRow();
                    nrow.CreateCells(dgvPur);
                    nrow.Cells[2].Value = r["bm"];
                    nrow.Cells[3].Value = r["mc"];
                    nrow.Cells[4].Value = r["sccj"];
                    nrow.Cells[5].Value = r["gg"];
                    nrow.Cells[6].Value = r["jhdw"];
                    nrow.Cells[7].Value = r["yysl"];
                    dgvPur.Rows.Add(nrow);
                }
            }
        }

        private void lkRemoteConn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            InitRemoteConnection();
        }

        private void FormCaiGou_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (this.remoteConn!=null&&this.remoteConn.State == ConnectionState.Open)
            {
                remoteConn.Close();
                remoteConn.Dispose();
            }
        }
    }
}
