using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_DBMS.DTO
{
    public class QuanLy
    {
        private string maQuanLy;
        public string MaQuanLy { get => maQuanLy; set => maQuanLy = value; }

        private string hoTen;
        public string HoTen { get => hoTen; set => hoTen = value; }

        private string maTangQL;
        public string MaTangQL { get => maTangQL; set => maTangQL = value; }      

        public QuanLy(string maQuanLy, string hoTen, string maTangQL)
        {
            this.MaQuanLy = maQuanLy;
            this.HoTen = hoTen;
            this.MaTangQL = maTangQL;          
        }
        public QuanLy(DataRow row)
        {
            this.maQuanLy = (string)row["MaQL"];
            this.hoTen = (string)row["HoTen"];
            this.maTangQL = (string)row["MaTangQL"];
        }
    }
}
