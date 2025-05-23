using _3_13_25.D2.Classes;
using _3_13_25.D2.QueryStorage;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Migrations.Model;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.ViewModel.D2.RegistrationLogics
{
    public class BookingLogics
    {
        public static bool isTransactionItemExist()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM D2.TransactionInformation WHERE Transaction_Id = @Id AND Subject = @Subject AND Tutor = @Tutor AND CAST(@DateTime AS DATETIME) BETWEEN CAST(Date_Schedule AS DATETIME) + CAST(Time_Period_Begin AS DATETIME) AND CAST(Date_Schedule AS DATETIME) + CAST(Time_Period_End AS DATETIME)", connection))
                {
                    command.Parameters.AddWithValue("@Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Subject", Enrollment.Subject);
                    command.Parameters.AddWithValue("@Tutor", Enrollment.TutorId);
                    command.Parameters.AddWithValue("@DateTime", OpsAndCalcs.CombineDateAndTime(Enrollment.SessionScheduleDate, Enrollment.StartSchedule));

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static void RegisterTransaction(string State)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.RegisterTransactions, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Student", Enrollment.StudentName);
                    command.Parameters.AddWithValue("@Email", Enrollment.StudentEmail);
                    command.Parameters.AddWithValue("@Created", DateTime.Now);
                    command.Parameters.AddWithValue("@Modified", DateTime.Now);
                    command.Parameters.AddWithValue("@Status", State);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool IsTransactionExist()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM D2.Transactions WHERE Transaction_Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", Enrollment.TransactionId);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static bool IsInformationExist()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM D2.TransactionInformation WHERE Transaction_Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", Enrollment.TransactionId);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static void RegisterTransactionInformation(string State)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.RegisterTransactionInformation, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Subject", Enrollment.Subject);
                    command.Parameters.AddWithValue("@Tutor", Enrollment.TutorId);
                    command.Parameters.AddWithValue("@Per_Hour_Rate", Enrollment.HourlyRate);
                    command.Parameters.AddWithValue("@Time_Period_Begin", Enrollment.StartSchedule);
                    command.Parameters.AddWithValue("@Time_Period_End", Enrollment.EndSchedule);
                    command.Parameters.AddWithValue("@Date_Schedule", Enrollment.SessionScheduleDate);
                    command.Parameters.AddWithValue("@State", State);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateTransactionInformation(string State, long tutor, DateTime date)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.UpdateTransactionInformation, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Tutor", tutor);
                    command.Parameters.AddWithValue("@Date", date);
                    command.Parameters.AddWithValue("@State", State);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateTransaction(string State)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.UpdateTransactions, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@Transaction_Id", Enrollment.TransactionId);
                    command.Parameters.AddWithValue("@Modified_Date", DateTime.Now);
                    command.Parameters.AddWithValue("@Status", State);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RegisterTransactionBilling()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                if (!IsBillingExist())
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
                else
                {
                    using (SqlCommand command = new SqlCommand("UPDATE D2.TransactionBilling SET Total_Value = @Value WHERE Transaction_Id = @Id", connection))
                    {
                        command.Parameters.AddWithValue("@Value", Enrollment.TotalFee);
                        command.Parameters.AddWithValue("@Id", Enrollment.TransactionId);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static bool IsBillingExist()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(1) FROM D2.TransactionBilling WHERE Transaction_Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", Enrollment.TransactionId);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static bool IsTutorAvailable(long tutor, DateTime date)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.IsTutorValid, connection))
                {
                    command.Parameters.AddWithValue("@tutor", tutor);
                    command.Parameters.AddWithValue("@date", date);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static void DropOnUpdate(long id, string subject, long tutor, DateTime date)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.DropOnUpdate, connection))
                {
                    command.Parameters.AddWithValue("@Id", id);
                    command.Parameters.AddWithValue("@Subject", subject);
                    command.Parameters.AddWithValue("@Tutor", tutor);
                    command.Parameters.AddWithValue("@Date", date.Date);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
