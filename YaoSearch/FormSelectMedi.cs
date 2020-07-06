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
    public partial class FormSelectMedi : Form
    {
        public delegate void SetGYSHandler(string ypmc, string ypbm);
        public event SetGYSHandler setGYSEvent;
        SqlConnection thisConn;
        public FormSelectMedi()
        {
            InitializeComponent();
        }
        public FormSelectMedi(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
        }
        private void txtMedi_TextChanged(object sender, EventArgs e)
        {
            string gys = txtMedi.Text;
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectMedicine(thisConn, gys);
                this.dgvMedi.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (setGYSEvent != null
    && dgvMedi.SelectedRows.Count > 0)
            {
                string gysbm = dgvMedi.SelectedRows[0].Cells[0].Value.ToString();//供应商编码
                string gysmc = dgvMedi.SelectedRows[0].Cells[1].Value.ToString();//供应商名称
                setGYSEvent(gysmc, gysbm);
                this.Close();
            }
        }

        private void FormSelectMedi_Load(object sender, EventArgs e)
        {
            
        }
    }
}
