using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winShoesStoreManagementSystem
{
    public partial class frmSignUp : Form
    {
        public frmSignUp()
        {
            InitializeComponent();
        }

        private void lblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin login = new frmLogin();
            login.Show();
            Hide();
        }
    }
}
