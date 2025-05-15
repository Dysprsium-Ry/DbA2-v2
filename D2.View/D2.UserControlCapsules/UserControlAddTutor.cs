using _3_13_25.D2.DbConn;
using _3_13_25.D2.QueryStorage;
using _3_13_25.D2.View.D2.Forms;
using BienvenidoOnlineTutorServices.D2.Classes;
using BOTS.Database_Connection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlCapsules
{
    public partial class UserControlAddTutor : UserControl
    {
        public UserControlAddTutor()
        {
            InitializeComponent();
        }

        private void UserControlAddTutor_Load(object sender, EventArgs e)
        {
            Subjects_Load();
            dateTimeValueSetter();
        }

        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text))
                {
                    MessageBox.Show("Empty Field/s", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            TemporalData.TutorName = textBoxTutorName.Text;
            TemporalData.TutorEmail = textBoxTutorEmail.Text;
            TemporalData.Subject = comboBoxExpertise.Text;
            TemporalData.HourlyRate = numericUpDownHourlyRate.Value;
            TemporalData.InTime = dateTimePickerBeginTime.Value.TimeOfDay;
            TemporalData.OutTime = dateTimePickerEndTime.Value.TimeOfDay;

            if (TutorClass.CheckTutor())
            {
                MessageBox.Show("Tutor already exists", "Action Invalid", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TutorClass.ManageTutor();
            this.Dispose();
        }

        private void buttonTutorDelete_Click(object sender, EventArgs e)
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
                }

                if (control is ComboBox comboBox)
                {
                    Subjects_Load();
                }

                if (control is DateTimePicker picker)
                {
                    picker.Value = DateTime.Today;
                }
            }
        }

        private void Subjects_Load()
        {
            comboBoxExpertise.DataSource = null;
            comboBoxExpertise.DataSource = DataLoadCast.fetchSubject();
            comboBoxExpertise.DisplayMember = "Subject";
            comboBoxExpertise.ValueMember = "Subject";
        }

        private void dateTimeValueSetter()
        {
            DateTime today = DateTime.Now.Date;
            int minimumHour = 8;
            int maximumHour = 17;
            DateTime minDateTime = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0);
            DateTime maxDateTime = new DateTime(today.Year, today.Month, today.Day, maximumHour, 0, 0);

            dateTimePickerBeginTime.Value = minDateTime;
            dateTimePickerEndTime.Value = maxDateTime;

            dateTimePickerBeginTime.ValueChanged += (s, e) =>
            {
                DateTime selectedTime = dateTimePickerBeginTime.Value;

                if (selectedTime < minDateTime)
                {
                    dateTimePickerBeginTime.Value = minDateTime;
                    return;
                }

                if (selectedTime >= maxDateTime)
                {
                    dateTimePickerBeginTime.Value = maxDateTime.AddHours(-1);
                }

                DateTime newEndTime = selectedTime.AddHours(1);
                dateTimePickerEndTime.Value = newEndTime <= maxDateTime ? newEndTime : maxDateTime;
            };

            dateTimePickerEndTime.ValueChanged += (s, e) =>
            {
                DateTime beginTime = dateTimePickerBeginTime.Value;
                DateTime endTime = dateTimePickerEndTime.Value;

                if (endTime <= beginTime)
                {
                    dateTimePickerEndTime.Value = beginTime.AddHours(1);
                }

                if (dateTimePickerEndTime.Value > maxDateTime)
                {
                    dateTimePickerEndTime.Value = maxDateTime;
                }
            };
        }

    }
}
