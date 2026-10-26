namespace RestoFlow
{
    partial class Tables
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCleaning = new System.Windows.Forms.Button();
            this.btnReserved = new System.Windows.Forms.Button();
            this.btnOccupied = new System.Windows.Forms.Button();
            this.btnTableReservation = new System.Windows.Forms.Button();
            this.btnAvailable = new System.Windows.Forms.Button();
            this.btnAllTables = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDiningSummary = new System.Windows.Forms.Label();
            this.flpTableContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddTable = new System.Windows.Forms.Button();
            this.btnEditFloorPlan = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.panel1.Controls.Add(this.btnCleaning);
            this.panel1.Controls.Add(this.btnReserved);
            this.panel1.Controls.Add(this.btnOccupied);
            this.panel1.Controls.Add(this.btnTableReservation);
            this.panel1.Controls.Add(this.btnAvailable);
            this.panel1.Controls.Add(this.btnAllTables);
            this.panel1.Location = new System.Drawing.Point(27, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1447, 87);
            this.panel1.TabIndex = 0;
            // 
            // btnCleaning
            // 
            this.btnCleaning.Image = global::RestoFlow.Properties.Resources.circle__4_;
            this.btnCleaning.Location = new System.Drawing.Point(640, 24);
            this.btnCleaning.Name = "btnCleaning";
            this.btnCleaning.Size = new System.Drawing.Size(144, 38);
            this.btnCleaning.TabIndex = 9;
            this.btnCleaning.Text = "0 Cleaning";
            this.btnCleaning.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCleaning.UseVisualStyleBackColor = true;
            this.btnCleaning.Click += new System.EventHandler(this.btnCleaning_Click);
            // 
            // btnReserved
            // 
            this.btnReserved.Image = global::RestoFlow.Properties.Resources.shape;
            this.btnReserved.Location = new System.Drawing.Point(478, 24);
            this.btnReserved.Name = "btnReserved";
            this.btnReserved.Size = new System.Drawing.Size(144, 38);
            this.btnReserved.TabIndex = 8;
            this.btnReserved.Text = "0 Reserved";
            this.btnReserved.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnReserved.UseVisualStyleBackColor = true;
            this.btnReserved.Click += new System.EventHandler(this.btnReserved_Click);
            // 
            // btnOccupied
            // 
            this.btnOccupied.Image = global::RestoFlow.Properties.Resources.circle__3_;
            this.btnOccupied.Location = new System.Drawing.Point(316, 24);
            this.btnOccupied.Name = "btnOccupied";
            this.btnOccupied.Size = new System.Drawing.Size(144, 38);
            this.btnOccupied.TabIndex = 7;
            this.btnOccupied.Text = "0 Occupied";
            this.btnOccupied.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOccupied.UseVisualStyleBackColor = true;
            this.btnOccupied.Click += new System.EventHandler(this.btnOccupied_Click);
            // 
            // btnTableReservation
            // 
            this.btnTableReservation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnTableReservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTableReservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTableReservation.Image = global::RestoFlow.Properties.Resources.plus__1_;
            this.btnTableReservation.Location = new System.Drawing.Point(1190, 17);
            this.btnTableReservation.Name = "btnTableReservation";
            this.btnTableReservation.Size = new System.Drawing.Size(236, 49);
            this.btnTableReservation.TabIndex = 6;
            this.btnTableReservation.Text = "   New Reservation";
            this.btnTableReservation.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTableReservation.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnTableReservation.UseVisualStyleBackColor = false;
            this.btnTableReservation.Click += new System.EventHandler(this.btnTableReservation_Click);
            // 
            // btnAvailable
            // 
            this.btnAvailable.Image = global::RestoFlow.Properties.Resources.circle__2_;
            this.btnAvailable.Location = new System.Drawing.Point(156, 24);
            this.btnAvailable.Name = "btnAvailable";
            this.btnAvailable.Size = new System.Drawing.Size(144, 38);
            this.btnAvailable.TabIndex = 2;
            this.btnAvailable.Text = "0 Available";
            this.btnAvailable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAvailable.UseVisualStyleBackColor = true;
            this.btnAvailable.Click += new System.EventHandler(this.btnAvailable_Click);
            // 
            // btnAllTables
            // 
            this.btnAllTables.Location = new System.Drawing.Point(17, 24);
            this.btnAllTables.Name = "btnAllTables";
            this.btnAllTables.Size = new System.Drawing.Size(120, 38);
            this.btnAllTables.TabIndex = 1;
            this.btnAllTables.Text = "0 All Tables";
            this.btnAllTables.UseVisualStyleBackColor = true;
            this.btnAllTables.Click += new System.EventHandler(this.btnAllTables_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(39, 129);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(186, 30);
            this.label1.TabIndex = 12;
            this.label1.Text = "Main dining floor";
            // 
            // lblDiningSummary
            // 
            this.lblDiningSummary.AutoSize = true;
            this.lblDiningSummary.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiningSummary.Location = new System.Drawing.Point(40, 167);
            this.lblDiningSummary.Name = "lblDiningSummary";
            this.lblDiningSummary.Size = new System.Drawing.Size(184, 25);
            this.lblDiningSummary.TabIndex = 13;
            this.lblDiningSummary.Text = "0 tables · 0 total seats";
            // 
            // flpTableContainer
            // 
            this.flpTableContainer.AutoScroll = true;
            this.flpTableContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.flpTableContainer.Location = new System.Drawing.Point(27, 219);
            this.flpTableContainer.Name = "flpTableContainer";
            this.flpTableContainer.Padding = new System.Windows.Forms.Padding(10);
            this.flpTableContainer.Size = new System.Drawing.Size(1447, 680);
            this.flpTableContainer.TabIndex = 14;
            // 
            // btnAddTable
            // 
            this.btnAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAddTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddTable.Image = global::RestoFlow.Properties.Resources.plus__1_;
            this.btnAddTable.Location = new System.Drawing.Point(1000, 129);
            this.btnAddTable.Name = "btnAddTable";
            this.btnAddTable.Size = new System.Drawing.Size(204, 57);
            this.btnAddTable.TabIndex = 10;
            this.btnAddTable.Text = "   Add Table";
            this.btnAddTable.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddTable.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTable.UseVisualStyleBackColor = false;
            this.btnAddTable.Click += new System.EventHandler(this.btnAddTable_Click);
            // 
            // btnEditFloorPlan
            // 
            this.btnEditFloorPlan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnEditFloorPlan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditFloorPlan.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditFloorPlan.Image = global::RestoFlow.Properties.Resources.edit;
            this.btnEditFloorPlan.Location = new System.Drawing.Point(1238, 129);
            this.btnEditFloorPlan.Name = "btnEditFloorPlan";
            this.btnEditFloorPlan.Size = new System.Drawing.Size(236, 57);
            this.btnEditFloorPlan.TabIndex = 11;
            this.btnEditFloorPlan.Text = "   Edit Floor Plan";
            this.btnEditFloorPlan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditFloorPlan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditFloorPlan.UseVisualStyleBackColor = false;
            // 
            // Tables
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1490, 885);
            this.Controls.Add(this.flpTableContainer);
            this.Controls.Add(this.lblDiningSummary);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnEditFloorPlan);
            this.Controls.Add(this.btnAddTable);
            this.Controls.Add(this.panel1);
            this.Name = "Tables";
            this.Load += new System.EventHandler(this.Tables_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnTableReservation;
        private System.Windows.Forms.Button btnAvailable;
        private System.Windows.Forms.Button btnAllTables;
        private System.Windows.Forms.Button btnCleaning;
        private System.Windows.Forms.Button btnReserved;
        private System.Windows.Forms.Button btnOccupied;
        private System.Windows.Forms.Button btnAddTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDiningSummary;
        private System.Windows.Forms.FlowLayoutPanel flpTableContainer;
        private System.Windows.Forms.Button btnEditFloorPlan;
    }
}
