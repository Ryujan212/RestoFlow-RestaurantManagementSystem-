using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class frmChooseSize : Form
    {
        public frmChooseSize()
        {
            InitializeComponent();
            this.Load += FrmChooseSize_Load;
            this.SizeChanged += FrmChooseSize_SizeChanged;
        }

        private void FrmChooseSize_Load(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void FrmChooseSize_SizeChanged(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void ApplyFormRounding()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            int radius = 25; // Kadak-on sa rounded corners
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        // Kapag pinindot ang Size (halimbawa, Regular o Large button):
        private void btnSelectSize_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // Kapag pinindot ang Cancel o Custom X button sa itaas:
        private void btnCancelSize_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
