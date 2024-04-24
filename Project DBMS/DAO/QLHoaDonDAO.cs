using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            string query = "SELECT * FROM XemListHoaDon();";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public DataTable GetListHoaDonNuoc()
        {
            string query = "Select * FROM XemListHoaDonNuoc();";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public DataTable GetListHoaDonDien()
        {
            string query = "Select * from XemListHoaDonDien();";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public void InsertHoaDonNuoc(string MaPhong, string NgayTaoHoaDon, string SoNuocCu, string SoNuocMoi)
        {
            string query = "InsertTienNuoc @MaPhong , @NgayTaoHoaDon , @SoNuocDauThang , @SoNuocCuoiThang";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaPhong, NgayTaoHoaDon, SoNuocCu, SoNuocMoi });
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);

            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");

            }
        }
        public void InsertHoaDonDien(string MaPhong, string NgayTaoHoaDon, string SoDienCu, string SoDienMoi)
        {
            string query = "InsertTienDien @MaPhong , @NgayTaoHoaDon , @SoDienDauThang , @SoDienCuoiThang";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaPhong, NgayTaoHoaDon, SoDienCu, SoDienMoi });
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }
        }
        public void InsertTongHoaDon (string MaHoaDon, string MaPhong, string PhuongThucThanhToan, string LoaiHoaDon, string NgayTaoHoaDon)
        {
            string query = "InsertTongHoaDon @MaHoaDon , @MaPhong , @PhuongThucThanhToan , @LoaiHoaDon , @NgayTaoHoaDon ";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaHoaDon, MaPhong, PhuongThucThanhToan, LoaiHoaDon, NgayTaoHoaDon });
                MessageBox.Show("Thêm thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");

            }
        }
        public void UpdateHoaDon (string MaHoaDon, int TrangThai)
        {
            string query = "UpdateHoaDon @MaHoaDon , @TrangThai";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaHoaDon, TrangThai });
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");

            }
        }
        public void DeleteHoaDon (string MaHoaDon)
        {
            string query = "DeleteHoaDon @MaHoaDon";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaHoaDon });
                MessageBox.Show("Xóa thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");

            }
        }
    }
}
