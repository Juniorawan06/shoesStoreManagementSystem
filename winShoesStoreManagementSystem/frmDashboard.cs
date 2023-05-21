﻿using System;
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
            frmShoesSizes sizes = new frmShoesSizes();
            sizes.TopLevel = false;
            panelContainer.Controls.Add(sizes);
            sizes.Dock = DockStyle.Fill;
            sizes.Visible = true;
        }
    }
}
