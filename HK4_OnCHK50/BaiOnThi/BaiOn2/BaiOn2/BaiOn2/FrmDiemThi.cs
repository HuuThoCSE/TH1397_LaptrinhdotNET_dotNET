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
            dgvDiemthi.DataSource = db.DiemThis;
        }


        private void FrmDiemThi_Load(object sender, EventArgs e)
        {
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {

        }
    }
}
