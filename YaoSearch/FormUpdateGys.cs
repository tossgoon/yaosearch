using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace YaoSearch
{
    public partial class FormUpdateGys : Form
    {
        SqlConnection thisConn;
        public FormUpdateGys()
        {
            InitializeComponent();
        }
        public FormUpdateGys(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
        }

        private void txtGYS_TextChanged(object sender, EventArgs e)
        {
            string gys = txtGYS.Text;
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectGYSForUpdate(thisConn, gys);
                this.dgvGYS.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FormUpdateGys_Load(object sender, EventArgs e)
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectGYSForUpdate(thisConn, "");
                this.dgvGYS.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dgvGYS_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && this.dgvGYS.SelectedRows.Count > 0 && dgvGYS.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvGYS.SelectedRows[0];
                if (row.Cells[0].Value != null)
                {
                    txtbm.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    txtbm.Text = "";
                }
                if (row.Cells[1].Value != null)
                {
                    this.txtmc.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    txtmc.Text = "";
                }
                if (row.Cells[3].Value != null)
                {
                    this.txt_qybm.Text = row.Cells[3].Value.ToString();
                }
                else
                {
                    txt_qybm.Text = "";
                }
                lbtip_info.Text = " ";
            }
        }

        private void btnSaveInfo_Click(object sender, EventArgs e)
        {
            string qybm = this.txt_qybm.Text;
            string bm = txtbm.Text;//编码
          
            SqlCommand thisCommand = thisConn.CreateCommand();
            if (bm != null && bm != "")
            {
                thisCommand.CommandText = string.Format("update p_gysxx_wh Set xkzh='{0}'  WHERE bm = {1}", qybm, bm);
                thisCommand.ExecuteNonQuery();
            }
            if (this.dgvGYS.SelectedRows != null)
            {
                this.dgvGYS.SelectedRows[0].Cells[3].Value = qybm;
            }
            lbtip_info.Text = "ok";
        }
    }
}
