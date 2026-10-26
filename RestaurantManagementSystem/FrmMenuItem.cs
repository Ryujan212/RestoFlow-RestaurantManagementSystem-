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
    public partial class FrmMenuItem : Form
    {
        private readonly string connectionString =
            @"Server=.\SQL Server Management;Database=RestoFlowDB;Integrated Security=True;TrustServerCertificate=True;";

        public FrmMenuItem()
        {
            InitializeComponent();
        }

        private void FrmMenuItem_Load(object sender, EventArgs e)
        {
            LoadCategories();
        }

        private void LoadCategories()
        {
            string query = @"
                SELECT CategoryID, CategoryName
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

                    cbCategory.DataSource = categories;
                    cbCategory.DisplayMember = "CategoryName";
                    cbCategory.ValueMember = "CategoryID";
                    cbCategory.SelectedIndex = -1;
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


        private void btnSave_Click(object sender, EventArgs e)
        {
            string itemName = tbItemName.Text.Trim();
            string description = tbDescription.Text.Trim();

            if (string.IsNullOrWhiteSpace(itemName))
            {
                MessageBox.Show("Please enter an item name.");
                tbItemName.Focus();
                return;
            }

            if (cbCategory.SelectedIndex < 0)
            {
                MessageBox.Show("Please select a category.");
                cbCategory.Focus();
                return;
            }

            string query = @"
                INSERT INTO MenuItems
                    (CategoryID, ItemName, Description, Price, IsAvailable)
                VALUES
                    (@CategoryID, @ItemName, @Description, @Price, @IsAvailable);";

            try
            {
                using (SqlConnection connection =
                    new SqlConnection(connectionString))
                using (SqlCommand command =
                    new SqlCommand(query, connection))
                {
                    command.Parameters.Add(
                        "@CategoryID", SqlDbType.Int).Value =
                        Convert.ToInt32(cbCategory.SelectedValue);

                    command.Parameters.Add(
                        "@ItemName", SqlDbType.NVarChar, 100).Value =
                        itemName;

                    SqlParameter descriptionParameter =
                     command.Parameters.Add(
                        "@Description",
                         SqlDbType.NVarChar,
                         255);

                    if (string.IsNullOrWhiteSpace(description))
                    {
                        descriptionParameter.Value = DBNull.Value;
                    }
                    else
                    {
                        descriptionParameter.Value = description;
                    }

                    command.Parameters.Add(
                        "@Price", SqlDbType.Decimal).Value =
                        numPrice.Value;

                    command.Parameters["@Price"].Precision = 10;
                    command.Parameters["@Price"].Scale = 2;

                    command.Parameters.Add(
                        "@IsAvailable", SqlDbType.Bit).Value =
                        chkAvailable.Checked;

                    connection.Open();
                    command.ExecuteNonQuery();
                }

                MessageBox.Show(
                    "Menu item added successfully!",
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Unable to save the menu item.\n" + ex.Message,
                    "Database Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
