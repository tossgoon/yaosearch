using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
namespace YaoSearch
{
    public partial class FormUpdateDrug : Form
    {
        SqlConnection thisConn;
        public FormUpdateDrug()
        {
            InitializeComponent();
        }

        public FormUpdateDrug(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string zxbm = this.txt_zxbm.Text;
            string regexStr = "G[0-9]{13}";
            if (!Regex.IsMatch(zxbm, regexStr))
            {
                MessageBox.Show("位数不匹配，请检查");
                return;
            }
            string bm = txtbm.Text;//编码
            int isup = 0;
            if (chk_isup.Checked)
            {
                isup = 1;
            }

            SqlCommand thisCommand = thisConn.CreateCommand();
            if (bm != null && bm != "")
            {
                thisCommand.CommandText = string.Format("update p_spjcxx_sz Set spmc='{0}',is_gzyp={1} WHERE bm = {2}", zxbm, isup, bm);
                thisCommand.ExecuteNonQuery();
            }
                

            if (this.dgvDrug.SelectedRows != null)
            {
                this.dgvDrug.SelectedRows[0].Cells[5].Value = zxbm;
                this.dgvDrug.SelectedRows[0].Cells[6].Value = isup;
            }
            tipinfo.Text = "保存成功";
        }

        private void FormUpdateDrug_Load(object sender, EventArgs e)
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectSpxxByName(thisConn, "");
                this.dgvDrug.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CDBOperate dbobj = new CDBOperate();
            DataTable dbtable = dbobj.SelectSpxxByName(thisConn, this.txtDrugName.Text);
            this.dgvDrug.DataSource = dbtable;
            /*
             * 
            if (this.dgvDrug.Columns.Count == 0)
            {
                DataGridViewCheckBoxColumn newColumn = new DataGridViewCheckBoxColumn();
                newColumn.HeaderText = "*";
                dgvDrug.Columns.Insert(0, newColumn);
                dgvDrug.Columns[0].Width = 30;
            }
             */
        }

        private void dgvDrug_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvDrug.SelectedRows[0];
                UpdateCurrentText(row);
                tipinfo.Text = "  ";
            }
        }

        private void UpdateCurrentText(DataGridViewRow row)
        {
            if (row.Cells[1].Value != null)
            {
                txtmc.Text = row.Cells[1].Value.ToString();
            }
            else
            {
                txtmc.Text = "";
            }
            if (row.Cells[2].Value != null)
            {
                txtsccj.Text = row.Cells[2].Value.ToString();
            }
            else
            {
                txtsccj.Text = "";
            }
            if (row.Cells[0].Value != null)
            {
                txtbm.Text = row.Cells[0].Value.ToString();
            }
            else
            {
                txtbm.Text = "";
            }
            if (row.Cells[3].Value != null)
            {
                txtgg.Text = row.Cells[3].Value.ToString();
            }
            else
            {
                txtgg.Text = "";
            }
            if (row.Cells[5].Value != null)
            {
                this.txt_zxbm.Text = row.Cells[5].Value.ToString();
            }
            else
            {
                this.txt_zxbm.Text = "";
            }
            if (row.Cells[6].Value != null && row.Cells[6].Value.ToString().Equals("1"))
            {
                this.chk_isup.Checked = true;
            }
            else
            {
                this.chk_isup.Checked = false;
            }

        }
    }
}
