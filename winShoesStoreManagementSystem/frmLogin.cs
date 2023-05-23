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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text == "admin")
            {
                frmAdminPanel adminPanel = new frmAdminPanel();
                adminPanel.Show();
                Hide();
            }
            else if(txtUserName.Text == "user")
            {
                frmUserPanel userPanel = new frmUserPanel();
                userPanel.Show();
                Hide();
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp sp = new frmSignUp();
            sp.Show();
            Hide();
        }
    }
}
