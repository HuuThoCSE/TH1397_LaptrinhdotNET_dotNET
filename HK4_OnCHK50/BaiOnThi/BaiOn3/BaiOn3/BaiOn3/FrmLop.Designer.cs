namespace BaiOn3
{
    partial class FrmLop
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
            this.label4 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.dgvLop = new System.Windows.Forms.DataGridView();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LopID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopMa = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLopTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSoSinhVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnThem = new System.Windows.Forms.Button();
            this.tbnSua = new System.Windows.Forms.Button();
            this.btnHide = new System.Windows.Forms.Button();
            this.btnTim = new System.Windows.Forms.Button();
            this.btnDong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Manage Lop";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(156, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên lớp";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(156, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã lớp";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(207, 59);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(254, 20);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(207, 91);
            this.textBox2.Margin = new System.Windows.Forms.Padding(2);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(254, 20);
            this.textBox2.TabIndex = 5;
            // 
            // dgvLop
            // 
            this.dgvLop.AllowUserToAddRows = false;
            this.dgvLop.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLop.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.LopID,
            this.colLopMa,
            this.colLopTen,
            this.colSoSinhVien});
            this.dgvLop.Location = new System.Drawing.Point(38, 272);
            this.dgvLop.Margin = new System.Windows.Forms.Padding(2);
            this.dgvLop.Name = "dgvLop";
            this.dgvLop.RowHeadersWidth = 51;
            this.dgvLop.RowTemplate.Height = 24;
            this.dgvLop.Size = new System.Drawing.Size(727, 121);
            this.dgvLop.TabIndex = 6;
            this.dgvLop.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLop_CellClick);
            this.dgvLop.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvLop_CellFormatting);
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 125;
            // 
            // LopID
            // 
            this.LopID.DataPropertyName = "LopID";
            this.LopID.HeaderText = "LopID";
            this.LopID.MinimumWidth = 6;
            this.LopID.Name = "LopID";
            this.LopID.Width = 125;
            // 
            // colLopMa
            // 
            this.colLopMa.DataPropertyName = "LopMa";
            this.colLopMa.HeaderText = "Mã lớp";
            this.colLopMa.MinimumWidth = 6;
            this.colLopMa.Name = "colLopMa";
            this.colLopMa.Width = 125;
            // 
            // colLopTen
            // 
            this.colLopTen.DataPropertyName = "LopTen";
            this.colLopTen.HeaderText = "Tên lớp";
            this.colLopTen.MinimumWidth = 6;
            this.colLopTen.Name = "colLopTen";
            this.colLopTen.Width = 125;
            // 
            // colSoSinhVien
            // 
            this.colSoSinhVien.DataPropertyName = "SoSinhVien";
            this.colSoSinhVien.HeaderText = "Số lượng";
            this.colSoSinhVien.MinimumWidth = 6;
            this.colSoSinhVien.Name = "colSoSinhVien";
            this.colSoSinhVien.Width = 125;
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(176, 201);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            // 
            // tbnSua
            // 
            this.tbnSua.Location = new System.Drawing.Point(259, 201);
            this.tbnSua.Margin = new System.Windows.Forms.Padding(2);
            this.tbnSua.Name = "tbnSua";
            this.tbnSua.Size = new System.Drawing.Size(56, 19);
            this.tbnSua.TabIndex = 8;
            this.tbnSua.Text = "Sửa";
            this.tbnSua.UseVisualStyleBackColor = true;
            this.tbnSua.Click += new System.EventHandler(this.tbnSua_Click);
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(346, 201);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(56, 19);
            this.btnHide.TabIndex = 8;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(445, 201);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 19);
            this.btnTim.TabIndex = 8;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(530, 201);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(56, 19);
            this.btnDong.TabIndex = 8;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // FrmLop
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(788, 420);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvLop);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmLop";
            this.Text = "FrmLop";
            this.Load += new System.EventHandler(this.FrmLop_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLop)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.DataGridView dgvLop;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.Button tbnSua;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn LopID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopMa;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLopTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSoSinhVien;
    }
}