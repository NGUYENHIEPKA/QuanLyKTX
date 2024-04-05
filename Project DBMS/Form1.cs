namespace Project_DBMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void RegisterBT_Click(object sender, EventArgs e)
        {
            DangKy DangKy = new DangKy();
            this.Hide();

            // Hiển thị form đăng ký dưới dạng một cửa sổ modal
            DangKy.ShowDialog();
            this.Close();
        }
    }
}
