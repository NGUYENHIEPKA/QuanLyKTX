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
    public partial class fThemHoaDonNuoc : Form
    {
        public fThemHoaDonNuoc()
        {
            InitializeComponent();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string MaPhong = maPhong_tb.Text;
            string NgayTaoHoaDon = dateTimePicker.Text;
            string SoNuocCu = oldNum_tb.Text;
            string SoNuocMoi = newNum_tb.Text;
            if (MaPhong == "" || NgayTaoHoaDon == "" || SoNuocCu == "" || SoNuocMoi == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                QLHoaDonDAO.Instance.InsertHoaDonNuoc(MaPhong, NgayTaoHoaDon, SoNuocCu, SoNuocMoi);
            }
        }
    }
}
