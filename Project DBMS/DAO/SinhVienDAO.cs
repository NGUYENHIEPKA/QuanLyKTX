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
            string query = "Select * from XemDanhSachSinhVien()";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }
        public DataTable FindSinhVienByRoom(string MaPhong)
        {
            string query = "Select * from dbo.SinhVien Where MaPhong = '" + MaPhong + "'";

            DataTable data = DataBase.Instance.Execute(query);
            return data;
        }


        public void AddPhongSinhVien(string MSSV, string MaPhong, string MaTang)
        {
            string query = string.Format("UTP_CapNhatChoOSinhVien @MaSV , @MaPhong , @MaTang ");
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MSSV, MaPhong, MaTang });
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }
        }
        public void UpdateThongTinSinhVien (string MSSV, string Name, string NgaySinh, string GioiTinh, string DiaChi, string SDT)
        {
            string query = string.Format("UTP_CapNhatThongTinSinhVien @MaSV , @HoTen , @NgaySinh , @GioiTinh , @DiaChi , @SDT ");

            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MSSV, Name, NgaySinh, GioiTinh, DiaChi, SDT });
                MessageBox.Show("Cập nhật thành công", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error :" + ex.Message, "Message");
            }
        }

        public void XoaSinhVien (string MSSV)
        {
            string query = "UTP_XoaSinhVien @MaSV ";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MSSV });
                MessageBox.Show("Xóa sinh viên thành công!", "Thông báo", MessageBoxButtons.OK);
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }
        public void DangKySinhVien (string MaSoSV ,string HoTen, string GioiTinh, string NgaySinh, string Address, string Sdt)
        {
            string query = "DangKyTaiKhoanSinhVien @MaSV , @HoTen , @GioiTinh , @NgaySinh , @DiaChi , @SDT";
            try
            {
                DataBase.Instance.ExecuteNonQuery(query, new object[] { MaSoSV, HoTen, GioiTinh, NgaySinh, Address, Sdt });
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
            }
        }
    }
}
