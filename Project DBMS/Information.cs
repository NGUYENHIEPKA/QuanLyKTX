using Project_DBMS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class Information : Form
    {
        string TaiKhoan;
        public Information(string TaiKhoan)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
            DisplayStudentInfo();
        }
        private void DisplayStudentInfo()
        {
            DataTable dt = ThongTinSinhVien.Instance.HienThongTinSV(this.TaiKhoan);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                MSSVLB.Text = row["MaSV"].ToString();
                NameLB.Text = row["HoTen"].ToString();
                BirthdayLB.Text = Convert.ToDateTime(row["NgaySinh"]).ToString("dd/MM/yyyy");
                GioitinhLB.Text = row["GioiTinh"].ToString();
                DiachiLB.Text = row["DiaChi"].ToString();
                SdtLB.Text = row["SDT"].ToString();
                PhongLB.Text = row["MaPhong"].ToString();
                TangLB.Text = row["MaTang"].ToString();

                byte[] imageData = (byte[])row["HinhAnh"];
                Image image;
                using (MemoryStream ms = new MemoryStream(imageData))
                {
                    image = Image.FromStream(ms);
                }
                ImgSV_ptbox.Image = image;
            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin sinh viên.");
            }
        }



        private void guna2GradientPanel4_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
