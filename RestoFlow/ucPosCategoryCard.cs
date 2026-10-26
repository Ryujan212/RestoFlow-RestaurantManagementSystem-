using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class ucPosCategoryCard : UserControl
    {
        public ucPosCategoryCard()
        {
            InitializeComponent();
        }
        public void SetData(Category cat)
        {
            lblPosCatname.Text = cat.Name;

            if (cat.CategoryImage != null)
            {
                pcbPosCat.Image = cat.CategoryImage;
                pcbPosCat.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // Rounded shape
            MakeRounded(this, 15);
            MakeRounded(pcbPosCat, 10);
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
