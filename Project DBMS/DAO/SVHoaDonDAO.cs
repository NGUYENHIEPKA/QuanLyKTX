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
        public DataTable GetListHoaDonSV()
        {
            string query = "SELECT MaHoaDon, LoaiHoaDon, NgayTaoHoaDon, PhuongThucThanhToan, SoTien, TrangThai " +
                            "FROM HoaDon WHERE MaPhong = 'A04';";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
