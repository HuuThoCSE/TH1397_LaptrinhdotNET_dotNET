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
    public partial class FrmSukienJoin : Form
    {
        public FrmSukienJoin()
        {
            InitializeComponent();
        }

        DataQuanLyClassDataContext db;

        private void FrmSukienJoin_Load(object sender, EventArgs e)
        {
            db = new DataQuanLyClassDataContext();
            dgvDiemdanh.DataSource = db.DiemDanhs;

            var dl = from sv in db.SinhViens
                     from sk in db.SuKiens
                     from dd in db.DiemDanhs
                     where dd.SinhvienID == sv.SinhvienID && dd.SukienID == sk.SukienID
                     select new
                     {
                         sv.SinhvienID,
                         sv.SinhvienTen,
                         sk.SukienID,
                         sk.SukienTen,
                     };

            cbLop.DataSource = db.Lops;
            cbLop.DisplayMember = "LopTen";
            cbLop.ValueMember = "LopID";

            cbSinhvien.DataSource = db.SinhViens;
            cbSinhvien.DisplayMember = "SinhvienTen";
            cbSinhvien.ValueMember = "SinhVienID";

            cbSukien.DataSource = db.SuKiens;
            cbSukien.DisplayMember = "SukienTen";
            cbSukien.ValueMember = "SukienID";


        }

        private void btnDiemdanh_Click(object sender, EventArgs e)
        {
            db = new DataQuanLyClassDataContext();
            db.themDiemDanh((int)cbSinhvien.SelectedValue, (int)cbSukien.SelectedValue);
          
        }
    }
}
