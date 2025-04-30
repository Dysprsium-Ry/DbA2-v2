using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.IdFetcherClasses
{
    class IdFetcher
    {
        public static long StudentId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT StudId FROM D2.Students WHERE StudUsername = @name", connection))
                {
                    command.Parameters.AddWithValue("@name", TemporalData.StudentLUserN);
                    object result = command.ExecuteScalar();
                    return (result != null) ? Convert.ToInt64(result) : 0;
                }
            }
        }

        public static long TutorId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT TutorId FROM D2.Tutor WHERE TutorName = @tutorname", connection))
                {
                    command.Parameters.AddWithValue("@tutorname", TemporalData.TutorName);
                    object result = command.ExecuteScalar();
                    return (result != null) ? Convert.ToInt64(result) : 0;
                }
            }
        }
        public static long SubjectId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT SubjectId FROM D2.Subject WHERE Subject = @subject", connection))
                {
                    command.Parameters.AddWithValue("@subject", TemporalData.Subject);
                    object result = command.ExecuteScalar();
                    return (result != null) ? Convert.ToInt64(result) : 0;
                }
            }
        }
    }
}
