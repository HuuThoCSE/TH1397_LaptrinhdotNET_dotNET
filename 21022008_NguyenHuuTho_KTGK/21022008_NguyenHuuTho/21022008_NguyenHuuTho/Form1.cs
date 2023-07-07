using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _21022008_NguyenHuuTho
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbThang.Text = "Tháng: "+DateTime.Now.Month + "/" + DateTime.Now.Year;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            cbHotenKH.SelectedIndex = -1;
            txtChisoCu.Clear();
            txtChisoMoi.Clear();
            txtSoKWTieuthu.Clear();
            txtSoKWTrongDinhmuc.Clear();
            txtSoKWVuotDinhmuc.Clear();
            txtTong.Clear();
            txtKetqua.Clear();
            btnIn.Enabled = false;
            txtChisoCu.Focus();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if(cbHotenKH.SelectedIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn tên Khách hàng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            } else
            {
                txtKetqua.Text = "Khách hàng: " + cbHotenKH.Text + "\r\n" +
                             "Số KW tiêu thụ: " + txtSoKWTieuthu.Text + "\r\n" +
                             "Tiền phải trả: " + txtTong.Text;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Lưu ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (rs == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void txtChisoCu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar)){
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void txtChisoMoi_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Vui lòng chỉ nhập số!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtChisoCu.Text) || string.IsNullOrEmpty(txtChisoMoi.Text))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ chỉ số.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                txtSoKWTieuthu.Text = (double.Parse(txtChisoMoi.Text) - double.Parse(txtChisoCu.Text)).ToString();
                if (double.Parse(txtSoKWTieuthu.Text) > 50)
                {
                    txtSoKWTrongDinhmuc.Text = "50";
                    txtSoKWVuotDinhmuc.Text = (double.Parse(txtSoKWTieuthu.Text) - 50).ToString();
                    txtTong.Text = (double.Parse(txtSoKWTrongDinhmuc.Text) * 500 + double.Parse(txtSoKWVuotDinhmuc.Text) * 1000 + (double.Parse(txtSoKWTrongDinhmuc.Text) * 500 + double.Parse(txtSoKWVuotDinhmuc.Text) * 1000) * 0.1).ToString();
                }
                else
                {
                    txtSoKWTrongDinhmuc.Text = txtSoKWTieuthu.Text;
                    txtSoKWVuotDinhmuc.Text = "0";
                    txtTong.Text = (double.Parse(txtSoKWTrongDinhmuc.Text) * 500 + (double.Parse(txtSoKWTrongDinhmuc.Text) * 500) * 0.1).ToString();
                }
                btnIn.Enabled = true;
            }
        }
    }
}
