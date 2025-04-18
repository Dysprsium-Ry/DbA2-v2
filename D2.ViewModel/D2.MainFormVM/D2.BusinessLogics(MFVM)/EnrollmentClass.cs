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
        #endregion
    }
}
