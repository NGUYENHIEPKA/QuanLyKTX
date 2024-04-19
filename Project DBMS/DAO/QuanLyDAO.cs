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
        public DataTable GetListQuanLy()
        {
            string query = "SELECT QuanLy.*, TaiKhoan.TaiKhoan\r\n" +
                "From QuanLy\r\n" +
                "JOIN TaiKhoan ON QuanLy.MaQL = TaiKhoan.TaiKhoan;\r\n";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
