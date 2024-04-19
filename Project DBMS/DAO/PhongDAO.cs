using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;

namespace Project_DBMS.DAO
{
    public class PhongDAO
    {
        private static PhongDAO instance;

        public static PhongDAO Instance
        {
            get { if (instance == null) instance = new PhongDAO(); return instance; }
            private set { instance = value; }
        }
        private PhongDAO() { }
        public DataTable GetListPhong()
        {
            //select từ hai bảng!!!
            string query = "SELECT Phong.*, LoaiPhong.GiaTien\r\n" +
                "FROM Phong\r\n" +
                "JOIN LoaiPhong ON Phong.MaLoaiPhong = LoaiPhong.MaLoaiPhong;\r\n";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
    }
}
