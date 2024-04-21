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
            LoaiPhongcb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "LoaiPhong", true, DataSourceUpdateMode.Never));
            SVHT_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoNguoi", true, DataSourceUpdateMode.Never));
            GiaPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));

        }
        void ClearPhongBinding()
        {
            Matang_tb.DataBindings.Clear();
            MaPhong_tb.DataBindings.Clear();
            MaLoaiPhong_tb.DataBindings.Clear();
            LoaiPhongcb.DataBindings.Clear();
            SVHT_tb.DataBindings.Clear();
            GiaPhong_tb.DataBindings.Clear();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow row = dataGridView.SelectedRows[0];
                // Lấy dữ liệu từ các ô trong hàng được chọn
                string maTang = row.Cells["MaTang"].Value.ToString();
                string maPhong = row.Cells["MaPhong"].Value.ToString();
                string maLoaiPhong = row.Cells["MaLoaiPhong"].Value.ToString();
                string loaiPhong = row.Cells["LoaiPhong"].Value.ToString();
                string soNguoi = row.Cells["SoNguoi"].Value.ToString();
                string giaTien = row.Cells["GiaTien"].Value.ToString();

                // Hiển thị dữ liệu lên các TextBox tương ứng
                Matang_tb.Text = maTang;
                MaPhong_tb.Text = maPhong;
                MaLoaiPhong_tb.Text = maLoaiPhong;
                LoaiPhongcb.Text = loaiPhong;
                SVHT_tb.Text = soNguoi;
                GiaPhong_tb.Text = giaTien;
            }
        }

        private void Update_Btn_Click(object sender, EventArgs e)
        {
            string MaTang = Matang_tb.Text;
            string MaPhong = MaPhong_tb.Text;
            string MaloaiPhong = MaLoaiPhong_tb.Text;
            string LoaiPhong = LoaiPhongcb.Text;
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

        /*private void MaPhong_tb_TextChanged(object sender, EventArgs e)
        {
            string searchText = MaPhong_tb.Text.Trim();
            if (!string.IsNullOrEmpty(searchText))
            {
                // Lọc dữ liệu trong DataGridView dựa trên nội dung của TextBox
                DataView dv = new DataView(dataGridView.DataSource as DataTable);
                dv.RowFilter = string.Format("MaPhong LIKE '%{0}%'", searchText);
                dataGridView.DataSource = dv;
            }
            else
            {
                // Nếu TextBox trống, hiển thị tất cả dữ liệu
                dataGridView.DataSource = PhongDAO.Instance.GetListPhong(); // yourOriginalDataSource là nguồn dữ liệu ban đầu của DataGridView
            }
        }*/

        private void Add_Btn_Click(object sender, EventArgs e)
        {
             
        }
    }
}
