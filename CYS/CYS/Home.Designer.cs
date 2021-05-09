namespace CYS
{
    partial class Home
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
            this.btSignin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.label1.Location = new System.Drawing.Point(269, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLEAR YOUR SKIN";
            // 
            // btSignin
            // 
            this.btSignin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignin.Location = new System.Drawing.Point(749, 28);
            this.btSignin.Name = "btSignin";
            this.btSignin.Size = new System.Drawing.Size(98, 32);
            this.btSignin.TabIndex = 1;
            this.btSignin.Text = "sign in";
            this.btSignin.UseVisualStyleBackColor = true;
            this.btSignin.Click += new System.EventHandler(this.btSignin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(38, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Helloo..";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSignin);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "CYS";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSignin;
        private System.Windows.Forms.Label label2;
    }
}

