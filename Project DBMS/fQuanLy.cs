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
    public partial class fQuanLy : Form
    {
        public fQuanLy()
        {
            InitializeComponent();
        }
        private void container(object _form)
        {
            if (guna2Panel_container.Controls.Count >= 0)
            {
                guna2Panel_container.Controls.Clear();
            }
            Form form = _form as Form;
            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Left;
            guna2Panel_container.Controls.Add(form);
            guna2Panel_container.Tag = form;
            form.Show();
        }
        private void UserInformationBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin cá nhân";
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Quản lý phòng";
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Quản lý sinh viên";
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Quản lý hóa đơn";
        }
    }
}
