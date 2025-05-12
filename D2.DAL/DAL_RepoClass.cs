using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.DAL
{
    public class DAL_RepoClass
    {
        public void Save(TransactionItems item)
        {
            using (SqlConnection conn = DatabaseConnection.Establish())
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = conn;

                    cmd.CommandText = @"
                IF EXISTS (
                    SELECT 1 FROM D2.TransactionInformation
                    WHERE Transaction_Id = @TransactionId AND Date_Schedule = @ScheduleDate
                )
                BEGIN
                    UPDATE D2.TransactionInformation
                    SET Subject = @Subject,
                        Tutor = @Tutor,
                        HourlyRate = @HourlyRate,
                        Time_Period_Begin = @StartSchedule,
                        Time_Period_End = @EndSchedule
                    WHERE Transaction_Id = @TransactionId AND Date_Schedule = @ScheduleDate
                END
                ELSE
                BEGIN
                    INSERT INTO D2.QueuedItems (Transaction_Id, Subject, Tutor, HourlyRate, Date_Schedule, Time_Period_Begin, Time_Period_End)
                    VALUES (@TransactionId, @Subject, @Tutor, @HourlyRate, @ScheduleDate, @StartSchedule, @EndSchedule)
                END";

                    cmd.Parameters.AddWithValue("@TransactionId", item.TransactionId);
                    cmd.Parameters.AddWithValue("@Subject", item.Subject);
                    cmd.Parameters.AddWithValue("@Tutor", item.Tutor);
                    cmd.Parameters.AddWithValue("@HourlyRate", item.HourlyRate);
                    cmd.Parameters.AddWithValue("@ScheduleDate", item.SessionScheduleDate);
                    cmd.Parameters.AddWithValue("@StartSchedule", item.StartSchedule);
                    cmd.Parameters.AddWithValue("@EndSchedule", item.EndSchedule);

                    cmd.ExecuteNonQuery();
                }
            }
        }

        public List<TransactionItems> GetAllByTransactionId(long transactionId)
        {
            List<TransactionItems> items = new List<TransactionItems>();

            using (SqlConnection conn = DatabaseConnection.Establish())
            {
                using (SqlCommand cmd = new SqlCommand("SELECT * FROM D2.TransactionInformation WHERE Transaction_Id = @TransactionId", conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionId", transactionId);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            items.Add(new TransactionItems
                            {
                                TransactionId = Convert.ToInt64(reader["TransactionId"]),
                                Subject = reader["Subject"].ToString(),
                                Tutor = reader["Tutor"].ToString(),
                                HourlyRate = Convert.ToDecimal(reader["HourlyRate"]),
                                SessionScheduleDate = Convert.ToDateTime(reader["SessionScheduleDate"]),
                                StartSchedule = TimeSpan.Parse(reader["StartSchedule"].ToString()),
                                EndSchedule = TimeSpan.Parse(reader["EndSchedule"].ToString())
                            });
                        }
                    }
                }
            }

            return items;
        }

        public void Delete(long transactionId, DateTime sessionScheduleDate)
        {
            using (SqlConnection conn = DatabaseConnection.Establish())
            {
                using (SqlCommand cmd = new SqlCommand("DELETE FROM D2.TransactionInformation WHERE Transaction_Id = @TransactionId AND Date_Schedule = @ScheduleDate", conn))
                {
                    cmd.Parameters.AddWithValue("@TransactionId", transactionId);
                    cmd.Parameters.AddWithValue("@ScheduleDate", sessionScheduleDate);
                    cmd.ExecuteNonQuery();
                }
            }
        }

    }
}
