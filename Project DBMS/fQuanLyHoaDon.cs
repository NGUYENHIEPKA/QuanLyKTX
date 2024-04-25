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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Project_DBMS
{
    public partial class fQuanLyHoaDon : Form
    {
        public fQuanLyHoaDon()
        {
            InitializeComponent();
            ShowListHoaDon();
            Binding();
        }
        void ShowListHoaDon()
        {
            ClearBinding();
            dataGridView.DataSource = QLHoaDonDAO.Instance.GetListHoaDon();

        }
        void Binding()
        {
            maHoaDon_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaHoaDon", true, DataSourceUpdateMode.Never));
            maPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            phuongThucThanhToan_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "PhuongThucThanhToan", true, DataSourceUpdateMode.Never));
            loaiHoaDon_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "LoaiHoaDon", true, DataSourceUpdateMode.Never));
            NgayTao_Date.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "NgayTaoHoaDon", true, DataSourceUpdateMode.Never));
            money_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoTien", true, DataSourceUpdateMode.Never));
            thanhToan_check.DataBindings.Add(new Binding("Checked", dataGridView.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
        }
        void ClearBinding()
        {
            maHoaDon_tb.DataBindings.Clear();
            maPhong_tb.DataBindings.Clear();
            phuongThucThanhToan_tb.DataBindings.Clear();
            loaiHoaDon_tb.DataBindings.Clear();
            NgayTao_Date.DataBindings.Clear();
            money_tb.DataBindings.Clear();
            thanhToan_check.DataBindings.Clear();
        }
        private void Add_Btn_Click(object sender, EventArgs e)
        {
            fThemHoaDon form = new fThemHoaDon();
            form.FormClosed += form_FormClosed;
            form.Show();
        }
        private void form_FormClosed(object sender, FormClosedEventArgs e)
        {
            ShowListHoaDon();
            Binding();
        }

        private void Renew_Btn_Click(object sender, EventArgs e)
        {
            ShowListHoaDon();
            Binding();
        }

        private void Edit_Btn_Click(object sender, EventArgs e)
        {
            string MaHoaDon = maHoaDon_tb.Text;
            int TrangThai;
            if (thanhToan_check.Checked)
            {
                TrangThai = 1;
            }
            else
            {
                TrangThai = 0;
            }
            fSuaHoaDon form = new fSuaHoaDon(MaHoaDon, TrangThai);
            form.FormClosed += form_FormClosed;
            form.Show();
        }

        private void Delete_Btn_Click(object sender, EventArgs e)
        {
            string MaHoaDon = maHoaDon_tb.Text;
            string NgayTaoHoaDon = NgayTao_Date.Text;
            QLHoaDonDAO.Instance.DeleteHoaDon(MaHoaDon, NgayTaoHoaDon);
            ShowListHoaDon();
            Binding();
        }
    }
}
