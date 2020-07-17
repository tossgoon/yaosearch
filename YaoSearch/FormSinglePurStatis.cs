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
    public partial class FormSinglePurStatis : Form
    {
        SqlConnection thisConn;
        public FormSinglePurStatis()
        {
            InitializeComponent();
        }

        public FormSinglePurStatis(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
        }

        private void dtpkEnddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtPurBm_TextChanged(object sender, EventArgs e)
        {
            string bm = this.txtPurBm.Text;
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectMedicine(thisConn, bm);
                this.dgvDrugInfo2.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void cDoubleBufferDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvStatis.SelectedRows.Count > 0 && dgvStatis.SelectedRows[0] != null)
            {
                try
                {
                    DataGridViewRow row = dgvStatis.SelectedRows[0];
                    //查询该药品的单品汇总
                    string dm = row.Cells[0].Value.ToString();
                    string bm = txtYpBm.Text;
                    CDBOperate dbobj = new CDBOperate();
                    DataTable dt = dbobj.SelectSingMedicineDetail(thisConn, bm,dm, this.dtpkBegindate.Value, this.dtpkEnddate.Value);
                    this.dgvDetail.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void dgvDrugInfo2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && dgvDrugInfo2.SelectedRows.Count > 0 && dgvDrugInfo2.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvDrugInfo2.SelectedRows[0];
                string bm = row.Cells[0].Value.ToString();
                this.txtPurNameSelect.Text = row.Cells[1].Value.ToString();
                this.txtYpBm.Text = bm;
                try
                {
                    //查询该药品的单品汇总
                    CDBOperate dbobj = new CDBOperate();
                    DataTable dt = dbobj.SelectSingMedicineStatis(thisConn, bm, this.dtpkBegindate.Value, this.dtpkEnddate.Value);
                    dgvStatis.DataSource = dt;

                    dgvDetail.DataSource = null;

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                
            }
        }
    }
}
