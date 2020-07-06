using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Threading;
using System.IO;
namespace YaoSearch
{
    public partial class FormMain : Form
    {
        private SqlConnection thisConn;//SQL Server数据库连接（本地）
        private string dm = "未设置";//店码
        private string gysmc = "";//供应商名称
        private string gysbm = "";//供应商编码
        private DateTime begindate;//起始日期
        private DateTime enddate;//终止日期
        private DateTime buydate;//购买日期
        private string ypbm = "";//药品编码
        private FormLoading formLoading;//loading窗口
        private string fileName;//导出文件名称
        private int unsaleNum;//查询滞销品种的数量
        private string remoteConn;//SQL Server数据库远程连接
        private string zxXmlPath;//上传中心的xml目录
        public FormMain()
        {
            thisConn = CDBOperate.GetConnection();
            if (CDBOperate.TryConnect(thisConn))
            {
                InitializeComponent();
            }
            else
            {
                FormSetting form = new FormSetting();
                form.setConnectEvent += form_setConnectEvent;
                form.setSettingEvent += form_setSettingEvent;
                form.ShowDialog();
            }
        }

        void form_setConnectEvent()
        {
            thisConn = CDBOperate.GetConnection();
            if (CDBOperate.TryConnect(thisConn))
            {
                InitializeComponent();
            }
            else
            {
                this.Close();
            }
        }

        private void 设置ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSetting form = new FormSetting();
            form.setSettingEvent += form_setSettingEvent;
            form.setConnectEvent += form_setConnectEventAfterOpen;
            form.setRemoteDbEvent += form_setRemoteDbEvent;
            form.setZxXmlPathEvent += form_setZxXmlPathEvent;
            form.ShowDialog();
        }

        void form_setZxXmlPathEvent(string xmlPath)
        {
            this.zxXmlPath = xmlPath;
        }
        void form_setRemoteDbEvent(string remoteConn)
        {
            this.remoteConn = remoteConn;
        }
        void form_setConnectEventAfterOpen()
        {
            thisConn = CDBOperate.GetConnection();
            if (!CDBOperate.TryConnect(thisConn))
            {
                MessageBox.Show("数据库连接错误");
            }
        }
        void form_setSettingEvent(string dm)
        {
            this.dm = dm;
            this.tlabelDm.Text = "店码:" + this.dm;
        }

