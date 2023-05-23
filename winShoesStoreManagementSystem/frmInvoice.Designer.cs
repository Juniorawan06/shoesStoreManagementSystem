namespace winShoesStoreManagementSystem
{
    partial class frmInvoice
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gvInvoice = new Guna.UI.WinForms.GunaDataGridView();
            this.shoeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeColor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeStyle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoePrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCancel = new Guna.UI.WinForms.GunaButton();
            this.btnConfirm = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoice)).BeginInit();
            this.SuspendLayout();
            // 
            // gvInvoice
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvInvoice.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvInvoice.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvInvoice.BackgroundColor = System.Drawing.Color.White;
            this.gvInvoice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvInvoice.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvInvoice.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvInvoice.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvInvoice.ColumnHeadersHeight = 27;
            this.gvInvoice.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoeId,
            this.shoeColor,
            this.shoeStyle,
            this.shoeSize,
            this.shoePrice});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvInvoice.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvInvoice.EnableHeadersVisualStyles = false;
            this.gvInvoice.GridColor = System.Drawing.Color.White;
            this.gvInvoice.Location = new System.Drawing.Point(67, 114);
            this.gvInvoice.Name = "gvInvoice";
            this.gvInvoice.ReadOnly = true;
            this.gvInvoice.RowHeadersVisible = false;
            this.gvInvoice.RowHeadersWidth = 51;
            this.gvInvoice.RowTemplate.Height = 24;
            this.gvInvoice.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvInvoice.Size = new System.Drawing.Size(1424, 329);
            this.gvInvoice.TabIndex = 6;
            this.gvInvoice.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gvInvoice.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvInvoice.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvInvoice.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvInvoice.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvInvoice.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvInvoice.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gvInvoice.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.gvInvoice.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvInvoice.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvInvoice.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvInvoice.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvInvoice.ThemeStyle.HeaderStyle.Height = 27;
            this.gvInvoice.ThemeStyle.ReadOnly = true;
            this.gvInvoice.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvInvoice.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvInvoice.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvInvoice.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvInvoice.ThemeStyle.RowsStyle.Height = 24;
            this.gvInvoice.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvInvoice.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // shoeId
            // 
            this.shoeId.HeaderText = "Shoe ID";
            this.shoeId.MinimumWidth = 6;
            this.shoeId.Name = "shoeId";
            this.shoeId.ReadOnly = true;
            // 
            // shoeColor
            // 
            this.shoeColor.HeaderText = "Shoe Color";
            this.shoeColor.MinimumWidth = 6;
            this.shoeColor.Name = "shoeColor";
            this.shoeColor.ReadOnly = true;
            // 
            // shoeStyle
            // 
            this.shoeStyle.HeaderText = "Shoe Style";
            this.shoeStyle.MinimumWidth = 6;
            this.shoeStyle.Name = "shoeStyle";
            this.shoeStyle.ReadOnly = true;
            // 
            // shoeSize
            // 
            this.shoeSize.HeaderText = "Shoe Size";
            this.shoeSize.MinimumWidth = 6;
            this.shoeSize.Name = "shoeSize";
            this.shoeSize.ReadOnly = true;
            // 
            // shoePrice
            // 
            this.shoePrice.HeaderText = "Shoe Price";
            this.shoePrice.MinimumWidth = 6;
            this.shoePrice.Name = "shoePrice";
            this.shoePrice.ReadOnly = true;
            // 
            // btnCancel
            // 
            this.btnCancel.AnimationHoverSpeed = 0.07F;
            this.btnCancel.AnimationSpeed = 0.03F;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.Gray;
            this.btnCancel.BorderColor = System.Drawing.Color.Black;
            this.btnCancel.BorderSize = 1;
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnCancel.FocusedColor = System.Drawing.Color.Empty;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Image = null;
            this.btnCancel.ImageSize = new System.Drawing.Size(20, 20);
            this.btnCancel.Location = new System.Drawing.Point(1144, 482);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnCancel.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnCancel.OnHoverForeColor = System.Drawing.Color.White;
            this.btnCancel.OnHoverImage = null;
            this.btnCancel.OnPressedColor = System.Drawing.Color.Black;
            this.btnCancel.Radius = 10;
            this.btnCancel.Size = new System.Drawing.Size(160, 42);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnConfirm
            // 
            this.btnConfirm.AnimationHoverSpeed = 0.07F;
            this.btnConfirm.AnimationSpeed = 0.03F;
            this.btnConfirm.BackColor = System.Drawing.Color.Transparent;
            this.btnConfirm.BaseColor = System.Drawing.Color.Gray;
            this.btnConfirm.BorderColor = System.Drawing.Color.Black;
            this.btnConfirm.BorderSize = 1;
            this.btnConfirm.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnConfirm.FocusedColor = System.Drawing.Color.Empty;
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnConfirm.ForeColor = System.Drawing.Color.White;
            this.btnConfirm.Image = null;
            this.btnConfirm.ImageSize = new System.Drawing.Size(20, 20);
            this.btnConfirm.Location = new System.Drawing.Point(1331, 482);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnConfirm.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnConfirm.OnHoverForeColor = System.Drawing.Color.White;
            this.btnConfirm.OnHoverImage = null;
            this.btnConfirm.OnPressedColor = System.Drawing.Color.Black;
            this.btnConfirm.Radius = 10;
            this.btnConfirm.Size = new System.Drawing.Size(160, 42);
            this.btnConfirm.TabIndex = 8;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 732);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.gvInvoice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInvoice";
            this.Text = "Invoice";
            ((System.ComponentModel.ISupportInitialize)(this.gvInvoice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gvInvoice;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeColor;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeStyle;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeSize;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoePrice;
        private Guna.UI.WinForms.GunaButton btnCancel;
        private Guna.UI.WinForms.GunaButton btnConfirm;
    }
}