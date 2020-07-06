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
    public partial class FormShowMediDetial : Form
    {
        SqlConnection thisConn;
        string dm;
        string vipbm;
        string ypbm;
        DateTime begindate;
        DateTime enddate;

        public FormShowMediDetial()
        {
            InitializeComponent();
        }
        public FormShowMediDetial(SqlConnection thisConn,string dm,string mc,string ypbm,string kahao,string vipbm,DateTime begindate,DateTime enddate)
        {
            InitializeComponent();
            
            this.thisConn = thisConn;
            this.vipbm = vipbm;
            this.begindate = begindate;
            this.enddate = enddate;
            this.dm = dm;
            this.ypbm = ypbm;
            txtKaHao.Text = kahao;
            txtName.Text = mc;
        }
        private void FormSelectGYS_Load(object sender, EventArgs e)
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectMedicineDetailByVIP(thisConn,vipbm,dm,ypbm,begindate,enddate);
                this.dgvMediDetail.DataSource = dbtable;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
