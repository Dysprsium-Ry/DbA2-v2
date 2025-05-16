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
                using (SqlCommand command = new SqlCommand("SELECT TutorId, TutorName, Expertise, HourlyRate, InTime, OutTime FROM D2.Tutor", connection))
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

        #endregion

        #region SubjectClass

        public static DataTable fetchSubject()
        {
            DataTable table = new DataTable();

            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Subject FROM D2.Subject", connection))
                {
                    using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }

        public static DataTable fetchSubjectTutor(string subject)
        {
            DataTable table = new DataTable();
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorName, Email, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE Expertise = @subject", connection))
                {
                    command.Parameters.AddWithValue("@subject", subject);
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
                using (SqlCommand command = new SqlCommand("SELECT D2.TransactionBilling.Transaction_Id, Total_Value, Payment_Amount, Bill_Status FROM D2.TransactionBilling INNER JOIN D2.Transactions ON D2.TransactionBilling.Transaction_Id = D2.Transactions.Transaction_Id WHERE Bill_Status != 'Paid' AND Status = 'Enrolled' ORDER BY D2.TransactionBilling.Transaction_Id", connection))
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
