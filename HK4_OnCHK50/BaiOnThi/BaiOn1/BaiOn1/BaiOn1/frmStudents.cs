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

namespace BaiOn1
{
    public partial class frmStudents : Form
    {
        public frmStudents()
        {
            InitializeComponent();
        }

        int StudentID;
        string strcon = @"server=desktop-tklnl00; database=schoolmanagement1; uid=sa; pwd=123456";
        SqlConnection conn;
        SqlCommand cmd;

        private void btnThem_Click(object sender, EventArgs e)
        {
            string Hoten = txtHoTen.Text;
            string[] nameParts = Hoten.Split(' ');

            string ho = nameParts[0];
            string demVaTen = string.Join(" ", nameParts, 1, nameParts.Length - 1);

            int age;
            bool isNumeric = int.TryParse(txtAge.Text, out age);

            if (!(isNumeric && age >= 6 && age <= 18))
            {
                MessageBox.Show("Vui lòng nhập tuổi từ 6 đến 18!");
            }

            string sql = "insert into Students (Name, Age, ClassID) " +
                         "values (N'" + txtHoTen.Text + "', " + txtAge.Text+ ", "+cbClasses.SelectedValue+")";
            //MessageBox.Show(sql.ToString());
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void loadData()
        {
            dgvStudents.Rows.Clear();
            string sql = "select Students.*, Classes.ClassID, Classes.ClassName from Students, Classes where Students.ClassID=Classes.ClassID";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                int i = dgvStudents.Rows.Add();
                DataGridViewRow dgv = dgvStudents.Rows[i];
                dgv.Cells["colStudentID"].Value = dr["StudentID"];
                dgv.Cells["colName"].Value = dr["Name"];
                dgv.Cells["colAge"].Value = dr["Age"];
                dgv.Cells["colClassID"].Value = dr["ClassID"];
            }
            dr.Close();

            //cbClasses.Items.Clear();
            Dictionary<string, string> classDict = new Dictionary<string, string>();
            sql = "select distinct classID, ClassName from Classes";
            cmd = new SqlCommand(sql, conn);
            dr = cmd.ExecuteReader();
            while(dr.Read())
            {
                string classID = dr["ClassID"].ToString();
                string className = dr["ClassName"].ToString();

                classDict[classID] = className;
            }
            dr.Close();

            cbClasses.DataSource = new BindingSource(classDict, null);
            cbClasses.DisplayMember = "Value";
            cbClasses.ValueMember = "Key";
        }

        private void frmStudents_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            conn.Open();
            loadData();
        }

        private void dgvStudents_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvStudents.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dgvStudents.Rows.Count)
            {
                DataGridViewRow row = dgvStudents.CurrentRow;

                // Check if row is not null
                if (row != null)
                {
                    StudentID = (int)dgvStudents.CurrentRow.Cells["colStudentID"].Value;
                    txtHoTen.Text = dgvStudents.CurrentRow.Cells["colName"].Value.ToString();
                    txtAge.Text = dgvStudents.CurrentRow.Cells["colAge"].Value.ToString();
                    cbClasses.SelectedValue = dgvStudents.CurrentRow.Cells["colClassID"].Value.ToString();
                }
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update Students " +
                         "set Name=N'" + txtHoTen.Text + "', Age=" + txtAge.Text + ", ClassID=" + cbClasses.SelectedValue + "" +
                         "where StudentID="+StudentID+"";
            //MessageBox.Show(sql.ToString());
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete Students where StudentID=" + StudentID + "";
            //MessageBox.Show(sql.ToString());
            cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            loadData();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
