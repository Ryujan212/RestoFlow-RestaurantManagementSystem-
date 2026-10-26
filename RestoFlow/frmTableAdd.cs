using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class frmTableAdd : Form
    {
        public frmTableAdd()
        {
            InitializeComponent();

            // I-subscribe sa Load ug SizeChanged para ma-rounded ang tibuok pop-up form
            this.Load += FrmTableAdd_Load;
            this.SizeChanged += FrmTableAdd_SizeChanged;
        }

        private void FrmTableAdd_Load(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void FrmTableAdd_SizeChanged(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        // Method para gawing bilugan ang gilid ng mismong Windows Form para prehas sa mockup
        private void ApplyFormRounding()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            int radius = 25; // Kadak-on sa pagka-rounded sa mga kanto
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // ADD / CREATE BUTTON NG POP-UP FORM MO
        private void btnfrmAddTable_Click(object sender, EventArgs e)
        {
            // ========== VALIDATION ==========
            if (numTableNumber.Value <= 0)
            {
                MessageBox.Show("Please enter a valid Table Number!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTableNumber.Focus();
                return;
            }

            if (numTableCapacity.Value <= 0)
            {
                MessageBox.Show("Please enter a valid table capacity/seats!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numTableCapacity.Focus();
                return;
            }

            // ========== SAVE DATA MULA SA INPUTS MO ==========
            TableModel newTable = new TableModel
            {
                // KINI NA JUD: Numero ra gyud ang ipasa (e.g. "6" o "1") aron mao ray mabutang sa lblTableNumber!
                TableNumber = numTableNumber.Value.ToString(),

                // Ang capacity value mapunta sa seats field
                Seats = (int)numTableCapacity.Value,
                Status = "Available" // Default status sa simula
            };

            // I-save ang mesa sa static list ng Tables form
            RestoFlow.Tables.AllTables.Add(newTable);

            MessageBox.Show("Table added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // I-set ang result sa OK para mag-trigger ang refresh sa kabilang screen
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // CANCEL BUTTON NG POP-UP FORM MO
        private void btnCancelAddTable_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
