namespace QuanLyNhanVien
{
    partial class DanhMucPhongBan
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
            this.txtTenPB = new System.Windows.Forms.TextBox();
            this.dgvPB = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMota = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label3 = new System.Windows.Forms.Label();
            this.txtMota = new System.Windows.Forms.TextBox();
            this.btnThem = new System.Windows.Forms.Button();
            this.btnSua = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(120, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(349, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "DANH MỤC PHÒNG BAN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(46, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên PB:";
            // 
            // txtTenPB
            // 
            this.txtTenPB.Location = new System.Drawing.Point(98, 76);
            this.txtTenPB.Name = "txtTenPB";
            this.txtTenPB.Size = new System.Drawing.Size(266, 20);
            this.txtTenPB.TabIndex = 3;
            // 
            // dgvPB
            // 
            this.dgvPB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colTenPB,
            this.colMota,
            this.colMaPB});
            this.dgvPB.Location = new System.Drawing.Point(49, 187);
            this.dgvPB.Name = "dgvPB";
            this.dgvPB.Size = new System.Drawing.Size(506, 124);
            this.dgvPB.TabIndex = 5;
            this.dgvPB.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPB_CellClick);
            this.dgvPB.RowPrePaint += new System.Windows.Forms.DataGridViewRowPrePaintEventHandler(this.dgvPB_RowPrePaint);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.Name = "colSTT";
            // 
            // colTenPB
            // 
            this.colTenPB.DataPropertyName = "TenPB";
            this.colTenPB.HeaderText = "Tên PB";
            this.colTenPB.Name = "colTenPB";
            // 
            // colMota
            // 
            this.colMota.DataPropertyName = "MoTa";
            this.colMota.HeaderText = "Mô tả";
            this.colMota.Name = "colMota";
            // 
            // colMaPB
            // 
            this.colMaPB.DataPropertyName = "MaPB";
            this.colMaPB.HeaderText = "Mã PB";
            this.colMaPB.Name = "colMaPB";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(46, 114);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mô tả:";
            // 
            // txtMota
            // 
            this.txtMota.Location = new System.Drawing.Point(98, 111);
            this.txtMota.Name = "txtMota";
            this.txtMota.Size = new System.Drawing.Size(266, 20);
            this.txtMota.TabIndex = 4;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(119, 149);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 13;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnSua
            // 
            this.btnSua.Location = new System.Drawing.Point(209, 149);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(75, 23);
            this.btnSua.TabIndex = 14;
            this.btnSua.Text = "Sửa";
            this.btnSua.UseVisualStyleBackColor = true;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(295, 149);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 15;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(376, 149);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(75, 23);
            this.btnThoat.TabIndex = 16;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // DanhMucPhongBan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(587, 323);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvPB);
            this.Controls.Add(this.txtMota);
            this.Controls.Add(this.txtTenPB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DanhMucPhongBan";
            this.Text = "DanhMucPhongBan";
            this.Load += new System.EventHandler(this.DanhMucPhongBan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTenPB;
        private System.Windows.Forms.DataGridView dgvPB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtMota;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button btnSua;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTenPB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMota;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMaPB;
    }
}