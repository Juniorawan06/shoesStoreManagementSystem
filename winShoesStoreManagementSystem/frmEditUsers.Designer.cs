namespace winShoesStoreManagementSystem
{
    partial class frmEditUsers
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
            this.btnUpdate = new Guna.UI.WinForms.GunaButton();
            this.lblRole = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.lblUsername = new System.Windows.Forms.Label();
            this.txtContact = new Guna.UI.WinForms.GunaTextBox();
            this.txtUsername = new Guna.UI.WinForms.GunaTextBox();
            this.lblUpdateUsers = new System.Windows.Forms.Label();
            this.cmbRole = new Guna.UI.WinForms.GunaComboBox();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.AnimationHoverSpeed = 0.07F;
            this.btnUpdate.AnimationSpeed = 0.03F;
            this.btnUpdate.BackColor = System.Drawing.Color.Transparent;
            this.btnUpdate.BaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.BorderColor = System.Drawing.Color.Black;
            this.btnUpdate.BorderSize = 1;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnUpdate.FocusedColor = System.Drawing.Color.Empty;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Image = null;
            this.btnUpdate.ImageSize = new System.Drawing.Size(20, 20);
            this.btnUpdate.Location = new System.Drawing.Point(404, 401);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.OnHoverBaseColor = System.Drawing.Color.Gray;
            this.btnUpdate.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnUpdate.OnHoverForeColor = System.Drawing.Color.White;
            this.btnUpdate.OnHoverImage = null;
            this.btnUpdate.OnPressedColor = System.Drawing.Color.Black;
            this.btnUpdate.Radius = 10;
            this.btnUpdate.Size = new System.Drawing.Size(160, 42);
            this.btnUpdate.TabIndex = 43;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // lblRole
            // 
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblRole.Location = new System.Drawing.Point(35, 287);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(46, 23);
            this.lblRole.TabIndex = 39;
            this.lblRole.Text = "Role";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblContact.Location = new System.Drawing.Point(35, 196);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(75, 23);
            this.lblContact.TabIndex = 40;
            this.lblContact.Text = "Contact";
            // 
            // lblUsername
            // 
            this.lblUsername.AutoSize = true;
            this.lblUsername.Font = new System.Drawing.Font("Segoe UI Black", 10F, System.Drawing.FontStyle.Italic);
            this.lblUsername.Location = new System.Drawing.Point(35, 99);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(94, 23);
            this.lblUsername.TabIndex = 42;
            this.lblUsername.Text = "Username";
            // 
            // txtContact
            // 
            this.txtContact.BackColor = System.Drawing.Color.Transparent;
            this.txtContact.BaseColor = System.Drawing.Color.White;
            this.txtContact.BorderColor = System.Drawing.Color.Transparent;
            this.txtContact.BorderSize = 1;
            this.txtContact.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtContact.FocusedBaseColor = System.Drawing.Color.White;
            this.txtContact.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtContact.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtContact.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtContact.ForeColor = System.Drawing.Color.Black;
            this.txtContact.Location = new System.Drawing.Point(31, 223);
            this.txtContact.Margin = new System.Windows.Forms.Padding(4);
            this.txtContact.Name = "txtContact";
            this.txtContact.PasswordChar = '\0';
            this.txtContact.Radius = 5;
            this.txtContact.SelectedText = "";
            this.txtContact.Size = new System.Drawing.Size(888, 41);
            this.txtContact.TabIndex = 33;
            // 
            // txtUsername
            // 
            this.txtUsername.BackColor = System.Drawing.Color.Transparent;
            this.txtUsername.BaseColor = System.Drawing.Color.White;
            this.txtUsername.BorderColor = System.Drawing.Color.Transparent;
            this.txtUsername.BorderSize = 1;
            this.txtUsername.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUsername.FocusedBaseColor = System.Drawing.Color.White;
            this.txtUsername.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtUsername.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtUsername.Font = new System.Drawing.Font("Segoe UI", 10.8F);
            this.txtUsername.ForeColor = System.Drawing.Color.Black;
            this.txtUsername.Location = new System.Drawing.Point(31, 126);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.PasswordChar = '\0';
            this.txtUsername.Radius = 5;
            this.txtUsername.SelectedText = "";
            this.txtUsername.Size = new System.Drawing.Size(888, 41);
            this.txtUsername.TabIndex = 35;
            // 
            // lblUpdateUsers
            // 
            this.lblUpdateUsers.AutoSize = true;
            this.lblUpdateUsers.BackColor = System.Drawing.Color.Transparent;
            this.lblUpdateUsers.Font = new System.Drawing.Font("Segoe UI Black", 16F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblUpdateUsers.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblUpdateUsers.Location = new System.Drawing.Point(32, 40);
            this.lblUpdateUsers.Name = "lblUpdateUsers";
            this.lblUpdateUsers.Size = new System.Drawing.Size(394, 37);
            this.lblUpdateUsers.TabIndex = 28;
            this.lblUpdateUsers.Text = "FIll The Form to Update User";
            // 
            // cmbRole
            // 
            this.cmbRole.BackColor = System.Drawing.Color.Transparent;
            this.cmbRole.BaseColor = System.Drawing.Color.White;
            this.cmbRole.BorderColor = System.Drawing.Color.Silver;
            this.cmbRole.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbRole.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRole.FocusedColor = System.Drawing.Color.Empty;
            this.cmbRole.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cmbRole.ForeColor = System.Drawing.Color.Black;
            this.cmbRole.FormattingEnabled = true;
            this.cmbRole.Items.AddRange(new object[] {
            "--Select--",
            "Admin",
            "User"});
            this.cmbRole.Location = new System.Drawing.Point(31, 315);
            this.cmbRole.Name = "cmbRole";
            this.cmbRole.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cmbRole.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cmbRole.Radius = 5;
            this.cmbRole.Size = new System.Drawing.Size(888, 31);
            this.cmbRole.TabIndex = 44;
            // 
            // frmEditUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 520);
            this.Controls.Add(this.cmbRole);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.lblRole);
            this.Controls.Add(this.lblContact);
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.txtContact);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.lblUpdateUsers);
            this.Name = "frmEditUsers";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditUsers";
            this.Load += new System.EventHandler(this.frmEditUsers_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaButton btnUpdate;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label lblUsername;
        private Guna.UI.WinForms.GunaTextBox txtContact;
        private Guna.UI.WinForms.GunaTextBox txtUsername;
        private System.Windows.Forms.Label lblUpdateUsers;
        private Guna.UI.WinForms.GunaComboBox cmbRole;
    }
}