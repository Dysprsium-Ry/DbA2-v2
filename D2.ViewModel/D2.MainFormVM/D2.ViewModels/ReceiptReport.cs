using BOTS.Database_Connection;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.Classes
{
    public class ReceiptReport
    {
        public static long _Id;

        public static void ReceiptSetup(ReportViewer receipt)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("D2.InvoiceDetailsFetcher", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransactionId", _Id);

                    DataTable dataTable = new DataTable();
                    SqlDataAdapter adapter = new SqlDataAdapter(command);
                    adapter.Fill(dataTable);

                    receipt.LocalReport.DataSources.Clear();

                    ReportDataSource reportDataSource = new ReportDataSource("DbDtSet", dataTable);

                    ReportParameter transactionId = new ReportParameter("TransactionId", _Id.ToString());

                    receipt.LocalReport.ReportPath = "ReceiptReport.rdlc";
                    receipt.LocalReport.DataSources.Add(reportDataSource);
                    receipt.LocalReport.SetParameters(transactionId);

                    receipt.RefreshReport();
                    receipt.Refresh();
                }
            }
        }

        public static void TransacItemFetcher()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("D2.TransacItemFetcher", connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@TransacId", BillingObj.TransactionId);
                    command.Parameters.AddWithValue("@Student", BillingObj.Student);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            var itemsList = new ReceiptObject()
                            {
                                TransactionId = Convert.ToInt64(reader["Transaction Id"]),
                                Student = reader["Student"].ToString(),
                                Subject = reader["Subject"].ToString(),
                                Tutor = reader["Tutor"].ToString(),
                                TotalFee = Convert.ToDecimal(reader["Total Fee"]),
                                TotalAmountFee = Convert.ToDecimal(reader["Overall Total Fee"]),
                                PaidAmount = Convert.ToDecimal(reader["Paid Amount"]),
                                ScheduledDate = Convert.ToDateTime(reader["Scheduled Date"])
                            };
                        }
                    }
                }
            }
        }
    }
}
