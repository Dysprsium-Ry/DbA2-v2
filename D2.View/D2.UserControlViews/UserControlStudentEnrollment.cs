using _3_13_25.D2.DbConn;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using _3_13_25.D2.ViewModel.D2.RegistrationLogics;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlStudentEnrollment : UserControl
    {
        public UserControlStudentEnrollment()
        {
            InitializeComponent();
        }

        private void UserControlStudentEnrollment_Load(object sender, EventArgs e)
        {
            DataGrid_Load();
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            FieldValidity();

            TemporalData.StudentUserN = textBoxUsername.Text;
            TemporalData.StudentFirstName = textBoxFname.Text;
            TemporalData.StudentLastName = textBoxLname.Text;
            TemporalData.StudentEmail = textBoxEmail.Text;
            TemporalData.StudentLevel = textBoxLevel.Text;

            if (!StudEnrollmentLogics.IsStudentExist())
            {
                StudentEnrollment.Save();
                TemporalData.Clear();
                DataGrid_Load();
                clear();
            }
            else { MessageBox.Show("Username already used please select another.", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation); }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void clear()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                    TemporalData.Clear();
                }
            }
            buttonEnroll.Enabled = true;
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            FieldValidity();

            if (StudentEnrollment.IsUsernameTaken(textBoxUsername.Text, TemporalData.StudentId)) { MessageBox.Show("Username is already in use.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            TemporalData.StudentUserN = textBoxUsername.Text;
            TemporalData.StudentFirstName = textBoxFname.Text;
            TemporalData.StudentLastName = textBoxLname.Text;
            TemporalData.StudentEmail = textBoxEmail.Text;
            TemporalData.StudentLevel = textBoxLevel.Text;

            StudentEnrollment.Update();
            DataGrid_Load();
            buttonEnroll.Enabled = true;
            clear();
        }

        private void FieldValidity()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    if (string.IsNullOrWhiteSpace(textbox.Text))
                    {
                        MessageBox.Show("Field cannot be Empty", "Field Empty", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }
                }
            }
        }

        private void DataGrid_Load()
        {
            dataGridViewStudentList.DataSource = null;
            dataGridViewStudentList.DataSource = DataLoadCast.StudentsList();
            SetColumnHeaders(dataGridViewStudentList);
        }

        private void SetColumnHeaders(DataGridView dgv)
        {
            if (dgv.Columns.Contains("Id"))
            {
                dgv.Columns["Id"].HeaderText = "Student Id";
                dgv.Columns["Id"].Visible = false;
            }

            if (dgv.Columns.Contains("Username"))
            {
                dgv.Columns["Username"].HeaderText = "Username";
                //dgv.Columns["Status"].Visible = false;
            }

            if (dgv.Columns.Contains("Email"))
                dgv.Columns["Email"].HeaderText = "Email";

            if (dgv.Columns.Contains("First_Name"))
                dgv.Columns["First_Name"].HeaderText = "First Name";

            if (dgv.Columns.Contains("Last_Name"))
                dgv.Columns["Last_Name"].HeaderText = "Last Name";

            if (dgv.Columns.Contains("Current_Level"))
                dgv.Columns["Current_Level"].HeaderText = "Education Level";
        }

        private void dataGridViewStudentList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var idValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["Id"].Value;
            if (idValue != null)
            {
                TemporalData.StudentId = Convert.ToInt64(idValue);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewStudentList.SelectedRows.Count < 0)
                return;

            if (MessageBox.Show("This action cannot be undone, \n\nDo you wish to proceed?", "Warning!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                StudentEnrollment.Delete();
                DataGrid_Load();
                clear();
            }
            buttonEnroll.Enabled = true;
        }

        private void dataGridViewStudentList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            buttonEnroll.Enabled = false;

            var idValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["Id"].Value;
            var usernameValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["Username"].Value;
            var emailValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["Email"].Value;
            var fnameValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["First_Name"].Value;
            var lnameValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["Last_Name"].Value;
            var levelValue = dataGridViewStudentList.Rows[e.RowIndex].Cells["Current_Level"].Value;

            if (idValue != null)
            {
                TemporalData.StudentId = Convert.ToInt64(idValue);
                textBoxUsername.Text = usernameValue?.ToString();
                textBoxEmail.Text = emailValue?.ToString();
                textBoxFname.Text = fnameValue?.ToString();
                textBoxLname.Text = lnameValue?.ToString();
                textBoxLevel.Text = levelValue?.ToString();
            }
        }

        private void textBox_Leave(object sender, EventArgs e)
        {
            if (sender is TextBox textbox && textbox != textBoxEmail)
            {
                textbox.Text = textbox.Text.Trim().ToUpper();
            }
        }
    }
}
