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
using System.Xml.Linq;

namespace Project_DBMS
{
    public partial class fQuanLyPhong : Form
    {
        public fQuanLyPhong()
        {
            InitializeComponent();
            ShowListPhong();
            AddPhongnBinding();          
        }       

        void ShowListPhong()
        {
            dataGridView.DataSource = PhongDAO.Instance.GetListPhong();
        }
        void AddPhongnBinding()
        {
            Matang_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaTang", true, DataSourceUpdateMode.Never));
            MaPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            MaLoaiPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaLoaiPhong", true, DataSourceUpdateMode.Never));
            LoaiPhong_cb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "LoaiPhong", true, DataSourceUpdateMode.Never));
            SVHT_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoNguoi", true, DataSourceUpdateMode.Never));
            GiaPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));

        }
        void ClearPhongBinding()
        {
            Matang_tb.DataBindings.Clear();
            MaPhong_tb.DataBindings.Clear();
            MaLoaiPhong_tb.DataBindings.Clear();
            LoaiPhong_cb.DataBindings.Clear();
            SVHT_tb.DataBindings.Clear();
            GiaPhong_tb.DataBindings.Clear();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            // Thu thập dữ liệu từ các điều khiển giao diện người dùng
            string maPhong = MaPhong_tb.Text;
            string maTang = Matang_tb.Text;
            string maLoaiPhong = MaLoaiPhong_tb.Text;
            string loaiPhong = LoaiPhong_cb.Text;
            int soNguoi = int.Parse(SVHT_tb.Text);
            //int giaTien = int.Parse(GiaPhong_tb.Text);

            // Gọi phương thức AddPhong từ PhongDAO
            /*bool success =*/ PhongDAO.Instance.AddPhong(maPhong, maTang, maLoaiPhong, loaiPhong, soNguoi);

            // Nếu thêm thành công, làm mới danh sách và thông báo cho người dùng
            ClearPhongBinding();
            ShowListPhong(); // Làm mới danh sách phòng

        }


        private void Update_Btn_Click(object sender, EventArgs e)
        {
            string MaTang = Matang_tb.Text;
            string MaPhong = MaPhong_tb.Text;
            string MaloaiPhong = MaLoaiPhong_tb.Text;
            string LoaiPhong = LoaiPhong_cb.Text;
            string SoNguoi = SVHT_tb.Text;
            string GiaPhong = GiaPhong_tb.Text;
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {

        }

        private void Renew_Btn_Click(object sender, EventArgs e)
        {
            ClearPhongBinding();
            ShowListPhong();
            AddPhongnBinding();
        }

        private void Matang_tb_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaPhong_tb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
