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
            this.lblShoesSizes = new System.Windows.Forms.Label();
            this.lblEnterShoesSize = new System.Windows.Forms.Label();
            this.txtShoeSize = new System.Windows.Forms.TextBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblShoesSizes
            // 
            this.lblShoesSizes.AutoSize = true;
            this.lblShoesSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShoesSizes.Location = new System.Drawing.Point(327, 146);
            this.lblShoesSizes.Name = "lblShoesSizes";
            this.lblShoesSizes.Size = new System.Drawing.Size(192, 36);
            this.lblShoesSizes.TabIndex = 5;
            this.lblShoesSizes.Text = "Shoes Sizes";
            // 
            // lblEnterShoesSize
            // 
            this.lblEnterShoesSize.AutoSize = true;
            this.lblEnterShoesSize.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lblEnterShoesSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lblEnterShoesSize.Location = new System.Drawing.Point(254, 270);
            this.lblEnterShoesSize.Name = "lblEnterShoesSize";
            this.lblEnterShoesSize.Size = new System.Drawing.Size(171, 24);
            this.lblEnterShoesSize.TabIndex = 6;
            this.lblEnterShoesSize.Text = "Enter Shoes Size";
            // 
            // txtShoeSize
            // 
            this.txtShoeSize.Location = new System.Drawing.Point(458, 270);
            this.txtShoeSize.Multiline = true;
            this.txtShoeSize.Name = "txtShoeSize";
            this.txtShoeSize.Size = new System.Drawing.Size(146, 28);
            this.txtShoeSize.TabIndex = 7;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnCancel.Location = new System.Drawing.Point(601, 526);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(104, 33);
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnNext.Location = new System.Drawing.Point(725, 526);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(104, 33);
            this.btnNext.TabIndex = 9;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            // 
            // frmShoesSizes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 571);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.txtShoeSize);
            this.Controls.Add(this.lblEnterShoesSize);
            this.Controls.Add(this.lblShoesSizes);
            this.Name = "frmShoesSizes";
            this.Text = "Shoes Sizes";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblShoesSizes;
        private System.Windows.Forms.Label lblEnterShoesSize;
        private System.Windows.Forms.TextBox txtShoeSize;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnNext;
    }
}