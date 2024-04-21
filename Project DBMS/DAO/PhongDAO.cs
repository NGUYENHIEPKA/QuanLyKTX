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

        public void AddPhong(string maPhong, string maTang, string maLoaiPhong, string loaiPhong, int soNguoi)
        {
            string query = "INSERT INTO Phong (MaPhong, MaTang, MaLoaiPhong, LoaiPhong, SoNguoi) " +
                           "VALUES (@MaPhong, @MaTang, @MaLoaiPhong, @LoaiPhong, @SoNguoi)";

            // Danh sách tham số cho truy vấn
            object[] parameters = new object[]
            {
                maPhong,
                maTang,
                maLoaiPhong,
                loaiPhong,
                soNguoi
            };

            try
            {
                DataBase.Instance.ExecuteNonQuery(query, parameters);
                MessageBox.Show("Phòng đã được thêm thành công.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Có lỗi xảy ra khi thêm phòng.");
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }



    }
}
