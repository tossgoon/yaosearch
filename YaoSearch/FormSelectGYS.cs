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
    public partial class FormSelectGYS : Form
    {
        public delegate void SetGYSHandler(string gysmc,string gysbm);
        public event SetGYSHandler setGYSEvent;
        SqlConnection thisConn;
        public FormSelectGYS()
        {
            InitializeComponent();
        }
        public FormSelectGYS(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
        }
        private void FormSelectGYS_Load(object sender, EventArgs e)
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectGYS(thisConn, "");
                this.dgvGYS.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtGYS_TextChanged(object sender, EventArgs e)
        {
            string gys = txtGYS.Text;
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectGYS(thisConn, gys);
                this.dgvGYS.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void dgvGYS_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (setGYSEvent != null
                 && dgvGYS.SelectedRows.Count > 0)
            {
                string gysbm = dgvGYS.SelectedRows[0].Cells[0].Value.ToString();
                string gysmc = dgvGYS.SelectedRows[0].Cells[1].Value.ToString();
                setGYSEvent(gysmc,gysbm);
                this.Close();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (setGYSEvent != null
                && dgvGYS.SelectedRows.Count > 0)
            {
                string gysbm = dgvGYS.SelectedRows[0].Cells[0].Value.ToString();//供应商编码
                string gysmc = dgvGYS.SelectedRows[0].Cells[1].Value.ToString();//供应商名称
                setGYSEvent(gysmc, gysbm);
                this.Close();
            }
        }
    }
}
