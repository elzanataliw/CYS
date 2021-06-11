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
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbKering = new System.Windows.Forms.RadioButton();
            this.rbOily = new System.Windows.Forms.RadioButton();
            this.rbSensitif = new System.Windows.Forms.RadioButton();
            this.rbMix = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblWarning = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoEllipsis = true;
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(3, 18);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(1280, 46);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Sekarang pilih kondisi kulit yang menurut kamu paling mencerminkan kulitmu";
            this.lblQuestion.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(314, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "SKIN QUIZ";
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Location = new System.Drawing.Point(80, 320);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(74, 21);
            this.rbNormal.TabIndex = 9;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "Normal";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbKering
            // 
            this.rbKering.AutoSize = true;
            this.rbKering.Location = new System.Drawing.Point(336, 320);
            this.rbKering.Name = "rbKering";
            this.rbKering.Size = new System.Drawing.Size(70, 21);
            this.rbKering.TabIndex = 9;
            this.rbKering.TabStop = true;
            this.rbKering.Text = "Kering";
            this.rbKering.UseVisualStyleBackColor = true;
            // 
            // rbOily
            // 
            this.rbOily.AutoSize = true;
            this.rbOily.Location = new System.Drawing.Point(626, 320);
            this.rbOily.Name = "rbOily";
            this.rbOily.Size = new System.Drawing.Size(95, 21);
            this.rbOily.TabIndex = 9;
            this.rbOily.TabStop = true;
            this.rbOily.Text = "Berminyak";
            this.rbOily.UseVisualStyleBackColor = true;
            // 
            // rbSensitif
            // 
            this.rbSensitif.AutoSize = true;
            this.rbSensitif.Location = new System.Drawing.Point(524, 403);
            this.rbSensitif.Name = "rbSensitif";
            this.rbSensitif.Size = new System.Drawing.Size(75, 21);
            this.rbSensitif.TabIndex = 9;
            this.rbSensitif.TabStop = true;
            this.rbSensitif.Text = "Sensitif";
            this.rbSensitif.UseVisualStyleBackColor = true;
            // 
            // rbMix
            // 
            this.rbMix.AutoSize = true;
            this.rbMix.Location = new System.Drawing.Point(238, 403);
            this.rbMix.Name = "rbMix";
            this.rbMix.Size = new System.Drawing.Size(94, 21);
            this.rbMix.TabIndex = 9;
            this.rbMix.TabStop = true;
            this.rbMix.Text = "Campuran";
            this.rbMix.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblQuestion);
            this.groupBox1.Location = new System.Drawing.Point(80, 87);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(697, 121);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            // 
            // lblWarning
            // 
            this.lblWarning.AutoSize = true;
            this.lblWarning.ForeColor = System.Drawing.Color.Red;
            this.lblWarning.Location = new System.Drawing.Point(88, 232);
            this.lblWarning.Name = "lblWarning";
            this.lblWarning.Size = new System.Drawing.Size(102, 17);
            this.lblWarning.TabIndex = 11;
            this.lblWarning.Text = "warning pilihan";
            // 
            // quiz2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 509);
            this.Controls.Add(this.lblWarning);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.rbMix);
            this.Controls.Add(this.rbSensitif);
            this.Controls.Add(this.rbOily);
            this.Controls.Add(this.rbKering);
            this.Controls.Add(this.rbNormal);
            this.Controls.Add(this.label1);
            this.Name = "quiz2";
            this.Text = "quiz2";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbKering;
        private System.Windows.Forms.RadioButton rbOily;
        private System.Windows.Forms.RadioButton rbSensitif;
        private System.Windows.Forms.RadioButton rbMix;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblWarning;
    }
}