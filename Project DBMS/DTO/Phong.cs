using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class Phong
    {
        public Phong()
        {
            
        }

        private string maPhong;
        public string MaPhong { get => maPhong; set => maPhong = value; }
        
        private string maTang;
        public string MaTang { get => maTang; set => maTang = value; }
        
        private string maLoaiPhong;
        public string MaLoaiPhong { get => maLoaiPhong; set => maLoaiPhong = value; }
       
        private string loaiPhong;
        public string LoaiPhong { get => loaiPhong; set => loaiPhong = value; }
 
        private int soNguoi;
        public int SoNguoi { get => soNguoi; set => soNguoi = value; }

        private int giaTien;
        public int GiaTien { get => giaTien; set => giaTien = value; }

        public Phong(string maPhong, string maTang, string maLoaiPhong, string loaiPhong, int soNguoi, int giaTien)
        {
            this.MaPhong = maPhong;
            this.MaTang = maTang;
            this.MaLoaiPhong = maLoaiPhong;
            this.LoaiPhong= loaiPhong;
            this.SoNguoi = soNguoi;
            this.GiaTien = giaTien;
        }
        public Phong(DataRow row)
        {
            this.maPhong = (string)row["MaPhong"];
            this.maTang = (string)row["MaTang"];
            this.maLoaiPhong = (string)row["MaLoaiPhong"];
            this.loaiPhong = (string)row["LoaiPhong"];
            this.soNguoi = (int)row["SoNguoi"];
            this.giaTien = (int)row["GiaTien"];
        }
    }
}
