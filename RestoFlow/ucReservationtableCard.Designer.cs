namespace RestoFlow
{
    partial class ucReservationtableCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucReservationtableCard));
            this.lblTableGuestName = new System.Windows.Forms.Label();
            this.lblTimeTable = new System.Windows.Forms.Label();
            this.btnDeleteTable = new System.Windows.Forms.Button();
            this.cmbStatusDropdown = new System.Windows.Forms.ComboBox();
            this.lblStatusText = new System.Windows.Forms.Label();
            this.lblSeats = new System.Windows.Forms.Label();
            this.lblTableNumber = new System.Windows.Forms.Label();
            this.pnlStatusColor = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lblTableGuestName
            // 
            this.lblTableGuestName.AutoSize = true;
            this.lblTableGuestName.Location = new System.Drawing.Point(65, 131);
            this.lblTableGuestName.Name = "lblTableGuestName";
            this.lblTableGuestName.Size = new System.Drawing.Size(49, 20);
            this.lblTableGuestName.TabIndex = 30;
            this.lblTableGuestName.Text = "name";
            // 
            // lblTimeTable
            // 
            this.lblTimeTable.AutoSize = true;
            this.lblTimeTable.Location = new System.Drawing.Point(116, 97);
            this.lblTimeTable.Name = "lblTimeTable";
            this.lblTimeTable.Size = new System.Drawing.Size(39, 20);
            this.lblTimeTable.TabIndex = 29;
            this.lblTimeTable.Text = "time";
            // 
            // btnDeleteTable
            // 
            this.btnDeleteTable.Image = ((System.Drawing.Image)(resources.GetObject("btnDeleteTable.Image")));
            this.btnDeleteTable.Location = new System.Drawing.Point(122, 156);
            this.btnDeleteTable.Name = "btnDeleteTable";
            this.btnDeleteTable.Size = new System.Drawing.Size(37, 35);
            this.btnDeleteTable.TabIndex = 28;
            this.btnDeleteTable.UseVisualStyleBackColor = true;
            // 
            // cmbStatusDropdown
            // 
            this.cmbStatusDropdown.FormattingEnabled = true;
            this.cmbStatusDropdown.Location = new System.Drawing.Point(29, 163);
            this.cmbStatusDropdown.Name = "cmbStatusDropdown";
            this.cmbStatusDropdown.Size = new System.Drawing.Size(87, 28);
            this.cmbStatusDropdown.TabIndex = 27;
            // 
            // lblStatusText
            // 
            this.lblStatusText.AutoSize = true;
            this.lblStatusText.Location = new System.Drawing.Point(22, 97);
            this.lblStatusText.Name = "lblStatusText";
            this.lblStatusText.Size = new System.Drawing.Size(72, 20);
            this.lblStatusText.TabIndex = 26;
            this.lblStatusText.Text = "Available";
            // 
            // lblSeats
            // 
            this.lblSeats.AutoSize = true;
            this.lblSeats.Location = new System.Drawing.Point(65, 73);
            this.lblSeats.Name = "lblSeats";
            this.lblSeats.Size = new System.Drawing.Size(61, 20);
            this.lblSeats.TabIndex = 25;
            this.lblSeats.Text = "0 seats";
            // 
            // lblTableNumber
            // 
            this.lblTableNumber.AutoSize = true;
            this.lblTableNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTableNumber.Location = new System.Drawing.Point(74, 38);
            this.lblTableNumber.Name = "lblTableNumber";
            this.lblTableNumber.Size = new System.Drawing.Size(36, 37);
            this.lblTableNumber.TabIndex = 24;
            this.lblTableNumber.Text = "0";
            // 
            // pnlStatusColor
            // 
            this.pnlStatusColor.Location = new System.Drawing.Point(84, 19);
            this.pnlStatusColor.Name = "pnlStatusColor";
            this.pnlStatusColor.Size = new System.Drawing.Size(15, 15);
            this.pnlStatusColor.TabIndex = 23;
            // 
            // ucReservationtableCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblTableGuestName);
            this.Controls.Add(this.lblTimeTable);
            this.Controls.Add(this.btnDeleteTable);
            this.Controls.Add(this.cmbStatusDropdown);
            this.Controls.Add(this.lblStatusText);
            this.Controls.Add(this.lblSeats);
            this.Controls.Add(this.lblTableNumber);
            this.Controls.Add(this.pnlStatusColor);
            this.Name = "ucReservationtableCard";
            this.Size = new System.Drawing.Size(180, 210);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTableGuestName;
        private System.Windows.Forms.Label lblTimeTable;
        public System.Windows.Forms.Button btnDeleteTable;
        public System.Windows.Forms.ComboBox cmbStatusDropdown;
        public System.Windows.Forms.Label lblStatusText;
        public System.Windows.Forms.Label lblSeats;
        public System.Windows.Forms.Label lblTableNumber;
        public System.Windows.Forms.Panel pnlStatusColor;
    }
}
