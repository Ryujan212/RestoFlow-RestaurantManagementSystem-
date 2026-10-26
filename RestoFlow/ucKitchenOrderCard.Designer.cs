namespace RestoFlow
{
    partial class ucKitchenOrderCard
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
            this.btnActionOrder = new System.Windows.Forms.Button();
            this.lblKitchenOrderPrice = new System.Windows.Forms.Label();
            this.flpKitchenOrderItem = new System.Windows.Forms.FlowLayoutPanel();
            this.cbassignChef = new System.Windows.Forms.ComboBox();
            this.lblOrderType = new System.Windows.Forms.Label();
            this.lblKitchenStatus = new System.Windows.Forms.Label();
            this.lblOrderID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnActionOrder
            // 
            this.btnActionOrder.BackColor = System.Drawing.Color.Blue;
            this.btnActionOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActionOrder.ForeColor = System.Drawing.Color.White;
            this.btnActionOrder.Location = new System.Drawing.Point(173, 410);
            this.btnActionOrder.Name = "btnActionOrder";
            this.btnActionOrder.Size = new System.Drawing.Size(108, 35);
            this.btnActionOrder.TabIndex = 17;
            this.btnActionOrder.Text = "Pending";
            this.btnActionOrder.UseVisualStyleBackColor = false;
            // 
            // lblKitchenOrderPrice
            // 
            this.lblKitchenOrderPrice.AutoSize = true;
            this.lblKitchenOrderPrice.Location = new System.Drawing.Point(38, 417);
            this.lblKitchenOrderPrice.Name = "lblKitchenOrderPrice";
            this.lblKitchenOrderPrice.Size = new System.Drawing.Size(51, 20);
            this.lblKitchenOrderPrice.TabIndex = 16;
            this.lblKitchenOrderPrice.Text = "₱0.00";
            // 
            // flpKitchenOrderItem
            // 
            this.flpKitchenOrderItem.AutoSize = true;
            this.flpKitchenOrderItem.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.flpKitchenOrderItem.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpKitchenOrderItem.Location = new System.Drawing.Point(22, 106);
            this.flpKitchenOrderItem.Name = "flpKitchenOrderItem";
            this.flpKitchenOrderItem.Size = new System.Drawing.Size(281, 298);
            this.flpKitchenOrderItem.TabIndex = 15;
            // 
            // cbassignChef
            // 
            this.cbassignChef.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cbassignChef.FormattingEnabled = true;
            this.cbassignChef.Location = new System.Drawing.Point(23, 72);
            this.cbassignChef.Name = "cbassignChef";
            this.cbassignChef.Size = new System.Drawing.Size(280, 28);
            this.cbassignChef.TabIndex = 14;
            this.cbassignChef.Text = "Assign Chef..";
            // 
            // lblOrderType
            // 
            this.lblOrderType.AutoSize = true;
            this.lblOrderType.Location = new System.Drawing.Point(18, 45);
            this.lblOrderType.Name = "lblOrderType";
            this.lblOrderType.Size = new System.Drawing.Size(83, 20);
            this.lblOrderType.TabIndex = 13;
            this.lblOrderType.Text = "OrderType";
            // 
            // lblKitchenStatus
            // 
            this.lblKitchenStatus.AutoSize = true;
            this.lblKitchenStatus.Location = new System.Drawing.Point(211, 17);
            this.lblKitchenStatus.Name = "lblKitchenStatus";
            this.lblKitchenStatus.Size = new System.Drawing.Size(56, 20);
            this.lblKitchenStatus.TabIndex = 12;
            this.lblKitchenStatus.Text = "Status";
            // 
            // lblOrderID
            // 
            this.lblOrderID.AutoSize = true;
            this.lblOrderID.Location = new System.Drawing.Point(18, 17);
            this.lblOrderID.Name = "lblOrderID";
            this.lblOrderID.Size = new System.Drawing.Size(71, 20);
            this.lblOrderID.TabIndex = 11;
            this.lblOrderID.Text = "Order-ID";
            // 
            // ucKitchenOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnActionOrder);
            this.Controls.Add(this.lblKitchenOrderPrice);
            this.Controls.Add(this.flpKitchenOrderItem);
            this.Controls.Add(this.cbassignChef);
            this.Controls.Add(this.lblOrderType);
            this.Controls.Add(this.lblKitchenStatus);
            this.Controls.Add(this.lblOrderID);
            this.Name = "ucKitchenOrderCard";
            this.Size = new System.Drawing.Size(320, 463);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Button btnActionOrder;
        public System.Windows.Forms.Label lblKitchenOrderPrice;
        public System.Windows.Forms.FlowLayoutPanel flpKitchenOrderItem;
        public System.Windows.Forms.ComboBox cbassignChef;
        public System.Windows.Forms.Label lblOrderType;
        public System.Windows.Forms.Label lblKitchenStatus;
        public System.Windows.Forms.Label lblOrderID;
    }
}
