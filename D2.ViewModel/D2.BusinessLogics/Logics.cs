using _3_13_25.D2.QueryStorage;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
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
        public static bool IsTutorAvailable(string tutor, TimeSpan inTime, TimeSpan outTime, DateTime date)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand(Queries.IsTutorAvailable, connection))
                {
                    command.Parameters.AddWithValue("@Tutor", tutor);
                    command.Parameters.AddWithValue("@inTime", inTime);
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
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) AS Count FROM D2.Students WHERE StudUsername = @User", connection))
                {
                    command.Parameters.AddWithValue("@User", TemporalData.StudentLUserN);

                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }
    }
}
