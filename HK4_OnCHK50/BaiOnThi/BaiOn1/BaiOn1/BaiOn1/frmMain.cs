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
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void mnuMStudents_Click(object sender, EventArgs e)
        {
            frmStudents frmStudents = new frmStudents();
            frmStudents.MdiParent = this;
            frmStudents.Show();
        }

        private void mnuMClasses_Click(object sender, EventArgs e)
        {
            frmClasses frmClasses = new frmClasses();
            frmClasses.MdiParent = this;
            frmClasses.Show();
        }

        private void mnuMTeachers_Click(object sender, EventArgs e)
        {
            frmTeachers frmTeachers = new frmTeachers();
            frmTeachers.MdiParent = this;
            frmTeachers.Show();
        }
    }
}
