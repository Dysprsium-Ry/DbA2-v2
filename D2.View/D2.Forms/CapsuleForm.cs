using _3_13_25.D2.Classes;
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
        private readonly TransactionItems _editItem;
        private readonly BindingList<TransactionItems> _editList = new BindingList<TransactionItems>();
        private readonly int _index = -1;

        public CapsuleForm(BindingList<TransactionItems> binding, FormMode mode, TransactionItems editItem = null, int index = -1)
        {
            InitializeComponent();

            //this.FormClosed += (s, e) => { _editList.Clear(); this.Dispose(); };

            _mode = mode;
            _editList = binding;
            _editItem = editItem ?? new TransactionItems();
            _index = index;

            this.Text = _mode == FormMode.New ? "New Transaction" : "Edit Transaction";

            DateTimePickerDateSelection.MinDate = DateTime.Today;
            ComboBoxSubjectSelection.DataSource = DbItemFetcher.Subjects();
            TutorDetailsBindingSource.DataSource = DbItemFetcher.TutorsDetailsFetcher(ComboBoxSubjectSelection.Text);

            ComboBoxTutorSelection.DataSource = TutorDetailsBindingSource;
            ComboBoxTutorSelection.DisplayMember = "TutorName";
            ComboBoxTutorSelection.ValueMember = "TutorName";
        }

        private void CapsuleForm_Load(object sender, EventArgs e)
        {
            DataLoad(_editItem);

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
            if (TransactionLogics.IsTutorAvailable(ComboBoxTutorSelection.Text, TemporalData.OutTime, DateTimePickerDateSelection.Value.Date))
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
            bool isAlreadyExist = _editList.Any(item => item.Tutor == newItem.Tutor && item.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < item.EndSchedule && newItem.EndSchedule > item.StartSchedule);

            bool isStudentAvailable = _editList.Any(id => id.TransactionId == newItem.TransactionId && id.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < id.EndSchedule && newItem.EndSchedule > id.StartSchedule);
            bool isStudentOverlapping = TransactionItemList.TransactionQueues.SelectMany(sv => sv.Value).Any(item => item.TransactionId == newItem.TransactionId && item.SessionScheduleDate.Date == newItem.SessionScheduleDate.Date && newItem.StartSchedule < item.EndSchedule && newItem.EndSchedule > item.StartSchedule);

            if (!_editList.Contains(newItem))
            {
                if (isAlreadyExist || isOverlapping || isStudentAvailable || isStudentOverlapping)
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
                    _editList.Add(newItem);

                }
                else if (_mode == FormMode.Update)
                {
                    BookingLogics.DropOnUpdate(_editItem.TransactionId, _editItem.Subject, _editItem.Tutor, _editItem.SessionScheduleDate);

                    _editItem.Subject = newItem.Subject;
                    _editItem.Tutor = newItem.Tutor;
                    _editItem.HourlyRate = newItem.HourlyRate;
                    _editItem.StartSchedule = newItem.StartSchedule;
                    _editItem.EndSchedule = newItem.EndSchedule;
                    _editItem.SessionScheduleDate = newItem.SessionScheduleDate;

                    if (OpsAndCalcs.CombineDateAndTime(newItem.SessionScheduleDate, newItem.StartSchedule) > DateTime.Now.AddHours(1) && DateTime.Now < OpsAndCalcs.CombineDateAndTime(newItem.SessionScheduleDate, newItem.EndSchedule))
                    {
                        _editList[_index] = _editItem;
                    }
                    else { MessageBox.Show("Date invalid for transation", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }
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
            Save();
        }

        private void DataLoad(TransactionItems _item)
        {
            if (_mode == FormMode.Update)
            {
                ComboBoxSubjectSelection.Text = _item.Subject;
                ComboBoxTutorSelection.Text = _item.Tutor;
                DateTimePickerDateSelection.Value = _item.SessionScheduleDate;
            }
        }
    }
}