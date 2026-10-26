namespace RestoFlow
{
    partial class frmTableAdd
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
            this.btnfrmAddTable = new System.Windows.Forms.Button();
            this.btnCancelAddTable = new System.Windows.Forms.Button();
            this.numTableCapacity = new System.Windows.Forms.NumericUpDown();
            this.numTableNumber = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numTableCapacity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTableNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Yu Gothic UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(22, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "Add Table";
      
            // 
            // btnfrmAddTable
            // 
            this.btnfrmAddTable.BackColor = System.Drawing.Color.Aqua;
            this.btnfrmAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnfrmAddTable.Location = new System.Drawing.Point(331, 296);
            this.btnfrmAddTable.Name = "btnfrmAddTable";
            this.btnfrmAddTable.Size = new System.Drawing.Size(110, 49);
            this.btnfrmAddTable.TabIndex = 7;
            this.btnfrmAddTable.Text = "Add";
            this.btnfrmAddTable.UseVisualStyleBackColor = false;
            this.btnfrmAddTable.Click += new System.EventHandler(this.btnfrmAddTable_Click);
            // 
            // btnCancelAddTable
            // 
            this.btnCancelAddTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCancelAddTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelAddTable.Location = new System.Drawing.Point(187, 296);
            this.btnCancelAddTable.Name = "btnCancelAddTable";
            this.btnCancelAddTable.Size = new System.Drawing.Size(110, 49);
            this.btnCancelAddTable.TabIndex = 6;
            this.btnCancelAddTable.Text = "Cancel";
            this.btnCancelAddTable.UseVisualStyleBackColor = false;
            this.btnCancelAddTable.Click += new System.EventHandler(this.btnCancelAddTable_Click);
            // 
            // numTableCapacity
            // 
            this.numTableCapacity.Location = new System.Drawing.Point(219, 195);
            this.numTableCapacity.Name = "numTableCapacity";
            this.numTableCapacity.Size = new System.Drawing.Size(166, 26);
            this.numTableCapacity.TabIndex = 3;
            // 
            // numTableNumber
            // 
            this.numTableNumber.Location = new System.Drawing.Point(12, 195);
            this.numTableNumber.Name = "numTableNumber";
            this.numTableNumber.Size = new System.Drawing.Size(161, 26);
            this.numTableNumber.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(227, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 1;
            this.label3.Text = "Capacity";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Table Number";
            // 
            // frmTableAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(453, 381);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnfrmAddTable);
            this.Controls.Add(this.btnCancelAddTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.numTableCapacity);
            this.Controls.Add(this.numTableNumber);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmTableAdd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmTableAdd";
            ((System.ComponentModel.ISupportInitialize)(this.numTableCapacity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTableNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Button btnfrmAddTable;
        public System.Windows.Forms.Button btnCancelAddTable;
        public System.Windows.Forms.NumericUpDown numTableCapacity;
        public System.Windows.Forms.NumericUpDown numTableNumber;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}