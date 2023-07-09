namespace BaiOn3
{
    partial class FrmSinhVien
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
            this.btnDong = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.tbnSua = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.dgvSinhvien = new System.Windows.Forms.DataGridView();
            this.txtTen = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpNgaysinh = new System.Windows.Forms.DateTimePicker();
            this.txtMSSV = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtHo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMSSV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhvienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhvienHo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhvienTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhvienGioitinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhvienNgaysinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSinhvienStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(548, 241);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(56, 19);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(463, 241);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 19);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(364, 241);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(56, 19);
            this.btnHide.TabIndex = 18;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // tbnSua
            // 
            this.tbnSua.Location = new System.Drawing.Point(277, 241);
            this.tbnSua.Margin = new System.Windows.Forms.Padding(2);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(56, 19);
            this.tbnSua.TabIndex = 19;
            this.tbnSua.Text = "Sửa";
            this.tbnSua.UseVisualStyleBackColor = true;
            this.tbnSua.Click += new System.EventHandler(this.tbnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(194, 241);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSinhvien
            // 
            this.dgvSinhvien.AllowUserToAddRows = false;
            this.dgvSinhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSinhvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colMSSV,
            this.colSinhvienID,
            this.colSinhvienHo,
            this.colSinhvienTen,
            this.colSinhvienGioitinh,
            this.colSinhvienNgaysinh,
            this.colSinhvienStatus,
            this.colLopMa,
            this.colLopTen});
            this.dgvSinhvien.Location = new System.Drawing.Point(41, 297);
            this.dgvSinhvien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSinhvien.Name = "dgvSinhvien";
            this.dgvSinhvien.RowHeadersWidth = 51;
            this.dgvSinhvien.RowTemplate.Height = 24;
            this.dgvSinhvien.Size = new System.Drawing.Size(931, 169);
            this.dgvSinhvien.TabIndex = 14;
            this.dgvSinhvien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSinhvien_CellClick);
            this.dgvSinhvien.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvSinhvien_CellFormatting);
            this.dgvSinhvien.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvSinhvien_RowPrePaint);
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(307, 112);
            this.txtTen.Margin = new System.Windows.Forms.Padding(2);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(254, 20);
            this.txtTen.TabIndex = 12;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 115);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage SinhVien";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(249, 180);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Ngày sinh:";
            // 
            // dtpNgaysinh
            // 
            this.dtpNgaysinh.CustomFormat = "dd/MM/yyyy";
            this.dtpNgaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNgaysinh.Location = new System.Drawing.Point(307, 176);
            this.dtpNgaysinh.Margin = new System.Windows.Forms.Padding(2);
            this.dtpNgaysinh.Name = "dtpNgaysinh";
            this.dtpNgaysinh.Size = new System.Drawing.Size(253, 20);
            this.dtpNgaysinh.TabIndex = 21;
            // 
            // txtMSSV
            // 
            this.txtMSSV.Location = new System.Drawing.Point(306, 141);
            this.txtMSSV.Margin = new System.Windows.Forms.Padding(2);
            this.txtMSSV.Name = "txtMSSV";
            this.txtMSSV.Size = new System.Drawing.Size(254, 20);
            this.txtMSSV.TabIndex = 23;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(265, 143);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "MSSV:";
            // 
            // txtHo
            // 
            this.txtHo.Location = new System.Drawing.Point(307, 78);
            this.txtHo.Margin = new System.Windows.Forms.Padding(2);
            this.txtHo.Name = "txtHo";
            this.txtHo.Size = new System.Drawing.Size(254, 20);
            this.txtHo.TabIndex = 25;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(274, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 26;
            this.label5.Text = "Họ:";
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 125;
            // 
            // colMSSV
            // 
            this.colMSSV.DataPropertyName = "MSSV";
            this.colMSSV.HeaderText = "MSSV";
            this.colMSSV.Name = "colMSSV";
            // 
            // colSinhvienID
            // 
            this.colSinhvienID.DataPropertyName = "SinhvienID";
            this.colSinhvienID.HeaderText = "SinhvienID";
            this.colSinhvienID.Name = "colSinhvienID";
            this.colSinhvienID.Visible = false;
            // 
            // colSinhvienHo
            // 
            this.colSinhvienHo.DataPropertyName = "SinhvienHo";
            this.colSinhvienHo.HeaderText = "SinhvienHo";
            this.colSinhvienHo.Name = "colSinhvienHo";
            // 
            // colSinhvienTen
            // 
            this.colSinhvienTen.DataPropertyName = "SinhvienTen";
            this.colSinhvienTen.HeaderText = "SinhvienTen";
            this.colSinhvienTen.Name = "colSinhvienTen";
            // 
            // colSinhvienGioitinh
            // 
            this.colSinhvienGioitinh.DataPropertyName = "SInhvienGioitinh";
            this.colSinhvienGioitinh.HeaderText = "Giới tính";
            this.colSinhvienGioitinh.Name = "colSinhvienGioitinh";
            // 
            // colSinhvienNgaysinh
            // 
            this.colSinhvienNgaysinh.DataPropertyName = "SinhvienNgaysinh";
            this.colSinhvienNgaysinh.HeaderText = "Ngày sinh";
            this.colSinhvienNgaysinh.Name = "colSinhvienNgaysinh";
            // 
            // colSinhvienStatus
            // 
            this.colSinhvienStatus.DataPropertyName = "SinhvienStatus";
            this.colSinhvienStatus.HeaderText = "Tình trạng";
            this.colSinhvienStatus.Name = "colSinhvienStatus";
            // 
            // colLopMa
            // 
            this.colLopMa.DataPropertyName = "LopMa";
            this.colLopMa.HeaderText = "Mã lớp";
            this.colLopMa.Name = "colLopMa";
            // 
            // colLopTen
            // 
            this.colLopTen.DataPropertyName = "LopTen";
            this.colLopTen.HeaderText = "Tên lớp";
            this.colLopTen.Name = "colLopTen";
            this.colLopTen.Visible = false;
            // 
            // FrmSinhVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1033, 512);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtHo);
            this.Controls.Add(this.txtMSSV);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtpNgaysinh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSinhvien);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmSinhVien";
            this.Text = "FrmSinhVien";
            this.Load += new System.EventHandler(this.FrmSinhVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSinhvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button tbnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSinhvien;
        private System.Windows.Forms.TextBox txtTen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpNgaysinh;
        private System.Windows.Forms.TextBox txtMSSV;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtHo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMSSV;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhvienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhvienHo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhvienTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhvienGioitinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhvienNgaysinh;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSinhvienStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopTen;
    }
}