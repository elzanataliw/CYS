﻿namespace CYS
{
    partial class quiz3
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbLembab = new System.Windows.Forms.CheckBox();
            this.cbJerawat = new System.Windows.Forms.CheckBox();
            this.cbAging = new System.Windows.Forms.CheckBox();
            this.cbDaily = new System.Windows.Forms.CheckBox();
            this.cbColourBalance = new System.Windows.Forms.CheckBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(160, 134);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(505, 46);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Kondisi kulit yang diinginkan?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "SKIN QUIZ";
            // 
            // cbLembab
            // 
            this.cbLembab.AutoSize = true;
            this.cbLembab.Location = new System.Drawing.Point(80, 286);
            this.cbLembab.Name = "cbLembab";
            this.cbLembab.Size = new System.Drawing.Size(81, 21);
            this.cbLembab.TabIndex = 5;
            this.cbLembab.Text = "Lembab";
            this.cbLembab.UseVisualStyleBackColor = true;
            // 
            // cbJerawat
            // 
            this.cbJerawat.AutoSize = true;
            this.cbJerawat.Location = new System.Drawing.Point(323, 286);
            this.cbJerawat.Name = "cbJerawat";
            this.cbJerawat.Size = new System.Drawing.Size(154, 21);
            this.cbJerawat.TabIndex = 5;
            this.cbJerawat.Text = "Mengurangi jerawat";
            this.cbJerawat.UseVisualStyleBackColor = true;
            // 
            // cbAging
            // 
            this.cbAging.AutoSize = true;
            this.cbAging.Location = new System.Drawing.Point(612, 286);
            this.cbAging.Name = "cbAging";
            this.cbAging.Size = new System.Drawing.Size(205, 21);
            this.cbAging.TabIndex = 5;
            this.cbAging.Text = "Mengurangi tanda penuaan";
            this.cbAging.UseVisualStyleBackColor = true;
            // 
            // cbDaily
            // 
            this.cbDaily.AutoSize = true;
            this.cbDaily.Location = new System.Drawing.Point(464, 390);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(173, 21);
            this.cbDaily.TabIndex = 5;
            this.cbDaily.Text = "Perawatan rutin harian";
            this.cbDaily.UseVisualStyleBackColor = true;
            // 
            // cbColourBalance
            // 
            this.cbColourBalance.AutoSize = true;
            this.cbColourBalance.Location = new System.Drawing.Point(223, 390);
            this.cbColourBalance.Name = "cbColourBalance";
            this.cbColourBalance.Size = new System.Drawing.Size(149, 21);
            this.cbColourBalance.TabIndex = 5;
            this.cbColourBalance.Text = "Warna kulit merata";
            this.cbColourBalance.UseVisualStyleBackColor = true;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(333, 210);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(102, 17);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "warning pilihan";
            // 
            // quiz3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 506);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.cbColourBalance);
            this.Controls.Add(this.cbDaily);
            this.Controls.Add(this.cbAging);
            this.Controls.Add(this.cbJerawat);
            this.Controls.Add(this.cbLembab);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Name = "quiz3";
            this.Text = "quiz3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbLembab;
        private System.Windows.Forms.CheckBox cbJerawat;
        private System.Windows.Forms.CheckBox cbAging;
        private System.Windows.Forms.CheckBox cbDaily;
        private System.Windows.Forms.CheckBox cbColourBalance;
        private System.Windows.Forms.Label lblWarning;
    }
}