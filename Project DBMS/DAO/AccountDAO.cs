using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class AccountDAO
    {
        private static AccountDAO instance;

        public static AccountDAO Instance
        {
            get { if (instance == null) instance = new AccountDAO(); return instance; }
            private set { instance = value; }
        }
        private AccountDAO() { }
        public bool Login(string TaiKhoan, string MatKhau)
        {
            string query = "Select * from TaiKhoan Where TaiKhoan='" + TaiKhoan + "'AND MatKhau='" + MatKhau+"'";
            DataTable data = DataBase.Instance.Execute(query);
            return data.Rows.Count > 0;
        }
    }

}
