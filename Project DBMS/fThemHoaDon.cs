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
    public partial class fThemHoaDon : Form
    {
        private static int nextInvoiceNumber = 001;
        private static List<int> usedInvoiceNumbers = new List<int>();
        public fThemHoaDon()
        {
            InitializeComponent();
            Load();
        }
        void Load()
        {
            DataTable dt = QLHoaDonDAO.Instance.GetMaxIDBill();
            int tmp = int.Parse(dt.Rows[0][0].ToString());
            tmp += 1;
            maHoaDon_tb.Text = tmp.ToString();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string MaHoaDon = maHoaDon_tb.Text;
            string MaPhong = maPhong_tb.Text;
            string NgayTaoHoaDon = dateTimePicker.Text;
            string LoaiHoaDon = loaiHoaDon_tb.Text;
            string PhuongThucThanhToan = phuongThucThanhToan_tb.Text;
            if (MaHoaDon == "" || MaPhong == "" || NgayTaoHoaDon == "" || LoaiHoaDon == "" || PhuongThucThanhToan == "")
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin", "Thông báo", MessageBoxButtons.OK);
            }
            else
            {
                QLHoaDonDAO.Instance.InsertTongHoaDon(MaHoaDon, MaPhong, PhuongThucThanhToan, LoaiHoaDon, NgayTaoHoaDon);
                this.Close();
            }
        }
    }
}
