using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using Microsoft.ReportingServices.RdlExpressions.ExpressionHostObjectModel;
using System;
using System.CodeDom;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.MainFormV
{
    public partial class CapsuleForm : Form
    {
        BindingSource TutorDetailsBindingSource = new BindingSource();

        public CapsuleForm()
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
            if (TransactionLogics.IsTutorAvailable(ComboBoxTutorSelection.Text, TemporalData.InTime, TemporalData.OutTime, DateTimePickerDateSelection.Value.Date))
            {
                MessageBox.Show("Date occupied", "Date Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TemporalData.Subject = ComboBoxSubjectSelection.Text;
            TemporalData.TutorName = ComboBoxTutorSelection.Text;
            TemporalData.HourlyRate = Convert.ToDecimal(textBoxHourlyRate.Text);
            TemporalData.SessionScheduleDate = DateTimePickerDateSelection.Value.Date;

            TransactionItemList.DictionaryList(TemporalData.TransactionId);

            var newItem = new TransactionItems
            {
                TransactionId = TemporalData.TransactionId,
                Subject = TemporalData.Subject,
                Tutor = TemporalData.TutorName,
                HourlyRate = TemporalData.HourlyRate,
                SessionScheduleDate = TemporalData.SessionScheduleDate,
                StartSchedule = TemporalData.InTime,
                EndSchedule = TemporalData.OutTime
            };

            bool isOverlapping = TransactionItemList.TransactionQueues.SelectMany(kvp => kvp.Value).Any(item => item.Tutor == newItem.Tutor && item.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < item.EndSchedule && newItem.EndSchedule > item.StartSchedule);
            bool isAlreadyExist = TransactionItemList.BindingList.Any(item => item.Tutor == newItem.Tutor && item.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < item.EndSchedule && newItem.EndSchedule > item.StartSchedule);


            bool isStudentAvailable = TransactionItemList.BindingList.Any(id => id.TransactionId == newItem.TransactionId && id.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < id.EndSchedule && newItem.EndSchedule > id.StartSchedule);
            bool isStudentOverlapping = TransactionItemList.TransactionQueues.SelectMany(sv => sv.Value).Any(item => item.TransactionId == newItem.TransactionId && item.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < item.EndSchedule && newItem.EndSchedule > item.StartSchedule);

            if (!TransactionItemList.BindingList.Contains(newItem))
            {
                if (isAlreadyExist || isOverlapping || isStudentAvailable || isStudentOverlapping)
                {
                    DateTimePickerDateSelection.Focus();
                    if (MessageBox.Show("Date already occupied.", "Schedule Unavailable", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        return;
                    }
                    else { this.Close(); return; }
                }

                TransactionItemList.BindingList.Add(newItem);
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else { DialogResult = DialogResult.No; }    
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
            Cancel();
        }

        private void Cancel()
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            QueuedItemSave();
        }
    }
}