
namespace CYS
{
    partial class Login
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
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btSignin = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.btHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(145, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "hi, welcome back!";
            // 
            // tbUsername
            // 
            this.tbUsername.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsername.Location = new System.Drawing.Point(180, 158);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(212, 34);
            this.tbUsername.TabIndex = 1;
            this.tbUsername.Text = "username";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPassword.Location = new System.Drawing.Point(180, 210);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(212, 34);
            this.tbPassword.TabIndex = 2;
            this.tbPassword.Text = "username";
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // btSignin
            // 
            this.btSignin.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btSignin.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSignin.ForeColor = System.Drawing.SystemColors.Info;
            this.btSignin.Location = new System.Drawing.Point(239, 260);
            this.btSignin.Name = "btSignin";
            this.btSignin.Size = new System.Drawing.Size(98, 32);
            this.btSignin.TabIndex = 3;
            this.btSignin.Text = "sign in";
            this.btSignin.UseVisualStyleBackColor = false;
            this.btSignin.Click += new System.EventHandler(this.btSignin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.label2.Location = new System.Drawing.Point(162, 340);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 23);
            this.label2.TabIndex = 0;
            this.label2.Text = "dont have any account?";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.linkLabel1.Location = new System.Drawing.Point(320, 340);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 23);
            this.linkLabel1.TabIndex = 5;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "sign up here";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btHome.ForeColor = System.Drawing.SystemColors.Info;
            this.btHome.Location = new System.Drawing.Point(480, 350);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(69, 30);
            this.btHome.TabIndex = 5;
            this.btHome.Text = "home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // Login
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(584, 411);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSignin);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.tbUsername);
            this.Controls.Add(this.label1);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btSignin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button btHome;
    }
}