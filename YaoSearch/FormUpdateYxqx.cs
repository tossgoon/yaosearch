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
    public partial class FormUpdateYxqx : Form
    {
        SqlConnection thisConn;
        public FormUpdateYxqx()
        {
            InitializeComponent();
        }

        public FormUpdateYxqx(SqlConnection thisConn)
        {
            InitializeComponent();
            this.thisConn = thisConn;
        }


        private void cboxTypeSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            tstatusLabel.Text = "正在查询 ...";
            CDBOperate dbobj = new CDBOperate();
            DataTable dbtable = dbobj.SelectYxqx(thisConn, cboxTypeSelect.SelectedIndex);
            this.dgviewTbInfo.DataSource = dbtable;
            tstatusLabel.Text = "就绪.";
            if (dgviewTbInfo.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dgviewTbInfo.SelectedRows[0];

                if (row.Cells[0].Value != null)
                {
                    this.txtLsh.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    txtLsh.Text = "";
                }

                if (row.Cells[1].Value != null)
                {
                    this.txtCode.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    txtCode.Text = "";
                }
                if (row.Cells[2].Value != null)
                {
                    this.txtMc.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtMc.Text = "";
                }
                if (row.Cells[6].Value != null)
                {
                    this.txtYxqx.Text = row.Cells[6].Value.ToString();
                }
                else
                {
                    txtYxqx.Text = "";
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string lsh = this.txtLsh.Text;
            string yxqx = this.txtYxqx.Text;//编码
            if (yxqx.Length != 8)
            {
                MessageBox.Show("日期格式错误");
                return;
            }
            DateTime dt;
            if (!DateTime.TryParse(yxqx.Substring(0, 4) + "-" + yxqx.Substring(4, 2) + "-" + yxqx.Substring(6, 2), out dt))
            {
                MessageBox.Show("日期格式错误");
                return;
            }
            SqlCommand thisCommand = thisConn.CreateCommand();
            if (cboxTypeSelect.SelectedIndex == 0)
            {
                thisCommand.CommandText = string.Format("update kcgl_sprkd_xx Set yxqx='{0}'  WHERE lsh = '{1}'", yxqx, lsh);
            }
            else if (cboxTypeSelect.SelectedIndex == 1)
            {
                thisCommand.CommandText = string.Format("update sale_xsd_xx Set yxqx='{0}'  WHERE lsh = '{1}'", yxqx, lsh);
            }
            else if (cboxTypeSelect.SelectedIndex == 2)
            {
                thisCommand.CommandText = string.Format("update kcgl_spkcxx Set yxqx='{0}'  WHERE lsh = '{1}'", yxqx, lsh);
            }
            thisCommand.ExecuteNonQuery();
            if (this.dgviewTbInfo.SelectedRows != null)
            {
                this.dgviewTbInfo.SelectedRows[0].Cells[6].Value = yxqx;
            }
            this.tstatusLabel.Text = "ok";
        }

        private void dgviewTbInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1 && this.dgviewTbInfo.SelectedRows.Count > 0 && dgviewTbInfo.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgviewTbInfo.SelectedRows[0];

                if (row.Cells[0].Value != null)
                {
                    this.txtLsh.Text = row.Cells[0].Value.ToString();
                }
                else
                {
                    txtLsh.Text = "";
                }

                if (row.Cells[1].Value != null)
                {
                    this.txtCode.Text = row.Cells[1].Value.ToString();
                }
                else
                {
                    txtCode.Text = "";
                }
                if (row.Cells[2].Value != null)
                {
                    this.txtMc.Text = row.Cells[2].Value.ToString();
                }
                else
                {
                    txtMc.Text = "";
                }
                if (row.Cells[6].Value != null)
                {
                    this.txtYxqx.Text = row.Cells[6].Value.ToString();
                }
                else
                {
                    txtYxqx.Text = "";
                }
            }
        }
    }
}
