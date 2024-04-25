using Project_DBMS.DAO;
using System.Web;

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


        private void LoginBT_Click(object sender, EventArgs e)
        {
            string Taikhoan = UserTB.Text;
            string Matkhau = PassTB.Text;
            if(AccountDAO.Instance.Login(Taikhoan, Matkhau)== true)
            {
                if(Ktra(Taikhoan)=="QL")
                {
                    DataBase.Instance.DangNhap(Taikhoan, Matkhau);
                    fQuanLy fQuanLy = new fQuanLy();
                    fQuanLy.TextBoxValue = UserTB.Text;
                    this.Hide();
                    fQuanLy.ShowDialog();
                    this.Show();
                }
                else if(Ktra(Taikhoan)=="SV")
                {
                    DataBase.Instance.DangNhap(Taikhoan, Matkhau);
                    fSinhVien fSinhVien = new fSinhVien();
                    fSinhVien.TextBoxValue = UserTB.Text;
                    this.Hide();
                    fSinhVien.ShowDialog();
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Sai tài khoản mật khẩu");
            }
        }
        private string Ktra(string Id)
        {
            return Id.Substring(0, 2);
        }
    }
}
