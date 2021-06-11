namespace CYS
{
    partial class quiz4_2
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
            this.btnYa = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYa
            // 
            this.btnYa.Location = new System.Drawing.Point(107, 332);
            this.btnYa.Name = "btnYa";
            this.btnYa.Size = new System.Drawing.Size(243, 104);
            this.btnYa.TabIndex = 9;
            this.btnYa.Text = "Iya";
            this.btnYa.UseVisualStyleBackColor = true;
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(451, 332);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(243, 104);
            this.btnNo.TabIndex = 10;
            this.btnNo.Text = "Tidak";
            this.btnNo.UseVisualStyleBackColor = true;
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(146, 141);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(504, 46);
            this.lblQuestion.TabIndex = 7;
            this.lblQuestion.Text = "Sedang pakai AHA/BHA/PHA?";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(289, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 8;
            this.label1.Text = "SKIN QUIZ";
            // 
            // quiz4_2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnYa);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.Name = "quiz4_2";
            this.Text = "quiz4_2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYa;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Label label1;
    }
}