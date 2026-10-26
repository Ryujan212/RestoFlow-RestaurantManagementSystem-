using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class frmAddMenu : Form
    {
        public frmAddMenu()
        {
            InitializeComponent();

            // I-subscribe sa Load at SizeChanged para maging rounded ang pop-up form
            this.Load += FrmAddMenu_Load;
            this.SizeChanged += FrmAddMenu_SizeChanged;

            // Mapipilitang magkalaman ang dropdown sa mismong pag-create ng form
            LoadCategoriesIntoComboBox();
        }

        private void FrmAddMenu_Load(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void FrmAddMenu_SizeChanged(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        // Method para gawing bilugan ang gilid ng Windows Form para maging frameless custom UI
        private void ApplyFormRounding()
        {
            if (this.Width <= 0 || this.Height <= 0) return;

            int radius = 25; // Kapansin-pansing bilugan tulad ng iyong mockup
            GraphicsPath path = new GraphicsPath();
            path.AddArc(0, 0, radius, radius, 180, 90);
            path.AddArc(this.Width - radius, 0, radius, radius, 270, 90);
            path.AddArc(this.Width - radius, this.Height - radius, radius, radius, 0, 90);
            path.AddArc(0, this.Height - radius, radius, radius, 90, 90);
            path.CloseFigure();

            this.Region = new Region(path);
        }

        public void LoadCategoriesIntoComboBox()
        {
            if (cbAddMenuItem != null)
            {
                cbAddMenuItem.Items.Clear();
                foreach (var cat in RestoFlow.Menu.AllCategories)
                {
                    cbAddMenuItem.Items.Add(cat.Name);
                }

                if (cbAddMenuItem.Items.Count > 0)
                {
                    cbAddMenuItem.SelectedIndex = 0;
                }
                else
                {
                    cbAddMenuItem.Items.Add("No Categories Available");
                    cbAddMenuItem.SelectedIndex = 0;
                }
            }
        }

        // BROWSE BUTTON
        private void btnBrowseMenu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Item Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string folder = Path.Combine(Application.StartupPath, "FoodImages");
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    string fileName = Path.GetFileName(ofd.FileName);
                    string destination = Path.Combine(folder, fileName);

                    File.Copy(ofd.FileName, destination, true);

                    PcbAddItem.Image = Image.FromFile(destination);
                    PcbAddItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        // CREATE BUTTON NG ADD MENU FORM MO
        private void btnCreateAddMenu_Click(object sender, EventArgs e)
        {
            // ========== VALIDATION ==========
            if (string.IsNullOrWhiteSpace(tbNameAddItem.Text))
            {
                MessageBox.Show("Item Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNameAddItem.Focus();
                return;
            }

            if (cbAddMenuItem.SelectedItem == null || cbAddMenuItem.SelectedItem.ToString() == "No Categories Available")
            {
                MessageBox.Show("Please select a valid Category first!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (PcbAddItem.Image == null)
            {
                MessageBox.Show("Please select an Item Image!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ========== SAVE DATA TO MODEL ==========
            MenuItem newItem = new MenuItem
            {
                Name = tbNameAddItem.Text.Trim(),
                Category = cbAddMenuItem.SelectedItem.ToString(),
                Price = numPriceAddItem.Value,
                Stock = (int)numStockAddItem.Value,
                Description = tbDescAddItem.Text.Trim(),
                ItemImage = PcbAddItem.Image,
                IsUnavailable = cbaddAvailable.Checked
            };

            RestoFlow.Menu.AllMenuItems.Add(newItem);

            MessageBox.Show("Menu Item added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // CANCEL BUTTON NG ADD MENU FORM MO
        private void btnCancelAddMenu_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        // KUNG NAG-ADD KA NG CUSTOM 'X' BUTTON SA TAAS, I-LINK ITO SA EVENT:
        private void btnCloseCustom_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
