using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Windows.Forms;
using System.Data.SqlClient;

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

        public void AddPhong(string MaPhong, string MaTang, string MaLoaiPhong, string LoaiPhong, int SoNguoi)
        {
            string query = string.Format("UTP_ThemPhong @MaPhong , @MaTang , @MaLoaiPhong , @LoaiPhong , @SoNguoi ");
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaPhong, MaTang, MaLoaiPhong, LoaiPhong, SoNguoi });
                MessageBox.Show("Thêm phòng thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }
        }

        public void UpdatePhong(string MaPhong, string MaTang, string MaLoaiPhong, string LoaiPhong, int SoNguoi)
        {
            string query = string.Format("UTP_SuaPhong @MaPhong , @MaTang , @MaLoaiPhong , @LoaiPhong , @SoNguoi ");

            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaPhong, MaTang, MaLoaiPhong, LoaiPhong, SoNguoi });
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }
        }
        public void DeletePhong(string maPhong)
        {
            string query = string.Format("UTP_XoaPhong @MaPhong ");
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { maPhong });
                MessageBox.Show("Xóa phòng thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }
        }

        public DataTable FindRoom(string MaPhong)
        {
            if(MaPhong == "")
            {
                string query = "Select * from dbo.Phong";

                DataTable data = DataBase.Instance.Execute(query);
                return data;
            }
            else if( MaPhong != "")
            {
                string query = "Select * from dbo.Phong Where MaPhong = '" + MaPhong + "'";

                DataTable data = DataBase.Instance.Execute(query);
                return data;
            }
            else
            {
                return new DataTable();
            }

            
        }

    }
}
