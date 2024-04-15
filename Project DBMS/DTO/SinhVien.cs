using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class SinhVien
    {
        private string maSV;
        public string MaSV { get =>  maSV; set => maSV = value;}
        private string hoTen;
        public string HoTen { get => hoTen; set => hoTen = value;}
        private DateTime ngaySinh;
        public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value;}
        private string diaChi;
        public string DiaChi { get => diaChi; set => diaChi = value; }
        private string gioiTinh;
        public string GioiTinh { get => gioiTinh; set => gioiTinh = value;}
        private string sdt;
        public string SDT { get => sdt; set => sdt = value;}
        private string maPhong;
        public string MaPhong { get => maPhong; set => maPhong = value;}
        private string maTang;
        public string MaTang { get => maTang; set => maPhong = value; }

        public SinhVien (string maSV, string hoTen, DateTime ngaySinh, string diaChi, string gioiTinh, string sdt, string maPhong, string maTang)
        {
            this.MaSV = maSV;
            this.HoTen = hoTen;
            this.NgaySinh = ngaySinh;
            this.DiaChi = diaChi;
            this.GioiTinh = gioiTinh;
            this.SDT = sdt;
            this.MaPhong = maPhong;
            this.MaTang = maTang;
        }
        public SinhVien(DataRow row)
        {
            this.MaSV = (string)row["MaSV"];
            this.HoTen = (string)row["HoTen"];
            this.NgaySinh = (DateTime)row["NgaySinh"];
            this.DiaChi = (string)row["DiaChi"];
            this.GioiTinh = (string)row["GioiTinh"];
            this.SDT = (string)row["SDT"];
            this.MaPhong = (string)row["MaPhong"];
            this.MaTang = (string)row["MaTang"];
        }
    }
}
