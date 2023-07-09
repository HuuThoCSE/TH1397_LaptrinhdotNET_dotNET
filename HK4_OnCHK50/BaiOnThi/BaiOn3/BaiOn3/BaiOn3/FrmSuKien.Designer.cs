namespace BaiOn3
{
    partial class FrmSuKien
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
            this.dgvSukien = new System.Windows.Forms.DataGridView();
            this.txtDiadiem = new System.Windows.Forms.TextBox();
            this.txtSukien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.colSTT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSukienID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSukienTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSukienTimeStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSukienTimeEnd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSukienDiadiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSukien)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDong
            // 
            this.btnDong.Location = new System.Drawing.Point(543, 226);
            this.btnDong.Margin = new System.Windows.Forms.Padding(2);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(56, 19);
            this.btnDong.TabIndex = 16;
            this.btnDong.Text = "Đóng";
            this.btnDong.UseVisualStyleBackColor = true;
            // 
            // btnTim
            // 
            this.btnTim.Location = new System.Drawing.Point(458, 226);
            this.btnTim.Margin = new System.Windows.Forms.Padding(2);
            this.btnTim.Name = "btnTim";
            this.btnTim.Size = new System.Drawing.Size(56, 19);
            this.btnTim.TabIndex = 17;
            this.btnTim.Text = "Tìm";
            this.btnTim.UseVisualStyleBackColor = true;
            // 
            // btnHide
            // 
            this.btnHide.Location = new System.Drawing.Point(359, 226);
            this.btnHide.Margin = new System.Windows.Forms.Padding(2);
            this.btnHide.Name = "btnHide";
            this.btnHide.Size = new System.Drawing.Size(56, 19);
            this.btnHide.TabIndex = 18;
            this.btnHide.Text = "Hide";
            this.btnHide.UseVisualStyleBackColor = true;
            // 
            // tbnSua
            // 
            this.tbnSua.Location = new System.Drawing.Point(272, 226);
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
            this.btnThem.Location = new System.Drawing.Point(189, 226);
            this.btnThem.Margin = new System.Windows.Forms.Padding(2);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(56, 19);
            this.btnThem.TabIndex = 15;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // dgvSukien
            // 
            this.dgvSukien.AllowUserToAddRows = false;
            this.dgvSukien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSukien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colSTT,
            this.colSukienID,
            this.colSukienTen,
            this.colSukienTimeStart,
            this.colSukienTimeEnd,
            this.colSukienDiadiem});
            this.dgvSukien.Location = new System.Drawing.Point(51, 297);
            this.dgvSukien.Margin = new System.Windows.Forms.Padding(2);
            this.dgvSukien.Name = "dgvSukien";
            this.dgvSukien.RowHeadersWidth = 51;
            this.dgvSukien.RowTemplate.Height = 24;
            this.dgvSukien.Size = new System.Drawing.Size(727, 121);
            this.dgvSukien.TabIndex = 14;
            this.dgvSukien.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSukien_CellClick);
            // 
            // txtDiadiem
            // 
            this.txtDiadiem.Location = new System.Drawing.Point(291, 179);
            this.txtDiadiem.Margin = new System.Windows.Forms.Padding(2);
            this.txtDiadiem.Name = "txtDiadiem";
            this.txtDiadiem.Size = new System.Drawing.Size(254, 20);
            this.txtDiadiem.TabIndex = 13;
            // 
            // txtSukien
            // 
            this.txtSukien.Location = new System.Drawing.Point(291, 69);
            this.txtSukien.Margin = new System.Windows.Forms.Padding(2);
            this.txtSukien.Name = "txtSukien";
            this.txtSukien.Size = new System.Drawing.Size(254, 20);
            this.txtSukien.TabIndex = 12;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 182);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Địa điểm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(221, 72);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Tên sự kiện:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(11, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Manage Sukien";
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(291, 108);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(2);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(253, 20);
            this.dtpStart.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(193, 108);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Thời gian bắt đầu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(193, 146);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Thời gian kết thúc:";
            // 
            // dtpEnd
            // 
            this.dtpEnd.CustomFormat = "hh:mm:ss dd/MM/yyyy";
            this.dtpEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEnd.Location = new System.Drawing.Point(291, 145);
            this.dtpEnd.Margin = new System.Windows.Forms.Padding(2);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(253, 20);
            this.dtpEnd.TabIndex = 25;
            // 
            // colSTT
            // 
            this.colSTT.HeaderText = "STT";
            this.colSTT.MinimumWidth = 6;
            this.colSTT.Name = "colSTT";
            this.colSTT.Width = 125;
            // 
            // colSukienID
            // 
            this.colSukienID.DataPropertyName = "SukienID";
            this.colSukienID.HeaderText = "SukienID";
            this.colSukienID.Name = "colSukienID";
            // 
            // colSukienTen
            // 
            this.colSukienTen.DataPropertyName = "SukienTen";
            this.colSukienTen.HeaderText = "SukienTen";
            this.colSukienTen.Name = "colSukienTen";
            // 
            // colSukienTimeStart
            // 
            this.colSukienTimeStart.DataPropertyName = "SukienTimeStart";
            this.colSukienTimeStart.HeaderText = "SukienStart";
            this.colSukienTimeStart.Name = "colSukienTimeStart";
            // 
            // colSukienTimeEnd
            // 
            this.colSukienTimeEnd.DataPropertyName = "SukienTimeEnd";
            this.colSukienTimeEnd.HeaderText = "SukienEnd";
            this.colSukienTimeEnd.Name = "colSukienTimeEnd";
            // 
            // colSukienDiadiem
            // 
            this.colSukienDiadiem.DataPropertyName = "SukienDiadiem";
            this.colSukienDiadiem.HeaderText = "SukienDiadiem";
            this.colSukienDiadiem.Name = "colSukienDiadiem";
            // 
            // FrmSuKien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnDong);
            this.Controls.Add(this.btnTim);
            this.Controls.Add(this.btnHide);
            this.Controls.Add(this.tbnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.dgvSukien);
            this.Controls.Add(this.txtDiadiem);
            this.Controls.Add(this.txtSukien);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmSuKien";
            this.Text = "FrmSuKien";
            this.Load += new System.EventHandler(this.FrmSuKien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSukien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDong;
        private System.Windows.Forms.Button btnTim;
        private System.Windows.Forms.Button btnHide;
        private System.Windows.Forms.Button tbnSua;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.DataGridView dgvSukien;
        private System.Windows.Forms.TextBox txtDiadiem;
        private System.Windows.Forms.TextBox txtSukien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSTT;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSukienID;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSukienTen;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSukienTimeStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSukienTimeEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSukienDiadiem;
    }
}