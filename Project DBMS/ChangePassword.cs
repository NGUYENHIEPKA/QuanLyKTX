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
    public partial class ChangePassword : Form
    {
        public ChangePassword(string id)
        {
            InitializeComponent();
            this.id = id;
        }
        string id;
        private void ShowPassCB_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassCB.Checked)
            {
                OldPassTB.PasswordChar = '\0';
                NewPassTB.PasswordChar = '\0';
                NewPassAgTB.PasswordChar = '\0';
            }
            else
            {
                OldPassTB.PasswordChar = '•';
                NewPassTB.PasswordChar = '•';
                NewPassAgTB.PasswordChar = '•';


            }
        }

        private void DoiPassBT_Click(object sender, EventArgs e)
        {
            string tk = id;
            string passcu = OldPassTB.Text;
            string passmoi = NewPassTB.Text;
            string passsmoi1 = NewPassAgTB.Text;
            AccountDAO.Instance.sua(tk, passcu, passmoi, passsmoi1);
        }
    }
}
