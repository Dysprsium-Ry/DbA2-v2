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

    
}
