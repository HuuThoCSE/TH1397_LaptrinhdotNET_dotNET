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
    public partial class FrmDiemThi : Form
    {
        public FrmDiemThi()
        {
            InitializeComponent();
        }

        int DiemthiID;
        DataQLKTDataContext db;

        private void loadData()
        {
            db = new DataQLKTDataContext();
            //dgvDiemthi.DataSource = db.DiemThis; Xoa tk này đi dư thừa voãi...

            var dl = from sv in db.SinhViens
                     from dt in db.DiemThis
                     from mh in db.MonHocs
                     where dt.SinhvienID == sv.SinhvienID && dt.MonhocID == mh.MonhocID
                     select new { sv.SinhvienID, sv.HoTen, dt.MonhocID, mh.MonhocTen, dt.DiemthiID, dt.Diem };
            dgvDiemthi.DataSource = dl;

            cbSinhvien.DataSource = db.SinhViens;
            cbSinhvien.DisplayMember = "HoTen";
            cbSinhvien.ValueMember = "SinhvienID";

            cbMonhoc.DataSource = db.MonHocs; /*!!! Chú ý tên combobox */
            cbMonhoc.DisplayMember = "MonhocTen";
            cbMonhoc.ValueMember = "MonhocID";

        }


        private void FrmDiemThi_Load(object sender, EventArgs e)
        {
            loadData();
            //dgvDiemthi.AutoGenerateColumns = true;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.themDT((int)cbSinhvien.SelectedValue, (int)cbMonhoc.SelectedValue, double.Parse(txtDiem.Text));
            loadData();
        }

        private void dgvDiemthi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvDiemthi_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvDiemthi.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.suaDT(DiemthiID, (int)cbSinhvien.SelectedValue, (int)cbMonhoc.SelectedValue, double.Parse(txtDiem.Text));
            loadData();
        }

        private void dgvDiemthi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DiemthiID = (int)dgvDiemthi.CurrentRow.Cells["colDiemthiID"].Value;
            cbSinhvien.SelectedValue = (int)dgvDiemthi.CurrentRow.Cells["colSinhvienID"].Value;
            cbMonhoc.SelectedValue = (int)dgvDiemthi.CurrentRow.Cells["colMonhocID"].Value;
            txtDiem.Text = dgvDiemthi.CurrentRow.Cells["colDiem"].Value.ToString();

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.xoaDT(DiemthiID);
            loadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {

        }

        private void btnTim_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            var dl = from sv in db.SinhViens
                     from dt in db.DiemThis
                     from mh in db.MonHocs
                     where dt.SinhvienID == sv.SinhvienID && dt.MonhocID == mh.MonhocID
                     where sv.SinhvienID == (int)cbSinhvien.SelectedValue
                     where mh.MonhocID == (int)cbMonhoc.SelectedValue
                     select new { sv.SinhvienID, sv.HoTen, dt.MonhocID, mh.MonhocTen, dt.DiemthiID, dt.Diem };
            dgvDiemthi.DataSource = dl;
        }
    }
}
