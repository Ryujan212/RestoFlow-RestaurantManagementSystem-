using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class frmNewReservation : Form
    {
        public frmNewReservation()
        {
            InitializeComponent();

            this.Load += FrmNewReservation_Load;
            this.SizeChanged += FrmNewReservation_SizeChanged;

            LoadCreatedTablesIntoComboBox();
        }

        private void FrmNewReservation_Load(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void FrmNewReservation_SizeChanged(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void ApplyFormRounding()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            int radius = 25;
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        private void LoadCreatedTablesIntoComboBox()
        {
            if (cmbTable != null)
            {
                cmbTable.Items.Clear();

                foreach (var table in RestoFlow.Tables.AllTables)
                {
                    cmbTable.Items.Add(table.TableNumber);
                }

                if (cmbTable.Items.Count > 0)
                {
                    cmbTable.SelectedIndex = 0;
                }
                else
                {
                    cmbTable.Items.Add("No Tables Created Yet");
                    cmbTable.SelectedIndex = 0;
                }
            }
        }

        // CREATE RESERVATION BUTTON CLICK
        private void btnCreateReservation_Click(object sender, EventArgs e)
        {
            // ========== VALIDATION ==========
            if (string.IsNullOrWhiteSpace(txtGuestName.Text))
            {
                MessageBox.Show("Please enter the Guest Name!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtGuestName.Focus();
                return;
            }

            if (cmbTable.SelectedItem == null || cmbTable.SelectedItem.ToString() == "No Tables Created Yet")
            {
                MessageBox.Show("Please select a valid Table Number first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (numPartySize.Value <= 0)
            {
                MessageBox.Show("Please enter a valid party size/seats!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numPartySize.Focus();
                return;
            }

            // ========== SAVE DATA PATUNGO SA MODEL ==========
            TableModel newTable = new TableModel
            {
                TableNumber = cmbTable.SelectedItem.ToString(),
                Seats = (int)numPartySize.Value,
                Status = "Reserved",
                // TAMA NA KINI: Kung ano ang tinype mo sa time, isasama dito sa pag-save!
                Time = txtReservationTime.Text.Trim()
            };

            RestoFlow.Tables.AllTables.Add(newTable);

            MessageBox.Show("Reservation created successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnCancelReservation_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
