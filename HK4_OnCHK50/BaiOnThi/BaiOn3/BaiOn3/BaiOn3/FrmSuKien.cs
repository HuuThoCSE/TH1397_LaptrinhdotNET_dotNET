using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiOn3
{
    public partial class FrmSuKien : Form
    {
        public FrmSuKien()
        {
            InitializeComponent();
        }

        int SukienID;

        DataQuanLyClassDataContext db;


        private void loadData()
        {
            db = new DataQuanLyClassDataContext();
            dgvSukien.DataSource = db.SuKiens;

        }

        private void FrmSuKien_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            db = new DataQuanLyClassDataContext();
            db.themSuKien(txtSukien.Text, 1, ((DateTime)dtpStart.Value).Date, ((DateTime)dtpEnd.Value).Date, txtDiadiem.Text);
            loadData();
        }

        private void dgvSukien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SukienID = (int)dgvSukien.CurrentRow.Cells["colSukienID"].Value;
            txtSukien.Text = dgvSukien.CurrentRow.Cells["colSukienTen"].Value.ToString();
            txtDiadiem.Text = dgvSukien.CurrentRow.Cells["colSukienDiadiem"].Value.ToString();
            dtpStart.Value = ((DateTime)dgvSukien.CurrentRow.Cells["colSukienTimeStart"].Value).Date;
            dtpEnd.Value = ((DateTime)dgvSukien.CurrentRow.Cells["colSukienTimeEnd"].Value).Date;

        }

        private void tbnSua_Click(object sender, EventArgs e)
        {
            db = new DataQuanLyClassDataContext();
            db.suaSuKien(SukienID, txtSukien.Text, 1, ((DateTime)dtpStart.Value).Date, ((DateTime)dtpEnd.Value).Date, txtDiadiem.Text);
            loadData();
        }
    }
}
