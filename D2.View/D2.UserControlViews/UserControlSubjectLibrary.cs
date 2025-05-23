using _3_13_25.D2.DbConn;
using _3_13_25.D2.View.D2.Forms;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using System;
using System.Windows.Forms;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlSubjectLibrary : UserControl, IRefreshableControl
    {
        CapsuleBase openBase;
        UserControlSubjectLibControls openControl;

        public void RefreshControl()
        {
            Load_Data();
            Load_Data_Tutor(0);
        }

        public UserControlSubjectLibrary()
        {
            InitializeComponent();
        }

        private void UserControlSubjectLibrary_Load(object sender, EventArgs e)
        {
            RefreshControl();
        }

        private void Load_Data()
        {
            dataGridViewSubjects.DataSource = null;
            dataGridViewSubjects.DataSource = DataLoadCast.fetchSubject();
            dataGridViewSubjects.AutoGenerateColumns = true;
            SetColumnHeaders(dataGridViewSubjects);
            dataGridViewSubjects.Refresh();
        }

        private void Load_Data_Tutor(long subject)
        {
            dataGridViewTutors.DataSource = null;
            dataGridViewTutors.DataSource = DataLoadCast.fetchSubjectTutor(subject);
            dataGridViewTutors.AutoGenerateColumns = true;
            SetColumnHeaders(dataGridViewTutors);
            dataGridViewTutors.Refresh();
        }

        private void dataGridViewSubjects_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                long subject = Convert.ToInt64(dataGridViewSubjects.Rows[e.RowIndex].Cells["SubjectId"].Value);
                Load_Data_Tutor(subject);
            }
        }

        private void buttonAddToolInventory_Click(object sender, EventArgs e)
        {
            openControl = new UserControlSubjectLibControls(UserControlSubjectLibControls.RegistrationType.Save, long.MinValue);
            openBase = new CapsuleBase(openControl);
            openBase.ShowDialog();
            RefreshControl();
        }

        private void buttonDeleteToolInventory_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.SelectedRows[0].Index >= 0)
            {
                SubjectLogics.DeleteSubject(dataGridViewSubjects.SelectedRows[0].Cells["Subject"].Value.ToString());
                RefreshControl();
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (dataGridViewSubjects.Rows.Count > 0)
            {
                if (dataGridViewSubjects.SelectedRows[0].Index >= 0)
                {
                    if (!string.IsNullOrEmpty(dataGridViewSubjects.SelectedRows[0].Cells["Subject"].Value.ToString()))
                    {
                        openControl = new UserControlSubjectLibControls(UserControlSubjectLibControls.RegistrationType.Update, Convert.ToInt64(dataGridViewSubjects.SelectedRows[0].Cells["SubjectId"].Value));
                        openBase = new CapsuleBase(openControl);
                        openBase.ShowDialog();

                        RefreshControl();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a subject to update.");
                }
            }
        }

        private void SetColumnHeaders(DataGridView dgv)
        {
            if (dgv.Columns.Contains("TutorId"))
            {
                dgv.Columns["TutorId"].HeaderText = "Id";
                dgv.Columns["TutorId"].Visible = false;
            }

            if (dgv.Columns.Contains("SubjectId"))
            {
                dgv.Columns["SubjectId"].HeaderText = "Subject Id";
                dgv.Columns["SubjectId"].Visible = false;
            }

            if (dgv.Columns.Contains("TutorName"))
            {
                dgv.Columns["TutorName"].HeaderText = "Name";
                //dgv.Columns["Status"].Visible = false;
            }

            if (dgv.Columns.Contains("Email"))
                dgv.Columns["Email"].HeaderText = "Email";

            if (dgv.Columns.Contains("HourlyRate"))
                dgv.Columns["HourlyRate"].HeaderText = "Hourly Rate";

            if (dgv.Columns.Contains("InTime"))
            {
                dgv.Columns["InTime"].HeaderText = "In Time";
                //dgv.Columns["InTime"].DefaultCellStyle.Format = @"hh:mm tt";
            }

            if (dgv.Columns.Contains("OutTime"))
            {
                dgv.Columns["OutTime"].HeaderText = "Out Time";
                //dgv.Columns["OutTime"].DefaultCellStyle.Format = @"hh:mm tt";
            }
        }
    }
}
