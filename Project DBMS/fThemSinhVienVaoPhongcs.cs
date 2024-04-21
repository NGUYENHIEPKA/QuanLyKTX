using Guna.UI2.WinForms.Enums;
using Project_DBMS.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class fThemSinhVienVaoPhongcs : Form
    {
        string MSSV;
        string Name;
        string GioiTinh;
        string NgaySinh;
        string DiaChi;
        string SDT;
        string MaPhong;
        string MaTang;
        public fThemSinhVienVaoPhongcs(string MSSV, string Name, string GioiTinh, string NgaySinh, string DiaChi, string SDT, string MaPhong, string MaTang)
        {
            InitializeComponent();
            this.MSSV = MSSV;
            this.Name = Name;
            this.GioiTinh = GioiTinh;
            this.NgaySinh = NgaySinh;
            this.DiaChi = DiaChi;
            this.SDT = SDT;
            this.MaPhong = MaPhong;
            this.MaTang = MaTang;
            Load();
        }
        private void Load()
        {
            this.MSSV_tb.Text = MSSV;
            this.Name_tb.Text = Name;
            this.GioiTinhcb.Text = GioiTinh;
            this.BirthDay_Date.Text = NgaySinh;
            this.Address_tb.Text = DiaChi;
            this.sdt_tb.Text = SDT;
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string MSSV = MSSV_tb.Text;
            string GioiTinh = GioiTinhcb.Text;
            string Name = Name_tb.Text;
            string DiaChi = Address_tb.Text;
            string SDT = sdt_tb.Text;
            string NgaySinh = BirthDay_Date.Text;
            string MaPhong = maPhong_tb.Text;
            string MaTang = maTang_tb.Text;
            if (MaPhong == "" && MaTang == "")
            {
                SinhVienDAO.Instance.UpdateThongTinSinhVien(MSSV, Name, NgaySinh, GioiTinh, DiaChi, SDT);
            }
            else
            {
                SinhVienDAO.Instance.AddPhongSinhVien(MSSV, MaPhong, MaTang);
            }
            this.Close();
        }
    }
}
