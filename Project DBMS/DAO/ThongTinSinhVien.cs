using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class ThongTinSinhVien
    {
        private static ThongTinSinhVien instance;

        public static ThongTinSinhVien Instance
        {
            get { if (instance == null) instance = new ThongTinSinhVien(); return instance; }
            private set { instance = value; }
        }
        private ThongTinSinhVien() { }
        public DataTable HienThongTinSV(string TaiKhoan)
        {
            string query = "Select * from dbo.SinhVien Where MaSV= '" + TaiKhoan + "'";
            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }

}
