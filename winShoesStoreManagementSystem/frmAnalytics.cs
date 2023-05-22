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
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            chartColumn.Series["Column"].Points.AddXY("Total Purchases", 900);
            chartColumn.Series["Column"].Points.AddXY("Total Sales", 350);
            chartColumn.Series["Column"].Points.AddXY("Total Profit", 900);
            chartColumn.Series["Column"].Points.AddXY("Total stock", 136);

            lblPurchases.Text = "900";
            lblSales.Text = "350";
            lblProfit.Text = "900";
            lblStock.Text = "136";
        }
    }
}
