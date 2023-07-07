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
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        public static string userId;

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // Set up database connection
            SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");
            string qry = "SELECT userId as [User Id], userName as Name, contact as Contact, role as Role FROM tblUsers";

            // Retrieve data from the database
            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            // Bind data to DataGridView
            gvUsers.DataSource = dt;

            // Add edit button column
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };
            gvUsers.Columns.Add(btnEdit);

            // Add delete button column
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
            };
            gvUsers.Columns.Add(btnDelete);

            // Handle CellMouseEnter event to change cursor
            gvUsers.CellMouseEnter += (s, mouseEnterEventArgs) =>
            {
                if (mouseEnterEventArgs.ColumnIndex == btnEdit.Index || mouseEnterEventArgs.ColumnIndex == btnDelete.Index)
                {
                    gvUsers.Cursor = Cursors.Hand;
                }
            };
            // Handle CellContentClick event for the DataGridView
            gvUsers.CellContentClick += (s, cellEventArgs) =>
            {
                // Check if the clicked cell is in the buttons column
                if (cellEventArgs.ColumnIndex == btnEdit.Index && cellEventArgs.RowIndex >= 0 )
                {
                    // Get the selected row index
                    int rowIndex = cellEventArgs.RowIndex;

                    // Get the data from the selected row
                    DataGridViewRow selectedRow = gvUsers.Rows[rowIndex];
                    userId = selectedRow.Cells["User Id"].Value.ToString();

                    frmEditUsers edit = new frmEditUsers();
                    edit.Show();
                }
                else if (cellEventArgs.ColumnIndex == btnDelete.Index && cellEventArgs.RowIndex >= 0)
                {
                    // Get the selected row index
                    int rowIndex = cellEventArgs.RowIndex;

                    // Get the data from the selected row
                    DataGridViewRow selectedRow = gvUsers.Rows[rowIndex];
                    userId = selectedRow.Cells["User Id"].Value.ToString();

                    string sql = "delete from tblUsers where userId = " + userId + ";";
                    SqlCommand Deletecmd = new SqlCommand(sql, con);

                    con.Open();
                    Deletecmd.ExecuteNonQuery();
                    con.Close();

                    string update = "SELECT userId, userName, contact, role FROM tblUsers";

                    // Retrieve data from the database
                    SqlCommand updateCmd = new SqlCommand(update, con);
                    SqlDataAdapter da = new SqlDataAdapter(updateCmd);
                    DataTable dta = new DataTable();
                    da.Fill(dta);

                    gvUsers.DataSource = dta;
                }
            };
        }
    }
}
