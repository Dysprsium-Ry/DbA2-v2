using _3_13_25.D2.Classes;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.MainFormVM.D2.BusinessLogics_MFVM_;
using System;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.MainFormV
{
    public partial class NewTransactionForm : Form
    {
        public NewTransactionForm()
        {
            InitializeComponent();
            textBoxStudentName.AutoCompleteCustomSource = DtEstablisher.studentListFetcher();
            this.FormClosed += (s, e) => { clearTemporalDatas(); Cancel(); refreshFields(); };
        }

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TemporalData.StudentName))
            {
                textBoxStudentName.Text = TemporalData.StudentName;
            }

            TextBoxTransactionID.Text = TemporalData.TransactionId.ToString();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox && string.IsNullOrEmpty(textbox.Text))
                {
                    MessageBox.Show("Username does not match any record", "Invalid Student!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxStudentName.Focus();
                    return;
                }

                if (control is not (Button or DataGridView or Label))
                {
                    control.Enabled = false;
                }
            }

            TemporalData.StudentName = textBoxStudentName.Text;

            capsuleForm capsule = new capsuleForm();
            if (capsule.ShowDialog() == DialogResult.OK)
            {
                DataGrid_Load();
            }
        }

        private void DataGrid_Load()
        {
            DataGridViewQueuedItems.DataSource = null;

            DataGridViewQueuedItems.DataSource = QueuedItemList.QueuedItemsList;

            DataGridViewQueuedItems.Columns["TransactionId"].HeaderText = "Transaction ID";
            DataGridViewQueuedItems.Columns["QueuedSubject"].HeaderText = "Subject";
            DataGridViewQueuedItems.Columns["QueuedTutor"].HeaderText = "Tutor";
            DataGridViewQueuedItems.Columns["QueuedHourlyRate"].HeaderText = "Hourly Rate";
            DataGridViewQueuedItems.Columns["QueuedStartTime"].HeaderText = "Start Time";
            DataGridViewQueuedItems.Columns["QueuedEndTime"].HeaderText = "End Time";
            DataGridViewQueuedItems.Columns["QueuedSessionSchedule"].HeaderText = "Schedule";

            DataGridViewQueuedItems.Columns["TransactionId"].Visible = false;

            DataGridViewQueuedItems.CellFormatting += DataGridViewQueuedItems_CellFormatting;
        }

        private void DataGridViewQueuedItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataGridViewQueuedItems.Columns[e.ColumnIndex].Name == "QueuedStartTime" ||
                DataGridViewQueuedItems.Columns[e.ColumnIndex].Name == "QueuedEndTime")
            {
                if (e.Value is TimeSpan timeValue)
                {
                    e.Value = DateTime.Today.Add(timeValue).ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (DataGridViewQueuedItems.Columns[e.ColumnIndex].Name == "QueuedSessionSchedule")
            {
                if (e.Value is DateTime sessionDate)
                {
                    e.Value = sessionDate.ToString("MMMM dd, yyyy - hh:mm tt");
                    e.FormattingApplied = true;
                }
            }
        }


        private void textBoxStudentName_TextChanged(object sender, EventArgs e)
        {
            TextBoxStudEmail.Text = DbItemFetcher.StudentEmailFetcher(textBoxStudentName.Text);
            TemporalData.StudentName = textBoxStudentName.Text;
            if (TemporalData.TransactionId != DbItemFetcher.TransactionIdFetcher())
            {
                TextBoxTransactionID.Text = (TemporalData.TransactionId = DbItemFetcher.TransactionIdFetcher()).ToString();
            }
        }

        private void Register(string State)
        {
            if (QueuedItemList.QueuedItemsList.Count > 0)
            {
                Enrollment.TransactionId = long.Parse(TextBoxTransactionID.Text);
                Enrollment.StudentName = TemporalData.StudentName;
                Enrollment.StudentEmail = TextBoxStudEmail.Text;

                BillingClass.RegisterTransaction(State);

                foreach (var item in QueuedItemList.QueuedItemsList)
                {
                    Enrollment.Subject = item.QueuedSubject;
                    Enrollment.TutorName = item.QueuedTutor;
                    Enrollment.HourlyRate = item.QueuedHourlyRate;
                    Enrollment.StartSchedule = item.QueuedStartTime;
                    Enrollment.EndSchedule = item.QueuedEndTime;
                    Enrollment.SessionScheduleDate = item.QueuedSessionSchedule;
                    Enrollment.TotalFee = decimal.Parse(textBoxTotal.Text);

                    BillingClass.RegisterTransactionInformation();
                }
                BillingClass.RegisterTransactionBilling();
                Cancel();
                this.Close();
            }
        }

        private void Enroll()
        {
            Register("Enroll");

            MessageBox.Show("Enrolled Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Cancel()
        {
            if (QueuedItemList.QueuedItemsList.Count > 0)
            {
                QueuedItemList.QueuedItemsList.Clear();
                DataGridViewQueuedItems.DataSource = null;
                DataGrid_Load();
                this.Close();
            }
        }

        private void Draft()
        {
            Register("Draft");

            MessageBox.Show("Queue Drafted", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Remove()
        {
            if (DataGridViewQueuedItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridViewQueuedItems.SelectedRows)
                {
                    QueuedItemList.QueuedItemsList.RemoveAt(row.Index);
                }
                DataGridViewQueuedItems.DataSource = null;
                DataGrid_Load();
            }
        }

        private void Edit()
        {
            if (DataGridViewQueuedItems.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridViewQueuedItems.SelectedRows)
                {
                    var items = new EditItemList
                    {
                        Subject = row.Cells["QueuedSubject"].Value.ToString(),
                        Tutor = row.Cells["QueuedTutor"].Value.ToString(),
                        EditHourlyRate = Convert.ToDecimal(row.Cells["QueuedHourlyRate"].Value),
                        EditStartTime = (TimeSpan)row.Cells["QueuedStartTime"].Value,
                        EditEndTime = (TimeSpan)row.Cells["QueuedEndTime"].Value,
                        EditScheduleDate = Convert.ToDateTime(row.Cells["QueuedSessionSchedule"].Value)
                    };

                    EditItemListCollection.EditSubject = row.Cells["QueuedSubject"].Value.ToString();
                    EditItemListCollection.EditTutor = row.Cells["QueuedTutor"].Value.ToString();
                    EditItemListCollection.EditHourlyRate = Convert.ToDecimal(row.Cells["QueuedHourlyRate"].Value);
                    EditItemListCollection.EditStartTime = (TimeSpan)row.Cells["QueuedStartTime"].Value;
                    EditItemListCollection.EditEndTime = (TimeSpan)row.Cells["QueuedEndTime"].Value;
                    EditItemListCollection.EditScheduleDate = Convert.ToDateTime(row.Cells["QueuedSessionSchedule"].Value);
                }
            }
        }

        private void reLoad()
        {
            this.Activated += (s, e) =>
            {
                try
                {
                    if (QueuedItemList.QueuedItemsList == null)
                    {
                        textBoxTotal.Text = "0.00";
                        return;
                    }

                    var items = QueuedItemList.QueuedItemsList;

                    if (textBoxTotal.InvokeRequired)
                    {
                        textBoxTotal.Invoke(new Action(() =>
                        {
                            textBoxTotal.Text = items.Count > 0
                                ? items.Sum(item => item.QueuedHourlyRate).ToString("0.00")
                                : "0.00";
                        }));
                    }
                    else
                    {
                        textBoxTotal.Text = items.Count > 0
                            ? items.Sum(item => item.QueuedHourlyRate).ToString("0.00")
                            : "0.00";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error updating total: {ex.Message}");
                    textBoxTotal.Text = "0.00";
                }
                return;
            };

        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            Enroll();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel();
        }

        private void buttonDraft_Click(object sender, EventArgs e)
        {
            Draft();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void clearTemporalDatas()
        {
            TemporalData.StudentName = string.Empty;
            TemporalData.Subject = string.Empty;
            TemporalData.TutorName = string.Empty;
            TemporalData.HourlyRate = 0;
            TemporalData.InTime = TimeSpan.Zero;
            TemporalData.OutTime = TimeSpan.Zero;
            TemporalData.SessionScheduleDate = DateTime.MinValue;
        }

        private void refreshFields()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();
                }
            }
        }
    }
}
