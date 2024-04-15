using Project_DBMS.DAO;
using Project_DBMS.DTO;
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

        }
    }
}
