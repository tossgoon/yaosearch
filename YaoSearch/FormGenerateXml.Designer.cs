﻿namespace YaoSearch
{
    partial class FormGenerateXml
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
            this.date_k_in = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtXmlPath = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.date_k_out = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.date_k_init = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtComCode = new System.Windows.Forms.TextBox();
            this.txtComName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbdate_in = new System.Windows.Forms.Label();
            this.lbdate_out = new System.Windows.Forms.Label();
            this.lbdate_init = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbdate_in);
            this.groupBox1.Controls.Add(this.date_k_in);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(24, 206);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 126);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "进货单";
            // 
            // date_k_in
            // 
            this.date_k_in.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_k_in.Location = new System.Drawing.Point(89, 31);
            this.date_k_in.Name = "date_k_in";
            this.date_k_in.Size = new System.Drawing.Size(159, 21);
            this.date_k_in.TabIndex = 0;
            this.date_k_in.Value = new System.DateTime(2020, 7, 23, 15, 11, 46, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "生成日期：";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 465);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(870, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Location = new System.Drawing.Point(773, 384);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(85, 26);
            this.btnGenerate.TabIndex = 2;
            this.btnGenerate.Text = "生成数据";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "保存目录：";
            // 
            // txtXmlPath
            // 
            this.txtXmlPath.Location = new System.Drawing.Point(96, 36);
            this.txtXmlPath.Name = "txtXmlPath";
            this.txtXmlPath.ReadOnly = true;
            this.txtXmlPath.Size = new System.Drawing.Size(762, 21);
            this.txtXmlPath.TabIndex = 4;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lbdate_out);
            this.groupBox4.Controls.Add(this.date_k_out);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Location = new System.Drawing.Point(307, 206);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(269, 126);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "出货单";
            // 
            // date_k_out
            // 
            this.date_k_out.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_k_out.Location = new System.Drawing.Point(88, 31);
            this.date_k_out.Name = "date_k_out";
            this.date_k_out.Size = new System.Drawing.Size(145, 21);
            this.date_k_out.TabIndex = 0;
            this.date_k_out.Value = new System.DateTime(2020, 7, 23, 15, 11, 56, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 3;
            this.label3.Text = "生成日期：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lbdate_init);
            this.groupBox2.Controls.Add(this.date_k_init);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(588, 206);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(270, 126);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "库存单";
            // 
            // date_k_init
            // 
            this.date_k_init.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.date_k_init.Location = new System.Drawing.Point(88, 31);
            this.date_k_init.Name = "date_k_init";
            this.date_k_init.Size = new System.Drawing.Size(145, 21);
            this.date_k_init.TabIndex = 0;
            this.date_k_init.Value = new System.DateTime(2020, 7, 23, 15, 12, 2, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(19, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 3;
            this.label4.Text = "生成日期：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 5;
            this.label5.Text = "单位编号：";
            // 
            // txtComCode
            // 
            this.txtComCode.Location = new System.Drawing.Point(96, 86);
            this.txtComCode.Name = "txtComCode";
            this.txtComCode.ReadOnly = true;
            this.txtComCode.Size = new System.Drawing.Size(152, 21);
            this.txtComCode.TabIndex = 4;
            // 
            // txtComName
            // 
            this.txtComName.Location = new System.Drawing.Point(337, 86);
            this.txtComName.Name = "txtComName";
            this.txtComName.ReadOnly = true;
            this.txtComName.Size = new System.Drawing.Size(521, 21);
            this.txtComName.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 89);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 5;
            this.label6.Text = "单位名称：";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 12);
            this.label7.TabIndex = 3;
            this.label7.Text = "上次生成日期：";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(19, 79);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 12);
            this.label8.TabIndex = 3;
            this.label8.Text = "上次生成日期：";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 79);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 12);
            this.label9.TabIndex = 3;
            this.label9.Text = "上次生成日期：";
            // 
            // lbdate_in
            // 
            this.lbdate_in.AutoSize = true;
            this.lbdate_in.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbdate_in.Location = new System.Drawing.Point(115, 79);
            this.lbdate_in.Name = "lbdate_in";
            this.lbdate_in.Size = new System.Drawing.Size(11, 12);
            this.lbdate_in.TabIndex = 4;
            this.lbdate_in.Text = " ";
            // 
            // lbdate_out
            // 
            this.lbdate_out.AutoSize = true;
            this.lbdate_out.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbdate_out.Location = new System.Drawing.Point(114, 79);
            this.lbdate_out.Name = "lbdate_out";
            this.lbdate_out.Size = new System.Drawing.Size(11, 12);
            this.lbdate_out.TabIndex = 4;
            this.lbdate_out.Text = " ";
            // 
            // lbdate_init
            // 
            this.lbdate_init.AutoSize = true;
            this.lbdate_init.ForeColor = System.Drawing.Color.ForestGreen;
            this.lbdate_init.Location = new System.Drawing.Point(114, 79);
            this.lbdate_init.Name = "lbdate_init";
            this.lbdate_init.Size = new System.Drawing.Size(11, 12);
            this.lbdate_init.TabIndex = 4;
            this.lbdate_init.Text = " ";
            // 
            // FormGenerateXml
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 487);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtComName);
            this.Controls.Add(this.txtComCode);
            this.Controls.Add(this.txtXmlPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormGenerateXml";
            this.Text = "FormGenerateXml";
            this.Load += new System.EventHandler(this.FormGenerateXml_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.DateTimePicker date_k_in;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtXmlPath;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DateTimePicker date_k_out;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DateTimePicker date_k_init;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtComCode;
        private System.Windows.Forms.TextBox txtComName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbdate_in;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lbdate_out;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbdate_init;
        private System.Windows.Forms.Label label9;
    }
}