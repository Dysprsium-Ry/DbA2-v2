using _3_13_25.D2.DbConn;
using _3_13_25.D2.View.D2.Forms;
using _3_13_25.D2.View.D2.UserControlCapsules;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlViews
{
    public partial class UserControlTutorRegistration : UserControl
    {

        public UserControlTutorRegistration()
        {
            InitializeComponent();
        }

        private void UserControlTutorRegistration_Load(object sender, EventArgs e)
        {
            DataGrid_Load();
        }

        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            UserControlAddTutor userControlAddTutor = new UserControlAddTutor();
            CapsuleBase capsuleBase = new CapsuleBase(userControlAddTutor);
            capsuleBase.ShowDialog();
            DataGrid_Load();
        }

        private void buttonTutorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to proceed? \nAction cannot be undone", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TutorClass.DeleteTutor();
                DataGrid_Load();
            }
        }

        private void dataGridViewTutorManagement_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > 0)
            {
                TemporalData.TutorId = Convert.ToInt64(dataGridViewTutorManagement.Rows[e.RowIndex].Cells["TutorId"].Value);
            }
        }

        private void DataGrid_Load()
        {
            dataGridViewTutorManagement.DataSource = null;
            DataLoadCast.DisplayTutors(dataGridViewTutorManagement);
            SetColumnHeaders(dataGridViewTutorManagement);
            dataGridViewTutorManagement.Refresh();
        }

        private void SetColumnHeaders(DataGridView dgv)
        {
            if (dgv.Columns.Contains("TutorId"))
            {
                dgv.Columns["TutorId"].HeaderText = "Id";
                dgv.Columns["TutorId"].Visible = false;
            }

            if (dgv.Columns.Contains("TutorName"))
            {
                dgv.Columns["TutorName"].HeaderText = "Name";
                //dgv.Columns["Status"].Visible = false;
            }

            if (dgv.Columns.Contains("Expertise"))
                dgv.Columns["Expertise"].HeaderText = "Expertise Subject";

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
