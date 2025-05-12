using _3_13_25.D2.IdFetcherClasses;
using _3_13_25.D2.QueryStorage;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.Classes
{
    public class OpsAndCalcs
    {
        public static decimal CalculateSumSessionFee(decimal currentTotal, decimal hourlyRate)
        {
            return currentTotal + hourlyRate;
        }
        public static decimal CalculateSubtSessionFee(decimal currenTotal, decimal hourlyRate)
        {
            return currenTotal - hourlyRate;
        }
        public static decimal SumPaidFee(decimal PaidFee, decimal PayFee)
        {
            return PaidFee + PayFee;
        }
        public static bool IfScheduleExist(DateTime date, TimeSpan time)
        {
            DateTime scheduleTime = date.Date + time;

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM D2.TransactionLog WHERE SessionEndSchedule >= @scheduleDate AND TutorId = @tutorId;", connection))
                {
                    command.Parameters.Add("@scheduleDate", SqlDbType.DateTime).Value = scheduleTime;
                    command.Parameters.AddWithValue("@tutorId", IdFetcher.TutorId());

                    int count = (command.ExecuteScalar() as int?) ?? 0;
                    return count > 0;
                }
            }
        }
        public static DateTime SessessionEndSchedule(DateTime date, TimeSpan time, int sessionDuration)
        {
            DateTime calculatedTime = date + time;
            TimeSpan sessionTimeSpan = TimeSpan.FromHours(sessionDuration);

            TimeSpan workStart = TemporalData.InTime;
            TimeSpan workEnd = TemporalData.OutTime;

            if (calculatedTime.TimeOfDay < workStart)
            {
                calculatedTime = calculatedTime.Date.Add(workStart);
            }
            else if (calculatedTime.TimeOfDay >= workEnd)
            {
                calculatedTime = calculatedTime.Date.AddDays(1).Add(workStart);
            }

            TimeSpan remainingToday = (workEnd - calculatedTime.TimeOfDay);

            if (sessionTimeSpan <= remainingToday)
            {
                calculatedTime = calculatedTime.Add(sessionTimeSpan);
            }
            else
            {
                calculatedTime = calculatedTime.Add(remainingToday);

                TimeSpan remainingSession = sessionTimeSpan - remainingToday;

                calculatedTime = calculatedTime.Date.AddDays(1).Add(workStart);

                calculatedTime = calculatedTime.Add(remainingSession);
            }
            return calculatedTime;
        }

        public static DateTime CombineDateAndTime(DateTime date, TimeSpan time)
        {
            DateTime combinedDateTime = date.Date + time;

            return combinedDateTime;
        }

        #region SearchBox

        public static void SearchBar(DataGridView dt, string query, string item)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@item", "%" + item + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dt.AutoGenerateColumns = true;
                        dt.DataSource = table;
                    }
                }
            }
        }

        public static void SearchingBilling(DataGridView dt, string Tutor)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("D2.SearchTransactionLogsForPending", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SearchText", "%" + Tutor + "%");

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable table = new DataTable();
                        adapter.Fill(table);
                        dt.AutoGenerateColumns = true;
                        dt.DataSource = table;
                    }
                }
            }
        }

        #endregion

        public static bool IsStudentNameExist(string Name)
        {
            if (string.IsNullOrWhiteSpace(Name))
                return false;

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.IsStudentNameExist, connection))
                {
                    command.Parameters.AddWithValue("@name", Name);
                    int count = (int)command.ExecuteScalar();
                    return count > 0;
                }
            }
        }

    }

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
        #endregion

        public void Refresh()
        {
            RefreshRequested?.Invoke();
        }
    }
}
