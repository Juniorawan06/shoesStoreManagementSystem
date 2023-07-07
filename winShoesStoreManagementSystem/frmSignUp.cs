using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
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

        // Set up database connection
        SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");
        private void lblSignIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmLogin lgoin = new frmLogin();
            Hide();
            lgoin.Show();
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string qry = "insert into tblUsers values ('" + txtUsername.Text + "','" + txtContact.Text + "','" + txtPassword.Text + "','" + cmbRole.Text + "')";

            SqlCommand cmd = new SqlCommand(qry, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtUsername.Clear();
            txtContact.Clear();
            txtPassword.Clear();
            txtConfirmPassword.Clear();

            MessageBox.Show("Your can SignIn now");
        }
    }
}
