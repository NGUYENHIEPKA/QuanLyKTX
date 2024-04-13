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
        public ChangePassword()
        {
            InitializeComponent();
        }

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
    }
}
