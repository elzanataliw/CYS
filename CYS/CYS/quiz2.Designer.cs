namespace CYS
{
    partial class quiz2
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.btnNext = new System.Windows.Forms.Button();
            this.panelRB = new System.Windows.Forms.Panel();
            this.rbOily = new System.Windows.Forms.RadioButton();
            this.rbSensitive = new System.Windows.Forms.RadioButton();
            this.rbDry = new System.Windows.Forms.RadioButton();
            this.rbMixed = new System.Windows.Forms.RadioButton();
            this.rbNorm = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.panelRB.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoEllipsis = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.lblQuestion.Location = new System.Drawing.Point(3, 18);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(691, 100);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Sekarang pilih kondisi kulit yang menurut kamu paling mencerminkan kulitmu";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(327, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "SKIN QUIZ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.groupBox1.Location = new System.Drawing.Point(107, 165);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(401, 289);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(102, 17);
            this.lblWarning.TabIndex = 11;
            this.lblWarning.Text = "warning pilihan";
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
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // panelRB
            // 
            this.panelRB.Controls.Add(this.rbNorm);
            this.panelRB.Controls.Add(this.rbMixed);
            this.panelRB.Controls.Add(this.rbDry);
            this.panelRB.Controls.Add(this.rbSensitive);
            this.panelRB.Controls.Add(this.rbOily);
            this.panelRB.Location = new System.Drawing.Point(107, 359);
            this.panelRB.Name = "panelRB";
            this.panelRB.Size = new System.Drawing.Size(697, 100);
            this.panelRB.TabIndex = 15;
            // 
            // rbOily
            // 
            this.rbOily.AutoSize = true;
            this.rbOily.Location = new System.Drawing.Point(71, 22);
            this.rbOily.Name = "rbOily";
            this.rbOily.Size = new System.Drawing.Size(53, 21);
            this.rbOily.TabIndex = 0;
            this.rbOily.TabStop = true;
            this.rbOily.Text = "Oily";
            this.rbOily.UseVisualStyleBackColor = true;
            // 
            // rbSensitive
            // 
            this.rbSensitive.AutoSize = true;
            this.rbSensitive.Location = new System.Drawing.Point(250, 22);
            this.rbSensitive.Name = "rbSensitive";
            this.rbSensitive.Size = new System.Drawing.Size(86, 21);
            this.rbSensitive.TabIndex = 0;
            this.rbSensitive.TabStop = true;
            this.rbSensitive.Text = "Sensitive";
            this.rbSensitive.UseVisualStyleBackColor = true;
            // 
            // rbDry
            // 
            this.rbDry.AutoSize = true;
            this.rbDry.Location = new System.Drawing.Point(463, 22);
            this.rbDry.Name = "rbDry";
            this.rbDry.Size = new System.Drawing.Size(51, 21);
            this.rbDry.TabIndex = 0;
            this.rbDry.TabStop = true;
            this.rbDry.Text = "Dry";
            this.rbDry.UseVisualStyleBackColor = true;
            // 
            // rbMixed
            // 
            this.rbMixed.AutoSize = true;
            this.rbMixed.Location = new System.Drawing.Point(150, 67);
            this.rbMixed.Name = "rbMixed";
            this.rbMixed.Size = new System.Drawing.Size(65, 21);
            this.rbMixed.TabIndex = 0;
            this.rbMixed.TabStop = true;
            this.rbMixed.Text = "Mixed";
            this.rbMixed.UseVisualStyleBackColor = true;
            // 
            // rbNorm
            // 
            this.rbNorm.AutoSize = true;
            this.rbNorm.Location = new System.Drawing.Point(386, 67);
            this.rbNorm.Name = "rbNorm";
            this.rbNorm.Size = new System.Drawing.Size(74, 21);
            this.rbNorm.TabIndex = 0;
            this.rbNorm.TabStop = true;
            this.rbNorm.Text = "Normal";
            this.rbNorm.UseVisualStyleBackColor = true;
            // 
            // quiz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.panelRB);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quiz2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quiz2";
            this.groupBox1.ResumeLayout(false);
            this.panelRB.ResumeLayout(false);
            this.panelRB.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWarning;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panelRB;
        private System.Windows.Forms.RadioButton rbNorm;
        private System.Windows.Forms.RadioButton rbMixed;
        private System.Windows.Forms.RadioButton rbDry;
        private System.Windows.Forms.RadioButton rbSensitive;
        private System.Windows.Forms.RadioButton rbOily;
    }
}