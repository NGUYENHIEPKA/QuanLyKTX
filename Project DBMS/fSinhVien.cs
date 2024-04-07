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

        private void UserInformationBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin cá nhân";
        }

        private void ContactBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin liên lạc";
        }

        private void AccommodationBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin lưu trú";
        }

        private void RequestBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin yêu cầu sửa chữa";
        }
    }
}
