
namespace CYS
{
    partial class quiz1
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
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnCewe = new System.Windows.Forms.Button();
            this.btnCowo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(321, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "SKIN QUIZ";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(138, 150);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(578, 46);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Tanya dong, Kamu cowo apa cewe?";
            // 
            // btnCewe
            // 
            this.btnCewe.Location = new System.Drawing.Point(473, 302);
            this.btnCewe.Name = "btnCewe";
            this.btnCewe.Size = new System.Drawing.Size(243, 104);
            this.btnCewe.TabIndex = 2;
            this.btnCewe.Text = "Cewe";
            this.btnCewe.UseVisualStyleBackColor = true;
            // 
            // btnCowo
            // 
            this.btnCowo.Location = new System.Drawing.Point(129, 302);
            this.btnCowo.Name = "btnCowo";
            this.btnCowo.Size = new System.Drawing.Size(243, 104);
            this.btnCowo.TabIndex = 2;
            this.btnCowo.Text = "Cowo";
            this.btnCowo.UseVisualStyleBackColor = true;
            // 
            // Skinquiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 553);
            this.Controls.Add(this.btnCowo);
            this.Controls.Add(this.btnCewe);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Skinquiz";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Skin Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnCewe;
        private System.Windows.Forms.Button btnCowo;
    }
}