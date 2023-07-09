using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiOn3
{
    public partial class FrmSinhVien : Form
    {
        public FrmSinhVien()
        {
            InitializeComponent();
        }

        int SinhvienID;

        DataQuanLyClassDataContext db;

        private void loadData()
        {
            db = new DataQuanLyClassDataContext();
            dgvSinhvien.DataSource = db.SinhViens;
        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Loại bỏ khoản trắng thừa
            string hoten = txtHoten.Text;
            hoten = string.Join(" ", hoten.Split(new char[] { ' ' },
                StringSplitOptions.RemoveEmptyEntries));

            // Tách chuổn thành một mảng các chuổis

            string[] nameParts = hoten.Split(' ');

            string email = string.Join("", txtMSSV.Text, "@st.vlute.edu.vn");

            MessageBox.Show("Họ: " + nameParts[1] + "\r\n" +
                            "Đệm: " + string.Join(" ", nameParts, 0, nameParts.Length - 1) + "\r\n" +
                            "Tên: " + nameParts[nameParts.Length - 1] + "\r\n" + email
                            , "..."); 

            
        }
    }
}
