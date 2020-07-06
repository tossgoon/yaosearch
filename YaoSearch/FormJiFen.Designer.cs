namespace YaoSearch
{
    partial class FormJiFen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormJiFen));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tbtnDeleteType = new System.Windows.Forms.ToolStripButton();
            this.cbxJiFenType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtzjm = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnUpdateType = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtlsj = new System.Windows.Forms.TextBox();
            this.txtdw = new System.Windows.Forms.TextBox();
            this.txtOldType = new System.Windows.Forms.TextBox();
            this.txtgg = new System.Windows.Forms.TextBox();
            this.txtsccj = new System.Windows.Forms.TextBox();
            this.txtmc = new System.Windows.Forms.TextBox();
            this.cboxUpdateType = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cboxBigType = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvDrug = new notePadProj.CDoubleBufferDataGridView();
            this.colDrugSpbm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colmc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colsccj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colgg = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colzjm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coldw = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collbbm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.collsj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tbtnDeleteType});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1015, 25);
            this.toolStrip1.TabIndex = 20;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tbtnDeleteType
            // 
            this.tbtnDeleteType.Image = ((System.Drawing.Image)(resources.GetObject("tbtnDeleteType.Image")));
            this.tbtnDeleteType.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tbtnDeleteType.Name = "tbtnDeleteType";
            this.tbtnDeleteType.Size = new System.Drawing.Size(100, 22);
            this.tbtnDeleteType.Text = "删除品种类别";
            this.tbtnDeleteType.Click += new System.EventHandler(this.tbtnDeleteType_Click);
            // 
            // cbxJiFenType
            // 
            this.cbxJiFenType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxJiFenType.FormattingEnabled = true;
            this.cbxJiFenType.Location = new System.Drawing.Point(334, 29);
            this.cbxJiFenType.Name = "cbxJiFenType";
            this.cbxJiFenType.Size = new System.Drawing.Size(266, 20);
            this.cbxJiFenType.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(240, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "选择查询类别：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(609, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 22;
            this.label2.Text = "注记码：";
            // 
            // txtzjm
            // 
            this.txtzjm.Location = new System.Drawing.Point(668, 28);
            this.txtzjm.Name = "txtzjm";
            this.txtzjm.Size = new System.Drawing.Size(207, 21);
            this.txtzjm.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 24;
            this.label3.Text = "名称：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.btnUpdateType);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtlsj);
            this.groupBox1.Controls.Add(this.txtdw);
            this.groupBox1.Controls.Add(this.txtOldType);
            this.groupBox1.Controls.Add(this.txtgg);
            this.groupBox1.Controls.Add(this.txtsccj);
            this.groupBox1.Controls.Add(this.txtmc);
            this.groupBox1.Controls.Add(this.cboxUpdateType);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Location = new System.Drawing.Point(4, 557);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1009, 89);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            // 
            // btnUpdateType
            // 
            this.btnUpdateType.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpdateType.Location = new System.Drawing.Point(910, 48);
            this.btnUpdateType.Name = "btnUpdateType";
            this.btnUpdateType.Size = new System.Drawing.Size(81, 31);
            this.btnUpdateType.TabIndex = 25;
            this.btnUpdateType.Text = "更新类别";
            this.btnUpdateType.UseVisualStyleBackColor = true;
            this.btnUpdateType.Click += new System.EventHandler(this.btnUpdateType_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(653, 63);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "零售价：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(530, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 12);
            this.label7.TabIndex = 24;
            this.label7.Text = "单位：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(384, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 12);
            this.label8.TabIndex = 24;
            this.label8.Text = "当前类别：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(408, 63);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 24;
            this.label6.Text = "规格：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 24;
            this.label5.Text = "生产厂家：";
            // 
            // txtlsj
            // 
            this.txtlsj.Location = new System.Drawing.Point(709, 59);
            this.txtlsj.Name = "txtlsj";
            this.txtlsj.ReadOnly = true;
            this.txtlsj.Size = new System.Drawing.Size(66, 21);
            this.txtlsj.TabIndex = 23;
            // 
            // txtdw
            // 
            this.txtdw.Location = new System.Drawing.Point(572, 59);
            this.txtdw.Name = "txtdw";
            this.txtdw.ReadOnly = true;
            this.txtdw.Size = new System.Drawing.Size(66, 21);
            this.txtdw.TabIndex = 23;
            // 
            // txtOldType
            // 
            this.txtOldType.Location = new System.Drawing.Point(451, 25);
            this.txtOldType.Name = "txtOldType";
            this.txtOldType.ReadOnly = true;
            this.txtOldType.Size = new System.Drawing.Size(187, 21);
            this.txtOldType.TabIndex = 23;
            // 
            // txtgg
            // 
            this.txtgg.Location = new System.Drawing.Point(451, 59);
            this.txtgg.Name = "txtgg";
            this.txtgg.ReadOnly = true;
            this.txtgg.Size = new System.Drawing.Size(64, 21);
            this.txtgg.TabIndex = 23;
            // 
            // txtsccj
            // 
            this.txtsccj.Location = new System.Drawing.Point(75, 58);
            this.txtsccj.Name = "txtsccj";
            this.txtsccj.ReadOnly = true;
            this.txtsccj.Size = new System.Drawing.Size(275, 21);
            this.txtsccj.TabIndex = 23;
            // 
            // txtmc
            // 
            this.txtmc.Location = new System.Drawing.Point(75, 26);
            this.txtmc.Name = "txtmc";
            this.txtmc.ReadOnly = true;
            this.txtmc.Size = new System.Drawing.Size(275, 21);
            this.txtmc.TabIndex = 23;
            // 
            // cboxUpdateType
            // 
            this.cboxUpdateType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxUpdateType.FormattingEnabled = true;
            this.cboxUpdateType.Location = new System.Drawing.Point(764, 22);
            this.cboxUpdateType.Name = "cboxUpdateType";
            this.cboxUpdateType.Size = new System.Drawing.Size(229, 20);
            this.cboxUpdateType.TabIndex = 21;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label4.Location = new System.Drawing.Point(681, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 22;
            this.label4.Text = "选择新类别：";
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(881, 27);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 26;
            this.btnSearch.Text = "查询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cboxBigType
            // 
            this.cboxBigType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxBigType.FormattingEnabled = true;
            this.cboxBigType.Location = new System.Drawing.Point(96, 30);
            this.cboxBigType.Name = "cboxBigType";
            this.cboxBigType.Size = new System.Drawing.Size(117, 20);
            this.cboxBigType.TabIndex = 21;
            this.cboxBigType.SelectedValueChanged += new System.EventHandler(this.cboxBigType_SelectedValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(25, 31);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "选择大类：";
            // 
            // dgvDrug
            // 
            this.dgvDrug.AllowUserToAddRows = false;
            this.dgvDrug.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDrug.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDrug.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrug.ColumnHeadersHeight = 30;
            this.dgvDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvDrug.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colDrugSpbm,
            this.colmc,
            this.colsccj,
            this.colgg,
            this.colzjm,
            this.coldw,
            this.collbbm,
            this.collsj});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrug.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrug.EnableHeadersVisualStyles = false;
            this.dgvDrug.Location = new System.Drawing.Point(4, 59);
            this.dgvDrug.MultiSelect = false;
            this.dgvDrug.Name = "dgvDrug";
            this.dgvDrug.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrug.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvDrug.RowHeadersWidth = 65;
            this.dgvDrug.RowTemplate.Height = 23;
            this.dgvDrug.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrug.Size = new System.Drawing.Size(1009, 492);
            this.dgvDrug.TabIndex = 19;
            this.dgvDrug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrug_CellClick);
            // 
            // colDrugSpbm
            // 
            this.colDrugSpbm.HeaderText = "bm";
            this.colDrugSpbm.Name = "colDrugSpbm";
            this.colDrugSpbm.ReadOnly = true;
            this.colDrugSpbm.Visible = false;
            this.colDrugSpbm.Width = 44;
            // 
            // colmc
            // 
            this.colmc.HeaderText = "品种名称";
            this.colmc.Name = "colmc";
            this.colmc.ReadOnly = true;
            this.colmc.Width = 64;
            // 
            // colsccj
            // 
            this.colsccj.HeaderText = "生产厂家";
            this.colsccj.Name = "colsccj";
            this.colsccj.ReadOnly = true;
            this.colsccj.Width = 64;
            // 
            // colgg
            // 
            this.colgg.HeaderText = "规格";
            this.colgg.Name = "colgg";
            this.colgg.ReadOnly = true;
            this.colgg.Width = 52;
            // 
            // colzjm
            // 
            this.colzjm.HeaderText = "注记码";
            this.colzjm.Name = "colzjm";
            this.colzjm.ReadOnly = true;
            this.colzjm.Width = 64;
            // 
            // coldw
            // 
            this.coldw.HeaderText = "单位";
            this.coldw.Name = "coldw";
            this.coldw.ReadOnly = true;
            this.coldw.Width = 52;
            // 
            // collbbm
            // 
            this.collbbm.HeaderText = "类别编码";
            this.collbbm.Name = "collbbm";
            this.collbbm.ReadOnly = true;
            this.collbbm.Width = 64;
            // 
            // collsj
            // 
            this.collsj.HeaderText = "零售价";
            this.collsj.Name = "collsj";
            this.collsj.ReadOnly = true;
            this.collsj.Width = 64;
            // 
            // FormJiFen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1015, 650);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtzjm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxBigType);
            this.Controls.Add(this.cbxJiFenType);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dgvDrug);
            this.Name = "FormJiFen";
            this.Text = "更改品种类别";
            this.Load += new System.EventHandler(this.FormJiFen_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private notePadProj.CDoubleBufferDataGridView dgvDrug;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tbtnDeleteType;
        private System.Windows.Forms.ComboBox cbxJiFenType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtzjm;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateType;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtdw;
        private System.Windows.Forms.TextBox txtgg;
        private System.Windows.Forms.TextBox txtsccj;
        private System.Windows.Forms.TextBox txtmc;
        private System.Windows.Forms.ComboBox cboxUpdateType;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtOldType;
        private System.Windows.Forms.ComboBox cboxBigType;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtlsj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDrugSpbm;
        private System.Windows.Forms.DataGridViewTextBoxColumn colmc;
        private System.Windows.Forms.DataGridViewTextBoxColumn colsccj;
        private System.Windows.Forms.DataGridViewTextBoxColumn colgg;
        private System.Windows.Forms.DataGridViewTextBoxColumn colzjm;
        private System.Windows.Forms.DataGridViewTextBoxColumn coldw;
        private System.Windows.Forms.DataGridViewTextBoxColumn collbbm;
        private System.Windows.Forms.DataGridViewTextBoxColumn collsj;
    }
}