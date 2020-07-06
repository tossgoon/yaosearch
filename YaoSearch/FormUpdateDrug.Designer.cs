namespace YaoSearch
{
    partial class FormUpdateDrug
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gboxdrug = new System.Windows.Forms.GroupBox();
            this.dgvDrug = new notePadProj.CDoubleBufferDataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.txt_zxbm = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtgg = new System.Windows.Forms.TextBox();
            this.txtbm = new System.Windows.Forms.TextBox();
            this.txtsccj = new System.Windows.Forms.TextBox();
            this.txtmc = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSaveInfo = new System.Windows.Forms.Button();
            this.txtDrugName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.chk_isup = new System.Windows.Forms.CheckBox();
            this.tipinfo = new System.Windows.Forms.Label();
            this.gboxdrug.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gboxdrug
            // 
            this.gboxdrug.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxdrug.Controls.Add(this.dgvDrug);
            this.gboxdrug.Location = new System.Drawing.Point(3, 151);
            this.gboxdrug.Name = "gboxdrug";
            this.gboxdrug.Size = new System.Drawing.Size(1188, 586);
            this.gboxdrug.TabIndex = 1;
            this.gboxdrug.TabStop = false;
            this.gboxdrug.Text = "药品信息";
            // 
            // dgvDrug
            // 
            this.dgvDrug.AllowUserToAddRows = false;
            this.dgvDrug.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDrug.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrug.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvDrug.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrug.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrug.ColumnHeadersHeight = 30;
            this.dgvDrug.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrug.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrug.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvDrug.EnableHeadersVisualStyles = false;
            this.dgvDrug.Location = new System.Drawing.Point(3, 17);
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
            this.dgvDrug.Size = new System.Drawing.Size(1182, 566);
            this.dgvDrug.TabIndex = 20;
            this.dgvDrug.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrug_CellClick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 740);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1193, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // txt_zxbm
            // 
            this.txt_zxbm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_zxbm.Location = new System.Drawing.Point(764, 23);
            this.txt_zxbm.Name = "txt_zxbm";
            this.txt_zxbm.Size = new System.Drawing.Size(247, 21);
            this.txt_zxbm.TabIndex = 60;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(669, 25);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(92, 17);
            this.label7.TabIndex = 59;
            this.label7.Text = "中心品种编码：";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(497, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 55;
            this.label4.Text = "规格：";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(497, 26);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 56;
            this.label6.Text = "编码：";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 57;
            this.label5.Text = "生产厂家：";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 58;
            this.label3.Text = "药品名称：";
            // 
            // txtgg
            // 
            this.txtgg.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtgg.Location = new System.Drawing.Point(540, 55);
            this.txtgg.Name = "txtgg";
            this.txtgg.ReadOnly = true;
            this.txtgg.Size = new System.Drawing.Size(106, 21);
            this.txtgg.TabIndex = 51;
            // 
            // txtbm
            // 
            this.txtbm.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtbm.Location = new System.Drawing.Point(540, 22);
            this.txtbm.Name = "txtbm";
            this.txtbm.ReadOnly = true;
            this.txtbm.Size = new System.Drawing.Size(106, 21);
            this.txtbm.TabIndex = 52;
            // 
            // txtsccj
            // 
            this.txtsccj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtsccj.Location = new System.Drawing.Point(95, 55);
            this.txtsccj.Name = "txtsccj";
            this.txtsccj.ReadOnly = true;
            this.txtsccj.Size = new System.Drawing.Size(383, 21);
            this.txtsccj.TabIndex = 53;
            // 
            // txtmc
            // 
            this.txtmc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtmc.Location = new System.Drawing.Point(95, 23);
            this.txtmc.Name = "txtmc";
            this.txtmc.ReadOnly = true;
            this.txtmc.Size = new System.Drawing.Size(383, 21);
            this.txtmc.TabIndex = 54;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tipinfo);
            this.groupBox1.Controls.Add(this.chk_isup);
            this.groupBox1.Controls.Add(this.btnSaveInfo);
            this.groupBox1.Controls.Add(this.txt_zxbm);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtgg);
            this.groupBox1.Controls.Add(this.txtbm);
            this.groupBox1.Controls.Add(this.txtsccj);
            this.groupBox1.Controls.Add(this.txtmc);
            this.groupBox1.Location = new System.Drawing.Point(6, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1182, 90);
            this.groupBox1.TabIndex = 61;
            this.groupBox1.TabStop = false;
            // 
            // btnSaveInfo
            // 
            this.btnSaveInfo.Location = new System.Drawing.Point(1017, 22);
            this.btnSaveInfo.Name = "btnSaveInfo";
            this.btnSaveInfo.Size = new System.Drawing.Size(75, 23);
            this.btnSaveInfo.TabIndex = 61;
            this.btnSaveInfo.Text = "保 存";
            this.btnSaveInfo.UseVisualStyleBackColor = true;
            this.btnSaveInfo.Click += new System.EventHandler(this.btnSaveInfo_Click);
            // 
            // txtDrugName
            // 
            this.txtDrugName.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtDrugName.Location = new System.Drawing.Point(81, 124);
            this.txtDrugName.Name = "txtDrugName";
            this.txtDrugName.Size = new System.Drawing.Size(936, 21);
            this.txtDrugName.TabIndex = 60;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(12, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 17);
            this.label1.TabIndex = 59;
            this.label1.Text = "药品名称：";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1023, 122);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 61;
            this.btnSearch.Text = "查 询";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // chk_isup
            // 
            this.chk_isup.AutoSize = true;
            this.chk_isup.Checked = true;
            this.chk_isup.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_isup.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.chk_isup.Location = new System.Drawing.Point(764, 55);
            this.chk_isup.Name = "chk_isup";
            this.chk_isup.Size = new System.Drawing.Size(76, 16);
            this.chk_isup.TabIndex = 62;
            this.chk_isup.Text = "数据上传";
            this.chk_isup.UseVisualStyleBackColor = true;
            // 
            // tipinfo
            // 
            this.tipinfo.AutoSize = true;
            this.tipinfo.Location = new System.Drawing.Point(1027, 55);
            this.tipinfo.Name = "tipinfo";
            this.tipinfo.Size = new System.Drawing.Size(17, 12);
            this.tipinfo.TabIndex = 63;
            this.tipinfo.Text = "  ";
            // 
            // FormUpdateDrug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1193, 762);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.txtDrugName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.gboxdrug);
            this.Name = "FormUpdateDrug";
            this.Text = "FormUpdateDrug";
            this.Load += new System.EventHandler(this.FormUpdateDrug_Load);
            this.gboxdrug.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrug)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gboxdrug;
        private notePadProj.CDoubleBufferDataGridView dgvDrug;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txt_zxbm;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtgg;
        private System.Windows.Forms.TextBox txtbm;
        private System.Windows.Forms.TextBox txtsccj;
        private System.Windows.Forms.TextBox txtmc;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnSaveInfo;
        private System.Windows.Forms.TextBox txtDrugName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.CheckBox chk_isup;
        private System.Windows.Forms.Label tipinfo;

    }
}