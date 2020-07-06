using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
namespace YaoSearch
{
    public partial class FormSetting : Form
    {
        public delegate void SetDBConnectHandler();
        public event SetDBConnectHandler setConnectEvent;

        public delegate void SetSettingHandler(string dm);
        public event SetSettingHandler setSettingEvent;

        public delegate void SetRemoteDbHandler(string remoteConn);
        public event SetRemoteDbHandler setRemoteDbEvent;

        public delegate void SetZxXmlPathHandler(string xmlPath);
        public event SetZxXmlPathHandler setZxXmlPathEvent;

        public FormSetting()
        {
            InitializeComponent();
        }

        private void btnConnTest_Click(object sender, EventArgs e)
        {
            bool isConntected = false;
            SqlConnection thisConn = new SqlConnection(txtDatabase.Text);
            try
            {
                thisConn.Open();
            }
            catch
            {
                isConntected = false;
            }
            finally
            {
                if (thisConn.State == ConnectionState.Open)
                {
                    isConntected = true;
                    thisConn.Close();
                    thisConn.Dispose();
                }
            }
            if (isConntected)
            {
                lbConnStatus.Text = "√连接正常.";
            }
            else
            {
                lbConnStatus.Text = "×数据库连接错误.";
            }
        }
        /// <summary>
        /// 往配置文件里写数据
        /// /
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSet_Click(object sender, EventArgs e)
        {
            //往文件里写配置文件
            string connstr = txtDatabase.Text;
            if (CDBOperate.WriteDBConnect2Txt(connstr))
            {
                MessageBox.Show("更改成功");
            }
        }

        private void FormSetting_Load(object sender, EventArgs e)
        {
            string str = CDBOperate.GetDBConnectFromTxt();
            txtDatabase.Text = str;
            string dianma = CDBOperate.GetDianMa();
            txtDM.Text = dianma;
            string remotedb = CDBOperate.GetRemoteDBConnectFromTxt();
            this.txtRemoteDb.Text = remotedb;

            this.txt_zx_xml_comcode.Text = CDBOperate.GetZxXmlComcodeFromTxt();
            this.txt_zx_xml_comname.Text = CDBOperate.GetZxXmlComnameFromTxt();
            this.txt_zx_xml_path.Text = CDBOperate.GetZxXmlPathFromTxt();

        }

        private void FormSetting_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (setConnectEvent != null)
            {
                setConnectEvent();
            }
        }

        private void btnSaveSetting_Click(object sender, EventArgs e)
        {
            if (txtDM.Text == "")
            {
                MessageBox.Show("店码为空");
                return;
            }
            string filePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            CIniFile myFile = new CIniFile(filePath);
            try
            {
                myFile.IniWriteValue("Setting", "DianMa", txtDM.Text);
                if (setSettingEvent != null)
                {
                    setSettingEvent(txtDM.Text);
                }
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnRemoteDB_Click(object sender, EventArgs e)
        {
            if (txtRemoteDb.Text == "")
            {
                MessageBox.Show("远程数据库连接为空");
                return;
            }
            string filePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            CIniFile myFile = new CIniFile(filePath);
            try
            {
                myFile.IniWriteValue("Setting", "RemoteDataBase", txtRemoteDb.Text);
                if (setRemoteDbEvent != null)
                {
                    setRemoteDbEvent(this.txtRemoteDb.Text);
                }
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog dlg = new FolderBrowserDialog();
            if (DialogResult.OK == dlg.ShowDialog())
            {
                txt_zx_xml_path.Text = dlg.SelectedPath;
            }
        }

        private void btnSavePath_Click(object sender, EventArgs e)
        {
            if (this.txt_zx_xml_path.Text == "")
            {
                MessageBox.Show("路径为空");
                return;
            }
            if (this.txt_zx_xml_comcode.Text == "")
            {
                MessageBox.Show("单位编号为空");
                return;
            }
            if (this.txt_zx_xml_comname.Text == "")
            {
                MessageBox.Show("单位名称为空");
                return;
            }


            string filePath = System.Windows.Forms.Application.StartupPath + "\\setting.ini";
            if (!File.Exists(filePath))
            {
                File.Create(filePath);
            }
            CIniFile myFile = new CIniFile(filePath);
            try
            {
                myFile.IniWriteValue("Setting", "ZxUploadXmlPath", this.txt_zx_xml_path.Text);
                myFile.IniWriteValue("Setting", "ZxUploadXmlComcode", this.txt_zx_xml_comcode.Text);
                myFile.IniWriteValue("Setting", "ZxUploadXmlComname", this.txt_zx_xml_comname.Text);

                if (setZxXmlPathEvent != null)
                {
                    setZxXmlPathEvent(this.txt_zx_xml_path.Text);
                }
                MessageBox.Show("保存成功");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
