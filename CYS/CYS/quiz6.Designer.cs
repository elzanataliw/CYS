namespace CYS
{
    partial class quiz6
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
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.SystemColors.Info;
            this.btn1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn1.Location = new System.Drawing.Point(205, 340);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(158, 82);
            this.btn1.TabIndex = 9;
            this.btn1.Text = "8 -10pm";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.lblQuestion.Location = new System.Drawing.Point(64, 227);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(795, 46);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "what time do you usually go to sleep each night?";
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
            this.btn2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn2.Location = new System.Drawing.Point(377, 340);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(158, 82);
            this.btn2.TabIndex = 9;
            this.btn2.Text = "10pm -12am ";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Info;
            this.btn3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.btn3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btn3.Location = new System.Drawing.Point(549, 340);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(158, 82);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "after 12pm";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // quiz6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background12;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "quiz6";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "quiz6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}