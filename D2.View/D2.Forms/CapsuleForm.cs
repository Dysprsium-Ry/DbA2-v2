using _3_13_25.D2.Classes;
using _3_13_25.D2.Model;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using _3_13_25.D2.ViewModel.D2.RegistrationLogics;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.MainFormV
{
    public partial class CapsuleForm : Form
    {
        BindingSource TutorDetailsBindingSource = new BindingSource();

        public enum FormMode { New, Update }
        private readonly FormMode _mode;
        private readonly TransactionItems _Items;
        private readonly BindingList<TransactionItems> _itemList = new BindingList<TransactionItems>();
        private readonly int _index = -1;

        public CapsuleForm(BindingList<TransactionItems> binding, FormMode mode, TransactionItems editItem = null, int index = -1)
        {
            InitializeComponent();

            _mode = mode;
            _itemList = binding;
            _Items = editItem ?? new TransactionItems();
            _index = index;

            this.Text = _mode == FormMode.New ? "New Transaction" : "Edit Transaction";

            DateTimePickerDateSelection.MinDate = DateTime.Today;
            ComboBoxSubjectSelection.DisplayMember = "Subject";
            ComboBoxSubjectSelection.ValueMember = "SubjectId";
            ComboBoxSubjectSelection.DataSource = DbItemFetcher.Subjects();
            TutorDetailsBindingSource.DataSource = DbItemFetcher.TutorsDetailsFetcher(Convert.ToInt64(ComboBoxSubjectSelection.SelectedValue));

            ComboBoxTutorSelection.DisplayMember = "TutorName";
            ComboBoxTutorSelection.ValueMember = "TutorId";
            ComboBoxTutorSelection.DataSource = TutorDetailsBindingSource;
        }

        private void CapsuleForm_Load(object sender, EventArgs e)
        {
            DataLoad(_Items);

            if (_mode == FormMode.New)
            {
                ComboBoxSubjectSelection.Enabled = true;
                ComboBoxTutorSelection.Enabled = true;
            }
            else if (_mode == FormMode.Update)
            {
                ComboBoxSubjectSelection.Enabled = false;
                ComboBoxTutorSelection.Enabled = false;
            }
            else { }
        }

        private void Save()
        {
            if (TransactionLogics.IsTutorAvailable(Convert.ToInt64(ComboBoxTutorSelection.SelectedValue), TemporalData.OutTime, DateTimePickerDateSelection.Value.Date))
            {
                MessageBox.Show("Date occupied", "Date Unavailable", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            TemporalData.Subject = ComboBoxSubjectSelection.Text;
            TemporalData.TutorId = Convert.ToInt64(ComboBoxTutorSelection.SelectedValue);
            TemporalData.TutorName = ComboBoxTutorSelection.Text;
            TemporalData.HourlyRate = Convert.ToDecimal(textBoxHourlyRate.Text);
            TemporalData.SessionScheduleDate = DateTimePickerDateSelection.Value.Date;

            TransactionItemList.DictionaryList(TemporalData.TransactionId);

            var newItem = new TransactionItems
            {
                TransactionId = TemporalData.TransactionId,
                Subject = TemporalData.Subject,
                Tutor = TemporalData.TutorId,
                TutorName = TemporalData.TutorName,
                HourlyRate = TemporalData.HourlyRate,
                SessionScheduleDate = TemporalData.SessionScheduleDate,
                StartSchedule = TemporalData.InTime,
                EndSchedule = TemporalData.OutTime
            };

            bool isConflict = _itemList.Any(item =>
            item.Tutor == newItem.Tutor &&
                (item.SessionScheduleDate.Date + item.StartSchedule) < (newItem.SessionScheduleDate.Date + newItem.EndSchedule) &&
                (item.SessionScheduleDate.Date + item.EndSchedule) > (newItem.SessionScheduleDate.Date + newItem.StartSchedule));

            bool ConflictSchedule = _itemList.Any(item => 
                (item.SessionScheduleDate.Date + item.StartSchedule) < (newItem.SessionScheduleDate.Date + newItem.EndSchedule) &&
                (item.SessionScheduleDate.Date + item.EndSchedule) > (newItem.SessionScheduleDate.Date + newItem.StartSchedule));

            if (!_itemList.Contains(newItem))
            {
                while (isConflict || ConflictSchedule)
                {
                    DateTimePickerDateSelection.Focus();
                    if (MessageBox.Show("Date already occupied.", "Schedule Unavailable", MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Retry)
                    {
                        return;
                    }
                    else { DialogResult = DialogResult.Cancel; this.Close(); return; }
                }

                if (_mode == FormMode.New)
                {
                    if (!BookingLogics.IsTutorAvailable(newItem.Tutor, newItem.SessionScheduleDate.Date, newItem.StartSchedule))
                    {
                        _itemList.Add(newItem);
                    }
                    else
                    {
                        MessageBox.Show($"This Tutor for Subject: {newItem.Subject} \n\nIs currently unavailable for booking for the specified date.\n\nYou can modify the date or change the details.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                }
                else if (_mode == FormMode.Update)
                {
                    BookingLogics.DropOnUpdate(_Items.TransactionId, _Items.Subject, _Items.Tutor, _Items.SessionScheduleDate);

                    if (OpsAndCalcs.CombineDateAndTime(newItem.SessionScheduleDate, newItem.StartSchedule) > DateTime.Now.AddHours(1) && DateTime.Now < OpsAndCalcs.CombineDateAndTime(newItem.SessionScheduleDate, newItem.EndSchedule))
                    {
                        _Items.Subject = newItem.Subject;
                        _Items.Tutor = newItem.Tutor;
                        _Items.TutorName = newItem.TutorName;
                        _Items.HourlyRate = newItem.HourlyRate;
                        _Items.StartSchedule = newItem.StartSchedule;
                        _Items.EndSchedule = newItem.EndSchedule;
                        _Items.SessionScheduleDate = newItem.SessionScheduleDate;

                        if (!BookingLogics.IsTutorAvailable(_Items.Tutor, _Items.SessionScheduleDate, _Items.StartSchedule))
                        {
                            _itemList[_index] = _Items;
                        }
                        else
                        {
                            MessageBox.Show($"This Tutor for this Subject\nIs currently unavailable for booking for the specified date.\n\nYou can modify the date or change the details.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    else { MessageBox.Show("Date invalid for transaction", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
                }
                DialogResult = DialogResult.Yes;
                this.Close();
            }
            else { DialogResult = DialogResult.No; }

        }

        private void ComboBoxSubjectSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxSubjectSelection.SelectedIndex != -1)
            {
                TutorDetailsBindingSource.DataSource = DbItemFetcher.TutorsDetailsFetcher((long)ComboBoxSubjectSelection.SelectedValue);

                ComboBoxTutorSelection.DataSource = null;
                ComboBoxTutorSelection.DataSource = TutorDetailsBindingSource;

                ComboBoxTutorSelection.DisplayMember = "TutorName";
                ComboBoxTutorSelection.ValueMember = "TutorId";
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
            Save();
        }

        private void DataLoad(TransactionItems _item)
        {
            if (_mode == FormMode.Update)
            {
                ComboBoxSubjectSelection.Text = _item.Subject;
                ComboBoxTutorSelection.SelectedValue = _item.Tutor;
                ComboBoxTutorSelection.Text = _item.TutorName;
                DateTimePickerDateSelection.Value = _item.SessionScheduleDate >= DateTime.Today ? _item.SessionScheduleDate : DateTime.Today;
            }
        }
    }
}