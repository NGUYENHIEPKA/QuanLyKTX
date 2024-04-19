using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class SVHoaDonDAO
    {
        private static SVHoaDonDAO instance;

        public static SVHoaDonDAO Instance
        {
            get { if (instance == null) instance = new SVHoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private SVHoaDonDAO() { }
        public DataTable GetListHoaDonSV(string TaiKhoan)
        {
            string query = "select MaHoaDon,HoaDon.MaPhong,SoTien,PhuongThucThanhToan,LoaiHoaDon,TrangThai,NgayTaoHoaDon from HoaDon,SinhVien where SinhVien.MaSV = '" + TaiKhoan + "'and SinhVien.MaPhong = HoaDon.MaPhong";
            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
