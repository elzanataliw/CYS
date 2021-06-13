namespace CYS
{
    partial class Result
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
            this.btnSelanjutnya = new System.Windows.Forms.Button();
            this.lblQuestion = new System.Windows.Forms.Label();
            this.btnSebelumnya = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblDesc = new System.Windows.Forms.Label();
            this.btnHome = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelanjutnya
            // 
            this.btnSelanjutnya.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSelanjutnya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSelanjutnya.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSelanjutnya.Location = new System.Drawing.Point(603, 431);
            this.btnSelanjutnya.Name = "btnSelanjutnya";
            this.btnSelanjutnya.Size = new System.Drawing.Size(158, 69);
            this.btnSelanjutnya.TabIndex = 14;
            this.btnSelanjutnya.Text = "next";
            this.btnSelanjutnya.UseVisualStyleBackColor = false;
            this.btnSelanjutnya.Click += new System.EventHandler(this.btnSelanjutnya_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(170)))), ((int)(((byte)(200)))));
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(292, 78);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(327, 51);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "HASIL SKIN QUIZ";
            // 
            // btnSebelumnya
            // 
            this.btnSebelumnya.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnSebelumnya.Enabled = false;
            this.btnSebelumnya.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSebelumnya.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSebelumnya.Location = new System.Drawing.Point(139, 431);
            this.btnSebelumnya.Name = "btnSebelumnya";
            this.btnSebelumnya.Size = new System.Drawing.Size(158, 69);
            this.btnSebelumnya.TabIndex = 13;
            this.btnSebelumnya.Text = "back";
            this.btnSebelumnya.UseVisualStyleBackColor = false;
            this.btnSebelumnya.Click += new System.EventHandler(this.btnSebelumnya_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.HotTrack;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.SystemColors.Info;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(622, 46);
            this.lblName.TabIndex = 11;
            this.lblName.Text = "Nama Bahan";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblDesc
            // 
            this.lblDesc.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblDesc.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.lblDesc.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblDesc.Location = new System.Drawing.Point(0, 46);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(622, 158);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Maaf tidak ada bahan yang cocok untuk jenis kulit/keinginan mu di database kami.";
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(150)))));
            this.btnHome.Location = new System.Drawing.Point(406, 486);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(114, 49);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Location = new System.Drawing.Point(139, 170);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 204);
            this.panel1.TabIndex = 15;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYS.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSebelumnya);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSelanjutnya);
            this.Controls.Add(this.lblQuestion);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Result";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.Load += new System.EventHandler(this.Result_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelanjutnya;
        private System.Windows.Forms.Label lblQuestion;
        private System.Windows.Forms.Button btnSebelumnya;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
    }
}