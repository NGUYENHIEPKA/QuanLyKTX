using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string query = "SELECT * from TaiKhoan WHERE TaiKhoan='" + TaiKhoan + "'AND MatKhau='" + MatKhau + "'";
            DataTable data = DataBase.Instance.Execute(query);
            return data.Rows.Count > 0;
        }
        public void sua(string taikhoan, string matkhaucu, string matkhaumoi, string matkhaumoi1)
        {
            string sqlStr = string.Format("UTP_DoiMatKhau @TaiKhoan , @MatKhauCu , @MatKhauMoi1 , @MatKhauMoi2 ");
            try
            {
                DataBase.Instance.ExecuteNonQuery(sqlStr, new object[] { taikhoan, matkhaucu, matkhaumoi, matkhaumoi1 });
                MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }   
        }
    }
}
