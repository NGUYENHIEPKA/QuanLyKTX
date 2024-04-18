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
    public partial class SinhVienHoaDon : Form
    {
        public SinhVienHoaDon()
        {
            InitializeComponent();
            ShowListHoaDon();
        }
        void ShowListHoaDon()
        {
            SinhVienListHoaDon.DataSource = SVHoaDonDAO.Instance.GetListHoaDonSV();
        }

        private void SinhVienListHoaDon_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
