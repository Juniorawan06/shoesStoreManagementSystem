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
    public partial class frmEditUsers : Form
    {
        public frmEditUsers()
        {
            InitializeComponent();
        }


        private string Id = frmUsers.userId;
        private SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");
        private void frmEditUsers_Load(object sender, EventArgs e)
        {
            string qry = "SELECT username, contact, role FROM tblUsers where userId = "+Id+";";

            // Retrieve data from the database
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            txtUsername.Text = dt.Rows[0]["username"].ToString();
            txtContact.Text = dt.Rows[0]["contact"].ToString();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string qry = "update tblUsers set username = '" + txtUsername.Text + "' , contact =  '" + txtContact.Text + "' , role = '" + cmbRole.Text + "' where userId = " + Id + ";";
            SqlCommand cmd = new SqlCommand(qry, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("User " + Id + " Updated Successfully");
            this.Close();
        }
    }
}
