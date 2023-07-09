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
    public partial class FrmLop : Form
    {
        public FrmLop()
        {
            InitializeComponent();
        }


        DataQuanLyClassDataContext db;

        private void loadData()
        {
            db = new DataQuanLyClassDataContext();
            dgvLop.DataSource = db.Lops;
        }

        private void FrmLop_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void tbnSua_Click(object sender, EventArgs e)
        {

        }

        private void dgvLop_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void dgvLop_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
