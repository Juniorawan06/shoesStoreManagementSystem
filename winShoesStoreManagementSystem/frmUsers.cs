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

        private void frmUsers_Load(object sender, EventArgs e)
        {
            // Set up database connection
            SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");

            // Retrieve data from the database
            SqlCommand cmd = new SqlCommand("SELECT userId, userName, email, role FROM tblUsers", con);
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);

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

            // Handle CellMouseEnter event to change cursor
            gvUsers.CellMouseEnter += (s, mouseEnterEventArgs) =>
            {
                if (mouseEnterEventArgs.ColumnIndex == btnEdit.Index)
                {
                    gvUsers.Cursor = Cursors.Hand;
                }
            };
            // Handle CellContentClick event for the DataGridView
            gvUsers.CellContentClick += (s, cellEventArgs) =>
            {
                // Check if the clicked cell is in the edit button column
                if (cellEventArgs.ColumnIndex == btnEdit.Index && cellEventArgs.RowIndex >= 0)
                {
                    // Get the selected row index
                    int rowIndex = cellEventArgs.RowIndex;

                    // Get the data from the selected row
                    DataGridViewRow selectedRow = gvUsers.Rows[rowIndex];
                    string userId = selectedRow.Cells["userId"].Value.ToString(); // Replace "userId" with the actual column name

                    // Open the edit form with the selected userId
                    MessageBox.Show(userId);

                    // Refresh the DataGridView if needed
                    // gvUsers.Refresh();
                }
            };
        }
    }
}
