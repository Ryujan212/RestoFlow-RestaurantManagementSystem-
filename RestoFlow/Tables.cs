using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class Tables : Form
    {
        // Global static list para sa lahat ng mesa sa restaurant
        public static List<TableModel> AllTables = new List<TableModel>();

        public Tables()
        {
            InitializeComponent();
        }

        public void MakeRounded(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);

            control.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Gray, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void Tables_Load(object sender, EventArgs e)
        {
            // Buo at ligtas ang lahat ng rounding codes mo!
            MakeRounded(panel1, 20);
            if (btnAllTables != null) MakeRounded(btnAllTables, 20);
            MakeRounded(btnReserved, 20);
            MakeRounded(btnAvailable, 20);
            MakeRounded(btnCleaning, 20);
            MakeRounded(btnOccupied, 20);
            MakeRounded(flpTableContainer, 20);

            LoadTableCards();
        }

        private void btnAddTable_Click(object sender, EventArgs e)
        {
            using (frmTableAdd frm = new frmTableAdd())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTableCards();
                }
            }
        }

        private void btnTableReservation_Click(object sender, EventArgs e)
        {
            using (frmNewReservation frm = new frmNewReservation())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadTableCards();
                }
            }
        }

        private void btnAllTables_Click(object sender, EventArgs e)
        {
            DisplayFilteredTables(AllTables);
        }

        private void btnAvailable_Click(object sender, EventArgs e)
        {
            var filtered = AllTables.Where(t => t.Status.Equals("Available", StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayFilteredTables(filtered);
        }

        private void btnOccupied_Click(object sender, EventArgs e)
        {
            var filtered = AllTables.Where(t => t.Status.Equals("Occupied", StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayFilteredTables(filtered);
        }

        private void btnReserved_Click(object sender, EventArgs e)
        {
            var filtered = AllTables.Where(t => t.Status.Equals("Reserved", StringComparison.OrdinalIgnoreCase) || t.Status.Equals("Reservation", StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayFilteredTables(filtered);
        }

        private void btnCleaning_Click(object sender, EventArgs e)
        {
            var filtered = AllTables.Where(t => t.Status.Equals("Cleaning", StringComparison.OrdinalIgnoreCase)).ToList();
            DisplayFilteredTables(filtered);
        }

        public void LoadTableCards()
        {
            DisplayFilteredTables(AllTables);
            UpdateFilterButtonCounters();
        }

        private void DisplayFilteredTables(List<TableModel> filteredList)
        {
            if (flpTableContainer == null) return;
            flpTableContainer.Controls.Clear();

            foreach (var table in filteredList)
            {
                TableCard card = new TableCard();
                card.SetData(table);

                flpTableContainer.Controls.Add(card);
                MakeRounded(card, 15);
            }
        }

        private void UpdateFilterButtonCounters()
        {
            int totalTables = AllTables.Count;
            int availableCount = AllTables.Count(t => t.Status.Equals("Available", StringComparison.OrdinalIgnoreCase));
            int occupiedCount = AllTables.Count(t => t.Status.Equals("Occupied", StringComparison.OrdinalIgnoreCase));
            int reservedCount = AllTables.Count(t => t.Status.Equals("Reserved", StringComparison.OrdinalIgnoreCase) || t.Status.Equals("Reservation", StringComparison.OrdinalIgnoreCase));
            int cleaningCount = AllTables.Count(t => t.Status.Equals("Cleaning", StringComparison.OrdinalIgnoreCase));
            int totalSeatsSum = AllTables.Sum(t => t.Seats);

            if (btnAllTables != null) btnAllTables.Text = totalTables.ToString() + " Tables";
            if (btnAvailable != null) btnAvailable.Text = availableCount.ToString() + " Available";
            if (btnOccupied != null) btnOccupied.Text = occupiedCount.ToString() + " Occupied";
            if (btnReserved != null) btnReserved.Text = reservedCount.ToString() + " Reserved";
            if (btnCleaning != null) btnCleaning.Text = cleaningCount.ToString() + " Cleaning";

            if (lblDiningSummary != null)
            {
                lblDiningSummary.Text = availableCount.ToString() + " tables · " + totalSeatsSum.ToString() + " total seats";
            }
        }

        // ==================== GIDUGANG OG BALIK KINI NGA METHOD PARA MAWALA ANG ERROR CS0117 ====================
        // Kini ang mag-load sa mga lamesa ngadto sa cbPosTableCart ComboBox dropdown sa Point of Sale view
        public static void LoadTablesToExternalComboBox(ComboBox targetComboBox)
        {
            if (targetComboBox == null) return;

            targetComboBox.Items.Clear();

            foreach (var table in AllTables)
            {
                targetComboBox.Items.Add(table.TableNumber);
            }

            if (targetComboBox.Items.Count > 0)
            {
                targetComboBox.SelectedIndex = 0;
            }
            else
            {
                targetComboBox.Items.Add("No Tables Available");
                targetComboBox.SelectedIndex = 0;
            }
        }
    }
}
