namespace winShoesStoreManagementSystem
{
    partial class frmBarCodeGeneration
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
            this.gbBarCodeGeneration = new Guna.UI.WinForms.GunaGroupBox();
            this.btnPrint = new Guna.UI.WinForms.GunaButton();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmTxtStyle = new Guna.UI.WinForms.GunaComboBox();
            this.cmTxtQuantity = new Guna.UI.WinForms.GunaComboBox();
            this.cmTxtCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmTxtSize = new Guna.UI.WinForms.GunaComboBox();
            this.cmTxtBrand = new Guna.UI.WinForms.GunaComboBox();
            this.lblBarCodeGenration = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbBarCodeGeneration.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbBarCodeGeneration
            // 
            this.gbBarCodeGeneration.BackColor = System.Drawing.Color.Transparent;
            this.gbBarCodeGeneration.BaseColor = System.Drawing.Color.WhiteSmoke;
            this.gbBarCodeGeneration.BorderColor = System.Drawing.Color.CornflowerBlue;
            this.gbBarCodeGeneration.BorderSize = 2;
            this.gbBarCodeGeneration.Controls.Add(this.pictureBox1);
            this.gbBarCodeGeneration.Controls.Add(this.lblBarCodeGenration);
            this.gbBarCodeGeneration.Controls.Add(this.btnPrint);
            this.gbBarCodeGeneration.Controls.Add(this.lblStyle);
            this.gbBarCodeGeneration.Controls.Add(this.lblQuantity);
            this.gbBarCodeGeneration.Controls.Add(this.lblCategory);
            this.gbBarCodeGeneration.Controls.Add(this.cmTxtStyle);
            this.gbBarCodeGeneration.Controls.Add(this.cmTxtQuantity);
            this.gbBarCodeGeneration.Controls.Add(this.cmTxtCategory);
            this.gbBarCodeGeneration.Controls.Add(this.lblSize);
            this.gbBarCodeGeneration.Controls.Add(this.lblBrand);
            this.gbBarCodeGeneration.Controls.Add(this.cmTxtSize);
            this.gbBarCodeGeneration.Controls.Add(this.cmTxtBrand);
            this.gbBarCodeGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbBarCodeGeneration.LineColor = System.Drawing.Color.Transparent;
            this.gbBarCodeGeneration.Location = new System.Drawing.Point(262, 110);
            this.gbBarCodeGeneration.Name = "gbBarCodeGeneration";
            this.gbBarCodeGeneration.Radius = 50;
            this.gbBarCodeGeneration.Size = new System.Drawing.Size(1159, 657);
            this.gbBarCodeGeneration.TabIndex = 13;
            this.gbBarCodeGeneration.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // btnPrint
            // 
            this.btnPrint.AnimationHoverSpeed = 0.07F;
            this.btnPrint.AnimationSpeed = 0.03F;
            this.btnPrint.BackColor = System.Drawing.Color.Transparent;
            this.btnPrint.BaseColor = System.Drawing.Color.Gray;
            this.btnPrint.BorderColor = System.Drawing.Color.Black;
            this.btnPrint.BorderSize = 1;
            this.btnPrint.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnPrint.FocusedColor = System.Drawing.Color.Empty;
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrint.ForeColor = System.Drawing.Color.White;
            this.btnPrint.Image = null;
            this.btnPrint.ImageSize = new System.Drawing.Size(20, 20);
            this.btnPrint.Location = new System.Drawing.Point(534, 576);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnPrint.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnPrint.OnHoverForeColor = System.Drawing.Color.White;
            this.btnPrint.OnHoverImage = null;
            this.btnPrint.OnPressedColor = System.Drawing.Color.Black;
            this.btnPrint.Radius = 10;
            this.btnPrint.Size = new System.Drawing.Size(103, 42);
            this.btnPrint.TabIndex = 23;
            this.btnPrint.Text = "Print";
            this.btnPrint.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblStyle
            // 
            this.lblStyle.AutoSize = true;
            this.lblStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblStyle.Location = new System.Drawing.Point(771, 119);
            this.lblStyle.Name = "lblStyle";
            this.lblStyle.Size = new System.Drawing.Size(51, 20);
            this.lblStyle.TabIndex = 18;
            this.lblStyle.Text = "Style";
            // 
            // lblQuantity
            // 
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblQuantity.Location = new System.Drawing.Point(603, 216);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(79, 20);
            this.lblQuantity.TabIndex = 19;
            this.lblQuantity.Text = "Quantity";
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblCategory.Location = new System.Drawing.Point(422, 119);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(84, 20);
            this.lblCategory.TabIndex = 20;
            this.lblCategory.Text = "Category";
            // 
            // cmTxtStyle
            // 
            this.cmTxtStyle.BackColor = System.Drawing.Color.Transparent;
            this.cmTxtStyle.BaseColor = System.Drawing.Color.White;
            this.cmTxtStyle.BorderColor = System.Drawing.Color.Silver;
            this.cmTxtStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTxtStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTxtStyle.FocusedColor = System.Drawing.Color.Empty;
            this.cmTxtStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmTxtStyle.ForeColor = System.Drawing.Color.Black;
            this.cmTxtStyle.FormattingEnabled = true;
            this.cmTxtStyle.Items.AddRange(new object[] {
            "--Select--"});
            this.cmTxtStyle.Location = new System.Drawing.Point(771, 144);
            this.cmTxtStyle.Name = "cmTxtStyle";
            this.cmTxtStyle.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmTxtStyle.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmTxtStyle.Radius = 5;
            this.cmTxtStyle.Size = new System.Drawing.Size(295, 31);
            this.cmTxtStyle.TabIndex = 13;
            // 
            // cmTxtQuantity
            // 
            this.cmTxtQuantity.BackColor = System.Drawing.Color.Transparent;
            this.cmTxtQuantity.BaseColor = System.Drawing.Color.White;
            this.cmTxtQuantity.BorderColor = System.Drawing.Color.Silver;
            this.cmTxtQuantity.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTxtQuantity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTxtQuantity.FocusedColor = System.Drawing.Color.Empty;
            this.cmTxtQuantity.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmTxtQuantity.ForeColor = System.Drawing.Color.Black;
            this.cmTxtQuantity.FormattingEnabled = true;
            this.cmTxtQuantity.Items.AddRange(new object[] {
            "--Select--"});
            this.cmTxtQuantity.Location = new System.Drawing.Point(603, 241);
            this.cmTxtQuantity.Name = "cmTxtQuantity";
            this.cmTxtQuantity.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmTxtQuantity.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmTxtQuantity.Radius = 5;
            this.cmTxtQuantity.Size = new System.Drawing.Size(295, 31);
            this.cmTxtQuantity.TabIndex = 14;
            // 
            // cmTxtCategory
            // 
            this.cmTxtCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmTxtCategory.BaseColor = System.Drawing.Color.White;
            this.cmTxtCategory.BorderColor = System.Drawing.Color.Silver;
            this.cmTxtCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTxtCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTxtCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmTxtCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmTxtCategory.ForeColor = System.Drawing.Color.Black;
            this.cmTxtCategory.FormattingEnabled = true;
            this.cmTxtCategory.Items.AddRange(new object[] {
            "--Select--"});
            this.cmTxtCategory.Location = new System.Drawing.Point(422, 144);
            this.cmTxtCategory.Name = "cmTxtCategory";
            this.cmTxtCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmTxtCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmTxtCategory.Radius = 5;
            this.cmTxtCategory.Size = new System.Drawing.Size(295, 31);
            this.cmTxtCategory.TabIndex = 15;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSize.Location = new System.Drawing.Point(255, 216);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(46, 20);
            this.lblSize.TabIndex = 21;
            this.lblSize.Text = "Size";
            // 
            // lblBrand
            // 
            this.lblBrand.AutoSize = true;
            this.lblBrand.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblBrand.Location = new System.Drawing.Point(92, 119);
            this.lblBrand.Name = "lblBrand";
            this.lblBrand.Size = new System.Drawing.Size(59, 20);
            this.lblBrand.TabIndex = 22;
            this.lblBrand.Text = "Brand";
            // 
            // cmTxtSize
            // 
            this.cmTxtSize.BackColor = System.Drawing.Color.Transparent;
            this.cmTxtSize.BaseColor = System.Drawing.Color.White;
            this.cmTxtSize.BorderColor = System.Drawing.Color.Silver;
            this.cmTxtSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTxtSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTxtSize.FocusedColor = System.Drawing.Color.Empty;
            this.cmTxtSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmTxtSize.ForeColor = System.Drawing.Color.Black;
            this.cmTxtSize.FormattingEnabled = true;
            this.cmTxtSize.Items.AddRange(new object[] {
            "--Select--"});
            this.cmTxtSize.Location = new System.Drawing.Point(255, 241);
            this.cmTxtSize.Name = "cmTxtSize";
            this.cmTxtSize.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmTxtSize.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmTxtSize.Radius = 5;
            this.cmTxtSize.Size = new System.Drawing.Size(295, 31);
            this.cmTxtSize.TabIndex = 16;
            // 
            // cmTxtBrand
            // 
            this.cmTxtBrand.BackColor = System.Drawing.Color.Transparent;
            this.cmTxtBrand.BaseColor = System.Drawing.Color.White;
            this.cmTxtBrand.BorderColor = System.Drawing.Color.Silver;
            this.cmTxtBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmTxtBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmTxtBrand.FocusedColor = System.Drawing.Color.Empty;
            this.cmTxtBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmTxtBrand.ForeColor = System.Drawing.Color.Black;
            this.cmTxtBrand.FormattingEnabled = true;
            this.cmTxtBrand.Items.AddRange(new object[] {
            "--Select--"});
            this.cmTxtBrand.Location = new System.Drawing.Point(92, 144);
            this.cmTxtBrand.Name = "cmTxtBrand";
            this.cmTxtBrand.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmTxtBrand.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmTxtBrand.Radius = 5;
            this.cmTxtBrand.Size = new System.Drawing.Size(295, 31);
            this.cmTxtBrand.TabIndex = 17;
            // 
            // lblBarCodeGenration
            // 
            this.lblBarCodeGenration.AutoSize = true;
            this.lblBarCodeGenration.BackColor = System.Drawing.Color.Transparent;
            this.lblBarCodeGenration.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblBarCodeGenration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblBarCodeGenration.Location = new System.Drawing.Point(455, 14);
            this.lblBarCodeGenration.Name = "lblBarCodeGenration";
            this.lblBarCodeGenration.Size = new System.Drawing.Size(292, 37);
            this.lblBarCodeGenration.TabIndex = 14;
            this.lblBarCodeGenration.Text = "Bar Code Generation";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(438, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(294, 234);
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
            // 
            // frmBarCodeGeneration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1569, 775);
            this.Controls.Add(this.gbBarCodeGeneration);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmBarCodeGeneration";
            this.Text = "frmBarCodeGeneration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.gbBarCodeGeneration.ResumeLayout(false);
            this.gbBarCodeGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGroupBox gbBarCodeGeneration;
        private Guna.UI.WinForms.GunaButton btnPrint;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI.WinForms.GunaComboBox cmTxtStyle;
        private Guna.UI.WinForms.GunaComboBox cmTxtQuantity;
        private Guna.UI.WinForms.GunaComboBox cmTxtCategory;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI.WinForms.GunaComboBox cmTxtSize;
        private Guna.UI.WinForms.GunaComboBox cmTxtBrand;
        private System.Windows.Forms.Label lblBarCodeGenration;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}