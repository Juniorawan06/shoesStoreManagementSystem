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
    public partial class frmAddPurchases : Form
    {
        public frmAddPurchases()
        {
            InitializeComponent();
        }
        private void txtBrand_Enter(object sender, EventArgs e)
        {
            if (txtBrand.Text == "Brand")
            {
                txtBrand.Text = string.Empty;
                txtBrand.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtBrand_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBrand.Text))
            {
                txtBrand.Text = "Brand";
                txtBrand.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtCategory_Enter(object sender, EventArgs e)
        {
            if (txtCategory.Text == "Category")
            {
                txtCategory.Text = string.Empty;
                txtCategory.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtCategory_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCategory.Text))
            {
                txtCategory.Text = "Category";
                txtCategory.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtColor_Enter(object sender, EventArgs e)
        {
            if (txtColor.Text == "Color")
            {
                txtColor.Text = string.Empty;
                txtColor.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtColor_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtColor.Text))
            {
                txtColor.Text = "Color";
                txtColor.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtSize_Enter(object sender, EventArgs e)
        {
            if (txtSize.Text == "Size")
            {
                txtSize.Text = string.Empty;
                txtSize.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtSize_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSize.Text))
            {
                txtSize.Text = "Size";
                txtSize.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtStyle_Enter(object sender, EventArgs e)
        {
            if (txtStyle.Text == "Style")
            {
                txtStyle.Text = string.Empty;
                txtStyle.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtStyle_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtStyle.Text))
            {
                txtStyle.Text = "Style";
                txtStyle.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtPrice_Enter(object sender, EventArgs e)
        {
            if (txtCostPrice.Text == "Cost Price")
            {
                txtCostPrice.Text = string.Empty;
                txtCostPrice.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtPrice_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCostPrice.Text))
            {
                txtCostPrice.Text = "Cost Price";
                txtCostPrice.ForeColor = SystemColors.GrayText;
            }
        }

        private void txtQuantity_Enter(object sender, EventArgs e)
        {
            if (txtQuantity.Text == "Quantity")
            {
                txtQuantity.Text = string.Empty;
                txtQuantity.ForeColor = SystemColors.WindowText;
            }
        }

        private void txtQuantity_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                txtQuantity.Text = "Quantity";
                txtQuantity.ForeColor = SystemColors.GrayText;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=JUNIOR-06\\SQLEXPRESS;Initial Catalog=dbSsms;Integrated Security=True");
            string qry = "insert into tblPurchases values ('" + txtBrand.Text + "','" + txtCategory.Text + "','" + txtStyle.Text + "','" + txtColor.Text + "','" + txtSize.Text + "','" + txtQuantity.Text + "','" + txtCostPrice.Text + "', 1, current_timestamp);";
            SqlCommand cmd = new SqlCommand(qry, con);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            txtBrand.Clear();
            txtCategory.Clear();
            txtStyle.Clear();
            txtColor.Clear();
            txtSize.Clear();
            txtQuantity.Clear();
            txtCostPrice.Clear();

            MessageBox.Show("Purchases Added Successfully");
            this.Close();
        }
    }
}
