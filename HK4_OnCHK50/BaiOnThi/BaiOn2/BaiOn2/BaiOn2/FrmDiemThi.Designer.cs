namespace BaiOn2
{
    partial class FrmDiemThi
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
            this.colHocKy = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonhocTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMonhocID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDiemthi = new System.Windows.Forms.DataGridView();
            this.colSoTinChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtHocky = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDong = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbSinhvien = new System.Windows.Forms.ComboBox();
            this.cbMonhoc = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemthi)).BeginInit();
            this.SuspendLayout();
            // 
            // colHocKy
            // 
            this.colHocKy.DataPropertyName = "HocKy";
            this.colHocKy.HeaderText = "Học kỳ";
            this.colHocKy.MinimumWidth = 6;
            this.colHocKy.Name = "colHocKy";
            this.colHocKy.Width = 125;
            // 
            // colMonhocTen
            // 
            this.colMonhocTen.DataPropertyName = "MonhocTen";
            this.colMonhocTen.HeaderText = "Môn học";
            this.colMonhocTen.MinimumWidth = 6;
            this.colMonhocTen.Name = "colMonhocTen";
            this.colMonhocTen.Width = 125;
            // 
            // colMonhocID
            // 
            this.colMonhocID.DataPropertyName = "MonhocID";
            this.colMonhocID.HeaderText = "ID";
            this.colMonhocID.MinimumWidth = 6;
            this.colMonhocID.Name = "colMonhocID";
            this.colMonhocID.Width = 125;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "STT";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 125;
            // 
            // dgvDiemthi
            // 
            this.dgvDiemthi.AllowUserToAddRows = false;
            this.dgvDiemthi.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDiemthi.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colMonhocID,
            this.colMonhocTen,
            this.colSoTinChi,
            this.colHocKy});
            this.dgvDiemthi.Location = new System.Drawing.Point(55, 387);
            this.dgvDiemthi.Name = "dgvDiemthi";
            this.dgvDiemthi.RowHeadersWidth = 51;
            this.dgvDiemthi.RowTemplate.Height = 24;
            this.dgvDiemthi.Size = new System.Drawing.Size(926, 140);
            this.dgvDiemthi.TabIndex = 39;
            // 
            // colSoTinChi
            // 
            this.colSoTinChi.DataPropertyName = "SoTinChi";
            this.colSoTinChi.HeaderText = "Số tín chỉ";
            this.colSoTinChi.MinimumWidth = 6;
            this.colSoTinChi.Name = "colSoTinChi";
            this.colSoTinChi.Width = 125;
            // 
            // txtHocky
            // 
            this.txtHocky.Location = new System.Drawing.Point(393, 191);
            this.txtHocky.Name = "txtHocky";
            this.txtHocky.Size = new System.Drawing.Size(354, 22);
            this.txtHocky.TabIndex = 38;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 37;
            this.label3.Text = "Điểm:";
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(702, 284);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(75, 23);
            this.btnDong.TabIndex = 33;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(549, 284);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 34;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(414, 284);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 35;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(264, 284);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 36;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(311, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 16);
            this.label5.TabIndex = 30;
            this.label5.Text = "Sinh viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(23, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 29);
            this.label1.TabIndex = 28;
            this.label1.Text = "Manage DiemThi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(316, 147);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 16);
            this.label2.TabIndex = 29;
            this.label2.Text = "Môn học:";
            // 
            // cbSinhvien
            // 
            this.cbSinhvien.FormattingEnabled = true;
            this.cbSinhvien.Location = new System.Drawing.Point(393, 101);
            this.cbSinhvien.Name = "cbSinhvien";
            this.cbSinhvien.Size = new System.Drawing.Size(354, 24);
            this.cbSinhvien.TabIndex = 40;
            // 
            // cbMonhoc
            // 
            this.cbMonhoc.FormattingEnabled = true;
            this.cbMonhoc.Location = new System.Drawing.Point(393, 144);
            this.cbMonhoc.Name = "cbMonhoc";
            this.cbMonhoc.Size = new System.Drawing.Size(354, 24);
            this.cbMonhoc.TabIndex = 41;
            // 
            // FrmDiemThi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1061, 575);
            this.Controls.Add(this.cbMonhoc);
            this.Controls.Add(this.cbSinhvien);
            this.Controls.Add(this.dgvDiemthi);
            this.Controls.Add(this.txtHocky);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Name = "FrmDiemThi";
            this.Text = "FrmDiemThi";
            this.Load += new System.EventHandler(this.FrmDiemThi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDiemthi)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridViewTextBoxColumn colHocKy;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonhocTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMonhocID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView dgvDiemthi;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoTinChi;
        private System.Windows.Forms.TextBox txtHocky;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbSinhvien;
        private System.Windows.Forms.ComboBox cbMonhoc;
    }
}