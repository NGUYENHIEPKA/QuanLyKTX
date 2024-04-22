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
        string TaiKhoan;
        public fThongTinCaNhanQLcpy(string TaiKhoan)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
            DisplayStudentInfo();

        }
        private void DisplayStudentInfo()
        {
            DataTable dt = QuanLyDAO.Instance.GetQuanLy(this.TaiKhoan);
            if (dt.Rows.Count > 0)
            {
                DataRow row = dt.Rows[0];
                maQL_tb.Text = row["MaQL"].ToString();
                tenQL_tb.Text = row["HoTen"].ToString();
                matangQL_tb.Text = row["MaTangQL"].ToString();
                tentk_tb.Text = row["TaiKhoan"].ToString();
                mkQL_tb.Text = row["MatKhau"].ToString();

            }
            else
            {
                MessageBox.Show("Không tìm thấy thông tin quản lý.");
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

                if (openFileDialog.ShowDialog() == DialogResult.OK) //Chưa cập nhật hình ảnh vào lại database
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

        }

        private void ChangePassword_Btn_Click(object sender, EventArgs e)
        {           
            string taiKhoan = tentk_tb.Text;
            string matKhau = mkQL_tb.Text;
            string newPassword = newMK1_tb.Text;
            string confirmPassword = newMK2_tb.Text;
            AccountDAO.Instance.sua(taiKhoan, matKhau, newPassword, confirmPassword);            
        }

        private void guna2GroupBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2CustomGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2ImageCheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2ImageCheckBox1.Checked)
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
    }
}
