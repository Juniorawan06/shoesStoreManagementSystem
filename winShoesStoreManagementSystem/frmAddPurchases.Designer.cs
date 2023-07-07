namespace winShoesStoreManagementSystem
{
    partial class frmAddPurchases
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
            this.btnAdd = new Guna.UI.WinForms.GunaButton();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBrandName = new System.Windows.Forms.Label();
            this.txtQuantity = new Guna.UI.WinForms.GunaTextBox();
            this.txtCostPrice = new Guna.UI.WinForms.GunaTextBox();
            this.txtStyle = new Guna.UI.WinForms.GunaTextBox();
            this.txtSize = new Guna.UI.WinForms.GunaTextBox();
            this.txtCategory = new Guna.UI.WinForms.GunaTextBox();
            this.txtColor = new Guna.UI.WinForms.GunaTextBox();
            this.txtBrand = new Guna.UI.WinForms.GunaTextBox();
            this.lblAddItems = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnAdd
            // 
            this.btnAdd.AnimationHoverSpeed = 0.07F;
            this.btnAdd.AnimationSpeed = 0.03F;
            this.btnAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnAdd.BaseColor = System.Drawing.Color.Gray;
            this.btnAdd.BorderColor = System.Drawing.Color.Black;
            this.btnAdd.BorderSize = 1;
            this.btnAdd.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAdd.FocusedColor = System.Drawing.Color.Empty;
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnAdd.ForeColor = System.Drawing.Color.White;
            this.btnAdd.Image = null;
            this.btnAdd.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAdd.Location = new System.Drawing.Point(585, 779);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAdd.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAdd.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAdd.OnHoverImage = null;
            this.btnAdd.OnPressedColor = System.Drawing.Color.Black;
            this.btnAdd.Radius = 10;
            this.btnAdd.Size = new System.Drawing.Size(160, 42);
            this.btnAdd.TabIndex = 27;
            this.btnAdd.Text = "Add";
            this.btnAdd.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblQuantity.Location = new System.Drawing.Point(36, 586);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(85, 23);
            this.lblQuantity.TabIndex = 20;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblPrice.Location = new System.Drawing.Point(36, 681);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(91, 23);
            this.lblPrice.TabIndex = 21;
            this.lblPrice.Text = "Cost Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.label3.Location = new System.Drawing.Point(36, 298);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 22;
            this.label3.Text = "Style";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.label2.Location = new System.Drawing.Point(36, 386);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 23);
            this.label2.TabIndex = 23;
            this.label2.Text = "Size";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblCategory.Location = new System.Drawing.Point(36, 207);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(86, 23);
            this.lblCategory.TabIndex = 24;
            this.lblCategory.Text = "Category";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.label1.Location = new System.Drawing.Point(36, 484);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 23);
            this.label1.TabIndex = 25;
            this.label1.Text = "Color";
            // 
            // lblBrandName
            // 
            this.lblBrandName.AutoSize = true;
            this.lblBrandName.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblBrandName.Location = new System.Drawing.Point(36, 110);
            this.lblBrandName.Name = "lblBrandName";
            this.lblBrandName.Size = new System.Drawing.Size(117, 23);
            this.lblBrandName.TabIndex = 26;
            this.lblBrandName.Text = "Brand Name";
            // 
            // txtQuantity
            // 
            this.txtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BaseColor = System.Drawing.Color.White;
            this.txtQuantity.BorderColor = System.Drawing.Color.Transparent;
            this.txtQuantity.BorderSize = 1;
            this.txtQuantity.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtQuantity.FocusedBaseColor = System.Drawing.Color.White;
            this.txtQuantity.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtQuantity.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtQuantity.ForeColor = System.Drawing.Color.DarkGray;
            this.txtQuantity.Location = new System.Drawing.Point(32, 613);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.PasswordChar = '\0';
            this.txtQuantity.Radius = 5;
            this.txtQuantity.SelectedText = "";
            this.txtQuantity.Size = new System.Drawing.Size(1266, 41);
            this.txtQuantity.TabIndex = 13;
            this.txtQuantity.Text = "Quantity";
            this.txtQuantity.Enter += new System.EventHandler(this.txtQuantity_Enter);
            this.txtQuantity.Leave += new System.EventHandler(this.txtQuantity_Leave);
            // 
            // txtCostPrice
            // 
            this.txtCostPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtCostPrice.BaseColor = System.Drawing.Color.White;
            this.txtCostPrice.BorderColor = System.Drawing.Color.Transparent;
            this.txtCostPrice.BorderSize = 1;
            this.txtCostPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCostPrice.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCostPrice.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCostPrice.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCostPrice.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCostPrice.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCostPrice.Location = new System.Drawing.Point(32, 708);
            this.txtCostPrice.Margin = new System.Windows.Forms.Padding(4);
            this.txtCostPrice.Name = "txtCostPrice";
            this.txtCostPrice.PasswordChar = '\0';
            this.txtCostPrice.Radius = 5;
            this.txtCostPrice.SelectedText = "";
            this.txtCostPrice.Size = new System.Drawing.Size(1266, 41);
            this.txtCostPrice.TabIndex = 14;
            this.txtCostPrice.Text = "Cost Price";
            this.txtCostPrice.Enter += new System.EventHandler(this.txtPrice_Enter);
            this.txtCostPrice.Leave += new System.EventHandler(this.txtPrice_Leave);
            // 
            // txtStyle
            // 
            this.txtStyle.BackColor = System.Drawing.Color.Transparent;
            this.txtStyle.BaseColor = System.Drawing.Color.White;
            this.txtStyle.BorderColor = System.Drawing.Color.Transparent;
            this.txtStyle.BorderSize = 1;
            this.txtStyle.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtStyle.FocusedBaseColor = System.Drawing.Color.White;
            this.txtStyle.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtStyle.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtStyle.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtStyle.ForeColor = System.Drawing.Color.DarkGray;
            this.txtStyle.Location = new System.Drawing.Point(32, 325);
            this.txtStyle.Margin = new System.Windows.Forms.Padding(4);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.PasswordChar = '\0';
            this.txtStyle.Radius = 5;
            this.txtStyle.SelectedText = "";
            this.txtStyle.Size = new System.Drawing.Size(1266, 41);
            this.txtStyle.TabIndex = 15;
            this.txtStyle.Text = "Style";
            this.txtStyle.Enter += new System.EventHandler(this.txtStyle_Enter);
            this.txtStyle.Leave += new System.EventHandler(this.txtStyle_Leave);
            // 
            // txtSize
            // 
            this.txtSize.BackColor = System.Drawing.Color.Transparent;
            this.txtSize.BaseColor = System.Drawing.Color.White;
            this.txtSize.BorderColor = System.Drawing.Color.Transparent;
            this.txtSize.BorderSize = 1;
            this.txtSize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSize.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSize.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSize.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSize.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtSize.ForeColor = System.Drawing.Color.DarkGray;
            this.txtSize.Location = new System.Drawing.Point(32, 413);
            this.txtSize.Margin = new System.Windows.Forms.Padding(4);
            this.txtSize.Name = "txtSize";
            this.txtSize.PasswordChar = '\0';
            this.txtSize.Radius = 5;
            this.txtSize.SelectedText = "";
            this.txtSize.Size = new System.Drawing.Size(1266, 41);
            this.txtSize.TabIndex = 16;
            this.txtSize.Text = "Size";
            this.txtSize.Enter += new System.EventHandler(this.txtSize_Enter);
            this.txtSize.Leave += new System.EventHandler(this.txtSize_Leave);
            // 
            // txtCategory
            // 
            this.txtCategory.BackColor = System.Drawing.Color.Transparent;
            this.txtCategory.BaseColor = System.Drawing.Color.White;
            this.txtCategory.BorderColor = System.Drawing.Color.Transparent;
            this.txtCategory.BorderSize = 1;
            this.txtCategory.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCategory.FocusedBaseColor = System.Drawing.Color.White;
            this.txtCategory.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtCategory.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtCategory.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtCategory.ForeColor = System.Drawing.Color.DarkGray;
            this.txtCategory.Location = new System.Drawing.Point(32, 234);
            this.txtCategory.Margin = new System.Windows.Forms.Padding(4);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.PasswordChar = '\0';
            this.txtCategory.Radius = 5;
            this.txtCategory.SelectedText = "";
            this.txtCategory.Size = new System.Drawing.Size(1266, 41);
            this.txtCategory.TabIndex = 17;
            this.txtCategory.Text = "Category";
            this.txtCategory.Enter += new System.EventHandler(this.txtCategory_Enter);
            this.txtCategory.Leave += new System.EventHandler(this.txtCategory_Leave);
            // 
            // txtColor
            // 
            this.txtColor.BackColor = System.Drawing.Color.Transparent;
            this.txtColor.BaseColor = System.Drawing.Color.White;
            this.txtColor.BorderColor = System.Drawing.Color.Transparent;
            this.txtColor.BorderSize = 1;
            this.txtColor.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtColor.FocusedBaseColor = System.Drawing.Color.White;
            this.txtColor.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtColor.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtColor.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtColor.ForeColor = System.Drawing.Color.DarkGray;
            this.txtColor.Location = new System.Drawing.Point(32, 511);
            this.txtColor.Margin = new System.Windows.Forms.Padding(4);
            this.txtColor.Name = "txtColor";
            this.txtColor.PasswordChar = '\0';
            this.txtColor.Radius = 5;
            this.txtColor.SelectedText = "";
            this.txtColor.Size = new System.Drawing.Size(1266, 41);
            this.txtColor.TabIndex = 18;
            this.txtColor.Text = "Color";
            this.txtColor.Enter += new System.EventHandler(this.txtColor_Enter);
            this.txtColor.Leave += new System.EventHandler(this.txtColor_Leave);
            // 
            // txtBrand
            // 
            this.txtBrand.BackColor = System.Drawing.Color.Transparent;
            this.txtBrand.BaseColor = System.Drawing.Color.White;
            this.txtBrand.BorderColor = System.Drawing.Color.Transparent;
            this.txtBrand.BorderSize = 1;
            this.txtBrand.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtBrand.FocusedBaseColor = System.Drawing.Color.White;
            this.txtBrand.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtBrand.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtBrand.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtBrand.ForeColor = System.Drawing.Color.DarkGray;
            this.txtBrand.Location = new System.Drawing.Point(32, 137);
            this.txtBrand.Margin = new System.Windows.Forms.Padding(4);
            this.txtBrand.Name = "txtBrand";
            this.txtBrand.PasswordChar = '\0';
            this.txtBrand.Radius = 5;
            this.txtBrand.SelectedText = "";
            this.txtBrand.Size = new System.Drawing.Size(1266, 41);
            this.txtBrand.TabIndex = 19;
            this.txtBrand.Text = "Brand";
            this.txtBrand.Enter += new System.EventHandler(this.txtBrand_Enter);
            this.txtBrand.Leave += new System.EventHandler(this.txtBrand_Leave);
            // 
            // lblAddItems
            // 
            this.lblAddItems.AutoSize = true;
            this.lblAddItems.BackColor = System.Drawing.Color.Transparent;
            this.lblAddItems.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblAddItems.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblAddItems.Location = new System.Drawing.Point(33, 51);
            this.lblAddItems.Name = "lblAddItems";
            this.lblAddItems.Size = new System.Drawing.Size(426, 37);
            this.lblAddItems.TabIndex = 12;
            this.lblAddItems.Text = "FIll The Form to Add Purchases";
            // 
            // frmAddPurchases
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1329, 850);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblCategory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBrandName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtCostPrice);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.txtSize);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtColor);
            this.Controls.Add(this.txtBrand);
            this.Controls.Add(this.lblAddItems);
            this.Name = "frmAddPurchases";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddPurchases";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnAdd;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBrandName;
        private Guna.UI.WinForms.GunaTextBox txtQuantity;
        private Guna.UI.WinForms.GunaTextBox txtCostPrice;
        private Guna.UI.WinForms.GunaTextBox txtStyle;
        private Guna.UI.WinForms.GunaTextBox txtSize;
        private Guna.UI.WinForms.GunaTextBox txtCategory;
        private Guna.UI.WinForms.GunaTextBox txtColor;
        private Guna.UI.WinForms.GunaTextBox txtBrand;
        private System.Windows.Forms.Label lblAddItems;
    }
}