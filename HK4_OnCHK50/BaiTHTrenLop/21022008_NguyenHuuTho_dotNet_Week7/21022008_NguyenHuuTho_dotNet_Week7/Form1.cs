using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace _21022008_NguyenHuuTho_dotNet_Week7
{
    public partial class Form1 : Form
    {
        string strcon = @"server=DESKTOP-UDG1TOM\SQLEXPRESS; database=QLPB_21022008; uid=sa; pwd=123456";

        SqlConnection conn;

        int id, idPB;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            DialogResult rs = MessageBox.Show("Bạn có muốn thoát?", "Thông báo!", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(rs == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void Loadgrid()
        {
            using(SqlConnection conn = new SqlConnection(strcon)) {
                conn.Open();
                SqlDataAdapter da = new SqlDataAdapter("select NHANVIEN.*, PHONGBAN.TenPB from NHANVIEN, PHONGBAN where NHANVIEN.MaPB = PHONGBAN.MaPB", conn);
                DataSet ds = new DataSet();
                da.Fill(ds, "NhV");

                if(dgvThTNhV.CurrentRow != null)
                {
                    tbHoten.Text = dgvThTNhV.CurrentRow.Cells["colHoten"].Value.ToString();
                    dtpNgaysinh.Text = dgvThTNhV.CurrentRow.Cells["colNgaySinh"].Value.ToString();
                    int.TryParse(dgvThTNhV.CurrentRow.Cells["colMaNV"].Value.ToString(), out id);
                }

                dgvThTNhV.DataSource = ds.Tables["NhV"];
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using(SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();
                SqlDataAdapter dap = new SqlDataAdapter("select * from PHONGBAN", conn);
                DataSet ds = new DataSet();
                dap.Fill(ds, "DsPB");

                cbPB.DataSource = ds.Tables["DsPB"];
                cbPB.DisplayMember = "TenPB";
                cbPB.ValueMember = "MaPB";
            }
            
            Loadgrid();
        }

        private void dgvThTNhV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgvThTNhV.CurrentRow.Cells["colMaNV"].Value;
            tbHoten.Text = dgvThTNhV.CurrentRow.Cells["colHoTen"].Value.ToString();
            dtpNgaysinh.Value = ((DateTime)dgvThTNhV.CurrentRow.Cells["colNgaysinh"].Value).Date;
            cbPB.SelectedValue = dgvThTNhV.CurrentRow.Cells["colMaPB"].Value;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Insert_NV";
                cmd.Parameters.AddWithValue("HoTen", tbHoten.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtpNgaysinh.Value);
                cmd.Parameters.AddWithValue("MaPB", (int)cbPB.SelectedValue);
                cmd.ExecuteNonQuery();
                Loadgrid();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Update_NV";
                cmd.Parameters.AddWithValue("HoTen", tbHoten.Text);
                cmd.Parameters.AddWithValue("NgaySinh", dtpNgaysinh.Value);
                cmd.Parameters.AddWithValue("MaPB", (int)cbPB.SelectedValue);
                cmd.Parameters.AddWithValue("MaNV", id);
                cmd.ExecuteNonQuery();
                Loadgrid();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection conn = new SqlConnection(strcon))
            {
                conn.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "Delete_NV";
                cmd.Parameters.AddWithValue("MaNV", id);
                cmd.ExecuteNonQuery();
                Loadgrid();
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            tbHoten.Clear();
            dtpNgaysinh.Value = DateTime.Now;
            cbPB.SelectedValue = 0;
        }
    }
}
