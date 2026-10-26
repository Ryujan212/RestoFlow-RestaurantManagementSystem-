using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace RestoFlow
{
    public partial class Menu : UserControl
    {
        public static List<MenuItem> AllMenuItems = new List<MenuItem>();
        public static List<Category> AllCategories = new List<Category>();

        public Menu()
        {
            InitializeComponent();
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

            control.Paint += (s, e) =>
            {
                e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.Gray, 1.5f))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            };
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            MakeRounded(pnlMenuSection, 20);
            MakeRounded(flpMenuCatSection, 20);
            MakeRounded(flpMenuItemSection, 20);

            LoadCategoryCards();
            LoadMenuCards();
            UpdateCategoryComboBox();
        }

        public void UpdateCategoryComboBox()
        {
            if (cbMenuCat != null)
            {
                cbMenuCat.Items.Clear();
                cbMenuCat.Items.Add("All Categories");
                foreach (var cat in AllCategories)
                {
                    cbMenuCat.Items.Add(cat.Name);
                }
                if (cbMenuCat.Items.Count > 0) cbMenuCat.SelectedIndex = 0;
            }
        }

        private void btnAddCategory_Click(object sender, EventArgs e)
        {
            using (frmAddCategory frm = new frmAddCategory())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadCategoryCards();
                    UpdateCategoryComboBox();
                }
            }
        }

        public void LoadCategoryCards()
        {
            flpMenuCatSection.Controls.Clear();

            foreach (var cat in AllCategories)
            {
                ucCategoryCard card = new ucCategoryCard();
                card.SetData(cat);
                flpMenuCatSection.Controls.Add(card);
            }
        }

        // STATIC METHOD: Para sa pag-load ng categories sa Point of Sale tab panel
        public static void LoadCategoriesToExternalPanel(FlowLayoutPanel externalPanel)
        {
            if (externalPanel == null) return;
            externalPanel.Controls.Clear();

            foreach (var cat in AllCategories)
            {
                ucPosCategoryCard posCard = new ucPosCategoryCard();
                posCard.SetData(cat);
                externalPanel.Controls.Add(posCard);
            }
        }

        private void btnAddMenu_Click(object sender, EventArgs e)
        {
            using (frmAddMenu frm = new frmAddMenu())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    LoadMenuCards();
                }
            }
        }

        // ADMIN SIDE DISPLAY: ucMenuFoodCard ang pupunta rito base sa pagwawasto mo
        public void LoadMenuCards()
        {
            flpMenuItemSection.Controls.Clear();

            foreach (var item in AllMenuItems)
            {
                ucMenuFoodCard menuCard = new ucMenuFoodCard();
                menuCard.SetData(item);
                flpMenuItemSection.Controls.Add(menuCard);
            }
        }

        // POS SIDE DISPLAY: ucAdminFoodCard naman ang ipapadala sa Point of Sale tab section mo
        public static void LoadMenuToExternalPanel(FlowLayoutPanel externalPanel)
        {
            if (externalPanel == null) return;
            externalPanel.Controls.Clear();

            foreach (var item in AllMenuItems)
            {
                ucAdminFoodCard adminCard = new ucAdminFoodCard();
                adminCard.SetData(item);
                externalPanel.Controls.Add(adminCard);
            }
        }
    }
}
