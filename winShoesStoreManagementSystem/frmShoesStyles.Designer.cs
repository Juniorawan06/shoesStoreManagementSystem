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
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.txtShoeSize = new System.Windows.Forms.TextBox();
            this.lblEnterShoesStyle = new System.Windows.Forms.Label();
            this.lblShoesStyles = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.Location = new System.Drawing.Point(725, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 33);
            this.btnNext.TabIndex = 19;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.Location = new System.Drawing.Point(601, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 33);
            this.btnBack.TabIndex = 18;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtShoeSize
            // 
            this.txtShoeSize.Location = new System.Drawing.Point(458, 270);
            this.txtShoeSize.Multiline = true;
            this.txtShoeSize.Name = "txtShoeSize";
            this.txtShoeSize.Size = new System.Drawing.Size(146, 28);
            this.txtShoeSize.TabIndex = 17;
            // 
            // lblEnterShoesStyle
            // 
            this.lblEnterShoesStyle.AutoSize = true;
            this.lblEnterShoesStyle.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnterShoesStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnterShoesStyle.Location = new System.Drawing.Point(254, 270);
            this.lblEnterShoesStyle.Name = "lblEnterShoesStyle";
            this.lblEnterShoesStyle.Size = new System.Drawing.Size(176, 24);
            this.lblEnterShoesStyle.TabIndex = 16;
            this.lblEnterShoesStyle.Text = "Enter Shoes Style";
            // 
            // lblShoesStyles
            // 
            this.lblShoesStyles.AutoSize = true;
            this.lblShoesStyles.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoesStyles.Location = new System.Drawing.Point(327, 146);
            this.lblShoesStyles.Name = "lblShoesStyles";
            this.lblShoesStyles.Size = new System.Drawing.Size(201, 36);
            this.lblShoesStyles.TabIndex = 15;
            this.lblShoesStyles.Text = "Shoes Styles";
            // 
            // frmShoesStyles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 571);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtShoeSize);
            this.Controls.Add(this.lblEnterShoesStyle);
            this.Controls.Add(this.lblShoesStyles);
            this.Name = "frmShoesStyles";
            this.Text = "Shoes Styles";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtShoeSize;
        private System.Windows.Forms.Label lblEnterShoesStyle;
        private System.Windows.Forms.Label lblShoesStyles;
    }
}