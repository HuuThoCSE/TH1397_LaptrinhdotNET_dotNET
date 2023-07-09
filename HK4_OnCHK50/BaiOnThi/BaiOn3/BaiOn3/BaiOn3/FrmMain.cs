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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void mnManageSinhVien_Click(object sender, EventArgs e)
        {
            FrmSinhVien frmSinhVien = new FrmSinhVien();
            frmSinhVien.MdiParent = this;
            frmSinhVien.Show();
        }

        private void mnManageLop_Click(object sender, EventArgs e)
        {
            FrmLop frmLop = new FrmLop();
            frmLop.MdiParent = this;
            frmLop.Show();
        }

        private void mnManageSuKien_Click(object sender, EventArgs e)
        {
            FrmSuKien frmSuKien = new FrmSuKien();
            frmSuKien.MdiParent = this;
            frmSuKien.Show();
        }

        private void mnuSukienJoin_Click(object sender, EventArgs e)
        {
            
        }

        private void mnuJoinSukien_Click(object sender, EventArgs e)
        {
            FrmSukienJoin frmSukienJoin = new FrmSukienJoin();
            frmSukienJoin.MdiParent = this;
            frmSukienJoin.Show();
        }
    }
}
