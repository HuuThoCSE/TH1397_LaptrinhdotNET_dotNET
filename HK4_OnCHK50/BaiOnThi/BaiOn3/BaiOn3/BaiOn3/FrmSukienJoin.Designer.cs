namespace BaiOn3
{
    partial class FrmSukienJoin
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbLop = new System.Windows.Forms.ComboBox();
            this.cbSinhvien = new System.Windows.Forms.ComboBox();
            this.cbSukien = new System.Windows.Forms.ComboBox();
            this.btnDiemdanh = new System.Windows.Forms.Button();
            this.dgvDiemdanh = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDiemdanhID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemdanh)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sinhvien Join Sukien";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(285, 65);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lớp:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(251, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sinh viên:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 156);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sự kiện";
            // 
            // cbLop
            // 
            this.cbLop.FormattingEnabled = true;
            this.cbLop.Location = new System.Drawing.Point(355, 62);
            this.cbLop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbLop.Name = "cbLop";
            this.cbLop.Size = new System.Drawing.Size(415, 24);
            this.cbLop.TabIndex = 2;
            // 
            // cbSinhvien
            // 
            this.cbSinhvien.FormattingEnabled = true;
            this.cbSinhvien.Location = new System.Drawing.Point(355, 106);
            this.cbSinhvien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSinhvien.Name = "cbSinhvien";
            this.cbSinhvien.Size = new System.Drawing.Size(415, 24);
            this.cbSinhvien.TabIndex = 3;
            // 
            // cbSukien
            // 
            this.cbSukien.FormattingEnabled = true;
            this.cbSukien.Location = new System.Drawing.Point(355, 153);
            this.cbSukien.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbSukien.Name = "cbSukien";
            this.cbSukien.Size = new System.Drawing.Size(415, 24);
            this.cbSukien.TabIndex = 3;
            // 
            // btnDiemdanh
            // 
            this.btnDiemdanh.Location = new System.Drawing.Point(254, 221);
            this.btnDiemdanh.Name = "btnDiemdanh";
            this.btnDiemdanh.Size = new System.Drawing.Size(106, 23);
            this.btnDiemdanh.TabIndex = 4;
            this.btnDiemdanh.Text = "Điểm danh";
            this.btnDiemdanh.UseVisualStyleBackColor = true;
            this.btnDiemdanh.Click += new System.EventHandler(this.btnDiemdanh_Click);
            // 
            // dgvDiemdanh
            // 
            this.dgvDiemdanh.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemdanh.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colDiemdanhID});
            this.dgvDiemdanh.Location = new System.Drawing.Point(20, 371);
            this.dgvDiemdanh.Name = "dgvDiemdanh";
            this.dgvDiemdanh.RowHeadersWidth = 51;
            this.dgvDiemdanh.RowTemplate.Height = 24;
            this.dgvDiemdanh.Size = new System.Drawing.Size(939, 150);
            this.dgvDiemdanh.TabIndex = 5;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 125;
            // 
            // colDiemdanhID
            // 
            this.colDiemdanhID.HeaderText = "DiemdanhID";
            this.colDiemdanhID.MinimumWidth = 6;
            this.colDiemdanhID.Name = "colDiemdanhID";
            this.colDiemdanhID.Width = 125;
            // 
            // FrmSukienJoin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 548);
            this.Controls.Add(this.dgvDiemdanh);
            this.Controls.Add(this.btnDiemdanh);
            this.Controls.Add(this.cbSukien);
            this.Controls.Add(this.cbSinhvien);
            this.Controls.Add(this.cbLop);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSukienJoin";
            this.Text = " ";
            this.Load += new System.EventHandler(this.FrmSukienJoin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemdanh)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbLop;
        private System.Windows.Forms.ComboBox cbSinhvien;
        private System.Windows.Forms.ComboBox cbSukien;
        private System.Windows.Forms.Button btnDiemdanh;
        private System.Windows.Forms.DataGridView dgvDiemdanh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDiemdanhID;
    }
}