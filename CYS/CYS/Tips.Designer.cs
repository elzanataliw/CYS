﻿
namespace CYS
{
    partial class Tips
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
            this.btNormal = new System.Windows.Forms.Button();
            this.btDry = new System.Windows.Forms.Button();
            this.btOily = new System.Windows.Forms.Button();
            this.btCombi = new System.Windows.Forms.Button();
            this.btSensi = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "CYS";
            // 
            // btNormal
            // 
            this.btNormal.BackColor = System.Drawing.SystemColors.Info;
            this.btNormal.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNormal.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btNormal.Location = new System.Drawing.Point(55, 148);
            this.btNormal.Margin = new System.Windows.Forms.Padding(2);
            this.btNormal.Name = "btNormal";
            this.btNormal.Size = new System.Drawing.Size(128, 33);
            this.btNormal.TabIndex = 4;
            this.btNormal.Text = "Normal Skin";
            this.btNormal.UseVisualStyleBackColor = false;
            this.btNormal.Click += new System.EventHandler(this.btNormal_Click);
            // 
            // btDry
            // 
            this.btDry.BackColor = System.Drawing.SystemColors.Info;
            this.btDry.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btDry.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btDry.Location = new System.Drawing.Point(55, 202);
            this.btDry.Margin = new System.Windows.Forms.Padding(2);
            this.btDry.Name = "btDry";
            this.btDry.Size = new System.Drawing.Size(128, 33);
            this.btDry.TabIndex = 5;
            this.btDry.Text = "Dry Skin";
            this.btDry.UseVisualStyleBackColor = false;
            this.btDry.Click += new System.EventHandler(this.btDry_Click);
            // 
            // btOily
            // 
            this.btOily.BackColor = System.Drawing.SystemColors.Info;
            this.btOily.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btOily.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btOily.Location = new System.Drawing.Point(55, 255);
            this.btOily.Margin = new System.Windows.Forms.Padding(2);
            this.btOily.Name = "btOily";
            this.btOily.Size = new System.Drawing.Size(128, 33);
            this.btOily.TabIndex = 6;
            this.btOily.Text = "Oily Skin";
            this.btOily.UseVisualStyleBackColor = false;
            this.btOily.Click += new System.EventHandler(this.btOily_Click);
            // 
            // btCombi
            // 
            this.btCombi.BackColor = System.Drawing.SystemColors.Info;
            this.btCombi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btCombi.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btCombi.Location = new System.Drawing.Point(55, 308);
            this.btCombi.Margin = new System.Windows.Forms.Padding(2);
            this.btCombi.Name = "btCombi";
            this.btCombi.Size = new System.Drawing.Size(128, 33);
            this.btCombi.TabIndex = 7;
            this.btCombi.Text = "Combination Skin";
            this.btCombi.UseVisualStyleBackColor = false;
            this.btCombi.Click += new System.EventHandler(this.btCombi_Click);
            // 
            // btSensi
            // 
            this.btSensi.BackColor = System.Drawing.SystemColors.Info;
            this.btSensi.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSensi.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btSensi.Location = new System.Drawing.Point(55, 357);
            this.btSensi.Margin = new System.Windows.Forms.Padding(2);
            this.btSensi.Name = "btSensi";
            this.btSensi.Size = new System.Drawing.Size(128, 33);
            this.btSensi.TabIndex = 8;
            this.btSensi.Text = "Sensitive Skin";
            this.btSensi.UseVisualStyleBackColor = false;
            this.btSensi.Click += new System.EventHandler(this.btSensi_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(261, 159);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "skin";
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btHome.ForeColor = System.Drawing.SystemColors.Info;
            this.btHome.Location = new System.Drawing.Point(581, 401);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(69, 30);
            this.btHome.TabIndex = 10;
            this.btHome.Text = "home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // Tips
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(684, 461);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSensi);
            this.Controls.Add(this.btCombi);
            this.Controls.Add(this.btOily);
            this.Controls.Add(this.btDry);
            this.Controls.Add(this.btNormal);
            this.Controls.Add(this.label1);
            this.Name = "Tips";
            this.Text = "Tips";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btNormal;
        private System.Windows.Forms.Button btDry;
        private System.Windows.Forms.Button btOily;
        private System.Windows.Forms.Button btCombi;
        private System.Windows.Forms.Button btSensi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btHome;
    }
}