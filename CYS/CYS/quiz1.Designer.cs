
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
            this.label1.Location = new System.Drawing.Point(327, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 1;
            this.label1.Text = "SKIN QUIZ";
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(0)))), ((int)(((byte)(150)))));
            this.lblQuestion.Location = new System.Drawing.Point(137, 227);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(640, 46);
            this.lblQuestion.TabIndex = 1;
            this.lblQuestion.Text = "Mau nanya nih, kamu cowo atau cewe?";
            // 
            // btnCewe
            // 
            this.btnCewe.BackColor = System.Drawing.SystemColors.Info;
            this.btnCewe.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCewe.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCewe.Location = new System.Drawing.Point(524, 322);
            this.btnCewe.Name = "btnCewe";
            this.btnCewe.Size = new System.Drawing.Size(200, 85);
            this.btnCewe.TabIndex = 2;
            this.btnCewe.Text = "Cewe";
            this.btnCewe.UseVisualStyleBackColor = false;
            this.btnCewe.Click += new System.EventHandler(this.btnCewe_Click);
            // 
            // btnCowo
            // 
            this.btnCowo.BackColor = System.Drawing.SystemColors.Info;
            this.btnCowo.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.btnCowo.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btnCowo.Location = new System.Drawing.Point(202, 322);
            this.btnCowo.Name = "btnCowo";
            this.btnCowo.Size = new System.Drawing.Size(200, 85);
            this.btnCowo.TabIndex = 2;
            this.btnCowo.Text = "Cowo";
            this.btnCowo.UseVisualStyleBackColor = true;
            this.btnCowo.Click += new System.EventHandler(this.btnCowo_Click);
            // 
            // quiz1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btnCowo);
            this.Controls.Add(this.btnCewe);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "quiz1";
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