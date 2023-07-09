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
    }
}
