namespace winShoesStoreManagementSystem
{
    partial class frmUserPanel
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserPanel));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pnlDashboard = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblSubject = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnShoesStyles = new System.Windows.Forms.Button();
            this.btnShoesColor = new System.Windows.Forms.Button();
            this.btnShoesSizes = new System.Windows.Forms.Button();
            this.btnAddItems = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lblStoreName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(238, 128);
            this.panel3.TabIndex = 0;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblStoreName.Location = new System.Drawing.Point(51, 94);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(128, 28);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "Store Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(63, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pnlDashboard
            // 
            this.pnlDashboard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDashboard.Location = new System.Drawing.Point(238, 80);
            this.pnlDashboard.Name = "pnlDashboard";
            this.pnlDashboard.Size = new System.Drawing.Size(1569, 732);
            this.pnlDashboard.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.lblSubject);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(238, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1569, 80);
            this.panel2.TabIndex = 4;
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUsername.Location = new System.Drawing.Point(1323, 17);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(152, 37);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblSubject
            // 
            this.lblSubject.AutoSize = true;
            this.lblSubject.BackColor = System.Drawing.Color.Transparent;
            this.lblSubject.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblSubject.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblSubject.Location = new System.Drawing.Point(63, 17);
            this.lblSubject.Name = "lblSubject";
            this.lblSubject.Size = new System.Drawing.Size(164, 37);
            this.lblSubject.TabIndex = 0;
            this.lblSubject.Text = "Dashboard";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Transparent;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(332, 17);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 5;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(883, 41);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "Search...";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnPurchases);
            this.panel1.Controls.Add(this.btnShoesStyles);
            this.panel1.Controls.Add(this.btnShoesColor);
            this.panel1.Controls.Add(this.btnShoesSizes);
            this.panel1.Controls.Add(this.btnAddItems);
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(238, 812);
            this.panel1.TabIndex = 3;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 440);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(238, 52);
            this.btnSale.TabIndex = 3;
            this.btnSale.Text = "Sales";
            this.btnSale.UseVisualStyleBackColor = false;
            // 
            // btnPurchases
            // 
            this.btnPurchases.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnPurchases.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPurchases.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPurchases.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchases.Image = ((System.Drawing.Image)(resources.GetObject("btnPurchases.Image")));
            this.btnPurchases.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPurchases.Location = new System.Drawing.Point(0, 388);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(238, 52);
            this.btnPurchases.TabIndex = 4;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = false;
            // 
            // btnShoesStyles
            // 
            this.btnShoesStyles.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShoesStyles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoesStyles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoesStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoesStyles.Image = ((System.Drawing.Image)(resources.GetObject("btnShoesStyles.Image")));
            this.btnShoesStyles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoesStyles.Location = new System.Drawing.Point(0, 336);
            this.btnShoesStyles.Name = "btnShoesStyles";
            this.btnShoesStyles.Size = new System.Drawing.Size(238, 52);
            this.btnShoesStyles.TabIndex = 6;
            this.btnShoesStyles.Text = "Shoes Styles";
            this.btnShoesStyles.UseVisualStyleBackColor = false;
            // 
            // btnShoesColor
            // 
            this.btnShoesColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShoesColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoesColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoesColor.Image = ((System.Drawing.Image)(resources.GetObject("btnShoesColor.Image")));
            this.btnShoesColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoesColor.Location = new System.Drawing.Point(0, 284);
            this.btnShoesColor.Name = "btnShoesColor";
            this.btnShoesColor.Size = new System.Drawing.Size(238, 52);
            this.btnShoesColor.TabIndex = 2;
            this.btnShoesColor.Text = "Shoes Colors";
            this.btnShoesColor.UseVisualStyleBackColor = false;
            // 
            // btnShoesSizes
            // 
            this.btnShoesSizes.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShoesSizes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoesSizes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoesSizes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnShoesSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoesSizes.Image = ((System.Drawing.Image)(resources.GetObject("btnShoesSizes.Image")));
            this.btnShoesSizes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoesSizes.Location = new System.Drawing.Point(0, 232);
            this.btnShoesSizes.Name = "btnShoesSizes";
            this.btnShoesSizes.Size = new System.Drawing.Size(238, 52);
            this.btnShoesSizes.TabIndex = 1;
            this.btnShoesSizes.Text = "Shoes Sizes";
            this.btnShoesSizes.UseVisualStyleBackColor = false;
            // 
            // btnAddItems
            // 
            this.btnAddItems.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItems.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddItems.Image = ((System.Drawing.Image)(resources.GetObject("btnAddItems.Image")));
            this.btnAddItems.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddItems.Location = new System.Drawing.Point(0, 180);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.Size = new System.Drawing.Size(238, 52);
            this.btnAddItems.TabIndex = 6;
            this.btnAddItems.Text = "Add Items";
            this.btnAddItems.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 760);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(238, 52);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // btnDashboard
            // 
            this.btnDashboard.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnDashboard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDashboard.Image = ((System.Drawing.Image)(resources.GetObject("btnDashboard.Image")));
            this.btnDashboard.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDashboard.Location = new System.Drawing.Point(0, 128);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(238, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
            // 
            // frmUserPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1807, 812);
            this.Controls.Add(this.pnlDashboard);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmUserPanel";
            this.Text = "frmUserPanel";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel pnlDashboard;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblSubject;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnShoesStyles;
        private System.Windows.Forms.Button btnShoesColor;
        private System.Windows.Forms.Button btnShoesSizes;
        private System.Windows.Forms.Button btnAddItems;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnDashboard;
    }
}