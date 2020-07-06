namespace YaoSearch
{
    partial class FormSetting
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSetting));
            this.btnSet = new System.Windows.Forms.Button();
            this.lbText = new System.Windows.Forms.Label();
            this.txtDatabase = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbConnStatus = new System.Windows.Forms.Label();
            this.btnConnTest = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtDM = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSaveSetting = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtRemoteDb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnConnectRemote = new System.Windows.Forms.Button();
            this.btnRemoteDB = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_zx_xml_path = new System.Windows.Forms.TextBox();
            this.btnSavePath = new System.Windows.Forms.Button();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_zx_xml_comcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_zx_xml_comname = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSet
            // 
            this.btnSet.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSet.Location = new System.Drawing.Point(653, 30);
            this.btnSet.Name = "btnSet";
            this.btnSet.Size = new System.Drawing.Size(81, 24);
            this.btnSet.TabIndex = 0;
            this.btnSet.Text = "保  存";
            this.btnSet.UseVisualStyleBackColor = true;
            this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbText.Location = new System.Drawing.Point(20, 35);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(65, 12);
            this.lbText.TabIndex = 1;
            this.lbText.Text = "本地数据库";
            // 
            // txtDatabase
            // 
            this.txtDatabase.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDatabase.Location = new System.Drawing.Point(91, 31);
            this.txtDatabase.Name = "txtDatabase";
            this.txtDatabase.Size = new System.Drawing.Size(555, 21);
            this.txtDatabase.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbConnStatus);
            this.groupBox1.Controls.Add(this.txtDatabase);
            this.groupBox1.Controls.Add(this.lbText);
            this.groupBox1.Controls.Add(this.btnConnTest);
            this.groupBox1.Controls.Add(this.btnSet);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox1.Location = new System.Drawing.Point(4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 100);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "数据库连接选项";
            // 
            // lbConnStatus
            // 
            this.lbConnStatus.AutoSize = true;
            this.lbConnStatus.Location = new System.Drawing.Point(280, 106);
            this.lbConnStatus.Name = "lbConnStatus";
            this.lbConnStatus.Size = new System.Drawing.Size(12, 12);
            this.lbConnStatus.TabIndex = 3;
            this.lbConnStatus.Text = " ";
            // 
            // btnConnTest
            // 
            this.btnConnTest.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnTest.Location = new System.Drawing.Point(653, 65);
            this.btnConnTest.Name = "btnConnTest";
            this.btnConnTest.Size = new System.Drawing.Size(81, 24);
            this.btnConnTest.TabIndex = 0;
            this.btnConnTest.Text = "测试连接";
            this.btnConnTest.UseVisualStyleBackColor = true;
            this.btnConnTest.Click += new System.EventHandler(this.btnConnTest_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtDM);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.btnSaveSetting);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox2.Location = new System.Drawing.Point(4, 112);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(747, 52);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "店码配置";
            // 
            // txtDM
            // 
            this.txtDM.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtDM.Location = new System.Drawing.Point(69, 19);
            this.txtDM.Name = "txtDM";
            this.txtDM.Size = new System.Drawing.Size(113, 21);
            this.txtDM.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(31, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "店码";
            // 
            // btnSaveSetting
            // 
            this.btnSaveSetting.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSaveSetting.Location = new System.Drawing.Point(188, 17);
            this.btnSaveSetting.Name = "btnSaveSetting";
            this.btnSaveSetting.Size = new System.Drawing.Size(81, 24);
            this.btnSaveSetting.TabIndex = 0;
            this.btnSaveSetting.Text = "保  存";
            this.btnSaveSetting.UseVisualStyleBackColor = true;
            this.btnSaveSetting.Click += new System.EventHandler(this.btnSaveSetting_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtRemoteDb);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.btnConnectRemote);
            this.groupBox3.Controls.Add(this.btnRemoteDB);
            this.groupBox3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.groupBox3.Location = new System.Drawing.Point(4, 174);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 94);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "总店服务器配置";
            // 
            // txtRemoteDb
            // 
            this.txtRemoteDb.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtRemoteDb.Location = new System.Drawing.Point(86, 24);
            this.txtRemoteDb.Name = "txtRemoteDb";
            this.txtRemoteDb.Size = new System.Drawing.Size(560, 21);
            this.txtRemoteDb.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(15, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 5;
            this.label1.Text = "远程数据库";
            // 
            // btnConnectRemote
            // 
            this.btnConnectRemote.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnectRemote.Location = new System.Drawing.Point(653, 58);
            this.btnConnectRemote.Name = "btnConnectRemote";
            this.btnConnectRemote.Size = new System.Drawing.Size(81, 24);
            this.btnConnectRemote.TabIndex = 3;
            this.btnConnectRemote.Text = "测试连接";
            this.btnConnectRemote.UseVisualStyleBackColor = true;
            // 
            // btnRemoteDB
            // 
            this.btnRemoteDB.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnRemoteDB.Location = new System.Drawing.Point(653, 23);
            this.btnRemoteDB.Name = "btnRemoteDB";
            this.btnRemoteDB.Size = new System.Drawing.Size(81, 24);
            this.btnRemoteDB.TabIndex = 4;
            this.btnRemoteDB.Text = "保  存";
            this.btnRemoteDB.UseVisualStyleBackColor = true;
            this.btnRemoteDB.Click += new System.EventHandler(this.btnRemoteDB_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnSelectPath);
            this.groupBox4.Controls.Add(this.btnSavePath);
            this.groupBox4.Controls.Add(this.txt_zx_xml_comname);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.txt_zx_xml_comcode);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Controls.Add(this.txt_zx_xml_path);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(4, 282);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(747, 155);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "中心数据上传文件路径";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "路径";
            // 
            // txt_zx_xml_path
            // 
            this.txt_zx_xml_path.Location = new System.Drawing.Point(69, 30);
            this.txt_zx_xml_path.Name = "txt_zx_xml_path";
            this.txt_zx_xml_path.Size = new System.Drawing.Size(527, 21);
            this.txt_zx_xml_path.TabIndex = 1;
            // 
            // btnSavePath
            // 
            this.btnSavePath.Location = new System.Drawing.Point(653, 119);
            this.btnSavePath.Name = "btnSavePath";
            this.btnSavePath.Size = new System.Drawing.Size(81, 23);
            this.btnSavePath.TabIndex = 2;
            this.btnSavePath.Text = "保存";
            this.btnSavePath.UseVisualStyleBackColor = true;
            this.btnSavePath.Click += new System.EventHandler(this.btnSavePath_Click);
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(602, 28);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(45, 23);
            this.btnSelectPath.TabIndex = 2;
            this.btnSelectPath.Text = "...";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "单位编号";
            // 
            // txt_zx_xml_comcode
            // 
            this.txt_zx_xml_comcode.Location = new System.Drawing.Point(69, 78);
            this.txt_zx_xml_comcode.Name = "txt_zx_xml_comcode";
            this.txt_zx_xml_comcode.Size = new System.Drawing.Size(101, 21);
            this.txt_zx_xml_comcode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(185, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "单位名称";
            // 
            // txt_zx_xml_comname
            // 
            this.txt_zx_xml_comname.Location = new System.Drawing.Point(241, 78);
            this.txt_zx_xml_comname.Name = "txt_zx_xml_comname";
            this.txt_zx_xml_comname.Size = new System.Drawing.Size(405, 21);
            this.txt_zx_xml_comname.TabIndex = 1;
            // 
            // FormSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 501);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "设置";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormSetting_FormClosed);
            this.Load += new System.EventHandler(this.FormSetting_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSet;
        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.TextBox txtDatabase;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lbConnStatus;
        private System.Windows.Forms.Button btnConnTest;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtDM;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSaveSetting;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtRemoteDb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnConnectRemote;
        private System.Windows.Forms.Button btnRemoteDB;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnSelectPath;
        private System.Windows.Forms.Button btnSavePath;
        private System.Windows.Forms.TextBox txt_zx_xml_path;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_zx_xml_comname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txt_zx_xml_comcode;
        private System.Windows.Forms.Label label4;
    }
}