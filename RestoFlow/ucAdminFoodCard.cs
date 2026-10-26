using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class ucAdminFoodCard : UserControl
    {
        private MenuItem _currentItem;

        public ucAdminFoodCard()
        {
            InitializeComponent();
            this.SizeChanged += UcAdminFoodCard_SizeChanged;

            // I-register ang click event para sa mismong Card background base
            this.Click += ucAdminFoodCard_Click;
        }

        private void UcAdminFoodCard_SizeChanged(object sender, EventArgs e)
        {
            ApplyRounding();
        }

        public void SetData(MenuItem item)
        {
            _currentItem = item;

            lblFoodName.Text = item.Name;
            lblFoodPrice.Text = "₱" + item.Price.ToString("F2");
            lblFoodStock.Text = "Stock: " + item.Stock.ToString();

            if (item.ItemImage != null)
            {
                pcbFoodImage.Image = item.ItemImage;
                pcbFoodImage.SizeMode = PictureBoxSizeMode.Zoom;
            }

            // SEGURADONG CLICKABLE: Ikabit ang parehong click event sa LAHAT ng labels at picture sa ibabaw ng card mo
            lblFoodName.Click += ucAdminFoodCard_Click;
            lblFoodPrice.Click += ucAdminFoodCard_Click;
            lblFoodStock.Click += ucAdminFoodCard_Click;
            if (pcbFoodImage != null) pcbFoodImage.Click += ucAdminFoodCard_Click;

            ApplyRounding();
        }

        // TAMA NA KINI: Direkta na ang pagka-rounded gamit ang kaugalingong method sa sulod sa card!
        private void ApplyRounding()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            // 1. Himuong rounded ang tibuok TableCard border
            LocalMakeRounded(this, 15);

            // 2. Himuong rounded pud ang pcbFoodImage sa sulod
            if (pcbFoodImage != null)
            {
                LocalMakeRounded(pcbFoodImage, 10);
            }
        }

        // AKONG GIDUGANG NGA LOCAL METHOD PARA MAWALA ANG ERROR CS0122:
        private void LocalMakeRounded(Control control, int radius)
        {
            if (control.Width <= 0 || control.Height <= 0) return;

            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(control.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(control.Width - radius, control.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, control.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            control.Region = new Region(path);
        }

        // EVENT HANDLER: Kung asa mo-open si frmChooseSize inig pislit sa card!
        private void ucAdminFoodCard_Click(object sender, EventArgs e)
        {
            if (_currentItem == null) return;

            // Buksan ang frmChooseSize bilang isang modal pop-up window sa gitna ng screen
            using (frmChooseSize frm = new frmChooseSize())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    // TODO: Dito mo ilalagay ang logic kung paano i-add sa POS Cart panel mo kapag nag-OK ang size selection
                }
            }
        }
    }
}
