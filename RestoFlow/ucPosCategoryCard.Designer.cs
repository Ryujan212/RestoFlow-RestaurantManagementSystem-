namespace RestoFlow
{
    partial class ucPosCategoryCard
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
            this.lblPosCatname = new System.Windows.Forms.Label();
            this.pcbPosCat = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPosCat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblPosCatname
            // 
            this.lblPosCatname.AutoSize = true;
            this.lblPosCatname.Location = new System.Drawing.Point(65, 17);
            this.lblPosCatname.Name = "lblPosCatname";
            this.lblPosCatname.Size = new System.Drawing.Size(51, 20);
            this.lblPosCatname.TabIndex = 3;
            this.lblPosCatname.Text = "label2";
            // 
            // pcbPosCat
            // 
            this.pcbPosCat.Location = new System.Drawing.Point(6, 8);
            this.pcbPosCat.Name = "pcbPosCat";
            this.pcbPosCat.Size = new System.Drawing.Size(41, 38);
            this.pcbPosCat.TabIndex = 2;
            this.pcbPosCat.TabStop = false;
            // 
            // ucPosCategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblPosCatname);
            this.Controls.Add(this.pcbPosCat);
            this.Name = "ucPosCategoryCard";
            this.Size = new System.Drawing.Size(179, 57);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPosCat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblPosCatname;
        private System.Windows.Forms.PictureBox pcbPosCat;
    }
}
