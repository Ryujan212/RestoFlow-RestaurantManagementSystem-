namespace RestoFlow
{
    partial class ucAdminFoodCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFoodStock = new System.Windows.Forms.Label();
            this.lblFoodPrice = new System.Windows.Forms.Label();
            this.lblFoodName = new System.Windows.Forms.Label();
            this.pcbFoodImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoodImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFoodStock
            // 
            this.lblFoodStock.AutoSize = true;
            this.lblFoodStock.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodStock.Location = new System.Drawing.Point(113, 198);
            this.lblFoodStock.Name = "lblFoodStock";
            this.lblFoodStock.Size = new System.Drawing.Size(65, 20);
            this.lblFoodStock.TabIndex = 9;
            this.lblFoodStock.Text = "Stock: 29";
            this.lblFoodStock.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // lblFoodPrice
            // 
            this.lblFoodPrice.AutoSize = true;
            this.lblFoodPrice.Font = new System.Drawing.Font("Arial Narrow", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.lblFoodPrice.Location = new System.Drawing.Point(3, 198);
            this.lblFoodPrice.Name = "lblFoodPrice";
            this.lblFoodPrice.Size = new System.Drawing.Size(60, 20);
            this.lblFoodPrice.TabIndex = 8;
            this.lblFoodPrice.Text = "₱120.00";
            // 
            // lblFoodName
            // 
            this.lblFoodName.Font = new System.Drawing.Font("Arial Narrow", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFoodName.Location = new System.Drawing.Point(3, 156);
            this.lblFoodName.Name = "lblFoodName";
            this.lblFoodName.Size = new System.Drawing.Size(150, 22);
            this.lblFoodName.TabIndex = 7;
            this.lblFoodName.Text = "Cheese Burger XL";
            // 
            // pcbFoodImage
            // 
            this.pcbFoodImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.pcbFoodImage.Location = new System.Drawing.Point(0, 0);
            this.pcbFoodImage.Name = "pcbFoodImage";
            this.pcbFoodImage.Size = new System.Drawing.Size(244, 136);
            this.pcbFoodImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbFoodImage.TabIndex = 6;
            this.pcbFoodImage.TabStop = false;
            // 
            // ucAdminFoodCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblFoodStock);
            this.Controls.Add(this.lblFoodPrice);
            this.Controls.Add(this.lblFoodName);
            this.Controls.Add(this.pcbFoodImage);
            this.Name = "ucAdminFoodCard";
            this.Size = new System.Drawing.Size(244, 226);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFoodImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblFoodStock;
        public System.Windows.Forms.Label lblFoodPrice;
        public System.Windows.Forms.Label lblFoodName;
        public System.Windows.Forms.PictureBox pcbFoodImage;
    }
}
