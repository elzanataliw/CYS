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
            this.label1 = new System.Windows.Forms.Label();
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
            this.btnSelanjutnya.Location = new System.Drawing.Point(550, 390);
            this.btnSelanjutnya.Name = "btnSelanjutnya";
            this.btnSelanjutnya.Size = new System.Drawing.Size(243, 104);
            this.btnSelanjutnya.TabIndex = 14;
            this.btnSelanjutnya.Text = "Selanjutnya";
            this.btnSelanjutnya.UseVisualStyleBackColor = true;
            this.btnSelanjutnya.Click += new System.EventHandler(this.btnSelanjutnya_Click);
            // 
            // lblQuestion
            // 
            this.lblQuestion.AutoSize = true;
            this.lblQuestion.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuestion.Location = new System.Drawing.Point(373, 84);
            this.lblQuestion.Name = "lblQuestion";
            this.lblQuestion.Size = new System.Drawing.Size(99, 46);
            this.lblQuestion.TabIndex = 11;
            this.lblQuestion.Text = "Hasil";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(303, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(245, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "SKIN QUIZ";
            // 
            // btnSebelumnya
            // 
            this.btnSebelumnya.Enabled = false;
            this.btnSebelumnya.Location = new System.Drawing.Point(79, 390);
            this.btnSebelumnya.Name = "btnSebelumnya";
            this.btnSebelumnya.Size = new System.Drawing.Size(243, 104);
            this.btnSebelumnya.TabIndex = 13;
            this.btnSebelumnya.Text = "Sebelumnya";
            this.btnSebelumnya.UseVisualStyleBackColor = true;
            this.btnSebelumnya.Click += new System.EventHandler(this.btnSebelumnya_Click);
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.lblDesc.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDesc.Location = new System.Drawing.Point(0, 46);
            this.lblDesc.Name = "lblDesc";
            this.lblDesc.Size = new System.Drawing.Size(622, 158);
            this.lblDesc.TabIndex = 11;
            this.lblDesc.Text = "Maaf tidak ada bahan yang cocok untuk jenis kulit/keinginan mu di database kami.";
            // 
            // btnHome
            // 
            this.btnHome.Location = new System.Drawing.Point(357, 427);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(153, 67);
            this.btnHome.TabIndex = 14;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.lblName);
            this.panel1.Controls.Add(this.lblDesc);
            this.panel1.Location = new System.Drawing.Point(125, 142);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(622, 204);
            this.panel1.TabIndex = 15;
            // 
            // Result
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::CYS.Properties.Resources.background2;
            this.ClientSize = new System.Drawing.Size(894, 520);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSebelumnya);
            this.Controls.Add(this.btnHome);
            this.Controls.Add(this.btnSelanjutnya);
            this.Controls.Add(this.lblQuestion);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSebelumnya;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel panel1;
    }
}