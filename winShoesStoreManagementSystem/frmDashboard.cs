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
            pnlDashboard.Controls.Clear();
            frmShoesSizes sizes = new frmShoesSizes
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(sizes);
            sizes.Show();
        }

        private void btnShoesColor_Click(object sender, EventArgs e)
        {
            pnlDashboard.Controls.Clear();
            frmShoesColors colors = new frmShoesColors
            {
                TopLevel = false,
                Dock = DockStyle.Fill
            };
            pnlDashboard.Controls.Add(colors);
            colors.Show();
        }
    }
}
