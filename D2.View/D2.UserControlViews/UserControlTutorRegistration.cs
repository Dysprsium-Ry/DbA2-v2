using _3_13_25.D2.DbConn;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
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
            DataLoadCast.TCDispTut(dataGridViewTutorManagement);
        }

        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Field cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            TemporalData.TutorName = textBoxTutorName.Text;
            TemporalData.TutorEmail = textBoxTutorEmail.Text;
            TemporalData.Subject = comboBoxExpertise.Text;
            TemporalData.HourlyRate = int.Parse(textBoxTutorHourlyRate.Text);
            TemporalData.InTime = dateTimePickerBeginTime.Value.TimeOfDay;
            TemporalData.OutTime = dateTimePickerEndTime.Value.TimeOfDay;

            if (TutorClass.CheckTutor())
            {
                MessageBox.Show("Tutor already exists", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TutorClass.ManageTutor();
            DataLoadCast.TCDispTut(dataGridViewTutorManagement);
        }

        private void buttonTutorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to proceed? \nAction cannot be undone", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TutorClass.DeleteTutor();
            }
        }
    }
}
