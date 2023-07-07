using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BaiOn1
{
    public partial class frmClasses : Form
    {
        public frmClasses()
        {
            InitializeComponent();
        }


        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        string strcon = @"server=DESKTOP-TKLNL00; database=SchoolManagement1; uid=sa; pwd=123456";
        SqlConnection conn;

        int ClassID;
        DataSet ds;

        private void loadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select Classes.*, Teachers.* " +
                                                    "from Classes, Teachers " +
                                                    "where Classes.TeacherID=Teachers.TeacherID", conn);
            ds = new DataSet();
            da.Fill(ds, "Classes");
            dgvClasses.DataSource = ds.Tables["Classes"];


            SqlDataAdapter daTeachers = new SqlDataAdapter("select TeacherID, Name from Teachers", conn);
            DataSet dsTeachers = new DataSet();
            daTeachers.Fill(dsTeachers, "Teachers");

            cbTeacher.DataSource = dsTeachers.Tables["Teachers"];
            cbTeacher.DisplayMember = "Name";
            cbTeacher.ValueMember = "TeacherID";
        }

        private void frmClasses_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            conn.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "themClass";
            cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text);
            cmd.Parameters.AddWithValue("@TeacherID", cbTeacher.SelectedIndex);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void dgvClasses_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvClasses.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "suaClass";
            cmd.Parameters.AddWithValue("@ClassID", ClassID);
            cmd.Parameters.AddWithValue("@ClassName", txtClassName.Text);
            cmd.Parameters.AddWithValue("@TeacherID", cbTeacher.SelectedValue);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void dgvClasses_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvClasses.Rows.Count)
            {
                DataGridViewRow row = dgvClasses.CurrentRow;

                // Check if row is not null
                if (row != null)
                {
                    ClassID = (int)dgvClasses.CurrentRow.Cells["colClassID"].Value;
                    txtClassName.Text = dgvClasses.CurrentRow.Cells["colClassName"].Value.ToString();
                    cbTeacher.SelectedValue = dgvClasses.CurrentRow.Cells["colTeacherID"].Value;
                }
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "xoaClass";
            cmd.Parameters.AddWithValue("@ClassID", ClassID);
            cmd.ExecuteNonQuery();
            loadData();
        }
    }
}
