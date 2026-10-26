using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class ucCategoryCard : UserControl
    {
        public ucCategoryCard()
        {
            InitializeComponent();
            this.SizeChanged += UcCategoryCard_SizeChanged;
            if (pcbCatIcon != null) pcbCatIcon.SizeChanged += UcCategoryCard_SizeChanged;
        }

        private void UcCategoryCard_SizeChanged(object sender, EventArgs e)
        {
            ApplyRounding();
        }

        public void SetData(Category cat)
        {
            lblCatName.Text = cat.Name;
            if (lbdescp != null) lbdescp.Text = cat.Description;

            if (cat.CategoryImage != null)
            {
                pcbCatIcon.Image = cat.CategoryImage;
                pcbCatIcon.SizeMode = PictureBoxSizeMode.Zoom;
            }

            ApplyRounding();
        }

        private void ApplyRounding()
        {
            MakeRounded(this, 15);
            if (pcbCatIcon != null) MakeRounded(pcbCatIcon, 10);
        }

        private void MakeRounded(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            System.Drawing.Drawing2D.GraphicsPath path = new System.Drawing.Drawing2D.GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();
            control.Region = new Region(path);
        }
    }
}
