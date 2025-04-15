using BOTS.Database_Connection;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace BienvenidoOnlineTutorServices.D2.Classes
{
    public class EnrollmentClass
    {
        #region function
        public static void TemporalDataSelectedValue(DataGridView dataGridView)
        {
            if (dataGridView.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView.Rows[dataGridView.SelectedCells[0].RowIndex];
                if (selectedRow != null)
                {
                    TemporalData.TutorName = selectedRow.Cells["TutorName"].Value.ToString();
                    TemporalData.HourlyRate = Convert.ToInt32(selectedRow.Cells["HourlyRate"].Value ?? 0);
                    TemporalData.InTime = (TimeSpan)selectedRow.Cells["Intime"].Value;
                    TemporalData.OutTime = (TimeSpan)selectedRow.Cells["OutTime"].Value;
                }
            }
        }

        public static void SelectRowDTGVStudentList(DataGridView dt)
        {
            DataGridViewRow selectedRow = dt.Rows[dt.SelectedCells[0].RowIndex];
            if (selectedRow != null)
            {
                TemporalData.StudentName = selectedRow.Cells["StudentName"].Value.ToString();
                TemporalData.StudentEmail = selectedRow.Cells["StudentEmail"].Value.ToString();
            }
        }

        public static void EnrollStudent()
        {
            using (SqlConnection connection = DatabaseConnection.Establish())
            {
                using (SqlCommand command = new SqlCommand("INSERT INTO D2.Students (StudUsername, StudentEmail) SELECT @name, @email WHERE NOT EXISTS ( SELECT 1 FROM D2.Students WHERE StudUsername = @name AND StudentEmail = @email );", connection))
                {
                    command.Parameters.AddWithValue("@name", TemporalData.StudentName);
                    command.Parameters.AddWithValue("@email", TemporalData.StudentEmail);
                    command.ExecuteNonQuery();
                }
            }
        }
        #endregion
    }
}
