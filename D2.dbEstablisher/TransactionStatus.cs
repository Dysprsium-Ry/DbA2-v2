using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3_13_25.D2.dbEstablisher
{
    public class TransactionStatus
    {
        public static event Action RefreshRequested;

        #region TransactionState

        public void TransactionState()
        {
            SqlDependency.Start(Database.Connectionstring);
            RegisterNotification();
        }

        private void RegisterNotification()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Payment_Amount FROM D2.TransactionBilling", connection))
                {
                    SqlDependency dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(OnDependencyChange);
                    command.ExecuteReader();
                }
            }
        }

        private void OnDependencyChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                UpdatePaymentStatuses();
                UpdateTransactionStatus();
            }
            RegisterNotification();
        }

        private void UpdatePaymentStatuses()
        {
            using (SqlConnection conn = DatabaseConnection.Establish())
            {
                string selectQuery = "SELECT Transaction_Id, Total_Value, Payment_Amount FROM D2.TransactionBilling";

                using (SqlCommand cmd = new SqlCommand(selectQuery, conn))
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long id = reader.GetInt64(0);
                        decimal totalFee = reader.GetDecimal(1);
                        decimal payment = reader.GetDecimal(2);

                        string newStatus = payment >= totalFee ? "Paid"
                                          : payment > 0 ? "Partial"
                                          : "Unpaid";

                        UpdateStatusInDb(id, newStatus);
                    }
                }
            }
        }

        private void UpdateTransactionStatus()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Transaction_Id, Payment_Amount FROM D2.TransactionBilling WHERE Transaction_Id = @Id", connection))
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        long transactionId = reader.GetInt64(0);
                        decimal paymentAmount = reader.GetDecimal(1);
                        string status = paymentAmount > 0 ? "Enrolled" : "Enlisted";

                        UpdateTransactionStatusInDb(transactionId, status);
                    }
                }
            }
        }

        private void UpdateStatusInDb(long transactionId, string status)
        {
            using (SqlConnection conn = DatabaseConnection.Establish())
            {
                string updateQuery = "UPDATE D2.TransactionBilling SET Bill_Status = @Status WHERE Transaction_Id = @Id";
                using (SqlCommand cmd = new SqlCommand(updateQuery, conn))
                {
                    cmd.Parameters.AddWithValue("@Status", status);
                    cmd.Parameters.AddWithValue("@Id", transactionId);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        private void UpdateTransactionStatusInDb(long id, string status)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.Transactions SET Status = @status WHERE Transaction_Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@status", status);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        public void Refresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
