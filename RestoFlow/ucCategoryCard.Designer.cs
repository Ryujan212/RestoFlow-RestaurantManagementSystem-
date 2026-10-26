namespace RestoFlow
{
    partial class ucCategoryCard
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
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.btnEditCategory = new System.Windows.Forms.Button();
            this.lbdescp = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.pcbCatIcon = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCatIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Location = new System.Drawing.Point(306, 15);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(42, 36);
            this.btnDeleteCategory.TabIndex = 21;
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            // 
            // btnEditCategory
            // 
            this.btnEditCategory.Location = new System.Drawing.Point(258, 15);
            this.btnEditCategory.Name = "btnEditCategory";
            this.btnEditCategory.Size = new System.Drawing.Size(42, 36);
            this.btnEditCategory.TabIndex = 20;
            this.btnEditCategory.UseVisualStyleBackColor = true;
            // 
            // lbdescp
            // 
            this.lbdescp.AutoSize = true;
            this.lbdescp.Location = new System.Drawing.Point(81, 70);
            this.lbdescp.Name = "lbdescp";
            this.lbdescp.Size = new System.Drawing.Size(89, 20);
            this.lbdescp.TabIndex = 19;
            this.lbdescp.Text = "Description";
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(81, 31);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(51, 20);
            this.lblCatName.TabIndex = 18;
            this.lblCatName.Text = "Name";
            // 
            // pcbCatIcon
            // 
            this.pcbCatIcon.Location = new System.Drawing.Point(12, 27);
            this.pcbCatIcon.Name = "pcbCatIcon";
            this.pcbCatIcon.Size = new System.Drawing.Size(63, 66);
            this.pcbCatIcon.TabIndex = 17;
            this.pcbCatIcon.TabStop = false;
            // 
            // ucCategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.btnDeleteCategory);
            this.Controls.Add(this.btnEditCategory);
            this.Controls.Add(this.lbdescp);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.pcbCatIcon);
            this.Name = "ucCategoryCard";
            this.Size = new System.Drawing.Size(361, 108);
            ((System.ComponentModel.ISupportInitialize)(this.pcbCatIcon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDeleteCategory;
        public System.Windows.Forms.Button btnEditCategory;
        public System.Windows.Forms.Label lbdescp;
        public System.Windows.Forms.Label lblCatName;
        public System.Windows.Forms.PictureBox pcbCatIcon;
    }
}
