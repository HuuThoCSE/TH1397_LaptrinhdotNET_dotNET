namespace BaiOn3
{
    partial class FrmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnManageSinhVien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnManageSuKien = new System.Windows.Forms.ToolStripMenuItem();
            this.mnManageLop = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnManageSinhVien,
            this.mnManageSuKien,
            this.mnManageLop});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnManageSinhVien
            // 
            this.mnManageSinhVien.Name = "mnManageSinhVien";
            this.mnManageSinhVien.Size = new System.Drawing.Size(138, 26);
            this.mnManageSinhVien.Text = "Manage SinhVien";
            this.mnManageSinhVien.Click += new System.EventHandler(this.mnManageSinhVien_Click);
            // 
            // mnManageSuKien
            // 
            this.mnManageSuKien.Name = "mnManageSuKien";
            this.mnManageSuKien.Size = new System.Drawing.Size(126, 24);
            this.mnManageSuKien.Text = "Manage SuKien";
            this.mnManageSuKien.Click += new System.EventHandler(this.mnManageSuKien_Click);
            // 
            // mnManageLop
            // 
            this.mnManageLop.Name = "mnManageLop";
            this.mnManageLop.Size = new System.Drawing.Size(106, 24);
            this.mnManageLop.Text = "Manage Lop";
            this.mnManageLop.Click += new System.EventHandler(this.mnManageLop_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "TynoClass";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnManageSinhVien;
        private System.Windows.Forms.ToolStripMenuItem mnManageSuKien;
        private System.Windows.Forms.ToolStripMenuItem mnManageLop;
    }
}

