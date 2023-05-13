using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_Thuchanh3
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có chắc muốn thoát", "Chú ý", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if(res == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Bai3_Load(object sender, EventArgs e)
        {

        }

        private void btnTinhtien_Click(object sender, EventArgs e)
        {
            if(!chkTaytrang.Checked)
            {
                tbChiphiTaytrang.Text = "0";
            }
            if(cbbSLTramrang.SelectedIndex == -1)
                cbbSLTramrang.Text = "0";
            
            btnXem.Enabled = true;
            tbTongcong.Text = (int.Parse(tbChiphiTaytrang.Text.Replace(".", "")) + int.Parse(tbChiphiTramrang.Text.Replace(".", ""))).ToString("N0");
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (chkTaytrang.Checked)
            {
                tbChiphiTaytrang.Text = 100000.ToString("N0");
            } else
            {
                tbChiphiTaytrang.Text = "0";
            }
        }

        private void cbbSLTramrang_SelectedIndexChanged(object sender, EventArgs e)
        {
            tbChiphiTramrang.Text = (int.Parse(cbbSLTramrang.Text)*150000).ToString("N0");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            Form currentForm = this;
            foreach (Control control in currentForm.Controls)
            {
                if (control is TextBox textBox)
                {
                    textBox.Clear();
                }

                if (control is ComboBox comboBox)
                {
                    comboBox.SelectedIndex = 0;
                }

                if (control is DateTimePicker dateTimePicker)
                {
                    dateTimePicker.ResetText();
                }

                chkTaytrang.Checked = false;

            }
        }

        private void btnXem_Click(object sender, EventArgs e)
        {
            if (tbTenkhachhang.Text == "")
            {
                MessageBox.Show("Không có dữ liệu.", "Chú ý!!!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            } else
                MessageBox.Show(
                "Khách hàng: " + tbTenkhachhang.Text + "\n" +
                "Tuổi: " + (DateTime.Now.Year - int.Parse(dpkNamsinh.Text)).ToString() + "\n" +
                "Tẩy trắng: " + int.Parse(tbChiphiTaytrang.Text.Replace(".", "")).ToString("N0") + "đ\n" +
                "Trám răng: " + int.Parse(tbChiphiTramrang.Text.Replace(".", "")).ToString("N0") + "đ\n" +
                "Tổng thanh toán: " + int.Parse(tbTongcong.Text.Replace(".", "")).ToString("N0") + "đ"
                , "Thông báo", MessageBoxButtons.OK);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
