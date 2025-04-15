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
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Tutor (TutorName, Expertise, HourlyRate, Email, InTime, OutTime) VALUES(@name, @expertise, @hourlyRate, @email, @intime, @outtime)", connection))
                {
                    command.Parameters.AddWithValue("@name", TemporalData.TutorName);
                    command.Parameters.AddWithValue("@email", TemporalData.TutorEmail);
                    command.Parameters.AddWithValue("@expertise", TemporalData.Subject);
                    command.Parameters.AddWithValue("@hourlyRate", TemporalData.HourlyRate);
                    command.Parameters.AddWithValue("@intime", TemporalData.InTime);
                    command.Parameters.AddWithValue("@outtime", TemporalData.OutTime);
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

        #endregion
    }
}
