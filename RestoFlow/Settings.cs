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
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }
        private void MakeRounded(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);

            // Optional: draw border
            control.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Gray, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            MakeRounded(pnlGenSettings, 20);
            MakeRounded(pnlInsideGenSettings, 20);
            MakeRounded(pnlInsideRestInfo, 20);
            MakeRounded(pnlInsideSystemSettings, 20);
            MakeRounded(pnlRestaurantInfo, 20);
            MakeRounded(pnlSystemSettings, 20);
            MakeRounded(pnlBackup, 20);
            MakeRounded(pnlAboutSystem, 20);
            MakeRounded(pnlUserManagement, 20);
        }
    }
}
