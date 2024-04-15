using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DAO
{
    public class SinhVienDAO
    {
        private static SinhVienDAO instance;

        public static SinhVienDAO Instance
        {
            get { if (instance == null) instance = new SinhVienDAO(); return instance; }
            private set { instance = value; }
        }
        private SinhVienDAO() { }
        public DataTable GetListSinhVien()
        {
            string query = "Select * from dbo.SinhVien";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
