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
    public partial class fQuanLyHoaDon : Form
    {
        public fQuanLyHoaDon()
        {
            InitializeComponent();
            ShowListHoaDon();
        }
        void ShowListHoaDon()
        {
            dataGridView.DataSource = QLHoaDonDAO.Instance.GetListHoaDon();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
