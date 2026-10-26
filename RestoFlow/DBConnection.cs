using System;
using System.Data;
using System.Data.SqlClient; // Kung may pulang linya rito, tingnan ang tip sa ibaba
using System.Windows.Forms;

namespace RestoFlow
{
    public static class DbConnection
    {
        // TAMA NA KINI: Ginagamit na ang RestoFlowDB bilang Initial Catalog batay sa iyong database name
        private static string connString = @"Data Source=localhost;Initial Catalog=RestoFlowDB;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=False;TrustServerCertificate=True;Command Timeout=0";

        // Public method upang kumuha ng mabilis at bukas na koneksyon sa SQL Server
        public static SqlConnection GetConnection()
        {
            SqlConnection conn = new SqlConnection(connString);
            try
            {
                if (conn.State == ConnectionState.Closed)
                {
                    conn.Open();
                }
                return conn;
            }
            catch (Exception ex)
            {
                MessageBox.Show("SQL Server Connection Failed:\n" + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return null;
            }
        }
    }
}
