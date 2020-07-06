using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Threading;
namespace YaoSearch
{
    public partial class FormJiFen : Form
    {
        private string olddm;
        private string dm;
        private SqlConnection thisConn;//SQL Server数据库连接
        private FormLoading formLoading;//loading窗口
        public FormJiFen()
        {
            InitializeComponent();
        }
        public FormJiFen(SqlConnection thisConn, string dm)
        {
            olddm = dm;
            //if (dm == "001")//店码是001的，会员所在店码可能是000和001
            //{
            //    this.dm = "('000','001')";
            //}
            //else
            //{
                this.dm = "'" + dm + "'";
            //}
            this.thisConn = thisConn;
            InitializeComponent();
        }
        /// <summary>
        /// 新增积分品种，从不积分中选择后新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tbtnAddType_Click(object sender, EventArgs e)
        {

        }

        private void FormJiFen_Load(object sender, EventArgs e)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            //0.更新大类cboxBigType里的类别
            DataTable bigdt = new DataTable();
            bigdt.Columns.Add("bm");
            thisCommand.CommandText = "SELECT DISTINCT SUBSTRING(bm,1,2) FROM p_splb_mc WHERE dm = " + dm;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                String bm = thisReader[0].ToString();
                if (bm.Length == 2)
                {
                    DataRow dr = bigdt.NewRow();
                    dr["bm"] = bm;
                    bigdt.Rows.Add(dr);
                }
            }
            thisReader.Close();
            cboxBigType.DataSource = bigdt;
            cboxBigType.DisplayMember = "bm";
            cboxBigType.ValueMember = "bm";
            cboxBigType.SelectedIndex = 0;
            //2.
            //UpdateSelectRows();
        }
        private void UpdateSelectRows()
        {
            string bigtype = cboxBigType.SelectedValue as string;//大类
            string jftype = cbxJiFenType.SelectedValue as string;//积分类别
            string lbmc = cbxJiFenType.Text;//类别名称
            string zjm = txtzjm.Text.Trim();
            string sqlstr;
            if (jftype == "-1")
            {
                //未在大类里所有品种
                if (zjm == "")
                {
                    sqlstr = "SELECT sz.bm, sz.mc,sz.sccj,sz.gg,sz.zjm,sz.dw,'-1' AS lbbm,'未分类' as lbmc,pfd.lsj FROM p_spjcxx_sz AS  sz"
                        + " LEFT JOIN (SELECT distinct lsj,bm FROM p_spjcxx_sz_fd WHERE dm =" + dm + ") AS  pfd ON sz.bm=pfd.bm"
 + " WHERE sz.bm NOT in(SELECT DISTINCT spbm FROM p_splb_sp WHERE dm =" + dm + " AND lbbm LIKE '" + bigtype + "%')"
 + " ORDER BY pfd.lsj DESC";
                }
                else
                {
                    sqlstr = "SELECT sz.bm, sz.mc,sz.sccj,sz.gg,sz.zjm,sz.dw,'-1' AS lbbm,'未分类' as lbmc,pfd.lsj FROM p_spjcxx_sz AS  sz"
                        + " LEFT JOIN (SELECT distinct lsj,bm FROM p_spjcxx_sz_fd WHERE dm =" + dm + ") AS  pfd ON sz.bm=pfd.bm"
 + " WHERE sz.bm NOT in(SELECT DISTINCT spbm FROM p_splb_sp WHERE dm =" + dm + " AND lbbm LIKE '" + bigtype + "%') AND sz.zjm LIKE '%" + zjm + "%'"
 + " ORDER BY pfd.lsj DESC";
                }
            }
            else if (jftype == "0")
            {
                //所有品种(该大类下的所有品种）
                if (zjm == "")
                {
                    sqlstr = "SELECT sz.bm, sz.mc,sz.sccj,sz.gg,sz.zjm,sz.dw,sp.lbbm,sp.lbbm+'('+ sp.mc+')' AS lbmc,pfd.lsj FROM p_spjcxx_sz AS sz"
                        + " LEFT JOIN (SELECT distinct sp1.lbbm,sp1.spbm,spmc1.mc FROM p_splb_sp AS sp1,p_splb_mc AS spmc1 WHERE sp1.dm =" + dm + " AND sp1.lbbm LIKE '" + bigtype + "%' AND sp1.lbbm=spmc1.bm) AS sp ON sz.bm=sp.spbm "
//                        + " LEFT JOIN p_splb_mc AS mc ON sp.lbbm=mc.bm"
                        + " LEFT JOIN (SELECT distinct lsj,bm FROM p_spjcxx_sz_fd WHERE dm =" + dm + ") AS  pfd ON sz.bm=pfd.bm"
                        + " ORDER BY pfd.lsj DESC";
                }
                else
                {
                    sqlstr = "SELECT sz.bm, sz.mc,sz.sccj,sz.gg,sz.zjm,sz.dw,sp.lbbm,sp.lbbm+'('+ sp.mc+')' AS lbmc,pfd.lsj FROM p_spjcxx_sz AS sz"
                        + " LEFT JOIN (SELECT distinct sp1.lbbm,sp1.spbm,spmc1.mc FROM p_splb_sp AS sp1,p_splb_mc AS spmc1 WHERE sp1.dm =" + dm + " AND sp1.lbbm LIKE '" + bigtype + "%' AND sp1.lbbm=spmc1.bm) AS sp ON sz.bm=sp.spbm "
                        + " LEFT JOIN (SELECT distinct lsj,bm FROM p_spjcxx_sz_fd WHERE dm =" + dm + ") AS  pfd ON sz.bm=pfd.bm"
                        + " WHERE sz.zjm LIKE '%" + zjm + "%'"
                        + " ORDER BY pfd.lsj DESC";
                }
            }
            else
            {
                if (zjm == "")
                {
                    sqlstr = "SELECT sz.bm, sz.mc,sz.sccj,sz.gg,sz.zjm,sz.dw,'" + jftype + "' AS lbbm,'" + lbmc + "' AS lbmc,pfd.lsj FROM p_splb_sp AS sp,p_spjcxx_sz AS  sz"
                        + " LEFT JOIN (SELECT distinct lsj,bm FROM p_spjcxx_sz_fd WHERE dm =" + dm + ") AS  pfd ON sz.bm=pfd.bm"
 + " WHERE sp.spbm=sz.bm AND sp.dm =" + dm + " AND sp.lbbm='" + jftype + "'"
 + " ORDER BY pfd.lsj DESC";
                }
                else
                {
                    sqlstr = "SELECT sz.bm, sz.mc,sz.sccj,sz.gg,sz.zjm,sz.dw,'" + jftype + "' AS lbbm,'" + lbmc + "' AS lbmc,pfd.lsj FROM p_splb_sp AS sp,p_spjcxx_sz AS  sz"
                        + " LEFT JOIN (SELECT distinct lsj,bm FROM p_spjcxx_sz_fd WHERE dm =" + dm + ") AS  pfd ON sz.bm=pfd.bm"
 + " WHERE sp.spbm=sz.bm AND sp.dm =" + dm + " AND sp.lbbm='" + jftype + "' AND sz.zjm LIKE '%" + zjm + "%'"
 + " ORDER BY pfd.lsj DESC";
                }
            }
            //多线程更新dgv行
            dgvDrug.Rows.Clear();
            ParameterizedThreadStart parStart = new ParameterizedThreadStart(UpdateDgvRows);
            Thread thread = new Thread(parStart);
            object o = sqlstr;
            thread.Start(o);
            formLoading = new FormLoading("正在查询...");
            formLoading.ShowDialog();
            //UpdateDgvRows(sqlstr);
        }
        /// <summary>
        /// 更新datagridview行
        /// </summary>
        private void UpdateDgvRows(object sqlstr)
        {
            SqlCommand thisCommand = thisConn.CreateCommand();
            thisCommand.CommandText = sqlstr as string;
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                string bm = "", mc = "", sccj = "", gg = "", zjm = "", dw = "", lbbm = "-1", lbmc = "", lsj = "";
                if (!thisReader.IsDBNull(0))
                {
                    bm = thisReader.GetString(0);
                }
                if (!thisReader.IsDBNull(1))
                {
                    mc = thisReader.GetString(1);
                }
                if (!thisReader.IsDBNull(2))
                {
                    sccj = thisReader.GetString(2);
                }
                if (!thisReader.IsDBNull(3))
                {
                    gg = thisReader.GetString(3);
                }
                if (!thisReader.IsDBNull(4))
                {
                    zjm = thisReader.GetString(4);
                }
                if (!thisReader.IsDBNull(5))
                {
                    dw = thisReader.GetString(5);
                }
                if (!thisReader.IsDBNull(6))
                {
                    lbbm = thisReader.GetString(6);
                }
                if (!thisReader.IsDBNull(7))
                {
                    lbmc = thisReader.GetString(7);
                }
                if (!thisReader.IsDBNull(8))
                {
                    lsj = thisReader.GetDecimal(8).ToString("#0.00");
                }
                this.Invoke((MethodInvoker)delegate()
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgvDrug);
                    row.Cells[dgvDrug.Columns["colDrugSpbm"].Index].Value = bm;
                    row.Cells[dgvDrug.Columns["colmc"].Index].Value = mc;
                    row.Cells[dgvDrug.Columns["colsccj"].Index].Value = sccj;
                    row.Cells[dgvDrug.Columns["colgg"].Index].Value = gg;
                    row.Cells[dgvDrug.Columns["colzjm"].Index].Value = zjm;
                    row.Cells[dgvDrug.Columns["coldw"].Index].Value = dw;
                    row.Cells[dgvDrug.Columns["collsj"].Index].Value = lsj;
                    if (lbbm == "-1")
                    {
                        row.Cells[dgvDrug.Columns["collbbm"].Index].Value = "未分类";
                    }
                    else
                    {
                        row.Cells[dgvDrug.Columns["collbbm"].Index].Value = lbmc;
                    }
                    row.Cells[dgvDrug.Columns["collbbm"].Index].Tag = lbbm;
                    dgvDrug.Rows.Add(row);
                });
            }
            thisReader.Close();
            this.Invoke((MethodInvoker)delegate()
            {
                if (dgvDrug.Rows.Count > 0)
                {
                    if (dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
                    {
                        DataGridViewRow row = dgvDrug.SelectedRows[0];
                        txtdw.Text = row.Cells[dgvDrug.Columns["coldw"].Index].Value.ToString();
                        txtgg.Text = row.Cells[dgvDrug.Columns["colgg"].Index].Value.ToString();
                        txtmc.Text = row.Cells[dgvDrug.Columns["colmc"].Index].Value.ToString();
                        txtsccj.Text = row.Cells[dgvDrug.Columns["colsccj"].Index].Value.ToString();
                        txtlsj.Text = row.Cells[dgvDrug.Columns["collsj"].Index].Value.ToString();
                        string lbmc = row.Cells[dgvDrug.Columns["collbbm"].Index].Value.ToString();//当前类别名称
                        string lbbm = "-1";
                        if (row.Cells[dgvDrug.Columns["collbbm"].Index].Tag != null && row.Cells[dgvDrug.Columns["collbbm"].Index].Tag.ToString() != "")
                        {
                            lbbm = row.Cells[dgvDrug.Columns["collbbm"].Index].Tag.ToString();
                        }
                        txtOldType.Text = lbmc;
                        txtOldType.Tag = lbbm;
                    }
                }
                formLoading.Dispose();
            });
        }

        private void tbtnDeleteType_Click(object sender, EventArgs e)
        {
            if (dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvDrug.SelectedRows[0];
                SqlCommand thisCommand = thisConn.CreateCommand();
                string spbm = row.Cells[dgvDrug.Columns["colDrugSpbm"].Index].Value.ToString();
                string oldlbbm = row.Cells[dgvDrug.Columns["collbbm"].Index].Tag.ToString();
                if (oldlbbm == "-1")
                {
                    MessageBox.Show("该品种没有分类");
                    return;
                }
                thisCommand.CommandText = "DELETE p_splb_sp WHERE dm = " + dm + " AND spbm='" + spbm + "' AND lbbm='" + oldlbbm + "'";
                int exenum = thisCommand.ExecuteNonQuery();
                if (exenum > 0)
                {
                    MessageBox.Show("执行完成");
                    dgvDrug.Rows.Remove(row);
                    if (dgvDrug.SelectedRows != null && dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
                    {
                        DataGridViewRow therow = dgvDrug.SelectedRows[0];
                        UpdateCurrentText(therow);
                    }
                }
                else
                {
                    MessageBox.Show("执行未成功");
                }
            }
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
            txtdw.Text = row.Cells[dgvDrug.Columns["coldw"].Index].Value.ToString();
            txtgg.Text = row.Cells[dgvDrug.Columns["colgg"].Index].Value.ToString();
            txtmc.Text = row.Cells[dgvDrug.Columns["colmc"].Index].Value.ToString();
            txtsccj.Text = row.Cells[dgvDrug.Columns["colsccj"].Index].Value.ToString();
            txtlsj.Text = row.Cells[dgvDrug.Columns["collsj"].Index].Value.ToString();
            string lbmc = row.Cells[dgvDrug.Columns["collbbm"].Index].Value.ToString();//当前类别名称
            string lbbm = "-1";
            if (row.Cells[dgvDrug.Columns["collbbm"].Index].Tag != null && row.Cells[dgvDrug.Columns["collbbm"].Index].Tag.ToString() != "")
            {
                lbbm = row.Cells[dgvDrug.Columns["collbbm"].Index].Tag.ToString();
            }
            txtOldType.Text = lbmc;
            txtOldType.Tag = lbbm;
        }

        private void btnUpdateType_Click(object sender, EventArgs e)
        {
            if (dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
            {
                DataGridViewRow row = dgvDrug.SelectedRows[0];
                string newlbbm = cboxUpdateType.SelectedValue.ToString();//新的类别编码
                string oldlbbm = txtOldType.Tag.ToString();//旧的类别编码
                if (newlbbm == oldlbbm)
                {
                    MessageBox.Show("选择一个不同的编码");
                }
                else
                {
                    SqlCommand thisCommand = thisConn.CreateCommand();
                    string spbm = row.Cells[dgvDrug.Columns["colDrugSpbm"].Index].Value.ToString();
                    if (newlbbm == "-1")
                    {
                        thisCommand.CommandText = "DELETE p_splb_sp WHERE dm = " + dm + " AND spbm='" + spbm + "' AND lbbm='" + oldlbbm + "'";
                    }
                    else
                    {
                        if (oldlbbm == "-1")
                        {
                            thisCommand.CommandText = "INSERT INTO p_splb_sp(dm,lbbm,spbm) VALUES('" + olddm + "','" + newlbbm + "','" + spbm + "')";
                        }
                        else
                        {
                            thisCommand.CommandText = "UPDATE p_splb_sp SET lbbm='" + newlbbm + "' WHERE dm = " + dm + " AND spbm='" + spbm + "' AND lbbm='" + oldlbbm + "'";
                        }
                    }
                    int exenum = thisCommand.ExecuteNonQuery();
                    if (exenum > 0)
                    {
                        MessageBox.Show("执行完成");
                        dgvDrug.Rows.Remove(row);
                        if (dgvDrug.SelectedRows != null && dgvDrug.SelectedRows.Count > 0 && dgvDrug.SelectedRows[0] != null)
                        {
                            DataGridViewRow therow = dgvDrug.SelectedRows[0];
                            UpdateCurrentText(therow);
                        }
                    }
                    else
                    {
                        MessageBox.Show("执行未成功");
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            cboxUpdateType.SelectedValue = cbxJiFenType.SelectedValue;
            txtOldType.Text = cboxUpdateType.Text;
            txtOldType.Tag = cbxJiFenType.SelectedValue;
            String searchType = cbxJiFenType.SelectedValue.ToString();
            UpdateSelectRows();
        }

        private void cboxBigType_SelectedValueChanged(object sender, EventArgs e)
        {
            String bigtype = cboxBigType.SelectedValue.ToString();//大类
            SqlCommand thisCommand = thisConn.CreateCommand();
            //1.更新cbxJiFenType里的类别
            DataTable dt = new DataTable();
            dt.Columns.Add("bm");
            dt.Columns.Add("mc");
            dt.Rows.Add("0", "所有品种");
            dt.Rows.Add("-1", "未分类");
            thisCommand.CommandText = "SELECT bm,mc FROM p_splb_mc WHERE dm = " + dm + " AND bm LIKE '" + bigtype + "%'";
            SqlDataReader thisReader = thisCommand.ExecuteReader();
            while (thisReader.Read())
            {
                String bm = thisReader["bm"].ToString();
                String mc = bm + "(" + thisReader["mc"].ToString() + ")";
                DataRow dr = dt.NewRow();
                dr["bm"] = bm;
                dr["mc"] = mc;
                dt.Rows.Add(dr);
            }
            thisReader.Close();
            cbxJiFenType.DataSource = dt;
            cbxJiFenType.DisplayMember = "mc";
            cbxJiFenType.ValueMember = "bm";
            cbxJiFenType.SelectedIndex = 0;

            DataTable newdt = dt.Copy();
            newdt.Rows.RemoveAt(0);
            cboxUpdateType.DataSource = newdt;
            cboxUpdateType.DisplayMember = "mc";
            cboxUpdateType.ValueMember = "bm";
            cboxUpdateType.SelectedIndex = 0;
        }
    }
}
