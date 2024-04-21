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
            CustomizeDesign();
        }
        private void CustomizeDesign()
        {
            panelbill.Visible = false;
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
        private void hideware()
        {
            if (panelbill.Visible == true)
            {
                panelbill.Visible = false;
            }
        }
        private void showware(Panel subware)
        {
            if (subware.Visible == false)
            {
                hideware();
                subware.Visible = true;
            }
            else
            {
                subware.Visible = false;
            }
        }
        private void UserInformationBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Thông tin cá nhân";
            container(new fThongTinCaNhanQL());
        }

        private void RoomBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Quản lý phòng";
            container(new fQuanLyPhong());
        }

        private void StudentBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Quản lý sinh viên";
            container(new fQuanLySinhVien());
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            label_value.Text = "Quản lý hóa đơn";
            showware(panelbill);
        }

        private void SumBill_Btn_Click(object sender, EventArgs e)
        {
            container(new fQuanLyHoaDon());
            hideware();
        }

        private void WaterBill_Btn_Click(object sender, EventArgs e)
        {
            hideware();
        }

        private void ElectricBill_Btn_Click(object sender, EventArgs e)
        {
            hideware();
        }
    }
}
