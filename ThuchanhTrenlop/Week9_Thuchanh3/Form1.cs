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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if(double.Parse(tbBankinh.Text) <=0)
            {
                DialogResult res = MessageBox.Show("Bạn nhập diện tích không hợp lệ!!!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (res == DialogResult.OK)
                {
                    tbBankinh.Focus();
                }
            } else
            {
                tbChuvi.Text = (double.Parse(tbBankinh.Text) * 2 * Math.PI).ToString("F5");
                tbDientich.Text = (Math.Pow(double.Parse(tbBankinh.Text), 2) * Math.PI).ToString("F5");
            }
            
        }

        private void btnTieptuc_Click(object sender, EventArgs e)
        {
            tbBankinh.Clear();
            tbChuvi.Clear();
            tbDientich.Clear();
        }
    }
}
