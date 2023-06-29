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

namespace QuanLyNhanVien
{
    public partial class DanhMucPhongBan : Form
    {
        public DanhMucPhongBan()
        {
            InitializeComponent();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        string strcon = @"server= DESKTOP-UDG1TOM\SQLEXPRESS; database=QLPB2; uid=sa; pwd=123456";
        SqlConnection conn;
        int id;
        DataSet ds;
        int MaPB;
        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "ThemPB";
            cmd.Parameters.AddWithValue("@TenPB", txtTenPB.Text);
            cmd.Parameters.AddWithValue("@MoTa", txtMota.Text);
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void LoadData()
        {
            SqlDataAdapter da = new SqlDataAdapter("select * from PHONGBAN", conn);
            ds = new DataSet();
            da.Fill(ds, "PhongBan");
            dgvPB.DataSource = ds.Tables["PhongBan"];
        }

        private void DanhMucPhongBan_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            conn.Open();
            LoadData();
        }


        private void dgvPB_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPB.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtTenPB.Text = dgvPB.CurrentRow.Cells["colTenPB"].Value.ToString();
            txtMota.Text = dgvPB.CurrentRow.Cells["colMoTa"].Value.ToString();
            MaPB = int.Parse(dgvPB.CurrentRow.Cells["colMaPB"].Value.ToString());
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "CapNhatPB";
            cmd.Parameters.AddWithValue("@id", MaPB);
            cmd.Parameters.AddWithValue("@Ten", txtTenPB.Text);
            cmd.Parameters.AddWithValue("@MT", txtMota.Text);
            cmd.ExecuteNonQuery();
            LoadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "XoaPB";
            cmd.Parameters.AddWithValue("@id", MaPB);
            cmd.ExecuteNonQuery();
            LoadData();
        }
    }
}
