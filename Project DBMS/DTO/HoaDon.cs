using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class HoaDon
    {
        private string maHoaDon;
        public string MaHoaDon { get => maHoaDon; set => maHoaDon = value; }
        private string maPhong;
        public string MaPhong { get => maPhong; set => maPhong = value; }
        private string soTien;
        public string SoTien { get => soTien; set => soTien = value; }
        private string phuongThucThanhToan;
        public string PhuongThucThanhToan {  get =>  phuongThucThanhToan; set => phuongThucThanhToan = value; }
        private string loaiHoaDon;
        public string LoaiHoaDon { get => loaiHoaDon; set => loaiHoaDon = value; }
        private string trangThai;
        public string TrangThai { get => trangThai; set => trangThai = value; }
        private string ngayTaoHoaDon;
        public string NgayTaoHoaDon { get => ngayTaoHoaDon; set => ngayTaoHoaDon = value; }
        public HoaDon(string maHoaDon, string maPhong, string soTien, string phuongThucThanhToan, string loaiHoaDon, string trangThai, string ngayTaoHoaDon)
        {
            this.MaHoaDon = maHoaDon;
            this.MaPhong = maPhong;
            this.SoTien = soTien;
            this.PhuongThucThanhToan = phuongThucThanhToan;
            this.LoaiHoaDon = loaiHoaDon;
            this.TrangThai = trangThai;
            this.NgayTaoHoaDon= ngayTaoHoaDon;
        }
        public HoaDon(DataRow row)
        {
            this.MaHoaDon = (string)row["MaHoaDon"];
            this.MaPhong = (string)row["MaPhong"];
            this.SoTien = (string)row["SoTien"];
            this.PhuongThucThanhToan = (string)row["PhuongThucThanhToan"];
            this.LoaiHoaDon = (string)row["LoaiHoaDon"];
            this.TrangThai = (string)row["TrangThai"];
            this.NgayTaoHoaDon = (string)row["NgayTaoHoaDon"];
        }
    }
}
