﻿namespace YaoSearch
{
    partial class FormLoading
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
            this.pbxLoading = new System.Windows.Forms.PictureBox();
            this.lbtip = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbxLoading
            // 
            this.pbxLoading.Image = global::YaoSearch.Properties.Resources.loading1;
            this.pbxLoading.Location = new System.Drawing.Point(0, -2);
            this.pbxLoading.Name = "pbxLoading";
            this.pbxLoading.Size = new System.Drawing.Size(172, 172);
            this.pbxLoading.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLoading.TabIndex = 0;
            this.pbxLoading.TabStop = false;
            // 
            // lbtip
            // 
            this.lbtip.AutoSize = true;
            this.lbtip.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lbtip.ForeColor = System.Drawing.Color.Navy;
            this.lbtip.Location = new System.Drawing.Point(220, 64);
            this.lbtip.Name = "lbtip";
            this.lbtip.Size = new System.Drawing.Size(90, 21);
            this.lbtip.TabIndex = 1;
            this.lbtip.Text = "当前操作：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pbxLoading);
            this.panel1.Controls.Add(this.lbtip);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(697, 172);
            this.panel1.TabIndex = 2;
            // 
            // FormLoading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(697, 172);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLoading";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormLoading";
            ((System.ComponentModel.ISupportInitialize)(this.pbxLoading)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxLoading;
        private System.Windows.Forms.Label lbtip;
        private System.Windows.Forms.Panel panel1;

    }
}