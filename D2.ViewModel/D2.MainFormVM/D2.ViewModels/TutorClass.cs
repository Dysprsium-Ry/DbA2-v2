using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class TutorClass
    {
        #region function

        public static void ManageTutor()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Tutor (TutorName, Email) VALUES(@name, @email)", connection))
                {
                    command.Parameters.AddWithValue("@name", TemporalData.TutorName);
                    command.Parameters.AddWithValue("@email", TemporalData.TutorEmail);
                    //command.Parameters.AddWithValue("@expertise", TemporalData.Subject);
                    //command.Parameters.AddWithValue("@hourlyRate", TemporalData.HourlyRate);
                    //command.Parameters.AddWithValue("@intime", TemporalData.InTime);
                    //command.Parameters.AddWithValue("@outtime", TemporalData.OutTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteTutor()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM D2.Tutor WHERE TutorId = @tutorId", connection))
                {
                    command.Parameters.AddWithValue("@tutorId", TemporalData.TutorId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool CheckTutor()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM D2.Tutor WHERE TutorName = @tutorname", connection))
                {
                    command.Parameters.AddWithValue("@tutorname", TemporalData.TutorName);
                    return Convert.ToInt32(command.ExecuteScalar()) > 0;
                }
            }
        }

        public static long FetchTutorId()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT Max(TutorId) FROM D2.Tutor", connection))
                {
                    return Convert.ToInt64(command.ExecuteScalar());
                }
            }
        }

        public static bool IsExpertiseExist(long tutor, long subject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM D2.TutorExpertise WHERE TutorId = @tutorId AND SubjectId = @subjectId", connection))
                {
                    command.Parameters.AddWithValue("@tutorId", tutor);
                    command.Parameters.AddWithValue("@subjectId", subject);
                    if (Convert.ToInt32(command.ExecuteScalar()) > 0) return true;
                    else return false;
                }
            }
        }

        public static void registerExpertise(long tutor, long subject, decimal hourlyRate, TimeSpan inTime, TimeSpan outTime)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.TutorExpertise (TutorId, SubjectId, HourlyRate, InTime, OutTime) VALUES(@tutor, @subject, @hourlyRate, @inTime, @outTime)", connection))
                {
                    command.Parameters.AddWithValue("@tutor", tutor);
                    command.Parameters.AddWithValue("@subject", subject);
                    command.Parameters.AddWithValue("@hourlyRate", hourlyRate);
                    command.Parameters.AddWithValue("@inTime", inTime);
                    command.Parameters.AddWithValue("@outTime", outTime);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteExpertise(long tutor, long subject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM D2.TutorExpertise WHERE TutorId = @tutorId AND SubjectId = @subject", connection))
                {
                    command.Parameters.AddWithValue("@tutorId", tutor);
                    command.Parameters.AddWithValue("@subject", subject);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateExpertise(long tutor, long subject)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.TutorExpertise SET SubjectId = @subject, InTime = @inTime, OutTime = @outTime WHERE TutorId = @tutorId AND SubjectId = @subject", connection))
                {
                    command.Parameters.AddWithValue("@subject", subject);
                    command.Parameters.AddWithValue("@inTime", TemporalData.InTime);
                    command.Parameters.AddWithValue("@outTime", TemporalData.OutTime);
                    command.Parameters.AddWithValue("@tutorId", tutor);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateDetails(long tutor, string name, string email)
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.Tutor SET TutorName = @name, Email = @email WHERE TutorId = @tutorId", connection))
                {
                    command.Parameters.AddWithValue("@name", name);
                    command.Parameters.AddWithValue("@email", email);
                    command.Parameters.AddWithValue("@tutorId", tutor);
                    command.ExecuteNonQuery();
                }
            }
        }

        #endregion

        public static List<long> PendingDelete { get; set; } = new List<long>();
    }
}
