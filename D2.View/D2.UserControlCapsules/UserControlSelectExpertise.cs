using _3_13_25.D2.Model;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.UserControlCapsules
{
    public partial class UserControlSelectExpertise : UserControl, IRefreshableControl
    {
        private BindingList<ExpertiseList> _expertiseList = new BindingList<ExpertiseList>();
        private List<long> _PendingDelete = new List<long>();
        private ExpertiseList _list;
        private long _id;

        public void RefreshControl()
        {
            DataLoad();
            DataGrid_Load();
        }

        public UserControlSelectExpertise(long tutorId, BindingList<ExpertiseList> expertiseLists)
        {
            InitializeComponent();
            dateTimeValueSetter();
            if(expertiseLists != null) _expertiseList = expertiseLists;
            _id = tutorId;

            //this.ParentForm.FormClosing += (s, e) => { if (_expertiseList.Contains != null) { save(); } };
        }

        private void UserControlSelectExpertise_Load(object sender, EventArgs e)
        {
            DataLoad();
            DataGrid_Load();
        }

        private void DataLoad()
        {
            comboBoxExpertise.DataSource = DbItemFetcher.Subjects();
            comboBoxExpertise.DisplayMember = "Subject";
            comboBoxExpertise.ValueMember = "SubjectId";
        }

        private void DataGrid_Load()
        {
            dataGridViewExpertiseList.DataSource = null;
            dataGridViewExpertiseList.DataSource = _expertiseList;
            DataGridFormat();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            var items = new ExpertiseList
            {
                SubjectId = Convert.ToInt64(comboBoxExpertise.SelectedValue),
                Subject = comboBoxExpertise.Text,
                HourlyRate = numericUpDownHourlyRate.Value,
                InTime = dateTimePickerBeginTime.Value.TimeOfDay,
                OutTime = dateTimePickerEndTime.Value.TimeOfDay
            };

            bool isExist = _expertiseList.Any(i => i.SubjectId != 0 && i.SubjectId == items.SubjectId);

            if (!isExist)
            {
                _expertiseList.Add(items);
                DataGrid_Load();
            }
            else { MessageBox.Show("Subject already exist", "Adding Error", MessageBoxButtons.OK, MessageBoxIcon.Error); }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpertiseList.RowCount > 0)
            {
                //_expertiseList = null;
                DataLoad();
                numericUpDownHourlyRate.Value = numericUpDownHourlyRate.Minimum;
            }
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            if (dataGridViewExpertiseList.Rows.Count > 0)
            {
                if (dataGridViewExpertiseList.SelectedRows[0].Index >= 0)
                {
                    TutorClass.PendingDelete.Add(Convert.ToInt64(dataGridViewExpertiseList.SelectedRows[0].Cells["SubjectId"].Value));
                    _expertiseList.RemoveAt(dataGridViewExpertiseList.SelectedRows[0].Index);
                }
            }
        }

        private void DataGridFormat()
        {
            if (dataGridViewExpertiseList.Columns.Contains("SubjectId"))
            {
                dataGridViewExpertiseList.Columns["SubjectId"].HeaderText = "Id";
                dataGridViewExpertiseList.Columns["SubjectId"].Visible = false;
            }
        }

        private void save()
        {
            Expertise.expertiseLists = _expertiseList;
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

        protected override void OnParentChanged(EventArgs e)
        {
            base.OnParentChanged(e);
            if (this.ParentForm != null)
            {
                this.ParentForm.FormClosing += (s, e) => { if (_expertiseList.Contains != null) { save(); } };
            }
        }
    }
}
