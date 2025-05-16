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
            Load_Data_Tutor(string.Empty);
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
            dataGridViewSubjects.Refresh();
        }

        private void Load_Data_Tutor(string subject)
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
                string subject = dataGridViewSubjects.Rows[e.RowIndex].Cells["Subject"].Value.ToString();
                Load_Data_Tutor(subject);
            }
        }

        private void buttonAddToolInventory_Click(object sender, EventArgs e)
        {
            openControl = new UserControlSubjectLibControls(UserControlSubjectLibControls.RegistrationType.Save, string.Empty);
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
            if (dataGridViewSubjects.SelectedRows[0].Index >= 0)
            {
                if (!string.IsNullOrEmpty(dataGridViewSubjects.SelectedRows[0].Cells["Subject"].Value.ToString()))
                {
                    openControl = new UserControlSubjectLibControls(UserControlSubjectLibControls.RegistrationType.Update, dataGridViewSubjects.SelectedRows[0].Cells["Subject"].Value.ToString());
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

        private void SetColumnHeaders(DataGridView dgv)
        {
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
