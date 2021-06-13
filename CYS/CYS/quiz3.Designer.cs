namespace CYS
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
            this.btnNext = new System.Windows.Forms.Button();
            this.panelCB = new System.Windows.Forms.Panel();
            this.panelCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.lblQuestion.Location = new System.Drawing.Point(202, 195);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(596, 46);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "Pilih 2 kondisi kulit yang diinginkan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 4;
            this.label1.Text = "SKIN QUIZ";
            // 
            // cbLembab
            // 
            this.cbLembab.AutoSize = true;
            this.cbLembab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.cbLembab.Location = new System.Drawing.Point(94, 332);
            this.cbLembab.Name = "cbLembab";
            this.cbLembab.Size = new System.Drawing.Size(81, 21);
            this.cbLembab.TabIndex = 5;
            this.cbLembab.Text = "Lembab";
            this.cbLembab.UseVisualStyleBackColor = true;
            this.cbLembab.CheckedChanged += new System.EventHandler(this.cbLembab_CheckedChanged);
            // 
            // cbJerawat
            // 
            this.cbJerawat.AutoSize = true;
            this.cbJerawat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.cbJerawat.Location = new System.Drawing.Point(337, 332);
            this.cbJerawat.Name = "cbJerawat";
            this.cbJerawat.Size = new System.Drawing.Size(154, 21);
            this.cbJerawat.TabIndex = 5;
            this.cbJerawat.Text = "Mengurangi jerawat";
            this.cbJerawat.UseVisualStyleBackColor = true;
            this.cbJerawat.CheckedChanged += new System.EventHandler(this.cbJerawat_CheckedChanged);
            // 
            // cbAging
            // 
            this.cbAging.AutoSize = true;
            this.cbAging.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.cbAging.Location = new System.Drawing.Point(626, 332);
            this.cbAging.Name = "cbAging";
            this.cbAging.Size = new System.Drawing.Size(205, 21);
            this.cbAging.TabIndex = 5;
            this.cbAging.Text = "Mengurangi tanda penuaan";
            this.cbAging.UseVisualStyleBackColor = true;
            this.cbAging.CheckedChanged += new System.EventHandler(this.cbAging_CheckedChanged);
            // 
            // cbDaily
            // 
            this.cbDaily.AutoSize = true;
            this.cbDaily.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.cbDaily.Location = new System.Drawing.Point(474, 409);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(173, 21);
            this.cbDaily.TabIndex = 5;
            this.cbDaily.Text = "Perawatan rutin harian";
            this.cbDaily.UseVisualStyleBackColor = true;
            this.cbDaily.CheckedChanged += new System.EventHandler(this.cbDaily_CheckedChanged);
            // 
            // cbColourBalance
            // 
            this.cbColourBalance.AutoSize = true;
            this.cbColourBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.cbColourBalance.Location = new System.Drawing.Point(233, 409);
            this.cbColourBalance.Name = "cbColourBalance";
            this.cbColourBalance.Size = new System.Drawing.Size(149, 21);
            this.cbColourBalance.TabIndex = 5;
            this.cbColourBalance.Text = "Warna kulit merata";
            this.cbColourBalance.UseVisualStyleBackColor = true;
            this.cbColourBalance.CheckedChanged += new System.EventHandler(this.cbColourBalance_CheckedChanged);
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(408, 245);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(213, 17);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "Pilihan Tidak Boleh Lebih Dari 2!";
            this.lblWarning.Visible = false;
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(225)))), ((int)(((byte)(80)))));
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btnNext.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnNext.Location = new System.Drawing.Point(794, 492);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(82, 40);
            this.btnNext.TabIndex = 13;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelCB
            // 
            this.panelCB.Controls.Add(this.cbLembab);
            this.panelCB.Controls.Add(this.cbJerawat);
            this.panelCB.Controls.Add(this.cbColourBalance);
            this.panelCB.Controls.Add(this.cbDaily);
            this.panelCB.Controls.Add(this.cbAging);
            this.panelCB.Location = new System.Drawing.Point(147, 298);
            this.panelCB.Name = "panelCB";
            this.panelCB.Size = new System.Drawing.Size(554, 100);
            this.panelCB.TabIndex = 14;
            // 
            // quiz3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quiz3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quiz3";
            this.panelCB.ResumeLayout(false);
            this.panelCB.PerformLayout();
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
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelCB;
    }
}