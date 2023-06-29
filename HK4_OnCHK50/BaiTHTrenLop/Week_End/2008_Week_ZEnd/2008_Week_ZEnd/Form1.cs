using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2008_Week_ZEnd
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        QLNVDataContext db;
        int id;
        private void LoadGridSV()
        {
            var dl = from a in db.SINHVIENs
                     select new { a.MaSV, a.HoTen, a.GioiTinh, a.NgaySinh };
            dgvSV.DataSource = dl;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            db = new QLNVDataContext();
            LoadGridSV();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgvSV.CurrentRow.Cells["colMaSV"].Value;
            txtHoten.Text = dgvSV.CurrentRow.Cells["colHoten"].Value.ToString();
            dtpNgaysinh.Value = (DateTime)dgvSV.CurrentRow.Cells["colNgaysinh"].Value;
            if (dgvSV.CurrentRow.Cells["colGioitinh"].Value.ToString() == "True")
            {
                chbGioitinh.Checked = true;
            }
            else
            {
                chbGioitinh.Checked = false;
            }
        }

        private void dgvSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSV.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (rs == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtHoten.Clear();
            dtpNgaysinh.Value = DateTime.Now;
            chbGioitinh.Checked = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            db = new QLNVDataContext();
            db.ThemSV(txtHoten.Text, dtpNgaysinh.Value, chbGioitinh.Checked ? 1 : 0);
            LoadGridSV();
        }
    }
}
