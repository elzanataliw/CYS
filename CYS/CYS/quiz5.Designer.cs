namespace CYS
{
    partial class quiz5
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
            this.btn1 = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(228, 310);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(150, 62);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "<1 jam";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.lblQuestion.Location = new System.Drawing.Point(135, 224);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(653, 46);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Berapa lama kamu kena sinar matahari?";
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
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.SystemColors.Info;
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Location = new System.Drawing.Point(384, 310);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(150, 62);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "1-3 Jam";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Info;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Location = new System.Drawing.Point(540, 310);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(150, 62);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "4-6 Jam";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Info;
            this.btn4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn4.Location = new System.Drawing.Point(302, 378);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(150, 62);
            this.btn4.TabIndex = 9;
            this.btn4.Text = "7-8 Jam";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.Info;
            this.btn5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn5.Location = new System.Drawing.Point(458, 378);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(150, 62);
            this.btn5.TabIndex = 9;
            this.btn5.Text = ">8 Jam";
            this.btn5.UseVisualStyleBackColor = false;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // quiz5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quiz5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quiz5";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
    }
}