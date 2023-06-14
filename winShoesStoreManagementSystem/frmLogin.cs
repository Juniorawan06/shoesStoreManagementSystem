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
    public partial class frmLogin : Form
    {
        public static string username;
        public frmLogin()
        {
            InitializeComponent();
        }

        // Set up database connection
        SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");
        private void btnLogin_Click(object sender, EventArgs e)
        {
            username = txtUserName.Text;
            try {
                con.Open();
                string qry = "SELECT userName, password, role FROM tblUsers where username ='" + txtUserName.Text + "' and password = '" + txtPassword.Text + "'";

                // Retrieve data from the database
                SqlDataAdapter da = new SqlDataAdapter(qry, con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    string role = dt.Rows[0]["role"].ToString();
                    if (role.Contains("Admin"))
                    {
                        frmAdminPanel admin = new frmAdminPanel();
                        Hide();
                        admin.Show();
                    }
                    else if (role.Contains("User"))
                    {
                        frmUserPanel user = new frmUserPanel();
                        Hide();
                        user.Show();
                    }
                }
                else
                {
                    MessageBox.Show("Invalid Credentials");
                }
            } 
            catch {
                    MessageBox.Show("Error in Conndection");
            }
            finally {
                con.Close();
            }
        }

        private void lblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmSignUp sp = new frmSignUp();
            Hide(); 
            sp.Show();
        }
    }
}
