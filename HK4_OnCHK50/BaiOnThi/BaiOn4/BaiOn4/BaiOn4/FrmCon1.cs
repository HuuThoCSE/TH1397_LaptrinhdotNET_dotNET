using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiOn4
{
    public partial class FrmCon1 : Form
    {
        public FrmCon1()
        {
            InitializeComponent();
            dgvSinhvien.AutoGenerateColumns = true;
            dgvSinhvien.AllowUserToAddRows = false;
        }

        private void FrmCon1_Load(object sender, EventArgs e)
        {
            DataQLTHDataContext db = new DataQLTHDataContext();
            dgvSinhvien.DataSource = db.SinhViens;
        }

        private void dgvSinhvien_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dgvSinhvien.Columns[e.ColumnIndex].Name == "SinhvienGioitinh")
                if(e.Value != null)
                {
                    bool value = (bool)e.Value;
                    e.Value = value ? "Nam" : "Nữ";
                    e.FormattingApplied = true;
                }

            if (dgvSinhvien.Columns[e.ColumnIndex].Name == "SinhvienNgaySinh")
                if(e.Value != null)
                {
                    e.Value = ((DateTime)e.Value).ToString("dd/MM/yyy");
                    e.FormattingApplied = true;
                }

            if (dgvSinhvien.Columns[e.ColumnIndex].Name == "SinhvienStatus")
                if(e.Value != null)
                {
                    if((int)e.Value == 1)
                    {
                        e.Value = "Còn học";
                    } else
                    {
                        e.Value = "...";
                    }
                }
        }

        private void dgvSinhvien_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvSinhvien.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1; 
        }

        private void dgvSinhvien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