        private void UpdateScore()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.UpdateScore(thisConn, dm);
                this.Invoke((MethodInvoker)delegate()
                {
                    dgvDrugSearch.DataSource = dbtable;
                    stripLabelInfo.Text = "更新不积分品种完成.";
                    formLoading.Dispose();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                    formLoading.Dispose();
                });
            }
        }

        private void tbtnUpdateBuyGive_Click(object sender, EventArgs e)
        {
            stripLabelInfo.Text = "正在更新品种，请稍后...";
            Thread thread = new Thread(new ThreadStart(UpdateBuyGive));
            thread.Start();
            formLoading = new FormLoading("更新买赠");
            formLoading.ShowDialog();
        }
        private void UpdateBuyGive()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                dbobj.UpdatePinMingPPC(thisConn, dm);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "品种更新完成.";
                    if (DialogResult.OK == MessageBox.Show("更新成功!"))
                    {
                        formLoading.Dispose();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                    formLoading.Dispose();
                });
            }
        }

        //private void btnSearchUnsalable_Click(object sender, EventArgs e)
        //{

        //}
        //private void SelectUnsalableItems()
        //{
        //    try
        //    {
        //        CDBOperate dbobj = new CDBOperate();
        //        DataTable dbtable = dbobj.GetUnSalableDrug(thisConn, begindate, enddate, buydate,unsaleNum);
        //        this.Invoke((MethodInvoker)delegate()
        //        {
        //            dgvDrugSearch.DataSource = dbtable;
        //            stripLabelInfo.Text = "查询滞销药品.";
        //            formLoading.Dispose();
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //        this.Invoke((MethodInvoker)delegate()
        //        {
        //            stripLabelInfo.Text = "";
        //            formLoading.Dispose();
        //        });
        //    }
        //}

        private void UpdatePercentage(object gsbm)
        {
            string sgsbm = gsbm as string;
            try
            {
                CDBOperate dbobj = new CDBOperate();
                dbobj.UpdatePercentage(thisConn, sgsbm);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "更新参考提成完成.";
                    if (DialogResult.OK == MessageBox.Show("更新成功!"))
                    {
                        formLoading.Dispose();
                    }
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                    formLoading.Dispose();
                });
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            string txtFilePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            if (System.IO.File.Exists(txtFilePath))
            {
                CIniFile myFile = new CIniFile(txtFilePath);
                this.dm = myFile.IniReadValue("Setting", "DianMa");
            }
            tlabelDm.Text = "店码：" + dm;
        }

        private void tbtnUpdateScore_Click(object sender, EventArgs e)
        {
            if (this.dm == "未设置")
            {
                MessageBox.Show("店码为空");
                return;
            }
            stripLabelInfo.Text = "正在更新不积分品种，请稍后...";
            Thread thread = new Thread(new ThreadStart(UpdateScore));
            thread.Start();
            formLoading = new FormLoading("更新不积分品种");
            formLoading.ShowDialog();
        }

        private void tbtnUpdatePercent_Click(object sender, EventArgs e)
        {
            if (this.dm == "未设置")
            {
                MessageBox.Show("店码为空");
                return;
            }
            stripLabelInfo.Text = "正在更新参考提成...";
            ParameterizedThreadStart parStart = new ParameterizedThreadStart(UpdatePercentage);
            Thread thread = new Thread(parStart);
            object o = this.dm;
            thread.Start(o);
            formLoading = new FormLoading("更新参考提成");
            formLoading.ShowDialog();
        }

        private void btnSearchGYS_Click(object sender, EventArgs e)
        {
            if (this.dm == "未设置")
            {
                MessageBox.Show("店码为空");
                return;
            }
            this.gysmc = txtGYS.Text;
            this.gysbm = txtGYSbm.Text;
            stripLabelInfo.Text = "正在查询供应商，很慢，请稍后...";
            Thread thread = new Thread(new ThreadStart(SelectGYS));
            thread.Start();
        }
        private void SelectGYS()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.GetGYS(thisConn, dm, gysmc, gysbm);
                this.Invoke((MethodInvoker)delegate()
                {
                    dgvDrugSearch.DataSource = dbtable;
                    stripLabelInfo.Text = "查询完成.";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                });
            }
        }
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            //comboBox1.DataSource
        }

        private void btnSelectGYS_Click(object sender, EventArgs e)
        {
            FormSelectGYS form = new FormSelectGYS(thisConn);
            form.setGYSEvent += form_setGYSEvent;
            form.ShowDialog();
        }

        void form_setGYSEvent(string gysmc, string gysbm)
        {
            txtGYS.Text = gysmc;
            txtGYSbm.Text = gysbm;
        }

        private void tbtnSelectVIP_Click(object sender, EventArgs e)
        {
            if (this.dm == "未设置")
            {
                MessageBox.Show("店码为空");
                return;
            }
            stripLabelInfo.Text = "正在查询会员，请稍后...";
            Thread thread = new Thread(new ThreadStart(SelectVIP));
            thread.Start();
            formLoading = new FormLoading("查询会员");
            formLoading.ShowDialog();
        }
        private void SelectVIP()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectVIP(thisConn, dm);
                this.Invoke((MethodInvoker)delegate()
                {
                    dgvDrugSearch.DataSource = dbtable;
                    stripLabelInfo.Text = "查询完成.";
                    formLoading.Dispose();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                    formLoading.Dispose();
                });
            }
        }
        private void SelectVIPLevel()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectVIPLevel(thisConn, dm);
                this.Invoke((MethodInvoker)delegate()
                {
                    dgvDrugSearch.DataSource = dbtable;
                    stripLabelInfo.Text = "查询完成.";
                    formLoading.Dispose();
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                    formLoading.Dispose();
                });
            }
        }
        private void SetMedicine(string ypmc, string ypbm)
        {
            this.txtMedcineName.Text = ypbm + " /" + ypmc;
            this.txtMedcineName.Tag = ypbm;
        }

        private void btnSelectMedicine_Click(object sender, EventArgs e)
        {
            FormSelectMedi form = new FormSelectMedi(thisConn);
            form.setGYSEvent += SetMedicine;
            form.ShowDialog();
        }

        private void btnSelectVIPMedi_Click(object sender, EventArgs e)
        {
            if (this.dm == "未设置")
            {
                MessageBox.Show("店码为空");
                return;
            }
            if (txtMedcineName.Tag == null)
            {
                MessageBox.Show("药品编码为空");
                return;
            }
            ypbm = txtMedcineName.Tag.ToString();//药品编码
            begindate = dtpkBegindate.Value;
            enddate = dtpkEnddate.Value.AddDays(1).AddSeconds(-1);
            stripLabelInfo.Text = "正在查询会员药品，请稍后...";
            Thread thread = new Thread(new ThreadStart(SelectVIPMedicine));
            thread.Start();
        }
        private void SelectVIPMedicine()
        {
            try
            {
                CDBOperate dbobj = new CDBOperate();
                DataTable dbtable = dbobj.SelectMedicineByVIP(thisConn, dm, ypbm, begindate, enddate);
                this.Invoke((MethodInvoker)delegate()
                {
                    dgvDrugSearch.DataSource = dbtable;
                    stripLabelInfo.Text = "查询完成.";
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "";
                });
            }
        }

        private void dgvDrugSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string mc;
            string kahao;
            string vipbm;
            string ypbm;
            DateTime begindate;
            DateTime enddate;

            if (this.dm == "未设置")
            {
                //MessageBox.Show("店码为空");
                return;
            }
            if (txtMedcineName.Tag == null)
            {
                //MessageBox.Show("药品编码为空");
                return;
            }
            ypbm = txtMedcineName.Tag.ToString();//药品编码
            begindate = dtpkBegindate.Value;
            enddate = dtpkEnddate.Value.AddDays(1).AddSeconds(-1);

            if (dgvDrugSearch.SelectedRows.Count > 0 && dgvDrugSearch.SelectedRows[0] != null && dgvDrugSearch.Columns[0].HeaderText == "khbm")
            {
                vipbm = dgvDrugSearch.SelectedRows[0].Cells[0].Value.ToString();
                mc = dgvDrugSearch.SelectedRows[0].Cells[1].Value.ToString();
                kahao = dgvDrugSearch.SelectedRows[0].Cells[2].Value.ToString();
                FormShowMediDetial form = new FormShowMediDetial(thisConn, dm, mc, ypbm, kahao, vipbm, begindate, enddate);
                form.ShowDialog();
            }
        }

        private void dtpkEnddate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbtnVipLevel_Click(object sender, EventArgs e)
        {
            stripLabelInfo.Text = "正在统计会员级别，请稍后...";
            Thread thread = new Thread(new ThreadStart(SelectVIPLevel));
            thread.Start();
            formLoading = new FormLoading("会员级别统计");
            formLoading.ShowDialog();
        }

        private void tbtnExportTxt_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                fileName = sfd.FileName;
                ParameterizedThreadStart parStart = new ParameterizedThreadStart(ExportDgv2Txt);
                Thread thread = new Thread(parStart);
                object o = this.dgvDrugSearch;
                thread.Start(o);
            }
        }
        private void ExportDgv2Txt(object dgv)
        {
            DataGridView dgvS = dgv as DataGridView;
            int rowscount = dgvS.Rows.Count;
            this.Invoke((MethodInvoker)delegate()
            {
                stripLabelInfo.Text = "准备数据导出...";
                tstripProgress.Maximum = rowscount + 1;
                tstripProgress.Minimum = 1;
                tstripProgress.Value = 1;
            });
            FileStream aFile = new FileStream(fileName, FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(aFile);//构建导出文件
            string str = "";
            //标题行 
            foreach (DataGridViewColumn dgvc in dgvS.Columns)
            {
                str += dgvc.HeaderText + ",";
            }
            sw.WriteLine(str);
            //内容
            int i = 1;
            foreach (DataGridViewRow row in dgvS.Rows)
            {
                str = "";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    str += cell.Value.ToString() + ",";
                }
                sw.WriteLine(str);
                this.Invoke((MethodInvoker)delegate()
                {
                    stripLabelInfo.Text = "正在导出第" + i + "/" + rowscount;
                    tstripProgress.Value++;
                });
            }
            sw.Close();
            sw.Dispose();
            this.Invoke((MethodInvoker)delegate()
            {
                MessageBox.Show("导出完成");
                stripLabelInfo.Text = "导出完成";
            });

        }

        private void dgvDrugSearch_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tbtnUpdateScoreType_Click(object sender, EventArgs e)
        {
            FormJiFen form = new FormJiFen(thisConn, dm);
            form.ShowDialog();
        }

        private void tbtnUnsale_Click(object sender, EventArgs e)
        {
            FormUnsale form = new FormUnsale(thisConn);
            form.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FormUpdateDrug formUpdateDrug = new FormUpdateDrug(thisConn);
            formUpdateDrug.ShowDialog();
        }

        private void tbtn_standard_gys_Click(object sender, EventArgs e)
        {
            FormUpdateGys formUpdateGys = new FormUpdateGys(thisConn);
            formUpdateGys.ShowDialog();
        }

        private void 采购管理ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCaiGou formCaiGou = new FormCaiGou(thisConn, dm);
            formCaiGou.ShowDialog();
        }

        private void 标准化药品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateDrug formUpdateDrug = new FormUpdateDrug(thisConn);
            formUpdateDrug.ShowDialog();
        }

        private void 标准化区域码ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateGys formUpdateGys = new FormUpdateGys(thisConn);
            formUpdateGys.ShowDialog();
        }

        private void 生成上传数据ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormGenerateXml formXml = new FormGenerateXml(thisConn);
            formXml.ShowDialog();
        }

        private void 有效期更新ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormUpdateYxqx form = new FormUpdateYxqx(thisConn);
            form.ShowDialog();
        }
    }
}
