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
    public partial class SinhVienHoaDon : Form
    {
        string TaiKhoan;
        public SinhVienHoaDon(string TaiKhoan)
        {
            InitializeComponent();
            this.TaiKhoan = TaiKhoan;
            ShowListHoaDon();
            AddHoaDonSVBinding();
        }
        void ShowListHoaDon()
        {
            SinhVienListHoaDon.DataSource = SVHoaDonDAO.Instance.GetListHoaDonSV(this.TaiKhoan);
        }
        void AddHoaDonSVBinding()
        {
            MaHoaDon_tb.DataBindings.Add(new Binding("Text", SinhVienListHoaDon.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            LoaiHoaDon_tb.DataBindings.Add(new Binding("Text", SinhVienListHoaDon.DataSource, "LoaiHoaDon", true, DataSourceUpdateMode.Never));
            NgayTao_tb.DataBindings.Add(new Binding("Text", SinhVienListHoaDon.DataSource, "NgayTaoHoaDon", true, DataSourceUpdateMode.Never));
            PTTT_tb.DataBindings.Add(new Binding("Text", SinhVienListHoaDon.DataSource, "PhuongThucThanhToan", true, DataSourceUpdateMode.Never));
            MoneyTB.DataBindings.Add(new Binding("Text", SinhVienListHoaDon.DataSource, "SoTien", true, DataSourceUpdateMode.Never));
            thanhToan_check.DataBindings.Add(new Binding("Checked", SinhVienListHoaDon.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));

        }

        private void SinhVienListHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
