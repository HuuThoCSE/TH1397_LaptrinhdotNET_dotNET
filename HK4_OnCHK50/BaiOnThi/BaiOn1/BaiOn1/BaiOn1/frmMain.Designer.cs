namespace BaiOn1
{
    partial class frmMain
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
            this.mnuMStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMClasses = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMTeachers = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuMStudents,
            this.mnuMClasses,
            this.mnuMTeachers});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuMStudents
            // 
            this.mnuMStudents.Name = "mnuMStudents";
            this.mnuMStudents.Size = new System.Drawing.Size(111, 20);
            this.mnuMStudents.Text = "Manage Students";
            this.mnuMStudents.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            this.mnuMStudents.Click += new System.EventHandler(this.mnuMStudents_Click);
            // 
            // mnuMClasses
            // 
            this.mnuMClasses.Name = "mnuMClasses";
            this.mnuMClasses.Size = new System.Drawing.Size(103, 20);
            this.mnuMClasses.Text = "Manage Classes";
            this.mnuMClasses.Click += new System.EventHandler(this.mnuMClasses_Click);
            // 
            // mnuMTeachers
            // 
            this.mnuMTeachers.Name = "mnuMTeachers";
            this.mnuMTeachers.Size = new System.Drawing.Size(110, 20);
            this.mnuMTeachers.Text = "Manage Teachers";
            this.mnuMTeachers.Click += new System.EventHandler(this.mnuMTeachers_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMain";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuMStudents;
        private System.Windows.Forms.ToolStripMenuItem mnuMClasses;
        private System.Windows.Forms.ToolStripMenuItem mnuMTeachers;
    }
}

