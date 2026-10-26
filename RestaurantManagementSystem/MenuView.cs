using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;


namespace RestaurantManagementSystem
{
    public partial class MenuView : UserControl
    {
        private readonly string connectionString =
            @"Server=.\SQL Server Management;Database=RestoFlowDB;Integrated Security=True;TrustServerCertificate=True;";
        public MenuView()
        {
            InitializeComponent();
        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            using (FrmMenuItem form = new FrmMenuItem())
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    LoadMenu();
                }
            }
        }
            

        private void MenuView_Load(object sender, EventArgs e)
        {
            LoadCategories();
            LoadMenu();
        }
        private void LoadCategories()
        {
            string query = @"
                SELECT CategoryName
                FROM Categories
                WHERE IsActive = 1
                ORDER BY CategoryName;";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection))
                {
                    DataTable categories = new DataTable();
                    adapter.Fill(categories);

                    cbCategory.Items.Clear();
                    cbCategory.Items.Add("All Categories");

                    foreach (DataRow row in categories.Rows)
                    {
                        cbCategory.Items.Add(
                            row["CategoryName"].ToString());
                    }

                    cbCategory.SelectedIndex = 0;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load categories.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void LoadMenu()
        {
            string query = @"
                SELECT
                    M.MenuItemID,
                    M.ItemName,
                    C.CategoryName,
                    M.Description,
                    M.Price,
                    M.IsAvailable
                FROM MenuItems AS M
                INNER JOIN Categories AS C
                    ON M.CategoryID = C.CategoryID
                ORDER BY M.ItemName;";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(query, connection))
                {
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMenu.DataSource = table;
                }

                FormatMenuGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to load menu items.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void FormatMenuGrid()
        {
            if (dgvMenu.Columns.Count == 0)
                return;

            dgvMenu.Columns["MenuItemID"].HeaderText = "ID";
            dgvMenu.Columns["ItemName"].HeaderText = "Item Name";
            dgvMenu.Columns["CategoryName"].HeaderText = "Category";
            dgvMenu.Columns["Description"].HeaderText = "Description";
            dgvMenu.Columns["Price"].HeaderText = "Price";
            dgvMenu.Columns["IsAvailable"].HeaderText = "Available";

            dgvMenu.Columns["MenuItemID"].FillWeight = 40;
            dgvMenu.Columns["Price"].DefaultCellStyle.Format =
                "₱#,##0.00";
        }

        private void FilterMenu()
        {
            string query = @"
                SELECT
                    M.MenuItemID,
                    M.ItemName,
                    C.CategoryName,
                    M.Description,
                    M.Price,
                    M.IsAvailable
                FROM MenuItems AS M
                INNER JOIN Categories AS C
                    ON M.CategoryID = C.CategoryID
                WHERE M.ItemName LIKE @Search
                  AND (
                      @Category = 'All Categories'
                      OR C.CategoryName = @Category
                  )
                ORDER BY M.ItemName;";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                using (SqlDataAdapter adapter =
                    new SqlDataAdapter(command))
                {
                    command.Parameters.Add(
                        "@Search",
                        SqlDbType.NVarChar,
                        100
                    ).Value = "%" + tbSearch.Text.Trim() + "%";

                    command.Parameters.Add(
                        "@Category",
                        SqlDbType.NVarChar,
                        60
                    ).Value = string.IsNullOrWhiteSpace(cbCategory.Text)
                        ? "All Categories"
                        : cbCategory.Text;

                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dgvMenu.DataSource = table;
                }

                FormatMenuGrid();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to filter menu items.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(
            object sender, EventArgs e)
        {
            FilterMenu();
        }

        private void cmbCategory_SelectedIndexChanged(
            object sender, EventArgs e)
        {
            FilterMenu();
        }

        private void btnRefresh_Click(
            object sender, EventArgs e)
        {
            LoadCategories();
            LoadMenu();
        }
    }
}
