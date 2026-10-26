namespace RestoFlow
{
    partial class TableCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TableCard));
            this.cmbStatusDropdown = new System.Windows.Forms.ComboBox();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.pnlStatusColor = new System.Windows.Forms.Panel();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.lblTableGuestName = new System.Windows.Forms.Label();
            this.lblTimeTable = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbStatusDropdown
            // 
            this.cmbStatusDropdown.FormattingEnabled = true;
            this.cmbStatusDropdown.Location = new System.Drawing.Point(25, 158);
            this.cmbStatusDropdown.Name = "cmbStatusDropdown";
            this.cmbStatusDropdown.Size = new System.Drawing.Size(87, 28);
            this.cmbStatusDropdown.TabIndex = 19;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(18, 92);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(72, 20);
            this.lblStatusText.TabIndex = 18;
            this.lblStatusText.Text = "Available";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(61, 68);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(61, 20);
            this.lblSeats.TabIndex = 17;
            this.lblSeats.Text = "0 seats";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.Location = new System.Drawing.Point(70, 33);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(36, 37);
            this.lblTableNumber.TabIndex = 15;
            this.lblTableNumber.Text = "0";
            // 
            // pnlStatusColor
            // 
            this.pnlStatusColor.Location = new System.Drawing.Point(80, 14);
            this.pnlStatusColor.Name = "pnlStatusColor";
            this.pnlStatusColor.Size = new System.Drawing.Size(15, 15);
            this.pnlStatusColor.TabIndex = 14;
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTable.Image")));
            this.btnDeleteTable.Location = new System.Drawing.Point(118, 151);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(37, 35);
            this.btnDeleteTable.TabIndex = 20;
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // lblTableGuestName
            // 
            this.lblTableGuestName.AutoSize = true;
            this.lblTableGuestName.Location = new System.Drawing.Point(61, 126);
            this.lblTableGuestName.Name = "lblTableGuestName";
            this.lblTableGuestName.Size = new System.Drawing.Size(49, 20);
            this.lblTableGuestName.TabIndex = 22;
            this.lblTableGuestName.Text = "name";
            // 
            // lblTimeTable
            // 
            this.lblTimeTable.AutoSize = true;
            this.lblTimeTable.Location = new System.Drawing.Point(112, 92);
            this.lblTimeTable.Name = "lblTimeTable";
            this.lblTimeTable.Size = new System.Drawing.Size(39, 20);
            this.lblTimeTable.TabIndex = 21;
            this.lblTimeTable.Text = "time";
            // 
            // TableCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblTableGuestName);
            this.Controls.Add(this.lblTimeTable);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.cmbStatusDropdown);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.pnlStatusColor);
            this.Name = "TableCard";
            this.Size = new System.Drawing.Size(180, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnDeleteTable;
        public System.Windows.Forms.ComboBox cmbStatusDropdown;
        public System.Windows.Forms.Label lblStatusText;
        public System.Windows.Forms.Label lblSeats;
        public System.Windows.Forms.Label lblTableNumber;
        public System.Windows.Forms.Panel pnlStatusColor;
        private System.Windows.Forms.Label lblTableGuestName;
        private System.Windows.Forms.Label lblTimeTable;
    }
}
