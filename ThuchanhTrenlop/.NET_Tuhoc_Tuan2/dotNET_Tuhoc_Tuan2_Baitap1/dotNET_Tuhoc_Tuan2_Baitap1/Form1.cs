namespace dotNET_Tuhoc_Tuan2_Baitap1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "user" && txtPassword.Text == "123")
            {
                MessageBox.Show("Đăng nhập thành công!", "");
            }
            else
            {
                MessageBox.Show("Bạn hãy nhập lại!", "Thông báo");
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn thoát không?", "Lưu ý!!!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(res == DialogResult.Yes)
            {
                Application.Exit();
            } 
        }
    }
}