using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiOn1
{
    public partial class frmTeachers : Form
    {
        public frmTeachers()
        {
            InitializeComponent();
        }

        int id;

        DataSQLDataContext db;

        private void Load_Data()
        {
            db = new DataSQLDataContext();
            dgvTeachers.DataSource = db.Teachers;
        }
       
        private void frmTeachers_Load(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void dgvTeachers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvTeachers_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvTeachers.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            db.addTeachers(txtHoten.Text, txtSubject.Text);
            Load_Data();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            db = new DataSQLDataContext();
            db.suaTeachers(id, txtHoten.Text, txtSubject.Text);
            Load_Data();
        }

        private void dgvTeachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvTeachers.Rows.Count)
            {
                DataGridViewRow row = dgvTeachers.CurrentRow;

                // Check if row is not null
                if (row != null)
                {
                    id = (int)dgvTeachers.CurrentRow.Cells["colTeacherID"].Value;
                    txtHoten.Text = dgvTeachers.CurrentRow.Cells["colName"].Value.ToString();
                    txtSubject.Text = dgvTeachers.CurrentRow.Cells["colSubject"].Value.ToString();
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            db = new DataSQLDataContext();
            db.xoaTeachers(id);
            Load_Data();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
