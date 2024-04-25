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
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void CreateBT_Click(object sender, EventArgs e)
        {
            string MaSoSV = MSSVTB.Text;
            string HoTen = NameTB.Text;
            string GioiTinh = GioiTinhTB.Text;
            string NgaySinh = birthday_date.Text;
            string Address = DiaChiTB.Text;
            string Sdt = SDTTB.Text;

            if (MaSoSV == "" || HoTen == "" || GioiTinh == "" || NgaySinh == "" || Address == "" || Sdt == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else 
            {
                if (MaSoSV.Substring(0, 2) == "SV")
                {
                    SinhVienDAO.Instance.DangKySinhVien(MaSoSV, HoTen, GioiTinh, NgaySinh, Address, Sdt);
                }
                else
                {
                    MessageBox.Show("Vui lòng nhập đúng mã số sinh viên", "Thông báo", MessageBoxButtons.OK);
                }
            }
        }
    }
}
