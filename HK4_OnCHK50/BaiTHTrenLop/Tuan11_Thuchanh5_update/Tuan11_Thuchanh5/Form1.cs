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

namespace Tuan11_Thuchanh5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int id;
        String strcon = "server=C603-10\\SQLEXPRESS; database=QLPB; uid=sa; pwd=system";
        SqlConnection conn;
        SqlCommand cmd;

        private void LoadGrid()
        {
            gridQLPB.Rows.Clear();
            string sql = "select * from PHONGBAN";
            cmd = new SqlCommand(sql, conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                int i = gridQLPB.Rows.Add();
                DataGridViewRow drr = gridQLPB.Rows[i];
                drr.Cells["ColMaPB"].Value = dr["MaPB"];
                drr.Cells["ColTenPB"].Value = dr["TenPB"];
                drr.Cells["ColMota"].Value = dr["MoTa"];
            }
            dr.Close();
        }
        // Load dữ liệu lên girdview
        private void Form1_Load(object sender, EventArgs e)
        {
            conn = new SqlConnection(strcon);
            conn.Open();
            LoadGrid();
        }

        // Điền giá trị cho STT
        private void gridQLPB_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            gridQLPB.Rows[e.RowIndex].Cells["ColSTT"].Value = e.RowIndex + 1;
        }

        // Nút thêm
        private void btnThem_Click(object sender, EventArgs e)
        {
            string sql = "insert into PHONGBAN(TenPB, MoTa) values(@TenPB, @Mota)";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenPB", tbTenPB.Text);
                cmd.Parameters.AddWithValue("@Mota", tbMota.Text);
                cmd.ExecuteNonQuery();
            }
            LoadGrid();
        }

        // Đổ dữ liệu từ gridview lên textbox
        private void gridQLPB_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            id          = (int) gridQLPB.CurrentRow.Cells["ColMaPB"].Value;
            tbTenPB.Text    =   gridQLPB.CurrentRow.Cells["ColTenPB"].Value.ToString();
            tbMota.Text     =   gridQLPB.CurrentRow.Cells["ColMota"].Value.ToString();

        }

        // Nút xóa
        private void btnXoa_Click(object sender, EventArgs e)
        {
            using (SqlCommand cmd = new SqlCommand("delete PHONGBAN where MaPB=@id", conn))
            {
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadGrid();
        }

        // Nút đóng
        private void btnThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string sql = "update PHONGBAN set TenPB=@TenPB, MoTa=@Mota where MaPB=@id";
            using (SqlCommand cmd = new SqlCommand(sql, conn))
            {
                cmd.Parameters.AddWithValue("@TenPB", tbTenPB.Text);
                cmd.Parameters.AddWithValue("@Mota", tbMota.Text);
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }
            LoadGrid();
        }

        private void gridQLPB_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            id = (int)gridQLPB.CurrentRow.Cells["ColMaPB"].Value;
            tbTenPB.Text = gridQLPB.CurrentRow.Cells["ColTenPB"].Value.ToString();
            tbMota.Text = gridQLPB.CurrentRow.Cells["ColMota"].Value.ToString();
        }
    }
}
