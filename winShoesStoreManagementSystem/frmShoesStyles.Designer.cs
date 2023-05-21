namespace winShoesStoreManagementSystem
{
    partial class frmShoesStyles
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
            this.txtShoeSize = new System.Windows.Forms.TextBox();
            this.lblShoesStyles = new System.Windows.Forms.Label();
            this.gvShoesStyles = new System.Windows.Forms.DataGridView();
            this.gunaBtnAddOne = new Guna.UI.WinForms.GunaButton();
            this.gunaBtnAddBulk = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvShoesStyles)).BeginInit();
            this.SuspendLayout();
            // 
            // txtShoeSize
            // 
            this.txtShoeSize.Location = new System.Drawing.Point(543, 171);
            this.txtShoeSize.Multiline = true;
            this.txtShoeSize.Name = "txtShoeSize";
            this.txtShoeSize.Size = new System.Drawing.Size(225, 34);
            this.txtShoeSize.TabIndex = 17;
            // 
            // lblShoesStyles
            // 
            this.lblShoesStyles.AutoSize = true;
            this.lblShoesStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoesStyles.Location = new System.Drawing.Point(324, 109);
            this.lblShoesStyles.Name = "lblShoesStyles";
            this.lblShoesStyles.Size = new System.Drawing.Size(201, 36);
            this.lblShoesStyles.TabIndex = 15;
            this.lblShoesStyles.Text = "Shoes Styles";
            // 
            // gvShoesStyles
            // 
            this.gvShoesStyles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gvShoesStyles.Location = new System.Drawing.Point(78, 228);
            this.gvShoesStyles.Name = "gvShoesStyles";
            this.gvShoesStyles.RowHeadersWidth = 51;
            this.gvShoesStyles.RowTemplate.Height = 24;
            this.gvShoesStyles.Size = new System.Drawing.Size(690, 59);
            this.gvShoesStyles.TabIndex = 20;
            // 
            // gunaBtnAddOne
            // 
            this.gunaBtnAddOne.AnimationHoverSpeed = 0.07F;
            this.gunaBtnAddOne.AnimationSpeed = 0.03F;
            this.gunaBtnAddOne.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnAddOne.BaseColor = System.Drawing.Color.White;
            this.gunaBtnAddOne.BorderColor = System.Drawing.Color.Black;
            this.gunaBtnAddOne.BorderSize = 1;
            this.gunaBtnAddOne.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaBtnAddOne.FocusedColor = System.Drawing.Color.Empty;
            this.gunaBtnAddOne.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnAddOne.ForeColor = System.Drawing.Color.Black;
            this.gunaBtnAddOne.Image = null;
            this.gunaBtnAddOne.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaBtnAddOne.Location = new System.Drawing.Point(567, 12);
            this.gunaBtnAddOne.Name = "gunaBtnAddOne";
            this.gunaBtnAddOne.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaBtnAddOne.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaBtnAddOne.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaBtnAddOne.OnHoverImage = null;
            this.gunaBtnAddOne.OnPressedColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaBtnAddOne.Radius = 15;
            this.gunaBtnAddOne.Size = new System.Drawing.Size(124, 33);
            this.gunaBtnAddOne.TabIndex = 21;
            this.gunaBtnAddOne.Text = "Add One";
            this.gunaBtnAddOne.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // gunaBtnAddBulk
            // 
            this.gunaBtnAddBulk.AnimationHoverSpeed = 0.07F;
            this.gunaBtnAddBulk.AnimationSpeed = 0.03F;
            this.gunaBtnAddBulk.BackColor = System.Drawing.Color.Transparent;
            this.gunaBtnAddBulk.BaseColor = System.Drawing.Color.White;
            this.gunaBtnAddBulk.BorderColor = System.Drawing.Color.Black;
            this.gunaBtnAddBulk.BorderSize = 1;
            this.gunaBtnAddBulk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaBtnAddBulk.FocusedColor = System.Drawing.Color.Empty;
            this.gunaBtnAddBulk.Font = new System.Drawing.Font("Segoe UI Black", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaBtnAddBulk.ForeColor = System.Drawing.Color.Black;
            this.gunaBtnAddBulk.Image = null;
            this.gunaBtnAddBulk.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaBtnAddBulk.Location = new System.Drawing.Point(717, 12);
            this.gunaBtnAddBulk.Name = "gunaBtnAddBulk";
            this.gunaBtnAddBulk.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaBtnAddBulk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaBtnAddBulk.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaBtnAddBulk.OnHoverImage = null;
            this.gunaBtnAddBulk.OnPressedColor = System.Drawing.SystemColors.ActiveBorder;
            this.gunaBtnAddBulk.Radius = 15;
            this.gunaBtnAddBulk.Size = new System.Drawing.Size(124, 33);
            this.gunaBtnAddBulk.TabIndex = 22;
            this.gunaBtnAddBulk.Text = "Add Bulk";
            this.gunaBtnAddBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmShoesStyles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 571);
            this.Controls.Add(this.gunaBtnAddBulk);
            this.Controls.Add(this.gunaBtnAddOne);
            this.Controls.Add(this.gvShoesStyles);
            this.Controls.Add(this.txtShoeSize);
            this.Controls.Add(this.lblShoesStyles);
            this.Name = "frmShoesStyles";
            this.Text = "Shoes Styles";
            ((System.ComponentModel.ISupportInitialize)(this.gvShoesStyles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtShoeSize;
        private System.Windows.Forms.Label lblShoesStyles;
        private System.Windows.Forms.DataGridView gvShoesStyles;
        private Guna.UI.WinForms.GunaButton gunaBtnAddOne;
        private Guna.UI.WinForms.GunaButton gunaBtnAddBulk;
    }
}