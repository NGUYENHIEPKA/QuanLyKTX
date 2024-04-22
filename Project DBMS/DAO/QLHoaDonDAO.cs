using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class QLHoaDonDAO
    {
        private static QLHoaDonDAO instance;

        public static QLHoaDonDAO Instance
        {
            get { if (instance == null) instance = new QLHoaDonDAO(); return instance; }
            private set { instance = value; }
        }
        private QLHoaDonDAO() { }
        public DataTable GetListHoaDon()
        {
            string query = "SELECT * FROM XemListHoaDon();";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public DataTable GetListHoaDonNuoc()
        {
            string query = "Select * FROM XemListHoaDonNuoc();";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public DataTable GetListHoaDonDien()
        {
            string query = "Select * from XemListHoaDonDien();";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public void InsertHoaDonNuoc(string MaPhong, string NgayTaoHoaDon, string SoNuocCu, string SoNuocMoi)
        {
            string query = "InsertTienNuoc @MaPhong , @NgayTaoHoaDon , @SoNuocDauThang , @SoNuocCuoiThang";

            DataBase.Instance.ExecuteNonQuery(query, new object[] { MaPhong, NgayTaoHoaDon, SoNuocCu, SoNuocMoi });
        }
        public void InsertHoaDonDien(string MaPhong, string NgayTaoHoaDon, string SoDienCu, string SoDienMoi)
        {
            string query = "InsertTienDien @MaPhong , @NgayTaoHoaDon , @SoDienDauThang , @SoDienCuoiThang";

            DataBase.Instance.ExecuteNonQuery(query, new object[] { MaPhong, NgayTaoHoaDon, SoDienCu, SoDienMoi });
        }
    }
}
