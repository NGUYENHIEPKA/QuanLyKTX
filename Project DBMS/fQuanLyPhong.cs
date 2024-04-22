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
            string maPhong = MaPhong_tb.Text;
            string maTang = Matang_tb.Text;
            string maLoaiPhong = MaLoaiPhong_tb.Text;
            string loaiPhong = LoaiPhong_cb.Text;
            int soNguoi = int.Parse(SVHT_tb.Text);
            PhongDAO.Instance.AddPhong(maPhong, maTang, maLoaiPhong, loaiPhong, soNguoi);

            ClearPhongBinding();
            ShowListPhong();
            AddPhongnBinding();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            string maPhong = MaPhong_tb.Text;
            string maTang = Matang_tb.Text;
            string maLoaiPhong = MaLoaiPhong_tb.Text;
            string loaiPhong = LoaiPhong_cb.Text;
            int soNguoi = int.Parse(SVHT_tb.Text);
            PhongDAO.Instance.UpdatePhong(maPhong, maTang, maLoaiPhong, loaiPhong, soNguoi);

            ClearPhongBinding();
            ShowListPhong();
            AddPhongnBinding();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            string maPhong = MaPhong_tb.Text;
            PhongDAO.Instance.DeletePhong(maPhong);

            ClearPhongBinding();
            ShowListPhong();
            AddPhongnBinding();
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

        private void search_Btn_Click(object sender, EventArgs e)
        {
            string MaPhong = MaPhong_tb.Text;
            DataTable data = PhongDAO.Instance.FindRoom(MaPhong);

            dataGridView.DataSource = data;
        }
    }
}
