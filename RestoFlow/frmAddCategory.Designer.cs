namespace RestoFlow
{
    partial class frmAddCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.tbDescAddCat = new System.Windows.Forms.TextBox();
            this.tbNameAddcat = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnCreateAddItem = new System.Windows.Forms.Button();
            this.btnCancelAddItem = new System.Windows.Forms.Button();
            this.btnBrowseCatMenu = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PcbAddItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(28, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(302, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New Category";
            // 
            // tbDescAddCat
            // 
            this.tbDescAddCat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbDescAddCat.Location = new System.Drawing.Point(35, 281);
            this.tbDescAddCat.Name = "tbDescAddCat";
            this.tbDescAddCat.Size = new System.Drawing.Size(357, 26);
            this.tbDescAddCat.TabIndex = 23;
            this.tbDescAddCat.Text = "Optional Description";
            // 
            // tbNameAddcat
            // 
            this.tbNameAddcat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.tbNameAddcat.Location = new System.Drawing.Point(35, 201);
            this.tbNameAddcat.Name = "tbNameAddcat";
            this.tbNameAddcat.Size = new System.Drawing.Size(357, 26);
            this.tbNameAddcat.TabIndex = 22;
            this.tbNameAddcat.Text = "e.g Main Course";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 249);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Name";
            // 
            // btnCreateAddItem
            // 
            this.btnCreateAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAddItem.Location = new System.Drawing.Point(644, 455);
            this.btnCreateAddItem.Name = "btnCreateAddItem";
            this.btnCreateAddItem.Size = new System.Drawing.Size(95, 43);
            this.btnCreateAddItem.TabIndex = 35;
            this.btnCreateAddItem.Text = "Create";
            this.btnCreateAddItem.UseVisualStyleBackColor = false;
            this.btnCreateAddItem.Click += new System.EventHandler(this.btnCreateAddItem_Click);
            // 
            // btnCancelAddItem
            // 
            this.btnCancelAddItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelAddItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddItem.Location = new System.Drawing.Point(522, 455);
            this.btnCancelAddItem.Name = "btnCancelAddItem";
            this.btnCancelAddItem.Size = new System.Drawing.Size(95, 43);
            this.btnCancelAddItem.TabIndex = 34;
            this.btnCancelAddItem.Text = "Cancel";
            this.btnCancelAddItem.UseVisualStyleBackColor = false;
            this.btnCancelAddItem.Click += new System.EventHandler(this.btnCancelAddItem_Click);
            // 
            // btnBrowseCatMenu
            // 
            this.btnBrowseCatMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowseCatMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseCatMenu.Location = new System.Drawing.Point(549, 353);
            this.btnBrowseCatMenu.Name = "btnBrowseCatMenu";
            this.btnBrowseCatMenu.Size = new System.Drawing.Size(175, 37);
            this.btnBrowseCatMenu.TabIndex = 38;
            this.btnBrowseCatMenu.Text = "Browse";
            this.btnBrowseCatMenu.UseVisualStyleBackColor = false;
            this.btnBrowseCatMenu.Click += new System.EventHandler(this.btnBrowseCatMenu_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(579, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(132, 20);
            this.label7.TabIndex = 36;
            this.label7.Text = "Category Image *";
            // 
            // PcbAddItem
            // 
            this.PcbAddItem.BackColor = System.Drawing.Color.White;
            this.PcbAddItem.Location = new System.Drawing.Point(549, 178);
            this.PcbAddItem.Name = "PcbAddItem";
            this.PcbAddItem.Size = new System.Drawing.Size(175, 150);
            this.PcbAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAddItem.TabIndex = 37;
            this.PcbAddItem.TabStop = false;
            // 
            // frmAddCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBrowseCatMenu);
            this.Controls.Add(this.PcbAddItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnCreateAddItem);
            this.Controls.Add(this.btnCancelAddItem);
            this.Controls.Add(this.tbDescAddCat);
            this.Controls.Add(this.tbNameAddcat);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddCategory";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddCategory";
            ((System.ComponentModel.ISupportInitialize)(this.PcbAddItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.TextBox tbDescAddCat;
        public System.Windows.Forms.TextBox tbNameAddcat;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnCreateAddItem;
        public System.Windows.Forms.Button btnCancelAddItem;
        public System.Windows.Forms.Button btnBrowseCatMenu;
        public System.Windows.Forms.PictureBox PcbAddItem;
        private System.Windows.Forms.Label label7;
    }
}