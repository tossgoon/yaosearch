namespace YaoSearch
{
    partial class FormUpdateYxqx
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboxTypeSelect = new System.Windows.Forms.ComboBox();
            this.dgviewTbInfo = new notePadProj.CDoubleBufferDataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYxqx = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tstatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtLsh = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewTbInfo)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.txtYxqx);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtMc);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtLsh);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtCode);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboxTypeSelect);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(9, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1045, 88);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "选择类别：";
            // 
            // cboxTypeSelect
            // 
            this.cboxTypeSelect.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboxTypeSelect.FormattingEnabled = true;
            this.cboxTypeSelect.Items.AddRange(new object[] {
            "入库单",
            "出库单",
            "库存"});
            this.cboxTypeSelect.Location = new System.Drawing.Point(88, 19);
            this.cboxTypeSelect.Name = "cboxTypeSelect";
            this.cboxTypeSelect.Size = new System.Drawing.Size(113, 20);
            this.cboxTypeSelect.TabIndex = 1;
            this.cboxTypeSelect.SelectedIndexChanged += new System.EventHandler(this.cboxTypeSelect_SelectedIndexChanged);
            // 
            // dgviewTbInfo
            // 
            this.dgviewTbInfo.AllowUserToAddRows = false;
            this.dgviewTbInfo.AllowUserToDeleteRows = false;
            this.dgviewTbInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgviewTbInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgviewTbInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgviewTbInfo.Location = new System.Drawing.Point(9, 99);
            this.dgviewTbInfo.Name = "dgviewTbInfo";
            this.dgviewTbInfo.ReadOnly = true;
            this.dgviewTbInfo.RowTemplate.Height = 23;
            this.dgviewTbInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgviewTbInfo.Size = new System.Drawing.Size(1045, 568);
            this.dgviewTbInfo.TabIndex = 1;
            this.dgviewTbInfo.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgviewTbInfo_CellClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "编号";
            // 
            // txtCode
            // 
            this.txtCode.Location = new System.Drawing.Point(274, 20);
            this.txtCode.Name = "txtCode";
            this.txtCode.ReadOnly = true;
            this.txtCode.Size = new System.Drawing.Size(100, 21);
            this.txtCode.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "名称";
            // 
            // txtMc
            // 
            this.txtMc.Location = new System.Drawing.Point(424, 20);
            this.txtMc.Name = "txtMc";
            this.txtMc.ReadOnly = true;
            this.txtMc.Size = new System.Drawing.Size(300, 21);
            this.txtMc.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(743, 24);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "有效期";
            // 
            // txtYxqx
            // 
            this.txtYxqx.Location = new System.Drawing.Point(788, 20);
            this.txtYxqx.Name = "txtYxqx";
            this.txtYxqx.Size = new System.Drawing.Size(99, 21);
            this.txtYxqx.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(893, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 12);
            this.label5.TabIndex = 2;
            this.label5.Text = "(8位数字，如20190613)";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(812, 58);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tstatusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 670);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1066, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tstatusLabel
            // 
            this.tstatusLabel.Name = "tstatusLabel";
            this.tstatusLabel.Size = new System.Drawing.Size(35, 17);
            this.tstatusLabel.Text = "就绪.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(230, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "流水号";
            // 
            // txtLsh
            // 
            this.txtLsh.Location = new System.Drawing.Point(274, 58);
            this.txtLsh.Name = "txtLsh";
            this.txtLsh.ReadOnly = true;
            this.txtLsh.Size = new System.Drawing.Size(450, 21);
            this.txtLsh.TabIndex = 3;
            // 
            // FormUpdateYxqx
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1066, 692);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.dgviewTbInfo);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormUpdateYxqx";
            this.Text = "更新有效期限";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgviewTbInfo)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYxqx;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtMc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboxTypeSelect;
        private System.Windows.Forms.Label label1;
        private notePadProj.CDoubleBufferDataGridView dgviewTbInfo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tstatusLabel;
        private System.Windows.Forms.TextBox txtLsh;
        private System.Windows.Forms.Label label6;
    }
}