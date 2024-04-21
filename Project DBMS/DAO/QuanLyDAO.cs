using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class QuanLyDAO
    {
        private static QuanLyDAO instance;

        public static QuanLyDAO Instance
        {
            get { if (instance == null) instance = new QuanLyDAO(); return instance; }
            private set { instance = value; }
        }
        private QuanLyDAO() { }
        public DataTable GetQuanLy(string TaiKhoan)
        {
            string query = "Select MaQL, HoTen, MaTangQL,TaiKhoan, MatKhau  from dbo.QuanLy, dbo.TaiKhoan where QuanLy.MaQL ='" + TaiKhoan + "' and QuanLy.MaQL = TaiKhoan.TaiKhoan";
            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
