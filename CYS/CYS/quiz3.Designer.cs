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
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelCB = new System.Windows.Forms.Panel();
            this.cbDaily = new System.Windows.Forms.CheckBox();
            this.cbToneBalace = new System.Windows.Forms.CheckBox();
            this.cbAntiAging = new System.Windows.Forms.CheckBox();
            this.cbNoAcne = new System.Windows.Forms.CheckBox();
            this.cbLembab = new System.Windows.Forms.CheckBox();
            this.panelCB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.lblQuestion.Location = new System.Drawing.Point(239, 215);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(423, 46);
            this.lblQuestion.TabIndex = 3;
            this.lblQuestion.Text = "what are your skin goals?";
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
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(374, 261);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(155, 17);
            this.lblWarning.TabIndex = 12;
            this.lblWarning.Text = "Select up to 2 answers.";
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
            this.btnNext.Text = "next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelCB
            // 
            this.panelCB.Controls.Add(this.cbDaily);
            this.panelCB.Controls.Add(this.cbToneBalace);
            this.panelCB.Controls.Add(this.cbAntiAging);
            this.panelCB.Controls.Add(this.cbNoAcne);
            this.panelCB.Controls.Add(this.cbLembab);
            this.panelCB.Location = new System.Drawing.Point(167, 332);
            this.panelCB.Name = "panelCB";
            this.panelCB.Size = new System.Drawing.Size(584, 123);
            this.panelCB.TabIndex = 14;
            // 
            // cbDaily
            // 
            this.cbDaily.AutoSize = true;
            this.cbDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbDaily.Location = new System.Drawing.Point(320, 76);
            this.cbDaily.Name = "cbDaily";
            this.cbDaily.Size = new System.Drawing.Size(117, 28);
            this.cbDaily.TabIndex = 0;
            this.cbDaily.Text = "Daily Care";
            this.cbDaily.UseVisualStyleBackColor = true;
            this.cbDaily.CheckedChanged += new System.EventHandler(this.cbDaily_CheckedChanged);
            // 
            // cbToneBalace
            // 
            this.cbToneBalace.AutoSize = true;
            this.cbToneBalace.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbToneBalace.Location = new System.Drawing.Point(128, 76);
            this.cbToneBalace.Name = "cbToneBalace";
            this.cbToneBalace.Size = new System.Drawing.Size(150, 28);
            this.cbToneBalace.TabIndex = 0;
            this.cbToneBalace.Text = "Tone Balance";
            this.cbToneBalace.UseVisualStyleBackColor = true;
            this.cbToneBalace.CheckedChanged += new System.EventHandler(this.cbToneBalace_CheckedChanged);
            // 
            // cbAntiAging
            // 
            this.cbAntiAging.AutoSize = true;
            this.cbAntiAging.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbAntiAging.Location = new System.Drawing.Point(407, 18);
            this.cbAntiAging.Name = "cbAntiAging";
            this.cbAntiAging.Size = new System.Drawing.Size(120, 28);
            this.cbAntiAging.TabIndex = 0;
            this.cbAntiAging.Text = "Anti-Aging";
            this.cbAntiAging.UseVisualStyleBackColor = true;
            this.cbAntiAging.CheckedChanged += new System.EventHandler(this.cbAntiAging_CheckedChanged);
            // 
            // cbNoAcne
            // 
            this.cbNoAcne.AutoSize = true;
            this.cbNoAcne.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbNoAcne.Location = new System.Drawing.Point(221, 18);
            this.cbNoAcne.Name = "cbNoAcne";
            this.cbNoAcne.Size = new System.Drawing.Size(155, 28);
            this.cbNoAcne.TabIndex = 0;
            this.cbNoAcne.Text = "Clear of Acnes";
            this.cbNoAcne.UseVisualStyleBackColor = true;
            this.cbNoAcne.CheckedChanged += new System.EventHandler(this.cbNoAcne_CheckedChanged);
            // 
            // cbLembab
            // 
            this.cbLembab.AutoSize = true;
            this.cbLembab.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            this.cbLembab.Location = new System.Drawing.Point(43, 18);
            this.cbLembab.Name = "cbLembab";
            this.cbLembab.Size = new System.Drawing.Size(164, 28);
            this.cbLembab.TabIndex = 0;
            this.cbLembab.Text = "Boost Hydrating";
            this.cbLembab.UseVisualStyleBackColor = true;
            this.cbLembab.CheckedChanged += new System.EventHandler(this.cbLembab_CheckedChanged_1);
            // 
            // quiz3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background12;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.panelCB);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
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
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelCB;
        private System.Windows.Forms.CheckBox cbDaily;
        private System.Windows.Forms.CheckBox cbToneBalace;
        private System.Windows.Forms.CheckBox cbAntiAging;
        private System.Windows.Forms.CheckBox cbNoAcne;
        private System.Windows.Forms.CheckBox cbLembab;
    }
}