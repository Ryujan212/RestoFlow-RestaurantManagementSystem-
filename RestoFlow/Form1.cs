using System;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace RestoFlow
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ShowView(Control view)
        {
            foreach (Control c in contentPanel.Controls)
                c.Dispose();
            contentPanel.Controls.Clear();

            if (view is Form frm)
            {
                frm.TopLevel = false;
                frm.FormBorderStyle = FormBorderStyle.None;
            }

            view.Dock = DockStyle.Fill;
            contentPanel.Controls.Add(view);

            if (view is Form)
            {
                ((Form)view).Show();
            }

            // GIPWERSA NGA NAKA-BOLD: Kanunay naka-bold ang Header Title para propesyonal
            if (lblHeaderTitle != null)
            {
                lblHeaderTitle.Font = new Font(lblHeaderTitle.Font.FontFamily, lblHeaderTitle.Font.Size, FontStyle.Bold);
            }
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            ShowView(new Dashboard());
            lblHeaderTitle.Text = "Dashboard";
            lblHeaderDesc.Text = "Monitor sales, analytics, and overall restaurant performance today.";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            ShowView(new Menu());
            lblHeaderTitle.Text = "Main Menu";
            lblHeaderDesc.Text = "Manage your food items, prices, and configure restaurant menus.";
        }

        private void btnTables_Click(object sender, EventArgs e)
        {
            ShowView(new Tables());
            lblHeaderTitle.Text = "Tables";
            lblHeaderDesc.Text = "Monitor dining areas, table seating capacity, and current occupancy status.";
        }

        private void btnPOS_Click(object sender, EventArgs e)
        {
            ShowView(new PointofSale());
            lblHeaderTitle.Text = "Point of Sale";
            lblHeaderDesc.Text = "Process customer orders, billings, and take transactions efficiently.";

        }

        private void btnKitchen_Click(object sender, EventArgs e)
        {
            ShowView(new Kitchen());
            lblHeaderTitle.Text = "Kitchen";
            lblHeaderDesc.Text = "Track ongoing food preparation, orders queue, and ticket status.";
        }

        private void btnTH_Click(object sender, EventArgs e)
        {
            ShowView(new Tables());
            lblHeaderTitle.Text = "Transaction History";
            lblHeaderDesc.Text = "Review past sales, completed invoices, and historical receipt records.";
        }

        private void btnAcc_Click(object sender, EventArgs e)
        {
            ShowView(new Accountabilities());
            lblHeaderTitle.Text = "Accountabilities";
            lblHeaderDesc.Text = "Track cash counter responsibilities, staff shifts, and active registers.";
        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            ShowView(new Staff());
            lblHeaderTitle.Text = "Staff";
            lblHeaderDesc.Text = "Manage system access, active employees, roles, and user accounts.";
        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            ShowView(new ucInventory());
            lblHeaderTitle.Text = "Inventory";
            lblHeaderDesc.Text = "Track raw food supplies, ingredient stocks, and automatic low-stock alerts.";
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            ShowView(new Settings());
            lblHeaderTitle.Text = "Settings";
            lblHeaderDesc.Text = "Configure system preferences, themes, store details, and printer links.";
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            ShowView(new Reports());
            lblHeaderTitle.Text = "Reports";
            lblHeaderDesc.Text = "Generate comprehensive business statements, profit summaries, and audit logs.";
        }
    }
}
