using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Asset_Tracking_System
{
    /* Class to handle the SQL Server connection and stored procedures for assets. */
    public class AssetDatabase
    {
        /* Private field for the connection string. */
        private string connectionString;

        /* Constructor reading the connection string from App.config. */
        public AssetDatabase()
        {
            this.ConnectionString = ConfigurationManager.ConnectionStrings["AssetDBConnection"].ConnectionString;
        }

        /* Public property for the connection string with basic validation. */
        public string ConnectionString
        {
            get { return connectionString; }
            set
            {
                if (value != "")
                {
                    connectionString = value;
                }
            }
        }

        /* Helper method to run a stored procedure that returns rows for the DataGridView. */
        private DataTable ExecuteReportProcedure(string procedureName, SqlParameter parameter = null)
        {
            DataTable dt = new DataTable();

            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand(procedureName, conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;

                    if (parameter != null)
                    {
                        cmd.Parameters.Add(parameter);
                    }

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    conn.Open();
                    adapter.Fill(dt);
                }
            }

            return dt;
        }

        /* Gets all assets from the database to display in the DataGridView. */
        public DataTable GetAllAssets()
        {
            return ExecuteReportProcedure("usp_Asset_GetAll");
        }

        /* Adds a new asset using the stored procedure in SQL Server. */
        public void AddAsset(string assetTag, string modelName, string assetType, string category, decimal purchasePrice, DateTime purchaseDate, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Asset_Add", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetTag", assetTag);
                    cmd.Parameters.AddWithValue("@ModelName", modelName);
                    cmd.Parameters.AddWithValue("@AssetType", assetType);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@Status", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /* Updates an existing asset using the stored procedure in SQL Server. */
        public void UpdateAsset(int assetId, string assetTag, string modelName, string assetType, string category, decimal purchasePrice, DateTime purchaseDate, string status)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Asset_Update", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetId", assetId);
                    cmd.Parameters.AddWithValue("@AssetTag", assetTag);
                    cmd.Parameters.AddWithValue("@ModelName", modelName);
                    cmd.Parameters.AddWithValue("@AssetType", assetType);
                    cmd.Parameters.AddWithValue("@Category", category);
                    cmd.Parameters.AddWithValue("@PurchasePrice", purchasePrice);
                    cmd.Parameters.AddWithValue("@PurchaseDate", purchaseDate);
                    cmd.Parameters.AddWithValue("@Status", status);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /* Deletes an asset by ID using the stored procedure in SQL Server. */
        public void DeleteAsset(int assetId)
        {
            using (SqlConnection conn = new SqlConnection(connectionString))
            {
                using (SqlCommand cmd = new SqlCommand("usp_Asset_Delete", conn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@AssetId", assetId);

                    conn.Open();
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /* Report 1: Complete list of Laptops. */
        public DataTable GetLaptopsReport()
        {
            return ExecuteReportProcedure("usp_Report_GetLaptops");
        }

        /* Report 2: Complete list of Licenses. */
        public DataTable GetLicensesReport()
        {
            return ExecuteReportProcedure("usp_Report_GetLicenses");
        }

        /* Report 3: Complete list of broad intermediate category (Equipment). */
        public DataTable GetEquipmentReport()
        {
            return ExecuteReportProcedure("usp_Report_GetEquipment");
        }

        /* Report 4: Filter assets by minimum purchase price. */
        public DataTable FilterByPriceReport(decimal minPrice)
        {
            SqlParameter param = new SqlParameter("@MinPrice", SqlDbType.Decimal)
            {
                Precision = 10,
                Scale = 2,
                Value = minPrice
            };
            return ExecuteReportProcedure("usp_Report_FilterByPrice", param);
        }

        /* Report 5: Filter assets by status string. */
        public DataTable FilterByStatusReport(string status)
        {
            SqlParameter param = new SqlParameter("@Status", SqlDbType.VarChar, 30)
            {
                Value = status
            };
            return ExecuteReportProcedure("usp_Report_FilterByStatus", param);
        }

        /* Report 6: Custom query 1 - Available assets. */
        public DataTable GetAvailableAssetsReport()
        {
            return ExecuteReportProcedure("usp_Report_AvailableAssets");
        }

        /* Report 7: Custom query 2 - Assets ordered from highest to lowest price. */
        public DataTable GetMostExpensiveAssetsReport()
        {
            return ExecuteReportProcedure("usp_Report_MostExpensiveAssets");
        }
    }
}