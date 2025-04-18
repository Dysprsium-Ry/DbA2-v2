using _3_13_25.D2.QueryStorage;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.ViewModel.D2.MainFormVM.D2.BusinessLogics_MFVM_
{
    public class EditClass
    {
        public static List<QueuedItems> FetchEditLogData()
        {
            List<QueuedItems> editItemList = new List<QueuedItems>();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.FetchTransactionInformation, connection))
                {
                    command.Parameters.AddWithValue("@Id", TemporalData.TransactionId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var itemsList = new QueuedItems()
                            {
                                TransactionId = reader["Transaction_Id"] != DBNull.Value ? (long)reader["Transaction_Id"] : 0,
                                QueuedSubject = reader["Subject"] != DBNull.Value ? (string)reader["Subject"] : string.Empty,
                                QueuedTutor = reader["Tutor"] != DBNull.Value ? (string)reader["Tutor"] : string.Empty,
                                QueuedHourlyRate = reader["Per_Hour_Rate"] != DBNull.Value ? (decimal)reader["Per_Hour_Rate"] : decimal.Zero,
                                QueuedStartTime = reader["Time_Period_Begin"] != DBNull.Value ? (TimeSpan)reader["Time_Period_Begin"] : TimeSpan.Zero,
                                QueuedEndTime = reader["Time_Period_End"] != DBNull.Value ? (TimeSpan)reader["Time_Period_End"] : TimeSpan.Zero,
                                QueuedSessionSchedule = reader["Date_Schedule"] != DBNull.Value ? (DateTime)reader["Date_Schedule"] : DateTime.MinValue,
                            };

                            editItemList.Add(itemsList);
                        }
                    }
                }
            }

            return editItemList;
        }
    }
}
