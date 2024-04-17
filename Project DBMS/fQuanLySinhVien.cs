using Project_DBMS.DAO;
using Project_DBMS.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_DBMS
{
    public partial class fQuanLySinhVien : Form
    {
        public fQuanLySinhVien()
        {
            InitializeComponent();
            ShowListSinhVien();
            AddSinhVienBinding();
        }
        void ShowListSinhVien()
        {
            dataGridView.DataSource = SinhVienDAO.Instance.GetListSinhVien();
        }
        void AddSinhVienBinding()
        {
            MSSV_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaSV", true, DataSourceUpdateMode.Never));
            Name_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
            BirthDay_Date.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
            GioiTinhcb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
            Address_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
            sdt_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SDT", true, DataSourceUpdateMode.Never));

        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            string MSSV = MSSV_tb.Text;
            string Name = Name_tb.Text;
            string GioiTinh = GioiTinhcb.Text;
            string NgaySinh = BirthDay_Date.Text;
            string DiaChi = Address_tb.Text;
            string SDT = sdt_tb.Text;
            fThemSinhVienVaoPhongcs themSV = new fThemSinhVienVaoPhongcs(MSSV, Name, GioiTinh, NgaySinh, DiaChi, SDT);
            themSV.Show();

        }

        private void search_Btn_Click(object sender, EventArgs e)
        {
            string MaPhong = maPhong_tb.Text;
            if (MaPhong == "")
            {
                MessageBox.Show("Vui lòng nhập mã phòng", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView.DataSource = SinhVienDAO.Instance.FindSinhVienByRoom(MaPhong);
            }
        }
    }
}
