namespace YaoSearch
{
    partial class FormCaiGou
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDbConn = new System.Windows.Forms.TextBox();
            this.linkTestConn = new System.Windows.Forms.LinkLabel();
            this.lbresult = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDel = new System.Windows.Forms.Button();
            this.btnUnSelect = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnSelectAll = new System.Windows.Forms.Button();
            this.btnLoadPur = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.dgvPur = new notePadProj.CDoubleBufferDataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colselect = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.bm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sccj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jhdw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yssl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstripstatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lkRemoteConn = new System.Windows.Forms.LinkLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPur)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "远程数据库:";
            // 
            // txtDbConn
            // 
            this.txtDbConn.Location = new System.Drawing.Point(87, 23);
            this.txtDbConn.Name = "txtDbConn";
            this.txtDbConn.Size = new System.Drawing.Size(579, 21);
            this.txtDbConn.TabIndex = 1;
            // 
            // linkTestConn
            // 
            this.linkTestConn.AutoSize = true;
            this.linkTestConn.Location = new System.Drawing.Point(85, 61);
            this.linkTestConn.Name = "linkTestConn";
            this.linkTestConn.Size = new System.Drawing.Size(53, 12);
            this.linkTestConn.TabIndex = 2;
            this.linkTestConn.TabStop = true;
            this.linkTestConn.Text = "测试连接";
            this.linkTestConn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkTestConn_LinkClicked);
            // 
            // lbresult
            // 
            this.lbresult.AutoSize = true;
            this.lbresult.Location = new System.Drawing.Point(154, 60);
            this.lbresult.Name = "lbresult";
            this.lbresult.Size = new System.Drawing.Size(23, 12);
            this.lbresult.TabIndex = 3;
            this.lbresult.Text = "...";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnDel);
            this.groupBox1.Controls.Add(this.btnUnSelect);
            this.groupBox1.Controls.Add(this.btnUpload);
            this.groupBox1.Controls.Add(this.btnSelectAll);
            this.groupBox1.Controls.Add(this.btnLoadPur);
            this.groupBox1.Controls.Add(this.btnAdd);
            this.groupBox1.Controls.Add(this.dgvPur);
            this.groupBox1.Location = new System.Drawing.Point(1, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(788, 293);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "采购单";
            // 
            // btnDel
            // 
            this.btnDel.Location = new System.Drawing.Point(285, 20);
            this.btnDel.Name = "btnDel";
            this.btnDel.Size = new System.Drawing.Size(62, 30);
            this.btnDel.TabIndex = 8;
            this.btnDel.Text = "删除-";
            this.btnDel.UseVisualStyleBackColor = true;
            this.btnDel.Click += new System.EventHandler(this.btnDel_Click);
            // 
            // btnUnSelect
            // 
            this.btnUnSelect.ForeColor = System.Drawing.Color.RoyalBlue;
            this.btnUnSelect.Location = new System.Drawing.Point(109, 20);
            this.btnUnSelect.Name = "btnUnSelect";
            this.btnUnSelect.Size = new System.Drawing.Size(65, 30);
            this.btnUnSelect.TabIndex = 8;
            this.btnUnSelect.Text = "反选";
            this.btnUnSelect.UseVisualStyleBackColor = true;
            this.btnUnSelect.Click += new System.EventHandler(this.btnUnSelect_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpload.ForeColor = System.Drawing.Color.DarkCyan;
            this.btnUpload.Location = new System.Drawing.Point(663, 20);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(94, 30);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "上传采购单";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnSelectAll
            // 
            this.btnSelectAll.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnSelectAll.Location = new System.Drawing.Point(38, 20);
            this.btnSelectAll.Name = "btnSelectAll";
            this.btnSelectAll.Size = new System.Drawing.Size(65, 30);
            this.btnSelectAll.TabIndex = 8;
            this.btnSelectAll.Text = "全选";
            this.btnSelectAll.UseVisualStyleBackColor = true;
            this.btnSelectAll.Click += new System.EventHandler(this.btnSelectAll_Click);
            // 
            // btnLoadPur
            // 
            this.btnLoadPur.ForeColor = System.Drawing.Color.Navy;
            this.btnLoadPur.Location = new System.Drawing.Point(372, 20);
            this.btnLoadPur.Name = "btnLoadPur";
            this.btnLoadPur.Size = new System.Drawing.Size(80, 30);
            this.btnLoadPur.TabIndex = 8;
            this.btnLoadPur.Text = "自动生成+";
            this.btnLoadPur.UseVisualStyleBackColor = true;
            this.btnLoadPur.Click += new System.EventHandler(this.btnLoadPur_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAdd.Location = new System.Drawing.Point(214, 20);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(65, 30);
            this.btnAdd.TabIndex = 8;
            this.btnAdd.Text = "添加+";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // dgvPur
            // 
            this.dgvPur.AllowUserToAddRows = false;
            this.dgvPur.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPur.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvPur.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvPur.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPur.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.colselect,
            this.bm,
            this.mc,
            this.sccj,
            this.gg,
            this.jhdw,
            this.yssl});
            this.dgvPur.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnEnter;
            this.dgvPur.Location = new System.Drawing.Point(3, 58);
            this.dgvPur.Name = "dgvPur";
            this.dgvPur.RowTemplate.Height = 23;
            this.dgvPur.Size = new System.Drawing.Size(782, 255);
            this.dgvPur.TabIndex = 0;
            this.dgvPur.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPur_CellContentClick);
            this.dgvPur.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.dgvPur_RowsAdded);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 42;
            // 
            // colselect
            // 
            this.colselect.HeaderText = "选择";
            this.colselect.Name = "colselect";
            this.colselect.Width = 35;
            // 
            // bm
            // 
            this.bm.HeaderText = "编码";
            this.bm.Name = "bm";
            this.bm.ReadOnly = true;
            this.bm.Width = 54;
            // 
            // mc
            // 
            this.mc.HeaderText = "名称";
            this.mc.Name = "mc";
            this.mc.ReadOnly = true;
            this.mc.Width = 54;
            // 
            // sccj
            // 
            this.sccj.HeaderText = "生产厂家";
            this.sccj.Name = "sccj";
            this.sccj.ReadOnly = true;
            this.sccj.Width = 78;
            // 
            // gg
            // 
            this.gg.HeaderText = "规格";
            this.gg.Name = "gg";
            this.gg.ReadOnly = true;
            this.gg.Width = 54;
            // 
            // jhdw
            // 
            this.jhdw.HeaderText = "进货单位";
            this.jhdw.Name = "jhdw";
            this.jhdw.ReadOnly = true;
            this.jhdw.Width = 78;
            // 
            // yssl
            // 
            this.yssl.HeaderText = "数量";
            this.yssl.Name = "yssl";
            this.yssl.Width = 54;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstripstatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 399);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(797, 22);
            this.statusStrip1.TabIndex = 6;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstripstatus
            // 
            this.tstripstatus.Name = "tstripstatus";
            this.tstripstatus.Size = new System.Drawing.Size(35, 17);
            this.tstripstatus.Text = "就绪.";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.lkRemoteConn);
            this.groupBox2.Controls.Add(this.linkTestConn);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.txtDbConn);
            this.groupBox2.Controls.Add(this.lbresult);
            this.groupBox2.Location = new System.Drawing.Point(6, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(783, 80);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "设置";
            // 
            // lkRemoteConn
            // 
            this.lkRemoteConn.AutoSize = true;
            this.lkRemoteConn.Location = new System.Drawing.Point(672, 25);
            this.lkRemoteConn.Name = "lkRemoteConn";
            this.lkRemoteConn.Size = new System.Drawing.Size(89, 12);
            this.lkRemoteConn.TabIndex = 2;
            this.lkRemoteConn.TabStop = true;
            this.lkRemoteConn.Text = "设置远程数据库";
            this.lkRemoteConn.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkRemoteConn_LinkClicked);
            // 
            // FormCaiGou
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 421);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormCaiGou";
            this.Text = "FormCaiGou";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCaiGou_FormClosed);
            this.Load += new System.EventHandler(this.FormCaiGou_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPur)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDbConn;
        private System.Windows.Forms.LinkLabel linkTestConn;
        private System.Windows.Forms.Label lbresult;
        private System.Windows.Forms.GroupBox groupBox1;
        private notePadProj.CDoubleBufferDataGridView dgvPur;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstripstatus;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUnSelect;
        private System.Windows.Forms.Button btnSelectAll;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewCheckBoxColumn colselect;
        private System.Windows.Forms.DataGridViewTextBoxColumn bm;
        private System.Windows.Forms.DataGridViewTextBoxColumn mc;
        private System.Windows.Forms.DataGridViewTextBoxColumn sccj;
        private System.Windows.Forms.DataGridViewTextBoxColumn gg;
        private System.Windows.Forms.DataGridViewTextBoxColumn jhdw;
        private System.Windows.Forms.DataGridViewTextBoxColumn yssl;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnLoadPur;
        private System.Windows.Forms.LinkLabel lkRemoteConn;
    }
}