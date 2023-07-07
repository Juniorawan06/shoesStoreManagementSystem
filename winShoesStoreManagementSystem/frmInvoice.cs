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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Header;

namespace winShoesStoreManagementSystem
{
    public partial class frmInvoice : Form
    {
        public frmInvoice()
        {
            InitializeComponent();
        }

        // Set up database connection
        private SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");
        private DataTable dta = new DataTable();

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            string qry = "SELECT * FROM tblPurchases";

            // Retrieve data from the database
            SqlDataAdapter adapter = new SqlDataAdapter(qry, con);
            DataTable dt = new DataTable(); 
            adapter.Fill(dt);

            cmbReader.DataSource = dt;
            cmbReader.ValueMember = "purchaseId";
            cmbReader.DisplayMember = "purchaseId";
        }

        private void cmbReader_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }


            if (cmbReader.SelectedValue != null && int.TryParse(cmbReader.SelectedValue.ToString(), out int purchaseId))
            {
                string qry = "SELECT purchaseId, brand, category, style, color, size,costPrice as Price FROM tblPurchases WHERE purchaseId = @purchaseId";
                SqlCommand cmd = new SqlCommand(qry, con);
                cmd.Parameters.AddWithValue("@purchaseId", purchaseId);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable newDataTable = new DataTable(); 
                newDataTable.Load(reader);
                reader.Close();

                con.Close(); 

                dta.Merge(newDataTable); 
                gvInvoice.DataSource = dta;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            dta.Clear();
            gvInvoice.DataSource = dta;
        }
    }
}
