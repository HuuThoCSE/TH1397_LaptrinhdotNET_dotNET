using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiOn2
{
    public partial class FrmSV : Form
    {
        public FrmSV()
        {
            InitializeComponent();
        }

        int SinhvienID;

        DataQLKTDataContext db;

        private void loadData()
        {
            db = new DataQLKTDataContext();
            dgvSV.DataSource = db.SinhViens;
        }

        private void FrmSV_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void dgvSV_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSV.Columns[e.ColumnIndex].Name == "colGioiTinh")
            {
                if (e.Value != null)
                {
                    bool gioiTinh = (bool)e.Value;
                    e.Value = gioiTinh ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.themSV(txtHoten.Text, ((DateTime)dtpNgaysinh.Value).Date, cbGioitinh.Checked ? true : false, txtEmail.Text);
            loadData();
        }

        private void dgvSV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SinhvienID = (int)dgvSV.CurrentRow.Cells["colSinhvienID"].Value;
            txtHoten.Text = dgvSV.CurrentRow.Cells["colHoTen"].Value.ToString();
            dtpNgaysinh.Value = ((DateTime)dgvSV.CurrentRow.Cells["colNgaySinh"].Value).Date;
            cbGioitinh.Checked = dgvSV.CurrentRow.Cells["colGioiTinh"].Value.ToString() == "True";
            txtEmail.Text = dgvSV.CurrentRow.Cells["colEmail"].Value.ToString();
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.suaSV(SinhvienID, txtHoten.Text, ((DateTime)dtpNgaysinh.Value).Date, cbGioitinh.Checked ? true : false, txtEmail.Text);
            loadData();
        }

        private void dgvSV_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSV.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            if(MessageBox.Show("Bạn có chắc chắn muốn xóa?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                db.xoaSV(SinhvienID);
                loadData();
            }

        }

    }
}
