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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblBarCodeGenration = new System.Windows.Forms.Label();
            this.btnGenerate = new Guna.UI.WinForms.GunaButton();
            this.lblStyle = new System.Windows.Forms.Label();
            this.lblCategory = new System.Windows.Forms.Label();
            this.cmbStyle = new Guna.UI.WinForms.GunaComboBox();
            this.cmbCategory = new Guna.UI.WinForms.GunaComboBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.lblBrand = new System.Windows.Forms.Label();
            this.cmbColor = new Guna.UI.WinForms.GunaComboBox();
            this.cmbSize = new Guna.UI.WinForms.GunaComboBox();
            this.cmbBrand = new Guna.UI.WinForms.GunaComboBox();
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
            this.gbBarCodeGeneration.Controls.Add(this.btnGenerate);
            this.gbBarCodeGeneration.Controls.Add(this.lblStyle);
            this.gbBarCodeGeneration.Controls.Add(this.lblCategory);
            this.gbBarCodeGeneration.Controls.Add(this.cmbStyle);
            this.gbBarCodeGeneration.Controls.Add(this.cmbCategory);
            this.gbBarCodeGeneration.Controls.Add(this.lblColor);
            this.gbBarCodeGeneration.Controls.Add(this.lblSize);
            this.gbBarCodeGeneration.Controls.Add(this.lblBrand);
            this.gbBarCodeGeneration.Controls.Add(this.cmbColor);
            this.gbBarCodeGeneration.Controls.Add(this.cmbSize);
            this.gbBarCodeGeneration.Controls.Add(this.cmbBrand);
            this.gbBarCodeGeneration.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.gbBarCodeGeneration.LineColor = System.Drawing.Color.Transparent;
            this.gbBarCodeGeneration.Location = new System.Drawing.Point(262, 110);
            this.gbBarCodeGeneration.Name = "gbBarCodeGeneration";
            this.gbBarCodeGeneration.Radius = 50;
            this.gbBarCodeGeneration.Size = new System.Drawing.Size(1159, 657);
            this.gbBarCodeGeneration.TabIndex = 13;
            this.gbBarCodeGeneration.TextLocation = new System.Drawing.Point(10, 8);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.LightGray;
            this.pictureBox1.Location = new System.Drawing.Point(287, 284);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(604, 291);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 24;
            this.pictureBox1.TabStop = false;
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
            // btnGenerate
            // 
            this.btnGenerate.AnimationHoverSpeed = 0.07F;
            this.btnGenerate.AnimationSpeed = 0.03F;
            this.btnGenerate.BackColor = System.Drawing.Color.Transparent;
            this.btnGenerate.BaseColor = System.Drawing.Color.Gray;
            this.btnGenerate.BorderColor = System.Drawing.Color.Black;
            this.btnGenerate.BorderSize = 1;
            this.btnGenerate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGenerate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnGenerate.FocusedColor = System.Drawing.Color.Empty;
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.Image = null;
            this.btnGenerate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnGenerate.Location = new System.Drawing.Point(515, 583);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnGenerate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnGenerate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnGenerate.OnHoverImage = null;
            this.btnGenerate.OnPressedColor = System.Drawing.Color.Black;
            this.btnGenerate.Radius = 10;
            this.btnGenerate.Size = new System.Drawing.Size(145, 42);
            this.btnGenerate.TabIndex = 23;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
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
            // cmbStyle
            // 
            this.cmbStyle.BackColor = System.Drawing.Color.Transparent;
            this.cmbStyle.BaseColor = System.Drawing.Color.White;
            this.cmbStyle.BorderColor = System.Drawing.Color.Silver;
            this.cmbStyle.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStyle.FocusedColor = System.Drawing.Color.Empty;
            this.cmbStyle.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbStyle.ForeColor = System.Drawing.Color.Black;
            this.cmbStyle.FormattingEnabled = true;
            this.cmbStyle.Location = new System.Drawing.Point(771, 144);
            this.cmbStyle.Name = "cmbStyle";
            this.cmbStyle.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbStyle.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbStyle.Radius = 5;
            this.cmbStyle.Size = new System.Drawing.Size(295, 31);
            this.cmbStyle.TabIndex = 13;
            // 
            // cmbCategory
            // 
            this.cmbCategory.BackColor = System.Drawing.Color.Transparent;
            this.cmbCategory.BaseColor = System.Drawing.Color.White;
            this.cmbCategory.BorderColor = System.Drawing.Color.Silver;
            this.cmbCategory.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FocusedColor = System.Drawing.Color.Empty;
            this.cmbCategory.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbCategory.ForeColor = System.Drawing.Color.Black;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(422, 144);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbCategory.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbCategory.Radius = 5;
            this.cmbCategory.Size = new System.Drawing.Size(295, 31);
            this.cmbCategory.TabIndex = 15;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblColor.Location = new System.Drawing.Point(257, 217);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(54, 20);
            this.lblColor.TabIndex = 21;
            this.lblColor.Text = "Color";
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblSize.Location = new System.Drawing.Point(619, 217);
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
            // cmbColor
            // 
            this.cmbColor.BackColor = System.Drawing.Color.Transparent;
            this.cmbColor.BaseColor = System.Drawing.Color.White;
            this.cmbColor.BorderColor = System.Drawing.Color.Silver;
            this.cmbColor.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbColor.FocusedColor = System.Drawing.Color.Empty;
            this.cmbColor.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbColor.ForeColor = System.Drawing.Color.Black;
            this.cmbColor.FormattingEnabled = true;
            this.cmbColor.Location = new System.Drawing.Point(257, 242);
            this.cmbColor.Name = "cmbColor";
            this.cmbColor.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbColor.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbColor.Radius = 5;
            this.cmbColor.Size = new System.Drawing.Size(295, 31);
            this.cmbColor.TabIndex = 16;
            // 
            // cmbSize
            // 
            this.cmbSize.BackColor = System.Drawing.Color.Transparent;
            this.cmbSize.BaseColor = System.Drawing.Color.White;
            this.cmbSize.BorderColor = System.Drawing.Color.Silver;
            this.cmbSize.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSize.FocusedColor = System.Drawing.Color.Empty;
            this.cmbSize.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbSize.ForeColor = System.Drawing.Color.Black;
            this.cmbSize.FormattingEnabled = true;
            this.cmbSize.Location = new System.Drawing.Point(619, 242);
            this.cmbSize.Name = "cmbSize";
            this.cmbSize.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbSize.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbSize.Radius = 5;
            this.cmbSize.Size = new System.Drawing.Size(295, 31);
            this.cmbSize.TabIndex = 16;
            // 
            // cmbBrand
            // 
            this.cmbBrand.BackColor = System.Drawing.Color.Transparent;
            this.cmbBrand.BaseColor = System.Drawing.Color.White;
            this.cmbBrand.BorderColor = System.Drawing.Color.Silver;
            this.cmbBrand.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbBrand.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBrand.FocusedColor = System.Drawing.Color.Empty;
            this.cmbBrand.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbBrand.ForeColor = System.Drawing.Color.Black;
            this.cmbBrand.FormattingEnabled = true;
            this.cmbBrand.Location = new System.Drawing.Point(92, 144);
            this.cmbBrand.Name = "cmbBrand";
            this.cmbBrand.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbBrand.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbBrand.Radius = 5;
            this.cmbBrand.Size = new System.Drawing.Size(295, 31);
            this.cmbBrand.TabIndex = 17;
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
            this.Load += new System.EventHandler(this.frmBarCodeGeneration_Load);
            this.gbBarCodeGeneration.ResumeLayout(false);
            this.gbBarCodeGeneration.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaGroupBox gbBarCodeGeneration;
        private System.Windows.Forms.Label lblStyle;
        private System.Windows.Forms.Label lblCategory;
        private Guna.UI.WinForms.GunaComboBox cmbStyle;
        private Guna.UI.WinForms.GunaComboBox cmbCategory;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label lblBrand;
        private Guna.UI.WinForms.GunaComboBox cmbSize;
        private Guna.UI.WinForms.GunaComboBox cmbBrand;
        private System.Windows.Forms.Label lblBarCodeGenration;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Guna.UI.WinForms.GunaButton btnGenerate;
        private System.Windows.Forms.Label lblColor;
        private Guna.UI.WinForms.GunaComboBox cmbColor;
    }
}