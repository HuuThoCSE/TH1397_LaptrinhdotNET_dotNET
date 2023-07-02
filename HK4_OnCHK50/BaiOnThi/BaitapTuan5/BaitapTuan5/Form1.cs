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

namespace BaitapTuan5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into PHONGBAN values('" + txtTenPB.Text + "', N'" + txtMota.Text + "')";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            LoadGrid();
        }

        int id;

        SqlConnection conn;

        string strcon = "server=DESKTOP-TKLNL00; database=QLPB; uid=sa; pwd=123456";

        private void LoadGrid()
        {
            dgvPB.Rows.Clear();
            string sql = "select * from PHONGBAN";
            SqlCommand cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int i = dgvPB.Rows.Add();
                DataGridViewRow drr = dgvPB.Rows[i];
                drr.Cells["colMaPB"].Value = dr["MaPB"];
                drr.Cells["colTenPB"].Value = dr["TenPB"];
                drr.Cells["colMoTa"].Value = dr["MoTa"];
            }
            dr.Close();
        }

        private void dgvPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //conn = new SqlConnection(strcon);
            //conn.Open();
            //LoadGrid();
        }

        private void dgvPB_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            dgvPB.Rows[e.RowIndex].Cells["colSTT"].Value = e.RowIndex + 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            conn.Open();
            LoadGrid();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update PHONGBAN set TenPB=N'"+txtTenPB.Text+"', MoTa=N'"+txtMota.Text+"' where MaPB="+id+"";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            LoadGrid();
        }

        private void dgvPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)dgvPB.CurrentRow.Cells["colMaPB"].Value;
            txtTenPB.Text = dgvPB.CurrentRow.Cells["colTenPB"].Value.ToString();
            txtMota.Text = dgvPB.CurrentRow.Cells["colMoTa"].Value.ToString();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string sql = "delete PHONGBAN where MaPB=" + id + "";
            SqlCommand cmd = new SqlCommand(sql, conn);
            cmd.ExecuteNonQuery();
            LoadGrid();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Thông báo", "Bạn chắc chắn muốn thoát?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Application.Exit();
            }
        }
    }
}
