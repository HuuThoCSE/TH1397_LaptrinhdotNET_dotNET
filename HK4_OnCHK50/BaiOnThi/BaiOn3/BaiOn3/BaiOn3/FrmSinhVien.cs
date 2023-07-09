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
            //dgvSinhvien.DataSource = db.SinhViens;

            var dl = from sv in db.SinhViens
                     from l in db.Lops
                     where sv.LopID == l.LopID
                     select new
                     {
                         sv.SinhvienID,
                         sv.MSSV,
                         sv.SinhvienHo,
                         sv.SinhvienTen,
                         sv.SinhvienGioitinh,
                         sv.SinhvienNgaySinh,
                         sv.SinhvienStatus,
                         l.LopMa,
                         l.LopTen
                     };
            dgvSinhvien.DataSource = dl;

        }

        private void FrmSinhVien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            // Loại bỏ khoản trắng thừa
            string hoten = txtTen.Text;
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

        private void tbnSua_Click(object sender, EventArgs e)
        {

        }

        private void dgvSinhvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhvienID = (int)dgvSinhvien.CurrentRow.Cells["colSinhvienID"].Value;
            txtHo.Text = dgvSinhvien.CurrentRow.Cells["colSinhvienHo"].Value.ToString();
            txtTen.Text = dgvSinhvien.CurrentRow.Cells["colSinhvienTen"].Value.ToString();
            txtMSSV.Text = dgvSinhvien.CurrentRow.Cells["colMSSV"].Value.ToString();
            dtpNgaysinh.Value = ((DateTime)dgvSinhvien.CurrentRow.Cells["colSinhvienNgaysinh"].Value).Date;

        }

        private void dgvSinhvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSinhvien.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void dgvSinhvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSinhvien.Columns[e.ColumnIndex].Name == "colSinhvienGioitinh")
            {
                if (e.Value != null)
                {
                    bool gioitinh = (bool)e.Value;
                    e.Value = gioitinh ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }

            if (dgvSinhvien.Columns[e.ColumnIndex].Name == "colSinhvienStatus")
                if (e.Value != null)
                {
                    int type = (int)e.Value;
                    switch (type)
                    {
                        case 0:
                            e.Value = "Nghỉ học";
                            break;
                        case 1:
                            e.Value = "Còn học";
                            break;
                        case 2:
                            e.Value = "Chuyển ngành";
                            break;
                        default:
                            e.Value = "Ngoại lệ";
                            break;
                    }
                    e.FormattingApplied = true;
                }
            
            if (dgvSinhvien.Columns[e.ColumnIndex].Name == "colSinhvienNgaysinh")
                if(e.Value != null)
                {
                    DateTime date = (DateTime)e.Value;
                    e.Value = date.ToString("dd/MM/yyyy");
                    e.FormattingApplied = true;
                }
        }
    }
}
