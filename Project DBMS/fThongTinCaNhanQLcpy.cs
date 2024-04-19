using Project_DBMS.DAO;
using Project_DBMS.DTO;
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
    public partial class fThongTinCaNhanQLcpy : Form
    {
        public fThongTinCaNhanQLcpy()
        {
            InitializeComponent();
            LoadData();
        }
        public void LoadData()
        {
            // Lấy tên tài khoản từ TextBox tentk_tb
            string tentk = tentk_tb.Text;

            // Kiểm tra điều kiện tentk có trống hay không
            if (string.IsNullOrEmpty(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản để kiểm tra.");
                return;
            }

            // Lấy danh sách quản lý từ QuanLyDAO dựa trên tên tài khoản
            DataTable quanLyData = QuanLyDAO.Instance.GetListQuanLy();

            // Kiểm tra xem có dữ liệu trong bảng hay không
            if (quanLyData.Rows.Count > 0)
            {
                // Lấy hàng dữ liệu đầu tiên
                DataRow row = quanLyData.Rows[0];

                // Gán dữ liệu vào TextBox
                maQL_tb.Text = row["MaQL"].ToString();
                tenQL_tb.Text = row["HoTen"].ToString();
                matangQL_tb.Text = row["MaTangQL"].ToString();
            }
            else
            {
                // Xử lý khi không có dữ liệu trong bảng QuanLy
                MessageBox.Show("Không tìm thấy dữ liệu phù hợp cho tên tài khoản này.");
            }
        }

        private void ChangeImg_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;)|*.BMP;*.JPG;*.GIF;*.PNG;";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK) //Chưa cập nhật hình ảnh vào lại  database
                {
                    try
                    {
                        ImgQL_ptbox.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở tập tin: " + ex.Message);
                    }
                }
            }
        }

        private void guna2ImageRadioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ImageRadioButton1.Checked)
            {
                mkQL_tb.PasswordChar = '\0';
                newMK1_tb.PasswordChar = '\0';
                newMK2_tb.PasswordChar = '\0';
            }
            else
            {
                mkQL_tb.PasswordChar = '*';
                newMK1_tb.PasswordChar = '*';
                newMK2_tb.PasswordChar = '*';
            }
        }

        private void ChangePassword_Btn_Click(object sender, EventArgs e)
        {
            // Thieu dieu kien kiem tra mat khau hien tai co giong voi mk luu trong database chua

            string newPassword = newMK1_tb.Text;
            string confirmPassword = newMK2_tb.Text;

            if (newPassword == confirmPassword)
            {
                //Thay doi mat khau va thuc hien luu vao database, chua lam!

                MessageBox.Show("Thay đổi mật khẩu thành công!");
            }
            else
            {
                MessageBox.Show("Mật khẩu mới và xác nhận mật khẩu không khớp. Vui lòng thử lại.");
            }
        }
    }
}
