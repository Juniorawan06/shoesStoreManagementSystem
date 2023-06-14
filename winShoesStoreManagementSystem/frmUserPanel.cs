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
    public partial class frmUserPanel : Form
    {
        public frmUserPanel()
        {
            InitializeComponent();
        }

        private void frmUserPanel_Load_1(object sender, EventArgs e)
        {
            lblUsername.Text = frmLogin.username;
            lblSubject.Text = "Invoices";
            pnlDashboard.Controls.Clear();
            frmInvoice invoice = new frmInvoice
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(invoice);
            invoice.Show();
        }

        private void btnShoesSizes_Click_1(object sender, EventArgs e)
        {
            lblSubject.Text = "Shoes Sizes";
            pnlDashboard.Controls.Clear();
            frmShoesSizes sizes = new frmShoesSizes
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(sizes);
            sizes.Show();
        }
        private void btnShoesColor_Click_1(object sender, EventArgs e)
        {
            lblSubject.Text = "Shoes Colors";
            pnlDashboard.Controls.Clear();
            frmShoesColors colors = new frmShoesColors
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(colors);
            colors.Show();
        }

        private void btnShoesStyles_Click_1(object sender, EventArgs e)
        {
            lblSubject.Text = "Shoes Styles";
            pnlDashboard.Controls.Clear();
            frmShoesStyles styles = new frmShoesStyles
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(styles);
            styles.Show();
        }

        private void btnSale_Click_1(object sender, EventArgs e)
        {
            lblSubject.Text = "Sales";
            pnlDashboard.Controls.Clear();
            frmSales sales = new frmSales
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(sales);
            sales.Show();
        }

        private void btnAddItems_Click_1(object sender, EventArgs e)
        {
            lblSubject.Text = "Add Items";
            pnlDashboard.Controls.Clear();
            frmAddItems items = new frmAddItems
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(items);
            items.Show();
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Invoice";
            pnlDashboard.Controls.Clear();
            frmInvoice invoice = new frmInvoice
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(invoice);
            invoice.Show();
        }

        private void btnBrands_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Brands";
            pnlDashboard.Controls.Clear();
            frmBrands brands = new frmBrands
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(brands);
            brands.Show();
        }

        private void btnBarCode_Click(object sender, EventArgs e)
        {
            lblSubject.Text = "Bar Code";
            pnlDashboard.Controls.Clear();
            frmBarCodeGeneration barCode = new frmBarCodeGeneration
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(barCode);
            barCode.Show();
        }

        private void btnLogOut_Click_1(object sender, EventArgs e)
        {
            Hide();
            frmLogin login = new frmLogin();
            login.Show();
        }
    }
}

