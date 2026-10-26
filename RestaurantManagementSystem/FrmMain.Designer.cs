namespace RestaurantManagementSystem
{
    partial class FrmMain
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
            this.Sidebar = new System.Windows.Forms.Panel();
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnSR = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnInventory = new System.Windows.Forms.Button();
            this.btnTM = new System.Windows.Forms.Button();
            this.btnMM = new System.Windows.Forms.Button();
            this.btnPOS = new System.Windows.Forms.Button();
            this.btnDashboard = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Header = new System.Windows.Forms.Panel();
            this.lbldesc = new System.Windows.Forms.Label();
            this.lblHeaderTitle = new System.Windows.Forms.Label();
            this.contentPanel = new System.Windows.Forms.Panel();
            this.dashBoardView1 = new RestaurantManagementSystem.DashBoardView();
            this.dashBoardView2 = new RestaurantManagementSystem.DashBoardView();
            this.dashBoardView3 = new RestaurantManagementSystem.DashBoardView();
            this.menuView1 = new RestaurantManagementSystem.MenuView();
            this.Sidebar.SuspendLayout();
            this.Header.SuspendLayout();
            this.SuspendLayout();
            // 
            // Sidebar
            // 
            this.Sidebar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Sidebar.Controls.Add(this.btnSettings);
            this.Sidebar.Controls.Add(this.btnSR);
            this.Sidebar.Controls.Add(this.btnTransactions);
            this.Sidebar.Controls.Add(this.btnInventory);
            this.Sidebar.Controls.Add(this.btnTM);
            this.Sidebar.Controls.Add(this.btnMM);
            this.Sidebar.Controls.Add(this.btnPOS);
            this.Sidebar.Controls.Add(this.btnDashboard);
            this.Sidebar.Controls.Add(this.label1);
            this.Sidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.Sidebar.Location = new System.Drawing.Point(0, 0);
            this.Sidebar.Name = "Sidebar";
            this.Sidebar.Size = new System.Drawing.Size(238, 661);
            this.Sidebar.TabIndex = 0;
            // 
            // btnSettings
            // 
            this.btnSettings.Location = new System.Drawing.Point(12, 435);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(210, 40);
            this.btnSettings.TabIndex = 8;
            this.btnSettings.Text = "Settings";
            this.btnSettings.UseVisualStyleBackColor = true;
            this.btnSettings.Click += new System.EventHandler(this.btnSettings_Click);
            // 
            // btnSR
            // 
            this.btnSR.Location = new System.Drawing.Point(12, 389);
            this.btnSR.Name = "btnSR";
            this.btnSR.Size = new System.Drawing.Size(210, 40);
            this.btnSR.TabIndex = 7;
            this.btnSR.Text = "Sales Report";
            this.btnSR.UseVisualStyleBackColor = true;
            this.btnSR.Click += new System.EventHandler(this.btnSR_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(12, 343);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(210, 40);
            this.btnTransactions.TabIndex = 6;
            this.btnTransactions.Text = "Transactions";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnInventory
            // 
            this.btnInventory.Location = new System.Drawing.Point(12, 297);
            this.btnInventory.Name = "btnInventory";
            this.btnInventory.Size = new System.Drawing.Size(210, 40);
            this.btnInventory.TabIndex = 5;
            this.btnInventory.Text = "Inventory";
            this.btnInventory.UseVisualStyleBackColor = true;
            this.btnInventory.Click += new System.EventHandler(this.btnInventory_Click);
            // 
            // btnTM
            // 
            this.btnTM.Location = new System.Drawing.Point(12, 251);
            this.btnTM.Name = "btnTM";
            this.btnTM.Size = new System.Drawing.Size(210, 40);
            this.btnTM.TabIndex = 4;
            this.btnTM.Text = "Table Management";
            this.btnTM.UseVisualStyleBackColor = true;
            this.btnTM.Click += new System.EventHandler(this.btnTM_Click);
            // 
            // btnMM
            // 
            this.btnMM.Location = new System.Drawing.Point(12, 205);
            this.btnMM.Name = "btnMM";
            this.btnMM.Size = new System.Drawing.Size(210, 40);
            this.btnMM.TabIndex = 3;
            this.btnMM.Text = "Menu Management";
            this.btnMM.UseVisualStyleBackColor = true;
            this.btnMM.Click += new System.EventHandler(this.btnMM_Click);
            // 
            // btnPOS
            // 
            this.btnPOS.Location = new System.Drawing.Point(12, 159);
            this.btnPOS.Name = "btnPOS";
            this.btnPOS.Size = new System.Drawing.Size(210, 40);
            this.btnPOS.TabIndex = 2;
            this.btnPOS.Text = "Point of Sale";
            this.btnPOS.UseVisualStyleBackColor = true;
            this.btnPOS.Click += new System.EventHandler(this.btnPOS_Click);
            // 
            // btnDashboard
            // 
            this.btnDashboard.Location = new System.Drawing.Point(12, 113);
            this.btnDashboard.Name = "btnDashboard";
            this.btnDashboard.Size = new System.Drawing.Size(210, 40);
            this.btnDashboard.TabIndex = 1;
            this.btnDashboard.Text = "Dashboard";
            this.btnDashboard.UseVisualStyleBackColor = true;
            this.btnDashboard.Click += new System.EventHandler(this.btnDashboard_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(35, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "RestoFlow";
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.Header.Controls.Add(this.lbldesc);
            this.Header.Controls.Add(this.lblHeaderTitle);
            this.Header.Dock = System.Windows.Forms.DockStyle.Top;
            this.Header.Location = new System.Drawing.Point(238, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(846, 100);
            this.Header.TabIndex = 1;
            // 
            // lbldesc
            // 
            this.lbldesc.AutoSize = true;
            this.lbldesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldesc.Location = new System.Drawing.Point(38, 54);
            this.lbldesc.Name = "lbldesc";
            this.lbldesc.Size = new System.Drawing.Size(37, 16);
            this.lbldesc.TabIndex = 1;
            this.lbldesc.Text = "desc";
            // 
            // lblHeaderTitle
            // 
            this.lblHeaderTitle.AutoSize = true;
            this.lblHeaderTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHeaderTitle.Location = new System.Drawing.Point(37, 30);
            this.lblHeaderTitle.Name = "lblHeaderTitle";
            this.lblHeaderTitle.Size = new System.Drawing.Size(108, 24);
            this.lblHeaderTitle.TabIndex = 0;
            this.lblHeaderTitle.Text = "HeaderTitle";
            // 
            // contentPanel
            // 
            this.contentPanel.BackColor = System.Drawing.Color.White;
            this.contentPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentPanel.Location = new System.Drawing.Point(238, 100);
            this.contentPanel.Name = "contentPanel";
            this.contentPanel.Size = new System.Drawing.Size(846, 561);
            this.contentPanel.TabIndex = 2;
            // 
            // dashBoardView1
            // 
            this.dashBoardView1.Location = new System.Drawing.Point(0, 0);
            this.dashBoardView1.Name = "dashBoardView1";
            this.dashBoardView1.Size = new System.Drawing.Size(1684, 905);
            this.dashBoardView1.TabIndex = 3;
            // 
            // dashBoardView2
            // 
            this.dashBoardView2.Location = new System.Drawing.Point(0, 0);
            this.dashBoardView2.Name = "dashBoardView2";
            this.dashBoardView2.Size = new System.Drawing.Size(1684, 905);
            this.dashBoardView2.TabIndex = 4;
            // 
            // dashBoardView3
            // 
            this.dashBoardView3.Location = new System.Drawing.Point(0, 0);
            this.dashBoardView3.Name = "dashBoardView3";
            this.dashBoardView3.Size = new System.Drawing.Size(1684, 905);
            this.dashBoardView3.TabIndex = 5;
            // 
            // menuView1
            // 
            this.menuView1.Location = new System.Drawing.Point(0, 0);
            this.menuView1.Name = "menuView1";
            this.menuView1.Size = new System.Drawing.Size(1684, 905);
            this.menuView1.TabIndex = 6;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.menuView1);
            this.Controls.Add(this.dashBoardView3);
            this.Controls.Add(this.dashBoardView2);
            this.Controls.Add(this.dashBoardView1);
            this.Controls.Add(this.contentPanel);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.Sidebar);
            this.MinimumSize = new System.Drawing.Size(1100, 700);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.Sidebar.ResumeLayout(false);
            this.Sidebar.PerformLayout();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Sidebar;
        private System.Windows.Forms.Panel Header;
        private System.Windows.Forms.Panel contentPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnDashboard;
        private System.Windows.Forms.Button btnSettings;
        private System.Windows.Forms.Button btnSR;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnInventory;
        private System.Windows.Forms.Button btnTM;
        private System.Windows.Forms.Button btnMM;
        private System.Windows.Forms.Button btnPOS;
        private System.Windows.Forms.Label lblHeaderTitle;
        private System.Windows.Forms.Label lbldesc;
        private DashBoardView dashBoardView1;
        private DashBoardView dashBoardView2;
        private DashBoardView dashBoardView3;
        private MenuView menuView1;
    }
}