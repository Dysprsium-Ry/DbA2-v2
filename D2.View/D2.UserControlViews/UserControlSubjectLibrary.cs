using _3_13_25.D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlSubjectLibrary : UserControl
    {
        public UserControlSubjectLibrary()
        {
            InitializeComponent();
            buttonAddToolInventory.Click += buttonAddISubject_Click;
            SubjectClass.ShowSubjects(dataGridViewSubjects);
        }

        private void UserControlSubjectLibrary_Load(object sender, EventArgs e)
        {

        }

        private void buttonAddISubject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectLib.Text))
            {
                TemporalData.Subject = textBoxSubjectLib.Text;
                SubjectClass.AddSub();
                SubjectClass.ShowSubjects(dataGridViewSubjects);
            }
            else
            {
                MessageBox.Show("Textbox Value is invalid. Action aborted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDeleteToolInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectLib.Text))
            {
                TemporalData.Subject = textBoxSubjectLib.Text;
                SubjectClass.DeleteSub();
                SubjectClass.ShowSubjects(dataGridViewSubjects);
            }
            else
            {
                MessageBox.Show("Textbox Value is invalid. Action aborted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void dataGridViewSubjects_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewSubjects.Rows.Count)
            {
                var Expertise = dataGridViewSubjects.Rows[e.RowIndex].Cells[0].Value;

                if (Expertise != null)
                {
                    textBoxSubjectLib.Text = Convert.ToString(Expertise);
                }
                else
                {
                    MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selected row index is out of range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
