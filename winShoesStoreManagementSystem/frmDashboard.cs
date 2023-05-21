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
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void btnShoesSizes_Click(object sender, EventArgs e)
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

        private void btnShoesColor_Click(object sender, EventArgs e)
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

        private void btnShoesStyles_Click(object sender, EventArgs e)
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
    }
}
