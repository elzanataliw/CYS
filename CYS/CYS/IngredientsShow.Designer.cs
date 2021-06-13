
namespace CYS
{
    partial class IngredientsShow
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
            this.lstViewBahan = new System.Windows.Forms.ListView();
            this.NameCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.descCol = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btHome = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 24.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(284, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(315, 57);
            this.label1.TabIndex = 3;
            this.label1.Text = "INGREDIENTS";
            // 
            // lstViewBahan
            // 
            this.lstViewBahan.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameCol,
            this.descCol});
            this.lstViewBahan.HideSelection = false;
            this.lstViewBahan.Location = new System.Drawing.Point(76, 95);
            this.lstViewBahan.Name = "lstViewBahan";
            this.lstViewBahan.Size = new System.Drawing.Size(766, 384);
            this.lstViewBahan.TabIndex = 4;
            this.lstViewBahan.UseCompatibleStateImageBehavior = false;
            this.lstViewBahan.View = System.Windows.Forms.View.Details;
            // 
            // NameCol
            // 
            this.NameCol.Text = "Nama Bahan";
            this.NameCol.Width = 163;
            // 
            // descCol
            // 
            this.descCol.Text = "Deskripsi";
            this.descCol.Width = 300;
            // 
            // btHome
            // 
            this.btHome.BackColor = System.Drawing.SystemColors.Info;
            this.btHome.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btHome.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.btHome.Location = new System.Drawing.Point(775, 494);
            this.btHome.Name = "btHome";
            this.btHome.Size = new System.Drawing.Size(92, 37);
            this.btHome.TabIndex = 6;
            this.btHome.Text = "Home";
            this.btHome.UseVisualStyleBackColor = false;
            this.btHome.Click += new System.EventHandler(this.btHome_Click);
            // 
            // IngredientsShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::CYS.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(912, 567);
            this.Controls.Add(this.btHome);
            this.Controls.Add(this.lstViewBahan);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "IngredientsShow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IngredientsShow";
            this.Load += new System.EventHandler(this.IngredientsShow_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lstViewBahan;
        private System.Windows.Forms.ColumnHeader NameCol;
        private System.Windows.Forms.ColumnHeader descCol;
        private System.Windows.Forms.Button btHome;
    }
}