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
            string query = "Select * from dbo.HoaDon";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
