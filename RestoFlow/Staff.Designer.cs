namespace RestoFlow
{
    partial class Staff
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
            this.pnlCreateStaffSection = new System.Windows.Forms.Panel();
            this.btnStaffClear = new System.Windows.Forms.Button();
            this.btnStaffDelete = new System.Windows.Forms.Button();
            this.btnStaffUpdate = new System.Windows.Forms.Button();
            this.btnStaffAdd = new System.Windows.Forms.Button();
            this.cbStaffRule = new System.Windows.Forms.ComboBox();
            this.tbStaffContact = new System.Windows.Forms.TextBox();
            this.tbStaffFullname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvStaffContainer = new System.Windows.Forms.DataGridView();
            this.pnlCreateStaffSection.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlCreateStaffSection
            // 
            this.pnlCreateStaffSection.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.pnlCreateStaffSection.Controls.Add(this.btnStaffClear);
            this.pnlCreateStaffSection.Controls.Add(this.btnStaffDelete);
            this.pnlCreateStaffSection.Controls.Add(this.btnStaffUpdate);
            this.pnlCreateStaffSection.Controls.Add(this.btnStaffAdd);
            this.pnlCreateStaffSection.Controls.Add(this.cbStaffRule);
            this.pnlCreateStaffSection.Controls.Add(this.tbStaffContact);
            this.pnlCreateStaffSection.Controls.Add(this.tbStaffFullname);
            this.pnlCreateStaffSection.Controls.Add(this.label5);
            this.pnlCreateStaffSection.Controls.Add(this.label4);
            this.pnlCreateStaffSection.Controls.Add(this.label3);
            this.pnlCreateStaffSection.ForeColor = System.Drawing.Color.White;
            this.pnlCreateStaffSection.Location = new System.Drawing.Point(75, 66);
            this.pnlCreateStaffSection.Name = "pnlCreateStaffSection";
            this.pnlCreateStaffSection.Size = new System.Drawing.Size(1369, 303);
            this.pnlCreateStaffSection.TabIndex = 0;
            // 
            // btnStaffClear
            // 
            this.btnStaffClear.BackColor = System.Drawing.Color.Silver;
            this.btnStaffClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffClear.ForeColor = System.Drawing.Color.Black;
            this.btnStaffClear.Location = new System.Drawing.Point(922, 205);
            this.btnStaffClear.Name = "btnStaffClear";
            this.btnStaffClear.Size = new System.Drawing.Size(119, 47);
            this.btnStaffClear.TabIndex = 19;
            this.btnStaffClear.Text = "Clear";
            this.btnStaffClear.UseVisualStyleBackColor = false;
            // 
            // btnStaffDelete
            // 
            this.btnStaffDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStaffDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffDelete.ForeColor = System.Drawing.Color.Black;
            this.btnStaffDelete.Location = new System.Drawing.Point(774, 205);
            this.btnStaffDelete.Name = "btnStaffDelete";
            this.btnStaffDelete.Size = new System.Drawing.Size(119, 47);
            this.btnStaffDelete.TabIndex = 18;
            this.btnStaffDelete.Text = "Delete";
            this.btnStaffDelete.UseVisualStyleBackColor = false;
            // 
            // btnStaffUpdate
            // 
            this.btnStaffUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnStaffUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffUpdate.ForeColor = System.Drawing.Color.Black;
            this.btnStaffUpdate.Location = new System.Drawing.Point(627, 205);
            this.btnStaffUpdate.Name = "btnStaffUpdate";
            this.btnStaffUpdate.Size = new System.Drawing.Size(119, 47);
            this.btnStaffUpdate.TabIndex = 17;
            this.btnStaffUpdate.Text = "Update";
            this.btnStaffUpdate.UseVisualStyleBackColor = false;
            // 
            // btnStaffAdd
            // 
            this.btnStaffAdd.BackColor = System.Drawing.Color.Lime;
            this.btnStaffAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStaffAdd.ForeColor = System.Drawing.Color.Black;
            this.btnStaffAdd.Location = new System.Drawing.Point(474, 205);
            this.btnStaffAdd.Name = "btnStaffAdd";
            this.btnStaffAdd.Size = new System.Drawing.Size(119, 47);
            this.btnStaffAdd.TabIndex = 16;
            this.btnStaffAdd.Text = "Add";
            this.btnStaffAdd.UseVisualStyleBackColor = false;
            // 
            // cbStaffRule
            // 
            this.cbStaffRule.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbStaffRule.FormattingEnabled = true;
            this.cbStaffRule.Location = new System.Drawing.Point(520, 97);
            this.cbStaffRule.Name = "cbStaffRule";
            this.cbStaffRule.Size = new System.Drawing.Size(457, 28);
            this.cbStaffRule.TabIndex = 15;
            // 
            // tbStaffContact
            // 
            this.tbStaffContact.ForeColor = System.Drawing.Color.Gray;
            this.tbStaffContact.Location = new System.Drawing.Point(520, 139);
            this.tbStaffContact.Name = "tbStaffContact";
            this.tbStaffContact.Size = new System.Drawing.Size(457, 26);
            this.tbStaffContact.TabIndex = 14;
            this.tbStaffContact.Text = "+63";
            // 
            // tbStaffFullname
            // 
            this.tbStaffFullname.Location = new System.Drawing.Point(520, 52);
            this.tbStaffFullname.Name = "tbStaffFullname";
            this.tbStaffFullname.Size = new System.Drawing.Size(457, 26);
            this.tbStaffFullname.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(327, 136);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 25);
            this.label5.TabIndex = 12;
            this.label5.Text = "Contact:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(327, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 25);
            this.label4.TabIndex = 11;
            this.label4.Text = "Rule:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(327, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fullname:";
            // 
            // dgvStaffContainer
            // 
            this.dgvStaffContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStaffContainer.Location = new System.Drawing.Point(75, 408);
            this.dgvStaffContainer.Name = "dgvStaffContainer";
            this.dgvStaffContainer.RowHeadersWidth = 62;
            this.dgvStaffContainer.RowTemplate.Height = 28;
            this.dgvStaffContainer.Size = new System.Drawing.Size(1369, 492);
            this.dgvStaffContainer.TabIndex = 1;
            // 
            // Staff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dgvStaffContainer);
            this.Controls.Add(this.pnlCreateStaffSection);
            this.Name = "Staff";
            this.Size = new System.Drawing.Size(1512, 941);
            this.Load += new System.EventHandler(this.Staff_Load);
            this.pnlCreateStaffSection.ResumeLayout(false);
            this.pnlCreateStaffSection.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStaffContainer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCreateStaffSection;
        private System.Windows.Forms.Button btnStaffClear;
        private System.Windows.Forms.Button btnStaffDelete;
        private System.Windows.Forms.Button btnStaffUpdate;
        private System.Windows.Forms.Button btnStaffAdd;
        public System.Windows.Forms.ComboBox cbStaffRule;
        private System.Windows.Forms.TextBox tbStaffContact;
        private System.Windows.Forms.TextBox tbStaffFullname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvStaffContainer;
    }
}
