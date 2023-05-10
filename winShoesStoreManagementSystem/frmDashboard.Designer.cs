namespace winShoesStoreManagementSystem
{
    partial class frmDashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDashboard));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblStoreName = new System.Windows.Forms.Label();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.btnShoesSizes = new System.Windows.Forms.Button();
            this.btnShoesColor = new System.Windows.Forms.Button();
            this.btnSale = new System.Windows.Forms.Button();
            this.btnPurchases = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.lblDashborad = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.btnLogOut);
            this.panel1.Controls.Add(this.btnPurchases);
            this.panel1.Controls.Add(this.btnSale);
            this.panel1.Controls.Add(this.btnShoesColor);
            this.panel1.Controls.Add(this.btnShoesSizes);
            this.panel1.Controls.Add(this.btnDashboard);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 618);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.lblUsername);
            this.panel2.Controls.Add(this.lblDashborad);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(200, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(871, 80);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lblStoreName);
            this.panel3.Controls.Add(this.pictureBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 128);
            this.panel3.TabIndex = 0;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(200, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(871, 618);
            this.panel4.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(40, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 79);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblStoreName
            // 
            this.lblStoreName.AutoSize = true;
            this.lblStoreName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStoreName.Location = new System.Drawing.Point(35, 94);
            this.lblStoreName.Name = "lblStoreName";
            this.lblStoreName.Size = new System.Drawing.Size(116, 25);
            this.lblStoreName.TabIndex = 0;
            this.lblStoreName.Text = "Store Name";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Black;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSearch.Location = new System.Drawing.Point(267, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 12;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(355, 41);
            this.txtSearch.TabIndex = 7;
            this.txtSearch.Text = "   Search...";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.Image")));
            this.btnSearch.Location = new System.Drawing.Point(577, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(45, 41);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.UseVisualStyleBackColor = false;
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
            this.btnDashboard.Size = new System.Drawing.Size(200, 52);
            this.btnDashboard.TabIndex = 0;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = false;
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
            this.btnShoesSizes.Location = new System.Drawing.Point(0, 180);
            this.btnShoesSizes.Name = "btnShoesSizes";
            this.btnShoesSizes.Size = new System.Drawing.Size(200, 52);
            this.btnShoesSizes.TabIndex = 1;
            this.btnShoesSizes.Text = "Shoes Sizes";
            this.btnShoesSizes.UseVisualStyleBackColor = false;
            // 
            // btnShoesColor
            // 
            this.btnShoesColor.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnShoesColor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnShoesColor.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShoesColor.Image = ((System.Drawing.Image)(resources.GetObject("btnShoesColor.Image")));
            this.btnShoesColor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShoesColor.Location = new System.Drawing.Point(0, 232);
            this.btnShoesColor.Name = "btnShoesColor";
            this.btnShoesColor.Size = new System.Drawing.Size(200, 52);
            this.btnShoesColor.TabIndex = 2;
            this.btnShoesColor.Text = "Shoes Color";
            this.btnShoesColor.UseVisualStyleBackColor = false;
            // 
            // btnSale
            // 
            this.btnSale.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnSale.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSale.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSale.Image = ((System.Drawing.Image)(resources.GetObject("btnSale.Image")));
            this.btnSale.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSale.Location = new System.Drawing.Point(0, 284);
            this.btnSale.Name = "btnSale";
            this.btnSale.Size = new System.Drawing.Size(200, 52);
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
            this.btnPurchases.Location = new System.Drawing.Point(0, 336);
            this.btnPurchases.Name = "btnPurchases";
            this.btnPurchases.Size = new System.Drawing.Size(200, 52);
            this.btnPurchases.TabIndex = 4;
            this.btnPurchases.Text = "Purchases";
            this.btnPurchases.UseVisualStyleBackColor = false;
            // 
            // btnLogOut
            // 
            this.btnLogOut.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btnLogOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogOut.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnLogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogOut.Image = ((System.Drawing.Image)(resources.GetObject("btnLogOut.Image")));
            this.btnLogOut.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogOut.Location = new System.Drawing.Point(0, 566);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(200, 52);
            this.btnLogOut.TabIndex = 5;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = false;
            // 
            // lblDashborad
            // 
            this.lblDashborad.AutoSize = true;
            this.lblDashborad.BackColor = System.Drawing.Color.Transparent;
            this.lblDashborad.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDashborad.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblDashborad.Location = new System.Drawing.Point(72, 19);
            this.lblDashborad.Name = "lblDashborad";
            this.lblDashborad.Size = new System.Drawing.Size(131, 29);
            this.lblDashborad.TabIndex = 0;
            this.lblDashborad.Text = "Dashboard";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.BackColor = System.Drawing.Color.Transparent;
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsername.Location = new System.Drawing.Point(714, 19);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(124, 29);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // frmDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 618);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel1);
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblStoreName;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSearch;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnPurchases;
        private System.Windows.Forms.Button btnSale;
        private System.Windows.Forms.Button btnShoesColor;
        private System.Windows.Forms.Button btnShoesSizes;
        private System.Windows.Forms.Label lblUsername;
        private System.Windows.Forms.Label lblDashborad;
    }
}