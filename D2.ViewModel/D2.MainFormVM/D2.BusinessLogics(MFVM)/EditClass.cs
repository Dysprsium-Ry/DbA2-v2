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
        public static List<QueuedItems> FetchClientData()
        {
            List<QueuedItems> ClientItemList = new List<QueuedItems>();

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
                                Subject = reader["Subject"] != DBNull.Value ? (string)reader["Subject"] : string.Empty,
                                Tutor = reader["Tutor"] != DBNull.Value ? (string)reader["Tutor"] : string.Empty,
                                HourlyRate = reader["Per_Hour_Rate"] != DBNull.Value ? (decimal)reader["Per_Hour_Rate"] : decimal.Zero,
                                StartSchedule = reader["Time_Period_Begin"] != DBNull.Value ? (TimeSpan)reader["Time_Period_Begin"] : TimeSpan.Zero,
                                EndSchedule = reader["Time_Period_End"] != DBNull.Value ? (TimeSpan)reader["Time_Period_End"] : TimeSpan.Zero,
                                SessionScheduleDate = reader["Date_Schedule"] != DBNull.Value ? (DateTime)reader["Date_Schedule"] : DateTime.MinValue,
                                Status = reader["Transaction_State"] != DBNull.Value ? (string)reader["Transaction_State"] : string.Empty,
                            };

                            ClientItemList.Add(itemsList);
                        }
                    }
                }
            }

            return ClientItemList;
        }
    }
}
