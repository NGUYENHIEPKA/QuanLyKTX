using Guna.UI2.WinForms;
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
    public partial class fSinhVien : Form
    {
        public fSinhVien()
        {
            InitializeComponent();
        }
        public string TextBoxValue { get; set; }
        private void UserInformationBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin cá nhân";
            Thongtincanhan(new Information(this.TextBoxValue));
        }

        private void HoaDonBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Hóa đơn";
            Hienthihoadon(new SinhVienHoaDon(this.TextBoxValue));
        }

        private void NoiQuyBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Nội quy";
            Hiennoiquy(new XemNoiQuy());
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin yêu cầu sửa chữa";
            HienSuaChua(new SinhVienSuaChua());
        }
        private void DoiPassBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Đổi mật khẩu";
            HienDoiPass(new ChangePassword());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Thongtincanhan(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }
        private void Hienthihoadon(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }
        private void Hiennoiquy(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }
        private void HienDoiPass(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }
        private void HienSuaChua(object _form)
        {
            if (guna2Panel_container.Controls.Count > 0) guna2Panel_container.Controls.Clear();
            Form fm = _form as Form;
            fm.TopLevel = false;
            fm.FormBorderStyle = FormBorderStyle.None;
            fm.Dock = DockStyle.Fill;
            guna2Panel_container.Controls.Add(fm);
            guna2Panel_container.Tag = fm;
            fm.Show();
        }
    }
}
