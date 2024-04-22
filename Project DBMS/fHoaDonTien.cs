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
    public partial class fHoaDonDien : Form
    {
        public fHoaDonDien()
        {
            InitializeComponent();
            Load();
            Binding();
        }
        void Load()
        {
            ClearBinding();
            dataGridView.DataSource = QLHoaDonDAO.Instance.GetListHoaDonDien();
        }
        void Binding()
        {
            MaPhong_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "MaPhong", true, DataSourceUpdateMode.Never));
            CreateDay_Date.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "NgayLapBieu", true, DataSourceUpdateMode.Never));
            oldNum_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoDienCu", true, DataSourceUpdateMode.Never));
            newNum_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "SoDienMoi", true, DataSourceUpdateMode.Never));
            money_tb.DataBindings.Add(new Binding("Text", dataGridView.DataSource, "TienDien", true, DataSourceUpdateMode.Never));
        }
        void ClearBinding()
        {
            MaPhong_tb.DataBindings.Clear();
            CreateDay_Date.DataBindings.Clear();
            oldNum_tb.DataBindings.Clear();
            newNum_tb.DataBindings.Clear();
            money_tb.DataBindings.Clear();
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            fThemHoaDonDien form = new fThemHoaDonDien();
            form.Show();
        }
    }
}
