using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;
using System.Windows.Forms;
using _3_13_25.D2.QueryStorage;
using Microsoft.ReportingServices.Diagnostics.Internal;
using System.ComponentModel;
using _3_13_25.D2.Model;

namespace _3_13_25.D2.DbConn
{
    public class DataLoadCast
    {
        #region StudentEnrollmentFetcher

        public static DataTable StudentsList()
        {
            DataTable list = new DataTable();
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.Students", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(list);
                    }
                }
            }
            return list;
        }

        #endregion

        #region TutorClass

        public static void DisplayTutors(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.Tutor", connection))
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

        public static BindingList<WeeklyScheduleSource> WeekSchedule(long tutor)
        {
            BindingList<WeeklyScheduleSource> list = new BindingList<WeeklyScheduleSource>();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT ti.Transaction_Id, ti.Subject, t.TutorName, ti.Per_Hour_Rate, ti.Time_Period_Begin, ti.Time_Period_End, ti.Date_Schedule, ti.Transaction_State FROM D2.TransactionInformation AS ti JOIN D2.Tutor AS t ON ti.Tutor = t.TutorId WHERE ti.Tutor = 3", connection))
                {
                    command.Parameters.AddWithValue("@tutor", tutor);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            WeeklyScheduleSource item = new WeeklyScheduleSource
                            {
                                TransactionId = reader.GetInt64(reader.GetOrdinal("Transaction_Id")),
                                //SubjectId = reader.GetInt64(reader.GetOrdinal("Subject")),
                                Subject = reader.GetString(reader.GetOrdinal("Subject")),
                                //TutorId = reader.GetInt64(reader.GetOrdinal("TutorId")),
                                TutorName = reader.GetString(reader.GetOrdinal("TutorName")),
                                HourlyRate = reader.GetDecimal(reader.GetOrdinal("Per_Hour_Rate")),
                                SessionScheduleDate = reader.GetDateTime(reader.GetOrdinal("Date_Schedule")),
                                StartSchedule = reader.GetTimeSpan(reader.GetOrdinal("Time_Period_Begin")),
                                EndSchedule = reader.GetTimeSpan(reader.GetOrdinal("Time_Period_End")),
                                Status = reader.GetString(reader.GetOrdinal("Transaction_State"))
                            };

                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        public static BindingList<ExpertiseList> TutorExpertise(long tutor)
        {
            BindingList<ExpertiseList> list = new BindingList<ExpertiseList>();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT te.SubjectId, s.Subject, te.HourlyRate, te.InTime, te.OutTime FROM D2.TutorExpertise AS te JOIN D2.Subject AS s ON te.SubjectId = s.SubjectId WHERE te.TutorId = @id", connection))
                {
                    command.Parameters.AddWithValue("@id", tutor);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var item = new ExpertiseList
                            {
                                SubjectId = reader.GetInt64(reader.GetOrdinal("SubjectId")),
                                Subject = reader.GetString(reader.GetOrdinal("Subject")),
                                HourlyRate = reader.GetDecimal(reader.GetOrdinal("HourlyRate")),
                                InTime = reader.GetTimeSpan(reader.GetOrdinal("InTime")),
                                OutTime = reader.GetTimeSpan(reader.GetOrdinal("OutTime"))
                            };
                            list.Add(item);
                        }
                    }
                }
            }
            return list;
        }

        #endregion

        #region SubjectClass

        public static DataTable fetchSubject()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.Subject", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        public static DataTable fetchSubjectTutor(long subject)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT t.TutorId, t.TutorName, t.Email, te.InTime, te.OutTime FROM D2.Tutor as t LEFT JOIN D2.TutorExpertise as te ON t.TutorId = te.TutorId WHERE te.SubjectId = @Id;", connection))
                {
                    command.Parameters.AddWithValue("@Id", subject);
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }

        #endregion

        #region TransactionList

        public static void TransactionList(DataGridView dataGridView)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.TransacListDisp, connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        DataTable dtTable = new DataTable();
                        adapter.Fill(dtTable);
                        dataGridView.AutoGenerateColumns = true;
                        dataGridView.DataSource = dtTable;
                    }
                }
            }
        }

        public static DataTable SearchTransactions(string searchTerm)
        {
            DataTable dt = new DataTable();
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.SearchTransactionList, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@SearchTerm", searchTerm);

                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(dt);
                    }
                }
            }

            return dt;
        }

        public static AutoCompleteStringCollection studentListFetcher()
        {
            List<string> data = new List<string>();
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.studentList, connection))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            data.Add(reader[0].ToString());
                        }
                    }
                }
            }

            foreach (string item in data)
            {
                collection.Add(item);
            }

            return collection;
        }
        #endregion

        #region Billing

        public static DataTable FetchBillingRecord()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT D2.TransactionBilling.Transaction_Id, Total_Value, Payment_Amount, Bill_Status FROM D2.TransactionBilling INNER JOIN D2.Transactions ON D2.TransactionBilling.Transaction_Id = D2.Transactions.Transaction_Id WHERE Bill_Status != 'Paid' AND Status != 'Draft' ORDER BY D2.TransactionBilling.Transaction_Id", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }
            return table;
        }

        #endregion
    }
}
