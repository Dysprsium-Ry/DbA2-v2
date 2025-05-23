using _3_13_25.D2.DataModels;
using _3_13_25.D2.QueryStorage;
using Azure.Core;
using BienvenidoOnlineTutorServices.D2.Classes;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.ViewModel.D2.BusinessLogics
{
    public class Logics
    {

    }

    public class TransactionLogics
    {
        public static bool IsTutorAvailable(long tutor, TimeSpan outTime, DateTime date)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.IsTutorAvailable, connection))
                {
                    command.Parameters.AddWithValue("@Tutor", tutor);
                    command.Parameters.AddWithValue("@outTime", outTime);
                    command.Parameters.AddWithValue("@date", date);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }
    }

    public class StudEnrollmentLogics
    {
        public static bool IsStudentExist()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) AS Count FROM D2.Students WHERE Username = @User", connection))
                {
                    command.Parameters.AddWithValue("@User", TemporalData.StudentUserN);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }
    }

    public class SubjectLogics
    {
        public static void RegisterSubject(string subject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Subject (Subject) VALUES(@subject)", connection))
                {
                    command.Parameters.AddWithValue("@subject", subject);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteSubject(string subject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM D2.Subject WHERE Subject = @subject", connection))
                {
                    command.Parameters.AddWithValue("@subject", subject);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateSubject(long id, string newSubject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.Subject SET Subject = @newSubject WHERE SubjectId = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@newSubject", newSubject);
                    command.ExecuteNonQuery();
                }
            }
        }
    }

    public class BillingLogics
    {
        public static void FetchBillingInformation(long transactionId)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Student_Name, Status, Transaction_Created FROM D2.Transactions WHERE Transaction_Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@id", transactionId);
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            TemporalData.StudentUserN = reader.GetString(0);
                            TemporalData.Status = reader.GetString(1);
                            TemporalData.SessionScheduleDate = reader.GetDateTime(2);
                        }
                    }
                }
            }
        }

        public static void PaymentRegistration(long id, decimal pay)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.TransactionBilling SET Payment_Amount = @pay WHERE Transaction_Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@pay", pay);
                    command.Parameters.AddWithValue("@id", id);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void RecordHistory(long id, decimal value, decimal amount)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.BillingHistory (Transaction_Id, Total_Value, Payment_Amount, Transaction_Date) VALUES (@id, @value, @amount, GETDATE())", connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    command.Parameters.AddWithValue("@value", value);
                    command.Parameters.AddWithValue("@amount", amount);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static List<BillingHistory> FetchBillingHistory(long id)
        {
            List<BillingHistory> _list = new List<BillingHistory>();
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.BillingHistory WHERE Transaction_Id = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", id);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new BillingHistory
                            {
                                TransactionId = reader.GetInt64(reader.GetOrdinal("Transaction_Id")),
                                TotalValue = reader.GetDecimal(reader.GetOrdinal("Total_Value")),
                                Amount = reader.GetDecimal(reader.GetOrdinal("Payment_Amount")),
                                TransactionDate = reader.GetDateTime(reader.GetOrdinal("Transaction_Date"))
                            };
                            _list.Add(item);
                        }
                    }
                }
            }
            return _list;
        }
    }
}
