namespace winShoesStoreManagementSystem
{
    partial class frmStock
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
            this.gvStock = new Guna.UI.WinForms.GunaDataGridView();
            this.btnAddItems = new Guna.UI.WinForms.GunaButton();
            this.btnAddBulk = new Guna.UI.WinForms.GunaButton();
            this.txtSearch = new Guna.UI.WinForms.GunaTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).BeginInit();
            this.SuspendLayout();
            // 
            // gvStock
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.gvStock.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.gvStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.gvStock.BackgroundColor = System.Drawing.Color.White;
            this.gvStock.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.gvStock.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvStock.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Gray;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gvStock.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.gvStock.ColumnHeadersHeight = 27;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gvStock.DefaultCellStyle = dataGridViewCellStyle3;
            this.gvStock.EnableHeadersVisualStyles = false;
            this.gvStock.GridColor = System.Drawing.Color.White;
            this.gvStock.Location = new System.Drawing.Point(50, 217);
            this.gvStock.Name = "gvStock";
            this.gvStock.ReadOnly = true;
            this.gvStock.RowHeadersVisible = false;
            this.gvStock.RowHeadersWidth = 51;
            this.gvStock.RowTemplate.Height = 24;
            this.gvStock.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.gvStock.Size = new System.Drawing.Size(1419, 467);
            this.gvStock.TabIndex = 32;
            this.gvStock.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.gvStock.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.gvStock.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.gvStock.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.gvStock.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.gvStock.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.gvStock.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.gvStock.ThemeStyle.GridColor = System.Drawing.Color.White;
            this.gvStock.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.Gray;
            this.gvStock.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.gvStock.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvStock.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.gvStock.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.gvStock.ThemeStyle.HeaderStyle.Height = 27;
            this.gvStock.ThemeStyle.ReadOnly = true;
            this.gvStock.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.gvStock.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.gvStock.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.gvStock.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.gvStock.ThemeStyle.RowsStyle.Height = 24;
            this.gvStock.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.gvStock.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
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
            this.btnAddItems.Location = new System.Drawing.Point(50, 126);
            this.btnAddItems.Name = "btnAddItems";
            this.btnAddItems.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddItems.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddItems.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddItems.OnHoverImage = null;
            this.btnAddItems.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddItems.Radius = 10;
            this.btnAddItems.Size = new System.Drawing.Size(125, 42);
            this.btnAddItems.TabIndex = 42;
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
            this.btnAddBulk.Location = new System.Drawing.Point(190, 126);
            this.btnAddBulk.Name = "btnAddBulk";
            this.btnAddBulk.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnAddBulk.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnAddBulk.OnHoverForeColor = System.Drawing.Color.White;
            this.btnAddBulk.OnHoverImage = null;
            this.btnAddBulk.OnPressedColor = System.Drawing.Color.Black;
            this.btnAddBulk.Radius = 10;
            this.btnAddBulk.Size = new System.Drawing.Size(127, 42);
            this.btnAddBulk.TabIndex = 43;
            this.btnAddBulk.Text = "+Add Bulk";
            this.btnAddBulk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.txtSearch.Location = new System.Drawing.Point(1098, 159);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.Radius = 8;
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(223, 33);
            this.txtSearch.TabIndex = 44;
            this.txtSearch.Text = "Search...";
            // 
            // frmStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 777);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.btnAddItems);
            this.Controls.Add(this.btnAddBulk);
            this.Controls.Add(this.gvStock);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmStock";
            this.Text = "~";
            ((System.ComponentModel.ISupportInitialize)(this.gvStock)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI.WinForms.GunaDataGridView gvStock;
        private Guna.UI.WinForms.GunaButton btnAddItems;
        private Guna.UI.WinForms.GunaButton btnAddBulk;
        private Guna.UI.WinForms.GunaTextBox txtSearch;
    }
}