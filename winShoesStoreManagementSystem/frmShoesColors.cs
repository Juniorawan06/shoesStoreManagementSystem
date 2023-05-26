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
    public partial class frmShoesColors : Form
    {
        public frmShoesColors()
        {
            InitializeComponent();
        }

        private void btnAddItems_Click(object sender, EventArgs e)
        {
            //lblSubject.Text = "Add Items";
            //pnlDashboard.Controls.Clear();
            frmAddItems items = new frmAddItems
            {
                TopLevel = false,
                TopMost = true,
                Dock = DockStyle.Fill
            };
            //pnlDashboard.Controls.Add(items); 
            items.Show();
        }
    }
}
