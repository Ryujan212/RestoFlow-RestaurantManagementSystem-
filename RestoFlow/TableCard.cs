using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class TableCard : UserControl
    {
        private TableModel _currentTable;

        public TableCard()
        {
            InitializeComponent();

            this.SizeChanged += TableCard_SizeChanged;

            if (cmbStatusDropdown != null)
            {
                cmbStatusDropdown.SelectedIndexChanged += cmbStatusDropdown_SelectedIndexChanged;
            }
        }

        private void TableCard_SizeChanged(object sender, EventArgs e)
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            ApplyRoundingToControl(this, 15);
            if (pnlStatusColor != null) ApplyRoundingToControl(pnlStatusColor, 4);
        }

        private void ApplyRoundingToControl(Control control, int radius)
        {
            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }

        // TAMA NA ANG DATA MAPPING: Kasama na ang lblTimeTable!
        public void SetData(TableModel table)
        {
            _currentTable = table;

            lblTableNumber.Text = table.TableNumber;
            lblSeats.Text = table.Seats.ToString() + " seats";
            lblStatusText.Text = table.Status;

            // TAMA NA KINI: Kung walang oras (dahil pinalitan sa drop down o bagong create lang na table), blanko o "Available" ang nakasulat
            if (lblTimeTable != null)
            {
                lblTimeTable.Text = string.IsNullOrEmpty(table.Time) ? "time" : table.Time;
            }

            if (cmbStatusDropdown != null)
            {
                cmbStatusDropdown.SelectedIndexChanged -= cmbStatusDropdown_SelectedIndexChanged;

                cmbStatusDropdown.Items.Clear();
                cmbStatusDropdown.Items.Add("Available");
                cmbStatusDropdown.Items.Add("Occupied");
                cmbStatusDropdown.Items.Add("Reserved");
                cmbStatusDropdown.Items.Add("Cleaning");

                int index = cmbStatusDropdown.FindStringExact(table.Status);
                if (index >= 0) cmbStatusDropdown.SelectedIndex = index;
                else cmbStatusDropdown.SelectedIndex = 0;

                cmbStatusDropdown.SelectedIndexChanged += cmbStatusDropdown_SelectedIndexChanged;
            }

            UpdateStatusVisuals(table.Status);
        }

        private void cmbStatusDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStatusDropdown == null || _currentTable == null) return;

            string selectedStatus = cmbStatusDropdown.SelectedItem.ToString();
            lblStatusText.Text = selectedStatus;
            _currentTable.Status = selectedStatus;

            // Kung pinalitan ng user sa "Available" o "Cleaning" ang status mula sa dropdown, opsyonal na linisin ang oras
            if (selectedStatus == "Available" || selectedStatus == "Cleaning")
            {
                _currentTable.Time = "";
                if (lblTimeTable != null) lblTimeTable.Text = "time";
            }

            UpdateStatusVisuals(selectedStatus);

            // Cross-form target refresh loop ng counters sa Tables.cs
            foreach (Form openForm in Application.OpenForms)
            {
                if (openForm is Form1 dashboardForm)
                {
                    foreach (Control ctrl in dashboardForm.Controls)
                    {
                        if (ctrl.Name == "contentPanel")
                        {
                            foreach (Control subCtrl in ctrl.Controls)
                            {
                                if (subCtrl is Tables mainTablesForm)
                                {
                                    mainTablesForm.LoadTableCards();
                                    return;
                                }
                            }
                        }
                    }
                }
            }
        }

        private void UpdateStatusVisuals(string status)
        {
            if (pnlStatusColor == null || lblStatusText == null) return;

            switch (status.Trim())
            {
                case "Available":
                    pnlStatusColor.BackColor = Color.ForestGreen;
                    lblStatusText.ForeColor = Color.ForestGreen;
                    break;
                case "Occupied":
                    pnlStatusColor.BackColor = Color.Firebrick;
                    lblStatusText.ForeColor = Color.Firebrick;
                    break;
                case "Reserved":
                case "Reservation":
                    pnlStatusColor.BackColor = Color.Orange;
                    lblStatusText.ForeColor = Color.Orange;
                    break;
                case "Cleaning":
                    pnlStatusColor.BackColor = Color.Gray;
                    lblStatusText.ForeColor = Color.Gray;
                    break;
                default:
                    pnlStatusColor.BackColor = Color.ForestGreen;
                    lblStatusText.ForeColor = Color.ForestGreen;
                    break;
            }
        }

        private void btnDeleteTable_Click(object sender, EventArgs e)
        {
            if (_currentTable == null) return;

            DialogResult result = MessageBox.Show($"Are you sure you want to delete Table {_currentTable.TableNumber}?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                Tables.AllTables.Remove(_currentTable);

                if (this.Parent is FlowLayoutPanel flp)
                {
                    flp.Controls.Remove(this);
                    this.Dispose();
                }

                foreach (Form openForm in Application.OpenForms)
                {
                    if (openForm is Form1 dashboardForm)
                    {
                        foreach (Control ctrl in dashboardForm.Controls)
                        {
                            if (ctrl.Name == "contentPanel")
                            {
                                foreach (Control subCtrl in ctrl.Controls)
                                {
                                    if (subCtrl is Tables mainTablesForm)
                                    {
                                        mainTablesForm.LoadTableCards();
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
