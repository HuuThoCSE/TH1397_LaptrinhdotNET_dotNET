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
    public partial class FrmMonHoc : Form
    {
        public FrmMonHoc()
        {
            InitializeComponent();
        }

        DataQLKTDataContext db;

        int MonhocID;

        private void btnThem_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.themMH(txtMonhoc.Text, int.Parse(txtSotinchi.Text), int.Parse(txtHocky.Text));
            loadData();
        }


        private void loadData()
        {
            db = new DataQLKTDataContext();
            dgvMonhoc.DataSource = db.MonHocs;
        }

        private void FrmMonHoc_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.suaMH(MonhocID, txtMonhoc.Text, int.Parse(txtSotinchi.Text), int.Parse(txtHocky.Text));
            loadData();
        }

        private void dgvMonhoc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            MonhocID = (int)dgvMonhoc.CurrentRow.Cells["colMonhocID"].Value;
            txtMonhoc.Text = dgvMonhoc.CurrentRow.Cells["colMonhocTen"].Value.ToString();
            txtSotinchi.Text = dgvMonhoc.CurrentRow.Cells["colSoTinChi"].Value.ToString();
            txtHocky.Text = dgvMonhoc.CurrentRow.Cells["colHocKy"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            db = new DataQLKTDataContext();
            db.xoaMH(MonhocID);
            loadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
