using _3_13_25.D2.QueryStorage;
using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.Classes
{
    public class BillingClass
    {
        #region function

        #endregion

        #region BillingDtGV
        public static void ShowBilling(DataGridView dataGridView)
        {
            string query = "SELECT * FROM D2.TransactionBilling";

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.DataSource = table;
                    }
                }
            }
        }

        public static void SelectedValue(DataGridView dataGridView)
        {
            DataGridViewRow selectedRow = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];

            if (selectedRow != null)
            {
                BillingObj.TransactionId = Convert.ToInt64(selectedRow.Cells["Transaction_Id"].Value ?? 0);
                BillingObj.TotalFee = Convert.ToDecimal(selectedRow.Cells["Total_Value"].Value ?? 0);
                BillingObj.PayFee = Convert.ToDecimal(selectedRow.Cells["Paid_Amount"].Value ?? 0);
            }
        }
        #endregion
    }
}
