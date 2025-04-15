using _3_13_25.D2.QueryStorage;
using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.Classes
{
    public class BillingClass
    {
        #region function

        public static void RegisterTransaction()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.RegisterTransaction, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Student", Enrollment.StudentName);
                    command.Parameters.AddWithValue("@Email", Enrollment.StudentEmail);
                    command.Parameters.AddWithValue("@Total_Value", Enrollment.TotalFee);
                    command.Parameters.AddWithValue("@State", "Enroll");
                    command.Parameters.AddWithValue("@Created", DateTime.Now);
                    command.Parameters.AddWithValue("@Modified", DateTime.Now);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RegisterTransactionInformation()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.RegisterTransactionInformation, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Subject", Enrollment.Subject);
                    command.Parameters.AddWithValue("@Tutor", Enrollment.TutorName);
                    command.Parameters.AddWithValue("@Per_Hour_Rate", Enrollment.HourlyRate);
                    command.Parameters.AddWithValue("@Time_Period_Begin", Enrollment.StartSchedule);
                    command.Parameters.AddWithValue("@Time_Period_End", Enrollment.EndSchedule);
                    command.Parameters.AddWithValue("@Date_Schedule", Enrollment.SessionScheduleDate);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RegisterTransactionBilling()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.RegisterTransactionBilling, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Total_Value", Enrollment.TotalFee);
                    command.Parameters.AddWithValue("@Payment_Amount", 0);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdatePayment()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.TransactionBilling SET PaidAmount = @paidAmount, PaymentStatus = @paymentStatus WHERE TransactionId = @transactionId", connection))
                {
                    command.Parameters.AddWithValue("@transactionId", BillingObj.TransactionId);
                    command.Parameters.AddWithValue("@paidAmount", OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay));
                    command.Parameters.AddWithValue("@paymentStatus", OpsAndCalcs.PaymentStatus(OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay), BillingObj.TotalFee));
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion

        #region DataGridViewProvider
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

        public static void ShowPartialBilling(DataGridView dataGridView)
        {
            //string query = "SELECT * FROM D2.PresentPartialBilling";
            string query = "SELECT * FROM D2.TransactionBillingPartial";
            //string query2 = "SELECT * FROM D2.TransactionBilling where PaymentStatus = 'Partial'";

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
        public static void ShowPaidBilling(DataGridView dataGridView)
        {
            //string query = "SELECT * FROM D2.PresentPaidBilling";
            string query = "SELECT * FROM D2.TransactionBillingPaid";
            //string query2 = "SELECT * FROM D2.TransactionBilling where PaymentStatus = 'Paid'";

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
                BillingObj.TransactionId = Convert.ToInt64(selectedRow.Cells["TransactionId"].Value ?? 0);
                BillingObj.Student = Convert.ToString(selectedRow.Cells["Student"].Value ?? 0);
                BillingObj.TotalFee = Convert.ToDecimal(selectedRow.Cells["TotalAmountFee"].Value ?? 0);
                BillingObj.PayFee = Convert.ToDecimal(selectedRow.Cells["PaidAmount"].Value ?? 0);
            }
        }
        #endregion
    }
}
