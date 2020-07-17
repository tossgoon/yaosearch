namespace YaoSearch
{
    partial class FormSinglePurStatis
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle53 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle54 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle55 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle56 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle49 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle50 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle51 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle52 = new System.Windows.Forms.DataGridViewCellStyle();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dtpkEnddate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label120 = new System.Windows.Forms.Label();
            this.dtpkBegindate = new System.Windows.Forms.DateTimePicker();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelInfo = new System.Windows.Forms.ToolStripStatusLabel();
            this.txtPurBm = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gboxSingleBuy = new System.Windows.Forms.GroupBox();
            this.txtPurNameSelect = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStatis = new notePadProj.CDoubleBufferDataGridView();
            this.dgvDetail = new notePadProj.CDoubleBufferDataGridView();
            this.txtYpBm = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvDrugInfo2 = new notePadProj.CDoubleBufferDataGridView();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.gboxSingleBuy.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatis)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugInfo2)).BeginInit();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Location = new System.Drawing.Point(6, 61);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dgvDrugInfo2);
            this.splitContainer1.Panel1.Controls.Add(this.label1);
            this.splitContainer1.Panel1.Controls.Add(this.txtPurBm);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dgvDetail);
            this.splitContainer1.Panel2.Controls.Add(this.dgvStatis);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtYpBm);
            this.splitContainer1.Panel2.Controls.Add(this.txtPurNameSelect);
            this.splitContainer1.Size = new System.Drawing.Size(1219, 574);
            this.splitContainer1.SplitterDistance = 441;
            this.splitContainer1.TabIndex = 1;
            // 
            // dtpkEnddate
            // 
            this.dtpkEnddate.Location = new System.Drawing.Point(389, 17);
            this.dtpkEnddate.Name = "dtpkEnddate";
            this.dtpkEnddate.Size = new System.Drawing.Size(135, 21);
            this.dtpkEnddate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.SteelBlue;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(296, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 20);
            this.label2.TabIndex = 35;
            this.label2.Text = "终止日期";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label120
            // 
            this.label120.BackColor = System.Drawing.Color.SteelBlue;
            this.label120.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label120.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label120.ForeColor = System.Drawing.Color.White;
            this.label120.Location = new System.Drawing.Point(18, 17);
            this.label120.Name = "label120";
            this.label120.Size = new System.Drawing.Size(91, 20);
            this.label120.TabIndex = 35;
            this.label120.Text = "起始日期";
            this.label120.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dtpkBegindate
            // 
            this.dtpkBegindate.Location = new System.Drawing.Point(110, 17);
            this.dtpkBegindate.Name = "dtpkBegindate";
            this.dtpkBegindate.Size = new System.Drawing.Size(138, 21);
            this.dtpkBegindate.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelInfo});
            this.statusStrip1.Location = new System.Drawing.Point(0, 642);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1230, 22);
            this.statusStrip1.TabIndex = 38;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelInfo
            // 
            this.statusLabelInfo.Name = "statusLabelInfo";
            this.statusLabelInfo.Size = new System.Drawing.Size(131, 17);
            this.statusLabelInfo.Text = "toolStripStatusLabel1";
            // 
            // txtPurBm
            // 
            this.txtPurBm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurBm.Location = new System.Drawing.Point(109, 10);
            this.txtPurBm.Name = "txtPurBm";
            this.txtPurBm.Size = new System.Drawing.Size(326, 21);
            this.txtPurBm.TabIndex = 20;
            this.txtPurBm.TextChanged += new System.EventHandler(this.txtPurBm_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "药品名称或编码:";
            // 
            // gboxSingleBuy
            // 
            this.gboxSingleBuy.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gboxSingleBuy.Controls.Add(this.dtpkEnddate);
            this.gboxSingleBuy.Controls.Add(this.label2);
            this.gboxSingleBuy.Controls.Add(this.dtpkBegindate);
            this.gboxSingleBuy.Controls.Add(this.label120);
            this.gboxSingleBuy.Location = new System.Drawing.Point(6, 2);
            this.gboxSingleBuy.Name = "gboxSingleBuy";
            this.gboxSingleBuy.Size = new System.Drawing.Size(1219, 53);
            this.gboxSingleBuy.TabIndex = 39;
            this.gboxSingleBuy.TabStop = false;
            // 
            // txtPurNameSelect
            // 
            this.txtPurNameSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPurNameSelect.Enabled = false;
            this.txtPurNameSelect.Location = new System.Drawing.Point(306, 11);
            this.txtPurNameSelect.Name = "txtPurNameSelect";
            this.txtPurNameSelect.Size = new System.Drawing.Size(460, 21);
            this.txtPurNameSelect.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 12);
            this.label3.TabIndex = 21;
            this.label3.Text = "药品名称:";
            // 
            // dgvStatis
            // 
            this.dgvStatis.AllowUserToAddRows = false;
            this.dgvStatis.AllowUserToDeleteRows = false;
            dataGridViewCellStyle53.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvStatis.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle53;
            this.dgvStatis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvStatis.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvStatis.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle54.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle54.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle54.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle54.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle54.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle54.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle54.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatis.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle54;
            this.dgvStatis.ColumnHeadersHeight = 30;
            this.dgvStatis.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle55.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle55.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle55.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle55.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle55.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle55.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle55.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvStatis.DefaultCellStyle = dataGridViewCellStyle55;
            this.dgvStatis.EnableHeadersVisualStyles = false;
            this.dgvStatis.Location = new System.Drawing.Point(3, 38);
            this.dgvStatis.MultiSelect = false;
            this.dgvStatis.Name = "dgvStatis";
            this.dgvStatis.ReadOnly = true;
            dataGridViewCellStyle56.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle56.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle56.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle56.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle56.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle56.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle56.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvStatis.RowHeadersDefaultCellStyle = dataGridViewCellStyle56;
            this.dgvStatis.RowHeadersWidth = 65;
            this.dgvStatis.RowTemplate.Height = 23;
            this.dgvStatis.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvStatis.Size = new System.Drawing.Size(763, 195);
            this.dgvStatis.TabIndex = 22;
            this.dgvStatis.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cDoubleBufferDataGridView1_CellClick);
            // 
            // dgvDetail
            // 
            this.dgvDetail.AllowUserToAddRows = false;
            this.dgvDetail.AllowUserToDeleteRows = false;
            dataGridViewCellStyle49.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dgvDetail.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle49;
            this.dgvDetail.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDetail.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDetail.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle50.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle50.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(254)))), ((int)(((byte)(254)))));
            dataGridViewCellStyle50.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle50.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle50.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle50.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle50.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle50;
            this.dgvDetail.ColumnHeadersHeight = 30;
            this.dgvDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle51.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle51.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle51.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle51.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle51.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle51.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle51.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDetail.DefaultCellStyle = dataGridViewCellStyle51;
            this.dgvDetail.EnableHeadersVisualStyles = false;
            this.dgvDetail.Location = new System.Drawing.Point(3, 239);
            this.dgvDetail.MultiSelect = false;
            this.dgvDetail.Name = "dgvDetail";
            this.dgvDetail.ReadOnly = true;
            dataGridViewCellStyle52.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle52.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(223)))), ((int)(((byte)(227)))));
            dataGridViewCellStyle52.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle52.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle52.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle52.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle52.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDetail.RowHeadersDefaultCellStyle = dataGridViewCellStyle52;
            this.dgvDetail.RowHeadersWidth = 65;
            this.dgvDetail.RowTemplate.Height = 23;
            this.dgvDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDetail.Size = new System.Drawing.Size(763, 330);
            this.dgvDetail.TabIndex = 22;
            // 
            // txtYpBm
            // 
            this.txtYpBm.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYpBm.Enabled = false;
            this.txtYpBm.Location = new System.Drawing.Point(75, 11);
            this.txtYpBm.Name = "txtYpBm";
            this.txtYpBm.Size = new System.Drawing.Size(148, 21);
            this.txtYpBm.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 12);
            this.label4.TabIndex = 21;
            this.label4.Text = "药品编码:";
            // 
            // dgvDrugInfo2
            // 
            this.dgvDrugInfo2.AllowUserToAddRows = false;
            this.dgvDrugInfo2.AllowUserToDeleteRows = false;
            this.dgvDrugInfo2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvDrugInfo2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDrugInfo2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvDrugInfo2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrugInfo2.Location = new System.Drawing.Point(5, 37);
            this.dgvDrugInfo2.Name = "dgvDrugInfo2";
            this.dgvDrugInfo2.ReadOnly = true;
            this.dgvDrugInfo2.RowHeadersWidth = 65;
            this.dgvDrugInfo2.RowTemplate.Height = 23;
            this.dgvDrugInfo2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDrugInfo2.Size = new System.Drawing.Size(430, 532);
            this.dgvDrugInfo2.TabIndex = 22;
            this.dgvDrugInfo2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDrugInfo2_CellClick);
            // 
            // FormSinglePurStatis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1230, 664);
            this.Controls.Add(this.gboxSingleBuy);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Name = "FormSinglePurStatis";
            this.Text = "单品采购汇总（总店）";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            this.splitContainer1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.gboxSingleBuy.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvStatis)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrugInfo2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DateTimePicker dtpkEnddate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label120;
        private System.Windows.Forms.DateTimePicker dtpkBegindate;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelInfo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPurBm;
        private System.Windows.Forms.GroupBox gboxSingleBuy;
        private notePadProj.CDoubleBufferDataGridView dgvDetail;
        private notePadProj.CDoubleBufferDataGridView dgvStatis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPurNameSelect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtYpBm;
        private notePadProj.CDoubleBufferDataGridView dgvDrugInfo2;

    }
}