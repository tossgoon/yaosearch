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
    public partial class FormSelectPur : Form
    {
        private SqlConnection  thisConn;
       internal delegate void SetSelectPurs(List<CSpxx> splist);
       internal event SetSelectPurs pursSelectEvent;
        public FormSelectPur()
        {
            InitializeComponent();
        }
        public FormSelectPur(SqlConnection thisConn)
        {
            this.thisConn = thisConn;
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            CDBOperate dbobj = new CDBOperate();
            DataTable dbtable = dbobj.SelectSpxx(thisConn, txtPurName.Text);

            if (dgvPurSelect.Columns.Count ==0)
            {
                DataGridViewCheckBoxColumn newColumn = new DataGridViewCheckBoxColumn();
                newColumn.HeaderText = "*";
                dgvPurSelect.Columns.Insert(0, newColumn);
                dgvPurSelect.Columns[0].Width = 30;
            }
            this.dgvPurSelect.DataSource = dbtable;
            for (int i = 1; i < dgvPurSelect.Columns.Count; i++)
            {
                dgvPurSelect.Columns[i].ReadOnly = true;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            List<CSpxx> splist = new List<CSpxx>();
            foreach (DataGridViewRow r in dgvPurSelect.Rows)
            {
                if ((bool)r.Cells[0].EditedFormattedValue == true)
                {
                    // bm,mc,sccj,gg,jhdw 
                    CSpxx sp = new CSpxx();
                    sp.Bm = r.Cells["bm"].Value.ToString();
                    sp.Gg = r.Cells["gg"].Value.ToString();
                    sp.Jhdw = r.Cells["jhdw"].Value.ToString();
                    sp.Mc = r.Cells["mc"].Value.ToString();
                    sp.Sccj = r.Cells["sccj"].Value.ToString();
                    splist.Add(sp);
                }
                
               
            }
            if (this.pursSelectEvent != null)
            {
                pursSelectEvent(splist);
                this.Close();
            }
        }
    }
}
