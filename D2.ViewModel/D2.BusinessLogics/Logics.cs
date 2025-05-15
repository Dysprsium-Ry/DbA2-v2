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
        public static bool IsTutorAvailable(string tutor, TimeSpan outTime, DateTime date)
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

        public static void UpdateSubject(string oldSubject, string newSubject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.Subject SET Subject = @newSubject WHERE Subject = @oldSubject", connection))
                {
                    command.Parameters.AddWithValue("@oldSubject", oldSubject);
                    command.Parameters.AddWithValue("@newSubject", newSubject);
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
