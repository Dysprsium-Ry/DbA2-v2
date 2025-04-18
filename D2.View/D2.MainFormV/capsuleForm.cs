using _3_13_25.D2.IdFetcherClasses;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.MainFormV
{
    public partial class capsuleForm : Form
    {
        BindingSource TutorDetailsBindingSource = new BindingSource();

        public capsuleForm()
        {
            InitializeComponent();

            DateTimePickerDateSelection.MinDate = DateTime.Today;

            ComboBoxSubjectSelection.DataSource = DbItemFetcher.Subjects();
            TutorDetailsBindingSource.DataSource = DbItemFetcher.TutorsDetailsFetcher(ComboBoxSubjectSelection.Text);

            ComboBoxTutorSelection.DataSource = TutorDetailsBindingSource;
            ComboBoxTutorSelection.DisplayMember = "TutorName";
            ComboBoxTutorSelection.ValueMember = "TutorName";
        }

        private void QueuedItemSave()
        {
            TemporalData.Subject = ComboBoxSubjectSelection.Text;
            TemporalData.TutorName = ComboBoxTutorSelection.Text;
            TemporalData.HourlyRate = Convert.ToDecimal(textBoxHourlyRate.Text);
            TemporalData.SessionScheduleDate = DateTimePickerDateSelection.Value.Date;

            var QueueItems = new QueuedItems
            {
                TransactionId = TemporalData.TransactionId,
                QueuedSubject = TemporalData.Subject,
                QueuedTutor = TemporalData.TutorName,
                QueuedHourlyRate = TemporalData.HourlyRate,
                QueuedStartTime = TemporalData.InTime,
                QueuedEndTime = TemporalData.OutTime,
                QueuedSessionSchedule = TemporalData.SessionScheduleDate,
            };

            if (!QueuedItemList.QueuedItemsList.Contains(QueueItems))
            {
                bool isExist = QueuedItemList.QueuedItemsList.Any(item => DateTimePickerDateSelection.Value.Date <= item.QueuedSessionSchedule);

                if (isExist)
                {
                    DateTimePickerDateSelection.Focus();
                    MessageBox.Show("This session is already booked. Please select another date.", "Session Already Booked", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                QueuedItemList.QueuedItemsList.Add(QueueItems);
                this.Close();
            }
        }

        private void ComboBoxSubjectSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSubjectSelection.SelectedIndex != -1)
            {
                TutorDetailsBindingSource.DataSource = DbItemFetcher.TutorsDetailsFetcher(ComboBoxSubjectSelection.Text);

                ComboBoxTutorSelection.DataSource = null;
                ComboBoxTutorSelection.DataSource = TutorDetailsBindingSource;

                ComboBoxTutorSelection.DisplayMember = "TutorName";
                ComboBoxTutorSelection.ValueMember = "TutorName";
            }
        }

        private void ComboBoxTutorSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            TutorDetails selectedTutor = ComboBoxTutorSelection.SelectedItem as TutorDetails;

            if (selectedTutor != null)
            {
                textBoxHourlyRate.Text = selectedTutor.HourlyRate.ToString();
                textBoxTimeSchedule.Text = $"{selectedTutor.InTime:hh\\:mm} - {selectedTutor.OutTime:hh\\:mm}";
                TemporalData.InTime = selectedTutor.InTime;
                TemporalData.OutTime = selectedTutor.OutTime;
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            QueuedItemSave();
        }
    }
}