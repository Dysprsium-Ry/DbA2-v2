using _3_13_25.D2.Classes;
using Azure.Core;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.ViewModel.D2.RegistrationLogics
{
    public class StudentEnrollment
    {
        public static void Save()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Students(Username, Email, First_Name, Last_Name, Current_Level) VALUES(@User, @Email, @Fname, @Lname, @Level)", connection))
                {
                    command.Parameters.AddWithValue("@User", TemporalData.StudentUserN);
                    command.Parameters.AddWithValue("@Email", TemporalData.StudentEmail);
                    command.Parameters.AddWithValue("@Fname", TemporalData.StudentFirstName);
                    command.Parameters.AddWithValue("@Lname", TemporalData.StudentLastName);
                    command.Parameters.AddWithValue("@Level", TemporalData.StudentLevel);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void fetch()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("SELECT * FROM D2.Students WHERE StudId = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", TemporalData.StudentId);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            TemporalData.StudentId = reader.GetInt64(reader.GetOrdinal("Id"));
                            TemporalData.StudentUserN = reader["Username"].ToString();
                            TemporalData.StudentEmail = reader["Email"].ToString();
                            TemporalData.StudentFirstName = reader["First_Name"].ToString();
                            TemporalData.StudentLastName = reader["Last_Name"].ToString();
                            TemporalData.StudentLevel = reader["Current_Level"].ToString();
                        }
                    }
                }
            }
        }

        public static void Delete()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("DELETE FROM D2.Students WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@Id", TemporalData.StudentId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void Update()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("UPDATE D2.Students SET Username = @User, Email = @Email, First_Name = @Fname, Last_Name = @Lname, Current_Level = @Level WHERE Id = @Id", connection))
                {
                    command.Parameters.AddWithValue("@User", TemporalData.StudentUserN);
                    command.Parameters.AddWithValue("@Email", TemporalData.StudentEmail);
                    command.Parameters.AddWithValue("@Fname", TemporalData.StudentFirstName);
                    command.Parameters.AddWithValue("@Lname", TemporalData.StudentLastName);
                    command.Parameters.AddWithValue("@Level", TemporalData.StudentLevel);
                    command.Parameters.AddWithValue("@Id", TemporalData.StudentId);
                    command.ExecuteNonQuery();
                }
            }
        }

        public static bool IsUsernameTaken(string newUsername, long currentUserId)
        {
            List<string> existingUsernames = new();

            using (SqlConnection conn = DatabaseConnection.Establish())
            {
                string query = "SELECT Username FROM D2.Students WHERE Id != @Id";
                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Id", currentUserId);

                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            existingUsernames.Add(reader.GetString(0));
                        }
                    }
                }
            }

            return existingUsernames.Any(u => u.Equals(newUsername, StringComparison.OrdinalIgnoreCase));
        }
    }
}
