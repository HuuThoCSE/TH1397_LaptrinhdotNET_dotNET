namespace Week9_Thuchanh3
{
    partial class Bai3
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbTenkhachhang = new System.Windows.Forms.TextBox();
            this.tbChiphiTaytrang = new System.Windows.Forms.TextBox();
            this.tbChiphiTramrang = new System.Windows.Forms.TextBox();
            this.dpkNamsinh = new System.Windows.Forms.DateTimePicker();
            this.chkTaytrang = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbTongcong = new System.Windows.Forms.TextBox();
            this.btnTinhtien = new System.Windows.Forms.Button();
            this.btnXem = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.cbbSLTramrang = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên khách hàng:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 134);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm sinh:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(58, 219);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(101, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Trám răng:";
            // 
            // tbTenkhachhang
            // 
            this.tbTenkhachhang.Location = new System.Drawing.Point(179, 96);
            this.tbTenkhachhang.Name = "tbTenkhachhang";
            this.tbTenkhachhang.Size = new System.Drawing.Size(200, 22);
            this.tbTenkhachhang.TabIndex = 5;
            this.tbTenkhachhang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // tbChiphiTaytrang
            // 
            this.tbChiphiTaytrang.Location = new System.Drawing.Point(236, 178);
            this.tbChiphiTaytrang.Name = "tbChiphiTaytrang";
            this.tbChiphiTaytrang.ReadOnly = true;
            this.tbChiphiTaytrang.Size = new System.Drawing.Size(143, 22);
            this.tbChiphiTaytrang.TabIndex = 7;
            this.tbChiphiTaytrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tbChiphiTaytrang.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // tbChiphiTramrang
            // 
            this.tbChiphiTramrang.Location = new System.Drawing.Point(236, 219);
            this.tbChiphiTramrang.Name = "tbChiphiTramrang";
            this.tbChiphiTramrang.ReadOnly = true;
            this.tbChiphiTramrang.Size = new System.Drawing.Size(143, 22);
            this.tbChiphiTramrang.TabIndex = 8;
            this.tbChiphiTramrang.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dpkNamsinh
            // 
            this.dpkNamsinh.CustomFormat = "yyyy";
            this.dpkNamsinh.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dpkNamsinh.Location = new System.Drawing.Point(179, 134);
            this.dpkNamsinh.Name = "dpkNamsinh";
            this.dpkNamsinh.Size = new System.Drawing.Size(200, 22);
            this.dpkNamsinh.TabIndex = 9;
            this.dpkNamsinh.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // chkTaytrang
            // 
            this.chkTaytrang.AutoSize = true;
            this.chkTaytrang.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkTaytrang.Location = new System.Drawing.Point(179, 178);
            this.chkTaytrang.Name = "chkTaytrang";
            this.chkTaytrang.Size = new System.Drawing.Size(18, 17);
            this.chkTaytrang.TabIndex = 10;
            this.chkTaytrang.UseVisualStyleBackColor = true;
            this.chkTaytrang.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(65, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Tẩy trắng:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Red;
            this.groupBox1.Location = new System.Drawing.Point(408, 77);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(272, 132);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ghi chú";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.Purple;
            this.label7.Location = new System.Drawing.Point(15, 79);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(195, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "- Trám răng: 150.000đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.Purple;
            this.label6.Location = new System.Drawing.Point(15, 38);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "- Tẩy trắng: 100.000đ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Blue;
            this.label8.Location = new System.Drawing.Point(126, 278);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(102, 20);
            this.label8.TabIndex = 12;
            this.label8.Text = "Tổng cộng:";
            // 
            // tbTongcong
            // 
            this.tbTongcong.Location = new System.Drawing.Point(236, 278);
            this.tbTongcong.Name = "tbTongcong";
            this.tbTongcong.ReadOnly = true;
            this.tbTongcong.Size = new System.Drawing.Size(143, 22);
            this.tbTongcong.TabIndex = 13;
            this.tbTongcong.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnTinhtien
            // 
            this.btnTinhtien.BackColor = System.Drawing.Color.Aqua;
            this.btnTinhtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTinhtien.ForeColor = System.Drawing.Color.Red;
            this.btnTinhtien.Location = new System.Drawing.Point(439, 219);
            this.btnTinhtien.Name = "btnTinhtien";
            this.btnTinhtien.Size = new System.Drawing.Size(100, 36);
            this.btnTinhtien.TabIndex = 14;
            this.btnTinhtien.Text = "Tính tiền";
            this.btnTinhtien.UseVisualStyleBackColor = false;
            this.btnTinhtien.Click += new System.EventHandler(this.btnTinhtien_Click);
            // 
            // btnXem
            // 
            this.btnXem.BackColor = System.Drawing.Color.Aqua;
            this.btnXem.Enabled = false;
            this.btnXem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXem.ForeColor = System.Drawing.Color.Red;
            this.btnXem.Location = new System.Drawing.Point(558, 219);
            this.btnXem.Name = "btnXem";
            this.btnXem.Size = new System.Drawing.Size(100, 36);
            this.btnXem.TabIndex = 15;
            this.btnXem.Text = "Xem";
            this.btnXem.UseVisualStyleBackColor = false;
            this.btnXem.Click += new System.EventHandler(this.btnXem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.BackColor = System.Drawing.Color.Aqua;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.ForeColor = System.Drawing.Color.Red;
            this.btnXoa.Location = new System.Drawing.Point(439, 271);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(100, 36);
            this.btnXoa.TabIndex = 16;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = false;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.Color.Aqua;
            this.btnThoat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.Red;
            this.btnThoat.Location = new System.Drawing.Point(558, 271);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(100, 36);
            this.btnThoat.TabIndex = 17;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // cbbSLTramrang
            // 
            this.cbbSLTramrang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbSLTramrang.FormattingEnabled = true;
            this.cbbSLTramrang.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbbSLTramrang.Location = new System.Drawing.Point(183, 219);
            this.cbbSLTramrang.Name = "cbbSLTramrang";
            this.cbbSLTramrang.Size = new System.Drawing.Size(47, 24);
            this.cbbSLTramrang.TabIndex = 18;
            this.cbbSLTramrang.SelectedIndexChanged += new System.EventHandler(this.cbbSLTramrang_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(231, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 29);
            this.label1.TabIndex = 19;
            this.label1.Text = "DỊCH VỤ NHA KHOA";
            // 
            // Bai3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(721, 382);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbbSLTramrang);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnXem);
            this.Controls.Add(this.btnTinhtien);
            this.Controls.Add(this.tbTongcong);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.chkTaytrang);
            this.Controls.Add(this.dpkNamsinh);
            this.Controls.Add(this.tbChiphiTramrang);
            this.Controls.Add(this.tbChiphiTaytrang);
            this.Controls.Add(this.tbTenkhachhang);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "Bai3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Bai3_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbTenkhachhang;
        private System.Windows.Forms.TextBox tbChiphiTaytrang;
        private System.Windows.Forms.TextBox tbChiphiTramrang;
        private System.Windows.Forms.DateTimePicker dpkNamsinh;
        private System.Windows.Forms.CheckBox chkTaytrang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbTongcong;
        private System.Windows.Forms.Button btnTinhtien;
        private System.Windows.Forms.Button btnXem;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox cbbSLTramrang;
        private System.Windows.Forms.Label label1;
    }
}