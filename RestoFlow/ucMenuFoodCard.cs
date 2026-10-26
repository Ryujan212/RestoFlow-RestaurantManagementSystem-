using System;
using System.Drawing;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class ucMenuFoodCard : UserControl
    {
        public ucMenuFoodCard()
        {
            InitializeComponent();
            this.SizeChanged += UcMenuFoodCard_SizeChanged;
            if (pictureBox1 != null) pictureBox1.SizeChanged += UcMenuFoodCard_SizeChanged;
        }

        private void UcMenuFoodCard_SizeChanged(object sender, EventArgs e)
        {
            ApplyRounding();
        }

        public void SetData(MenuItem item)
        {
            label1.Text = item.Name;
            label4.Text = item.Category;
            label6.Text = "₱" + item.Price.ToString("F2");
            label8.Text = item.Stock.ToString();
            if (item.ItemImage != null)
            {
                pictureBox1.Image = item.ItemImage;
                pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            }

            ApplyRounding();
        }

        private void ApplyRounding()
        {
            MakeRounded(this, 15);
            if (pictureBox1 != null) MakeRounded(pictureBox1, 10);
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
