using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class frmAddCategory : Form
    {
        private string selectedImagePath = "";

        public frmAddCategory()
        {
            InitializeComponent();

            // I-subscribe sa Load at SizeChanged para maging rounded ang pop-up form
            this.Load += FrmAddCategory_Load;
            this.SizeChanged += FrmAddCategory_SizeChanged;
        }

        private void FrmAddCategory_Load(object sender, EventArgs e)
        {
            ApplyFormRounding();
        }

        private void FrmAddCategory_SizeChanged(object sender, EventArgs e)
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

        // BROWSE BUTTON
        private void btnBrowseCatMenu_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select Category Image";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    string folder = Path.Combine(Application.StartupPath, "FoodImages");
                    if (!Directory.Exists(folder))
                        Directory.CreateDirectory(folder);

                    string fileName = Path.GetFileName(ofd.FileName);
                    string destination = Path.Combine(folder, fileName);

                    File.Copy(ofd.FileName, destination, true);
                    selectedImagePath = Path.Combine("FoodImages", fileName);

                    PcbAddItem.Image = Image.FromFile(destination);
                    PcbAddItem.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
        }

        // CREATE BUTTON NG ADD CATEGORY FORM MO
        private void btnCreateAddItem_Click(object sender, EventArgs e)
        {
            // ========== VALIDATION ==========
            if (string.IsNullOrWhiteSpace(tbNameAddcat.Text) || tbNameAddcat.Text == "e.g Main Course")
            {
                MessageBox.Show("Category Name is required!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tbNameAddcat.Focus();
                return;
            }

            if (PcbAddItem.Image == null)
            {
                MessageBox.Show("Please select a Category Image!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // ========== SAVE DATA TO MODEL ==========
            Category newCategory = new Category
            {
                Name = tbNameAddcat.Text.Trim(),
                Description = tbDescAddCat.Text.Trim(),
                CategoryImage = PcbAddItem.Image,
                ImagePath = selectedImagePath
            };

            RestoFlow.Menu.AllCategories.Add(newCategory);

            MessageBox.Show("Category added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        // CANCEL BUTTON NG ADD CATEGORY FORM MO
        private void btnCancelAddItem_Click(object sender, EventArgs e)
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
