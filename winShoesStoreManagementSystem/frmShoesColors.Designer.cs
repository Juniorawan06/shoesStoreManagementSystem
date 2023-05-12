namespace winShoesStoreManagementSystem
{
    partial class frmShoesColors
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
            this.lblEnterShoesColor = new System.Windows.Forms.Label();
            this.lblShoesColors = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.Location = new System.Drawing.Point(725, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 33);
            this.btnNext.TabIndex = 14;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // btnBack
            // 
            this.btnBack.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnBack.Location = new System.Drawing.Point(601, 526);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(104, 33);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // txtShoeSize
            // 
            this.txtShoeSize.Location = new System.Drawing.Point(458, 270);
            this.txtShoeSize.Multiline = true;
            this.txtShoeSize.Name = "txtShoeSize";
            this.txtShoeSize.Size = new System.Drawing.Size(146, 28);
            this.txtShoeSize.TabIndex = 12;
            // 
            // lblEnterShoesColor
            // 
            this.lblEnterShoesColor.AutoSize = true;
            this.lblEnterShoesColor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnterShoesColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnterShoesColor.Location = new System.Drawing.Point(254, 270);
            this.lblEnterShoesColor.Name = "lblEnterShoesColor";
            this.lblEnterShoesColor.Size = new System.Drawing.Size(181, 24);
            this.lblEnterShoesColor.TabIndex = 11;
            this.lblEnterShoesColor.Text = "Enter Shoes Color";
            // 
            // lblShoesColors
            // 
            this.lblShoesColors.AutoSize = true;
            this.lblShoesColors.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoesColors.Location = new System.Drawing.Point(327, 146);
            this.lblShoesColors.Name = "lblShoesColors";
            this.lblShoesColors.Size = new System.Drawing.Size(207, 36);
            this.lblShoesColors.TabIndex = 10;
            this.lblShoesColors.Text = "Shoes Colors";
            // 
            // frmShoesColors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 571);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.txtShoeSize);
            this.Controls.Add(this.lblEnterShoesColor);
            this.Controls.Add(this.lblShoesColors);
            this.Name = "frmShoesColors";
            this.Text = "frmShoesColors";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.TextBox txtShoeSize;
        private System.Windows.Forms.Label lblEnterShoesColor;
        private System.Windows.Forms.Label lblShoesColors;
    }
}