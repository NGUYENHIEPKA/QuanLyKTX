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
    public partial class fSuaHoaDon : Form
    {
        string MaHoaDon;
        int TrangThai;
        public fSuaHoaDon(string MaHoaDon, int TrangThai)
        {
            InitializeComponent();
            this.MaHoaDon = MaHoaDon;
            this.TrangThai = TrangThai;
            maHoaDon_tb.Text = MaHoaDon;
            if (TrangThai == 1)
            {
                thanhToan_check.Checked = true;
                unThanhToan_check.Checked = false;
            }
            else
            {
                thanhToan_check.Checked = false;
                unThanhToan_check.Checked = true;
            }
        }

        private void Add_Btn_Click(object sender, EventArgs e)
        {
            int TrangThai;
            if (thanhToan_check.Checked)
            {
                TrangThai = 1;
            }
            else if (unThanhToan_check.Checked)
            {
                TrangThai = 0;
            }
            QLHoaDonDAO.Instance.UpdateHoaDon(MaHoaDon, this.TrangThai);
            this.Close();
        }
    }
}
