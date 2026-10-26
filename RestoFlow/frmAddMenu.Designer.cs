namespace RestoFlow
{
    partial class frmAddMenu
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
            this.cbaddAvailable = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbDescAddItem = new System.Windows.Forms.TextBox();
            this.cbAddMenuItem = new System.Windows.Forms.ComboBox();
            this.numStockAddItem = new System.Windows.Forms.NumericUpDown();
            this.numPriceAddItem = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNameAddItem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnBrowseMenu = new System.Windows.Forms.Button();
            this.btnCreateAddMenu = new System.Windows.Forms.Button();
            this.btnCancelAddMenu = new System.Windows.Forms.Button();
            this.PcbAddItem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.numStockAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceAddItem)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAddItem)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(24, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 37);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add New Menu";
            // 
            // cbaddAvailable
            // 
            this.cbaddAvailable.Location = new System.Drawing.Point(393, 401);
            this.cbaddAvailable.Name = "cbaddAvailable";
            this.cbaddAvailable.Size = new System.Drawing.Size(117, 24);
            this.cbaddAvailable.TabIndex = 28;
            this.cbaddAvailable.Text = "Unavailable";
            this.cbaddAvailable.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Description*";
            // 
            // tbDescAddItem
            // 
            this.tbDescAddItem.Location = new System.Drawing.Point(24, 350);
            this.tbDescAddItem.Name = "tbDescAddItem";
            this.tbDescAddItem.Size = new System.Drawing.Size(486, 26);
            this.tbDescAddItem.TabIndex = 26;
            this.tbDescAddItem.Text = "Optional Description";
            // 
            // cbAddMenuItem
            // 
            this.cbAddMenuItem.FormattingEnabled = true;
            this.cbAddMenuItem.Location = new System.Drawing.Point(24, 274);
            this.cbAddMenuItem.Name = "cbAddMenuItem";
            this.cbAddMenuItem.Size = new System.Drawing.Size(198, 28);
            this.cbAddMenuItem.TabIndex = 25;
            this.cbAddMenuItem.Text = "Select Category";
            // 
            // numStockAddItem
            // 
            this.numStockAddItem.Location = new System.Drawing.Point(318, 276);
            this.numStockAddItem.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numStockAddItem.Name = "numStockAddItem";
            this.numStockAddItem.Size = new System.Drawing.Size(192, 26);
            this.numStockAddItem.TabIndex = 24;
            // 
            // numPriceAddItem
            // 
            this.numPriceAddItem.Location = new System.Drawing.Point(318, 185);
            this.numPriceAddItem.Maximum = new decimal(new int[] {
            9999999,
            0,
            0,
            0});
            this.numPriceAddItem.Name = "numPriceAddItem";
            this.numPriceAddItem.Size = new System.Drawing.Size(192, 26);
            this.numPriceAddItem.TabIndex = 23;
            this.numPriceAddItem.ThousandsSeparator = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(314, 242);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 22;
            this.label5.Text = "Stock *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 20);
            this.label4.TabIndex = 21;
            this.label4.Text = "Category *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(314, 162);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 20;
            this.label3.Text = "Price (₱) *";
            // 
            // tbNameAddItem
            // 
            this.tbNameAddItem.Location = new System.Drawing.Point(24, 185);
            this.tbNameAddItem.Name = "tbNameAddItem";
            this.tbNameAddItem.Size = new System.Drawing.Size(248, 26);
            this.tbNameAddItem.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 162);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 18;
            this.label2.Text = "Name *";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(618, 162);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 20);
            this.label7.TabIndex = 29;
            this.label7.Text = "Item Image *";
            // 
            // btnBrowseMenu
            // 
            this.btnBrowseMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnBrowseMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBrowseMenu.Location = new System.Drawing.Point(581, 372);
            this.btnBrowseMenu.Name = "btnBrowseMenu";
            this.btnBrowseMenu.Size = new System.Drawing.Size(175, 37);
            this.btnBrowseMenu.TabIndex = 31;
            this.btnBrowseMenu.Text = "Browse";
            this.btnBrowseMenu.UseVisualStyleBackColor = false;
            this.btnBrowseMenu.Click += new System.EventHandler(this.btnBrowseMenu_Click);
            // 
            // btnCreateAddMenu
            // 
            this.btnCreateAddMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnCreateAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateAddMenu.Location = new System.Drawing.Point(643, 453);
            this.btnCreateAddMenu.Name = "btnCreateAddMenu";
            this.btnCreateAddMenu.Size = new System.Drawing.Size(113, 51);
            this.btnCreateAddMenu.TabIndex = 33;
            this.btnCreateAddMenu.Text = "Create";
            this.btnCreateAddMenu.UseVisualStyleBackColor = false;
            this.btnCreateAddMenu.Click += new System.EventHandler(this.btnCreateAddMenu_Click);
            // 
            // btnCancelAddMenu
            // 
            this.btnCancelAddMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelAddMenu.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddMenu.Location = new System.Drawing.Point(521, 453);
            this.btnCancelAddMenu.Name = "btnCancelAddMenu";
            this.btnCancelAddMenu.Size = new System.Drawing.Size(113, 51);
            this.btnCancelAddMenu.TabIndex = 32;
            this.btnCancelAddMenu.Text = "Cancel";
            this.btnCancelAddMenu.UseVisualStyleBackColor = false;
            this.btnCancelAddMenu.Click += new System.EventHandler(this.btnCancelAddMenu_Click);
            // 
            // PcbAddItem
            // 
            this.PcbAddItem.BackColor = System.Drawing.Color.White;
            this.PcbAddItem.Location = new System.Drawing.Point(581, 197);
            this.PcbAddItem.Name = "PcbAddItem";
            this.PcbAddItem.Size = new System.Drawing.Size(175, 150);
            this.PcbAddItem.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PcbAddItem.TabIndex = 30;
            this.PcbAddItem.TabStop = false;
            // 
            // frmAddMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(800, 527);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCreateAddMenu);
            this.Controls.Add(this.btnCancelAddMenu);
            this.Controls.Add(this.btnBrowseMenu);
            this.Controls.Add(this.PcbAddItem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cbaddAvailable);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbDescAddItem);
            this.Controls.Add(this.cbAddMenuItem);
            this.Controls.Add(this.numStockAddItem);
            this.Controls.Add(this.numPriceAddItem);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbNameAddItem);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmAddMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmAddMenu";
            ((System.ComponentModel.ISupportInitialize)(this.numStockAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numPriceAddItem)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PcbAddItem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox cbaddAvailable;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox tbDescAddItem;
        public System.Windows.Forms.ComboBox cbAddMenuItem;
        public System.Windows.Forms.NumericUpDown numStockAddItem;
        public System.Windows.Forms.NumericUpDown numPriceAddItem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox tbNameAddItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.PictureBox PcbAddItem;
        public System.Windows.Forms.Button btnBrowseMenu;
        public System.Windows.Forms.Button btnCreateAddMenu;
        public System.Windows.Forms.Button btnCancelAddMenu;
    }
}