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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();

            this.IsMdiContainer = true;

            FrmDiemThi frmDiemThi = new FrmDiemThi();
            frmDiemThi.MdiParent = this;
            frmDiemThi.Show();

        }

        private void mnuMSV_Click(object sender, EventArgs e)
        {
            FrmSV frmSV = new FrmSV();
            frmSV.MdiParent = this;
            frmSV.Show();
        }

        private void mnuMMH_Click(object sender, EventArgs e)
        {
            FrmMonHoc frmMonHoc = new FrmMonHoc();
            frmMonHoc.MdiParent = this;
            frmMonHoc.Show();
        }

        private void mnuMDT_Click(object sender, EventArgs e)
        {
            FrmDiemThi frmDiemThi = new FrmDiemThi();
            frmDiemThi.MdiParent = this;
            frmDiemThi.Show();
        }

        private void mnuThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


        private void FrmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
