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
    public partial class frmPurchases : Form
    {
        public frmPurchases()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddPurchases purchases = new frmAddPurchases();
            purchases.Show();
        }

        private void frmPurchases_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");

            string qry = "SELECT * FROM tblPurchases";

            con.Open();

            SqlCommand cmd = new SqlCommand(qry, con);
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            ad.Fill(dt);

            gvPurchases.DataSource = dt;

            // Add edit button column
            DataGridViewButtonColumn btnEdit = new DataGridViewButtonColumn
            {
                HeaderText = "Edit",
                Text = "Edit",
                UseColumnTextForButtonValue = true,
            };
            gvPurchases.Columns.Add(btnEdit);

            // Add delete button column
            DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn
            {
                HeaderText = "Delete",
                Text = "Delete",
                UseColumnTextForButtonValue = true,
            };
            gvPurchases.Columns.Add(btnDelete);

            // Handle CellMouseEnter event to change cursor
            gvPurchases.CellMouseEnter += (s, mouseEnterEventArgs) =>
            {
                if (mouseEnterEventArgs.ColumnIndex == btnEdit.Index || mouseEnterEventArgs.ColumnIndex == btnDelete.Index)
                {
                    gvPurchases.Cursor = Cursors.Hand;
                }
            };
            // Handle CellContentClick event for the DataGridView
            gvPurchases.CellContentClick += (s, cellEventArgs) =>
            {
                // Check if the clicked cell is in the buttons column
                if (cellEventArgs.ColumnIndex == btnEdit.Index && cellEventArgs.RowIndex >= 0 || cellEventArgs.ColumnIndex == btnDelete.Index && cellEventArgs.RowIndex >= 0)
                {
                    // Get the selected row index
                    int rowIndex = cellEventArgs.RowIndex;

                    // Get the data from the selected row
                    DataGridViewRow selectedRow = gvPurchases.Rows[rowIndex];
                    string purchaseId = selectedRow.Cells["purchaseId"].Value.ToString();

                    // Open the edit form with the selected userId
                    MessageBox.Show(purchaseId);
                }
            };
            con.Close();
        }
    }
}
