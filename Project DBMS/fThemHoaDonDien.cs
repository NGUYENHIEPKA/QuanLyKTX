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
    public partial class fThemHoaDonDien : Form
    {
        public fThemHoaDonDien()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string MaPhong = maPhong_tb.Text;
            string NgayTaoHoaDon = dateTimePicker.Text;
            string SoDienCu = oldNum_tb.Text;
            string SoDienMoi = newNum_tb.Text;
            if (MaPhong == "" || NgayTaoHoaDon == "" || SoDienCu == "" || SoDienMoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                QLHoaDonDAO.Instance.InsertHoaDonDien(MaPhong, NgayTaoHoaDon, SoDienCu, SoDienMoi);
            }
            this.Close();
        }
    }
}
