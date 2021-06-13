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
            this.btTakequiz = new System.Windows.Forms.Button();
            this.btIngredient = new System.Windows.Forms.Button();
            this.btTips = new System.Windows.Forms.Button();
            this.btExit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.Info;
            this.label1.Location = new System.Drawing.Point(145, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(571, 81);
            this.label1.TabIndex = 0;
            this.label1.Text = "CLEAR YOUR SKIN";
            // 
            // btSignin
            // 
            this.btSignin.BackColor = System.Drawing.SystemColors.Info;
            this.btSignin.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btSignin.ForeColor = System.Drawing.SystemColors.Highlight;
            this.btSignin.Location = new System.Drawing.Point(779, 27);
            this.btSignin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btSignin.Name = "btSignin";
            this.btSignin.Size = new System.Drawing.Size(99, 38);
            this.btSignin.TabIndex = 1;
            this.btSignin.Text = "sign in";
            this.btSignin.UseVisualStyleBackColor = false;
            this.btSignin.Click += new System.EventHandler(this.btSignin_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(90)))), ((int)(((byte)(120)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(41, 32);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Helloo..";
            // 
            // btTakequiz
            // 
            this.btTakequiz.BackColor = System.Drawing.SystemColors.Info;
            this.btTakequiz.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btTakequiz.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btTakequiz.Location = new System.Drawing.Point(503, 295);
            this.btTakequiz.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTakequiz.Name = "btTakequiz";
            this.btTakequiz.Size = new System.Drawing.Size(159, 128);
            this.btTakequiz.TabIndex = 2;
            this.btTakequiz.Text = "Take Quiz";
            this.btTakequiz.UseVisualStyleBackColor = false;
            this.btTakequiz.Click += new System.EventHandler(this.btTakequiz_Click);
            // 
            // btIngredient
            // 
            this.btIngredient.BackColor = System.Drawing.SystemColors.Info;
            this.btIngredient.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btIngredient.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btIngredient.Location = new System.Drawing.Point(245, 295);
            this.btIngredient.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btIngredient.Name = "btIngredient";
            this.btIngredient.Size = new System.Drawing.Size(159, 48);
            this.btIngredient.TabIndex = 3;
            this.btIngredient.Text = "Ingredients";
            this.btIngredient.UseVisualStyleBackColor = false;
            this.btIngredient.Click += new System.EventHandler(this.btIngredient_Click);
            // 
            // btTips
            // 
            this.btTips.BackColor = System.Drawing.SystemColors.Info;
            this.btTips.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.btTips.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btTips.Location = new System.Drawing.Point(245, 375);
            this.btTips.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btTips.Name = "btTips";
            this.btTips.Size = new System.Drawing.Size(159, 48);
            this.btTips.TabIndex = 4;
            this.btTips.Text = "Tips";
            this.btTips.UseVisualStyleBackColor = false;
            this.btTips.Click += new System.EventHandler(this.btTips_Click);
            // 
            // btExit
            // 
            this.btExit.BackColor = System.Drawing.SystemColors.Info;
            this.btExit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btExit.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.btExit.Location = new System.Drawing.Point(819, 511);
            this.btExit.Name = "btExit";
            this.btExit.Size = new System.Drawing.Size(59, 33);
            this.btExit.TabIndex = 5;
            this.btExit.Text = "Exit";
            this.btExit.UseVisualStyleBackColor = false;
            this.btExit.Click += new System.EventHandler(this.btExit_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::CYS.Properties.Resources.background1;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btExit);
            this.Controls.Add(this.btTips);
            this.Controls.Add(this.btIngredient);
            this.Controls.Add(this.btTakequiz);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btSignin);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CYS";
            this.Activated += new System.EventHandler(this.Home_Activated);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btSignin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btTakequiz;
        private System.Windows.Forms.Button btIngredient;
        private System.Windows.Forms.Button btTips;
        private System.Windows.Forms.Button btExit;
    }
}

