namespace Week9_Thuchanh3
{
    partial class Form2
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
            this.gbLoaiPT = new System.Windows.Forms.GroupBox();
            this.radBac2 = new System.Windows.Forms.RadioButton();
            this.radBac1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbValueA = new System.Windows.Forms.TextBox();
            this.tbValueB = new System.Windows.Forms.TextBox();
            this.tbValueC = new System.Windows.Forms.TextBox();
            this.tbKq = new System.Windows.Forms.TextBox();
            this.btnGiai = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.gbLoaiPT.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbLoaiPT
            // 
            this.gbLoaiPT.Controls.Add(this.radBac2);
            this.gbLoaiPT.Controls.Add(this.radBac1);
            this.gbLoaiPT.Location = new System.Drawing.Point(47, 77);
            this.gbLoaiPT.Name = "gbLoaiPT";
            this.gbLoaiPT.Size = new System.Drawing.Size(363, 106);
            this.gbLoaiPT.TabIndex = 0;
            this.gbLoaiPT.TabStop = false;
            this.gbLoaiPT.Text = "Bạn vui lòng chọn:";
            // 
            // radBac2
            // 
            this.radBac2.AutoSize = true;
            this.radBac2.Location = new System.Drawing.Point(76, 64);
            this.radBac2.Name = "radBac2";
            this.radBac2.Size = new System.Drawing.Size(164, 20);
            this.radBac2.TabIndex = 1;
            this.radBac2.TabStop = true;
            this.radBac2.Text = "Giải phương trình Bậc 2";
            this.radBac2.UseVisualStyleBackColor = true;
            this.radBac2.CheckedChanged += new System.EventHandler(this.radBac2_CheckedChanged);
            // 
            // radBac1
            // 
            this.radBac1.AutoSize = true;
            this.radBac1.Location = new System.Drawing.Point(76, 33);
            this.radBac1.Name = "radBac1";
            this.radBac1.Size = new System.Drawing.Size(164, 20);
            this.radBac1.TabIndex = 0;
            this.radBac1.TabStop = true;
            this.radBac1.Text = "Giải phương trình Bậc 1";
            this.radBac1.UseVisualStyleBackColor = true;
            this.radBac1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(53, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(374, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Giải Phương Trình";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(57, 223);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhập a:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 261);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "Nhập b:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(57, 296);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 16);
            this.label4.TabIndex = 4;
            this.label4.Text = "Nhập c:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 331);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Kết quả:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // tbValueA
            // 
            this.tbValueA.Location = new System.Drawing.Point(123, 220);
            this.tbValueA.Name = "tbValueA";
            this.tbValueA.Size = new System.Drawing.Size(164, 22);
            this.tbValueA.TabIndex = 6;
            this.tbValueA.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueA_KeyPress);
            // 
            // tbValueB
            // 
            this.tbValueB.Location = new System.Drawing.Point(123, 259);
            this.tbValueB.Name = "tbValueB";
            this.tbValueB.Size = new System.Drawing.Size(164, 22);
            this.tbValueB.TabIndex = 7;
            this.tbValueB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueB_KeyPress);
            // 
            // tbValueC
            // 
            this.tbValueC.Location = new System.Drawing.Point(123, 296);
            this.tbValueC.Name = "tbValueC";
            this.tbValueC.Size = new System.Drawing.Size(164, 22);
            this.tbValueC.TabIndex = 8;
            this.tbValueC.TextChanged += new System.EventHandler(this.tbValueC_TextChanged);
            this.tbValueC.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbValueC_KeyPress);
            // 
            // tbKq
            // 
            this.tbKq.Location = new System.Drawing.Point(123, 331);
            this.tbKq.Multiline = true;
            this.tbKq.Name = "tbKq";
            this.tbKq.Size = new System.Drawing.Size(304, 85);
            this.tbKq.TabIndex = 9;
            // 
            // btnGiai
            // 
            this.btnGiai.Location = new System.Drawing.Point(304, 227);
            this.btnGiai.Name = "btnGiai";
            this.btnGiai.Size = new System.Drawing.Size(123, 34);
            this.btnGiai.TabIndex = 10;
            this.btnGiai.Text = "Giải";
            this.btnGiai.UseVisualStyleBackColor = true;
            this.btnGiai.Click += new System.EventHandler(this.btnGiai_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(304, 268);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(123, 34);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // Form2
            // 
            this.AcceptButton = this.btnGiai;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(455, 439);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnGiai);
            this.Controls.Add(this.tbKq);
            this.Controls.Add(this.tbValueC);
            this.Controls.Add(this.tbValueB);
            this.Controls.Add(this.tbValueA);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gbLoaiPT);
            this.Name = "Form2";
            this.Text = "Form2";
            this.gbLoaiPT.ResumeLayout(false);
            this.gbLoaiPT.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbLoaiPT;
        private System.Windows.Forms.RadioButton radBac2;
        private System.Windows.Forms.RadioButton radBac1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbValueA;
        private System.Windows.Forms.TextBox tbValueB;
        private System.Windows.Forms.TextBox tbValueC;
        private System.Windows.Forms.TextBox tbKq;
        private System.Windows.Forms.Button btnGiai;
        private System.Windows.Forms.Button btnThoat;
    }
}