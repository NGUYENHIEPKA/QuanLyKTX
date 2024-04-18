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
    public partial class fThongTinCaNhanQL : Form
    {
        public fThongTinCaNhanQL()
        {
            InitializeComponent();
        }

        void ShowListPhong()
        {
            //dataGridView.DataSource = QuanLyDAO.Instance.GetListQuanLy();
        }

        void AddPhongBinding()
        {
            /*
            Maphong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            MaTang_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaTang", true, DataSourceUpdateMode.Never));
            MaLoaiPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaLoaiPhong", true, DataSourceUpdateMode.Never));
            LoaiPhongcb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "LoaiPhong", true, DataSourceUpdateMode.Never));
            SVHT_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoNguoi", true, DataSourceUpdateMode.Never));
            GiaPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "GiaTien", true, DataSourceUpdateMode.Never));
            */
        }

        private void fThongTinCaNhanQL_Load(object sender, EventArgs e)
        {

        }

        private void ChangeImg_btn_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();

                openFileDialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG;)|*.BMP;*.JPG;*.GIF;*.PNG;";
                openFileDialog.Title = "Chọn ảnh";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        // Hiển thị ảnh đã chọn trong PictureBox
                        ImgQL_ptbox.Image = new System.Drawing.Bitmap(openFileDialog.FileName);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Không thể mở tập tin: " + ex.Message);
                    }
                }
            }
        }

        private void showpass_btn_Click(object sender, EventArgs e)
        {
 
        }
    }
}
