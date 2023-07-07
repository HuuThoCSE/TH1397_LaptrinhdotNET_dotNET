using Microsoft.SqlServer.Server;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week9_Thuchanh3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            tbValueC.Enabled = false;
            tbValueC.Clear();
        }

        private void radBac2_CheckedChanged(object sender, EventArgs e)
        {
            tbValueC.Enabled = true;
        }

        public void TinhBac1(double a, double b)
        {
            double x = 0;
            if (a == 0)
            {
                if (b == 0)
                {
                    tbKq.Text = "Phương trình vô số nghiệm";
                }
                else
                {
                    tbKq.Text = "Phương trình vô nghiệm";
                }
            }
            else
            {
                x = -b / a;
                tbKq.Text = String.Format("Nghiệm của phương trình là: {0}", x.ToString("F2"));
            }
        }

        public void TinhBac2(double a, double b, double c)
        {
            double delta, x1, x2;

            delta = b * b - 4 * a * c;

            if (delta < 0)
            {
                tbKq.Text = "Phương trình vô nghiệm";
            }
            else if (delta == 0)
            {
                x1 = x2 = -b / (2 * a);
                tbKq.Text = String.Format("Phương trình có nghiệm kép: x1 = x2 = {0}", x1.ToString("F2"));
            }
            else
            {
                x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                tbKq.Text = String.Format("Phương trình có 2 nghiệm phân biệt: x1 = {0}, x2 = {1}", x1.ToString("F2"), x2.ToString("F2"));
            }
        }

        private void btnGiai_Click(object sender, EventArgs e)
        {
            double a, b, c;
            if (!double.TryParse(tbValueA.Text, out a) ||
                !double.TryParse(tbValueB.Text, out b) ||
                !double.TryParse(tbValueC.Text, out c))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ vào các ô text");
                return;
            }

            if (tbValueC.Enabled == false)
            {
                TinhBac1(a, b);
            } else
            {
                TinhBac2(a, b, c);
            }

        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbValueA_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbValueB_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }

        private void tbValueC_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbValueC_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;

            if (!Char.IsDigit(ch) && ch != 8 && ch != 46)
            {
                e.Handled = true;
            }
        }
    }
}
