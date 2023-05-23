namespace winShoesStoreManagementSystem
{
    partial class frmShoesSizes
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
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            this.gvShoeSizes = new Guna.UI.WinForms.GunaDataGridView();
            this.shoeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeBrand = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shoeSize = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAddItems = new Guna.UI.WinForms.GunaButton();
            this.btnAddBulk = new Guna.UI.WinForms.GunaButton();
            ((System.ComponentModel.ISupportInitialize)(this.gvShoeSizes)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.Color.Transparent;
            this.txtSearch.BaseColor = System.Drawing.Color.White;
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderSize = 1;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSearch.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSearch.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.txtSearch.Location = new System.Drawing.Point(1247, 116);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(223, 33);
            this.txtSearch.TabIndex = 29;
            this.txtSearch.Text = "Search...";
            // 
            // gvShoeSizes
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvShoeSizes.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvShoeSizes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvShoeSizes.BackgroundColor = System.Drawing.Color.White;
            this.gvShoeSizes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvShoeSizes.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvShoeSizes.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvShoeSizes.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvShoeSizes.ColumnHeadersHeight = 27;
            this.gvShoeSizes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.shoeId,
            this.shoeBrand,
            this.shoeSize});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvShoeSizes.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvShoeSizes.EnableHeadersVisualStyles = false;
            this.gvShoeSizes.GridColor = System.Drawing.Color.White;
            this.gvShoeSizes.Location = new System.Drawing.Point(92, 184);
            this.gvShoeSizes.Name = "gvShoeSizes";
            this.gvShoeSizes.ReadOnly = true;
            this.gvShoeSizes.RowHeadersVisible = false;
            this.gvShoeSizes.RowHeadersWidth = 51;
            this.gvShoeSizes.RowTemplate.Height = 24;
            this.gvShoeSizes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvShoeSizes.Size = new System.Drawing.Size(1378, 473);
            this.gvShoeSizes.TabIndex = 30;
            this.gvShoeSizes.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gvShoeSizes.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvShoeSizes.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvShoeSizes.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvShoeSizes.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvShoeSizes.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvShoeSizes.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvShoeSizes.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gvShoeSizes.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.gvShoeSizes.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvShoeSizes.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvShoeSizes.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvShoeSizes.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvShoeSizes.ThemeStyle.HeaderStyle.Height = 27;
            this.gvShoeSizes.ThemeStyle.ReadOnly = true;
            this.gvShoeSizes.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvShoeSizes.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvShoeSizes.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvShoeSizes.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvShoeSizes.ThemeStyle.RowsStyle.Height = 24;
            this.gvShoeSizes.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvShoeSizes.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // shoeId
            // 
            this.shoeId.HeaderText = "Shoe ID";
            this.shoeId.MinimumWidth = 6;
            this.shoeId.Name = "shoeId";
            this.shoeId.ReadOnly = true;
            // 
            // shoeBrand
            // 
            this.shoeBrand.HeaderText = "Shoe Brand";
            this.shoeBrand.MinimumWidth = 6;
            this.shoeBrand.Name = "shoeBrand";
            this.shoeBrand.ReadOnly = true;
            // 
            // shoeSize
            // 
            this.shoeSize.HeaderText = "Shoe Size";
            this.shoeSize.MinimumWidth = 6;
            this.shoeSize.Name = "shoeSize";
            this.shoeSize.ReadOnly = true;
            // 
            // btnAddItems
            // 
            this.btnAddItems.AnimationHoverSpeed = 0.07F;
            this.btnAddItems.AnimationSpeed = 0.03F;
            this.btnAddItems.BackColor = System.Drawing.Color.Transparent;
            this.btnAddItems.BaseColor = System.Drawing.Color.Gray;
            this.btnAddItems.BorderColor = System.Drawing.Color.Black;
            this.btnAddItems.BorderSize = 1;
            this.btnAddItems.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddItems.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddItems.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddItems.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddItems.ForeColor = System.Drawing.Color.White;
            this.btnAddItems.Image = null;
            this.btnAddItems.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddItems.Location = new System.Drawing.Point(92, 116);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItems.OnHoverImage = null;
            this.btnAddItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItems.Radius = 10;
            this.btnAddItems.Size = new System.Drawing.Size(125, 42);
            this.btnAddItems.TabIndex = 38;
            this.btnAddItems.Text = "+Add Items";
            this.btnAddItems.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddBulk
            // 
            this.btnAddBulk.AnimationHoverSpeed = 0.07F;
            this.btnAddBulk.AnimationSpeed = 0.03F;
            this.btnAddBulk.BackColor = System.Drawing.Color.Transparent;
            this.btnAddBulk.BaseColor = System.Drawing.Color.Gray;
            this.btnAddBulk.BorderColor = System.Drawing.Color.Black;
            this.btnAddBulk.BorderSize = 1;
            this.btnAddBulk.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddBulk.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnAddBulk.FocusedColor = System.Drawing.Color.Empty;
            this.btnAddBulk.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAddBulk.ForeColor = System.Drawing.Color.White;
            this.btnAddBulk.Image = null;
            this.btnAddBulk.ImageSize = new System.Drawing.Size(20, 20);
            this.btnAddBulk.Location = new System.Drawing.Point(233, 116);
            this.btnAddBulk.Name = "btnAddBulk";
            this.btnAddBulk.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddBulk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBulk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddBulk.OnHoverImage = null;
            this.btnAddBulk.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBulk.Radius = 10;
            this.btnAddBulk.Size = new System.Drawing.Size(127, 42);
            this.btnAddBulk.TabIndex = 39;
            this.btnAddBulk.Text = "+Add Bulk";
            this.btnAddBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmShoesSizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 732);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnAddBulk);
            this.Controls.Add(this.gvShoeSizes);
            this.Controls.Add(this.txtSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmShoesSizes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoes Sizes";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.gvShoeSizes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI.WinForms.GunaTextBox txtSearch;
        private Guna.UI.WinForms.GunaDataGridView gvShoeSizes;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeBrand;
        private System.Windows.Forms.DataGridViewTextBoxColumn shoeSize;
        private Guna.UI.WinForms.GunaButton btnAddItems;
        private Guna.UI.WinForms.GunaButton btnAddBulk;
    }
}