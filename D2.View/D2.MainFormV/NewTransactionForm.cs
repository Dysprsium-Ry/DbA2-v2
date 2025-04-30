using _3_13_25.D2.Classes;
using _3_13_25.D2.DAL;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.MainFormVM.D2.BusinessLogics_MFVM_;
using BienvenidoOnlineTutorServices.D2.Objects;
using System;
using System.ComponentModel;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace _3_13_25.D2.View.D2.MainFormV
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
            textBoxStudentName.AutoCompleteCustomSource = DataLoadCast.studentListFetcher();
            this.FormClosed += (s, e) => { TemporalData.Clear(); Cancel(QueuedItemList.QueuedItemsBindingList); refreshControls(); QueuedItemList.TransactionQueues.Clear(); };
            _sumTotal();
        }   

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TemporalData.StudentLUserN))
            {
                textBoxStudentName.Text = TemporalData.StudentLUserN;
                textBoxStudentName.Enabled = false;
            }

            if (TemporalData.Status == "Enrolled")
            {
                foreach (Control control in this.Controls)
                {
                    if (control is Button button && button != buttonCancel)
                    {
                        button.Visible = false;
                    }
                }

                TextBoxStatus.Text = TemporalData.Status.ToString();
            }
            else { TextBoxStatus.Text = "Draft"; }

            TextBoxTransactionID.Text = TemporalData.TransactionId.ToString();
            DataGrid_Load(QueuedItemList.QueuedItemsBindingList);
            _sumTotal();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox && string.IsNullOrEmpty(textbox.Text) && textbox != textBoxTotal)
                {
                    MessageBox.Show("Username does not match any record", "Invalid Student!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxStudentName.Focus();
                    return;
                }
                else
                {
                    if (control is not (Button or DataGridView or Label))
                    {
                        control.Enabled = false;
                    }

                    TemporalData.TransactionId = Convert.ToInt64(TextBoxTransactionID.Text);
                }
            }

            TemporalData.StudentLUserN = textBoxStudentName.Text;

            capsuleForm capsule = new capsuleForm();
            var result = capsule.ShowDialog();

            while (true)
            {
                switch (result)
                {
                    case DialogResult.Yes:
                        if (QueuedItemList.GetQueueForDate(TemporalData.TransactionId).Count > 0)
                        {
                            DataGrid_Load(QueuedItemList.GetQueueForDate(TemporalData.TransactionId));
                        }
                        else
                        {
                            DataGrid_Load(QueuedItemList.QueuedItemsBindingList);
                        }
                        _sumTotal();
                        return;

                    case DialogResult.No:
                        MessageBox.Show("Item already exist", "Item Redundancy Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;

                    default:
                        return;
                }
            }
        }

        private void DataGrid_Load(object binding)
        {
            if (binding is not BindingList<QueuedItems> list) return;


            DataGridViewItemLists.CellFormatting -= DataGridViewQueuedItems_CellFormatting;

            DataGridViewItemLists.DataSource = null;
            DataGridViewItemLists.DataSource = list;

            SetColumnHeaders(DataGridViewItemLists);

            DataGridViewItemLists.CellFormatting += DataGridViewQueuedItems_CellFormatting;
        }

        private void SetColumnHeaders(DataGridView dgv)
        {
            if (dgv.Columns.Contains("TransactionId"))
            {
                dgv.Columns["TransactionId"].HeaderText = "Transaction ID";
                dgv.Columns["TransactionId"].Visible = false;
            }

            if (dgv.Columns.Contains("Status"))
            {
                dgv.Columns["Status"].HeaderText = "State";
                //dgv.Columns["Status"].Visible = false;
            }

            if (dgv.Columns.Contains("Subject"))
                dgv.Columns["Subject"].HeaderText = "Subject";

            if (dgv.Columns.Contains("Tutor"))
                dgv.Columns["Tutor"].HeaderText = "Tutor";

            if (dgv.Columns.Contains("HourlyRate"))
                dgv.Columns["HourlyRate"].HeaderText = "Hourly Rate";

            if (dgv.Columns.Contains("StartSchedule"))
                dgv.Columns["StartSchedule"].HeaderText = "Start Time";

            if (dgv.Columns.Contains("EndSchedule"))
                dgv.Columns["EndSchedule"].HeaderText = "End Time";

            if (dgv.Columns.Contains("SessionScheduleDate"))
                dgv.Columns["SessionScheduleDate"].HeaderText = "Schedule";
        }

        private void DataGridViewQueuedItems_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (DataGridViewItemLists.Columns[e.ColumnIndex].Name == "QueuedStartTime" ||
            DataGridViewItemLists.Columns[e.ColumnIndex].Name == "QueuedEndTime")
            {
                if (e.Value is TimeSpan timeValue)
                {
                    e.Value = DateTime.Today.Add(timeValue).ToString("hh:mm tt");
                    e.FormattingApplied = true;
                }
            }

            if (DataGridViewItemLists.Columns[e.ColumnIndex].Name == "QueuedSessionSchedule")
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
            DataGridReloader(QueuedItemList.QueuedItemsBindingList);

            if (string.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                TemporalData.Clear();
            }

            TextBoxStudEmail.Text = DbItemFetcher.StudentEmailFetcher(textBoxStudentName.Text);

            TemporalData.StudentLUserN = textBoxStudentName.Text;

            if (OpsAndCalcs.IsStudentNameExist(textBoxStudentName.Text))
            {
                TextBoxTransactionID.Text = TemporalData.TransactionId.ToString();
                fetchRecords();
            }
            else { TextBoxTransactionID.Text = (TemporalData.TransactionId = DbItemFetcher.NewTransactionIdFetcher()).ToString(); }
        }

        private void Register(string State)
        {
            if (QueuedItemList.GetQueueForDate(TemporalData.TransactionId).Count > 0)
            {
                Enrollment.TransactionId = long.Parse(TextBoxTransactionID.Text);
                Enrollment.StudentName = TemporalData.StudentLUserN;
                Enrollment.StudentEmail = TextBoxStudEmail.Text;

                BillingClass.RegisterTransaction(State);

                foreach (var item in QueuedItemList.GetQueueForDate(TemporalData.TransactionId))
                {
                    Enrollment.Subject = item.Subject;
                    Enrollment.TutorName = item.Tutor;
                    Enrollment.HourlyRate = item.HourlyRate;
                    Enrollment.StartSchedule = item.StartSchedule;
                    Enrollment.EndSchedule = item.EndSchedule;
                    Enrollment.SessionScheduleDate = item.SessionScheduleDate;
                    Enrollment.TotalFee = decimal.Parse(textBoxTotal.Text);

                    BillingClass.RegisterTransactionInformation(State);
                }

                //BillingClass.RegisterTransactionBilling();
                Cancel(QueuedItemList.QueuedItemsBindingList);
                this.Close();
            }
            else if (QueuedItemList.QueuedItemsBindingList.Count > 0)
            {
                Enrollment.TransactionId = long.Parse(TextBoxTransactionID.Text);
                Enrollment.StudentName = TemporalData.StudentLUserN;
                Enrollment.StudentEmail = TextBoxStudEmail.Text;

                BillingClass.RegisterTransaction(State);

                foreach (var item in QueuedItemList.QueuedItemsBindingList)
                {
                    Enrollment.Subject = item.Subject;
                    Enrollment.TutorName = item.Tutor;
                    Enrollment.HourlyRate = item.HourlyRate;
                    Enrollment.StartSchedule = item.StartSchedule;
                    Enrollment.EndSchedule = item.EndSchedule;
                    Enrollment.SessionScheduleDate = item.SessionScheduleDate;
                    Enrollment.TotalFee = decimal.Parse(textBoxTotal.Text);

                    BillingClass.RegisterTransactionInformation(State);
                }

                BillingClass.RegisterTransactionBilling();
                Cancel(QueuedItemList.QueuedItemsBindingList);
                this.Close();
            }
        }

        private void DataGridReloader(object binding)
        {
            if (binding is not BindingList<QueuedItems> List) return;

            List.Clear();
            DataGridViewItemLists.DataSource = null;
            DataGrid_Load(List);
        }

        private void Enroll()
        {
            Register("Enrolled");
            MessageBox.Show("Enrolled Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Cancel(object binding)
        {
            if (binding is not BindingList<QueuedItems> List) return;

            if (List.Count > 0)
            {
                DataGridReloader(List);
            }
            this.Close();
        }

        private void Save()
        {
            Register("Draft");
            MessageBox.Show("Transaction Saved as Draft", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Remove()
        {
            if (DataGridViewItemLists.SelectedRows.Count > 0 && DataGridViewItemLists.SelectedRows[0].Cells["Status"].Value?.ToString() == "Draft")
            {
                foreach (DataGridViewRow row in DataGridViewItemLists.SelectedRows)
                {
                    QueuedItemList.QueuedItemsBindingList.RemoveAt(row.Index);
                }
                DataGridViewItemLists.DataSource = null;
                DataGrid_Load(QueuedItemList.QueuedItemsBindingList);
            }
            else { }

            if (DataGridViewItemLists.SelectedRows.Count > 0 && DataGridViewItemLists.DataSource == QueuedItemList.GetQueueForDate(TemporalData.TransactionId))
            {
                _subtractTotal();

                foreach (DataGridViewRow row in DataGridViewItemLists.SelectedRows)
                {
                    QueuedItemList.GetQueueForDate(TemporalData.TransactionId).RemoveAt(row.Index);
                }

                if (DataGridViewItemLists.Rows.Count == 0)
                {
                    DataGridViewItemLists.DataSource = null;
                    DataGrid_Load(QueuedItemList.QueuedItemsBindingList);
                }
                else
                {
                    DataGridViewItemLists.DataSource = null;
                    DataGrid_Load(QueuedItemList.GetQueueForDate(TemporalData.TransactionId));
                }
            }
        }

        private void Edit()
        {
            if (DataGridViewItemLists.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in DataGridViewItemLists.SelectedRows)
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

        private void _sumTotal()
        {
            decimal calculatedSum = OpsAndCalcs.CalculateSumSessionFee(TemporalData.SessionTotal, TemporalData.HourlyRate);
            textBoxTotal.Text = calculatedSum.ToString();
            TemporalData.SessionTotal = calculatedSum;
        }


        private void _subtractTotal()
        {
            decimal subtracted = 0m;
            if (DataGridViewItemLists.SelectedRows.Count > 0)
            {
                var cellValue = DataGridViewItemLists.SelectedRows[0].Cells[3].Value;
                subtracted = Convert.ToDecimal(cellValue ?? 0m);
            }
            decimal newTotal = OpsAndCalcs.CalculateSubtSessionFee(TemporalData.SessionTotal, subtracted);
            textBoxTotal.Text = newTotal.ToString();
            TemporalData.SessionTotal = newTotal;
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            Enroll();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel(QueuedItemList.QueuedItemsBindingList);
        }

        private void buttonDraft_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void buttonRemove_Click(object sender, EventArgs e)
        {
            Remove();
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            Edit();
        }

        private void refreshControls()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox)
                {
                    textbox.Clear();

                    if (textbox.Name == "textBoxStudentName")
                    {
                        textbox.Enabled = true;
                    }
                }

                if (control is ComboBox comboBox)
                {
                    comboBox.Enabled = true;
                }

                if (control is Button button)
                {
                    button.Visible = true;
                }
            }
        }

        private void fetchRecords()
        {
            QueuedItemList.QueuedItemsBindingList.Clear();
            var editItemList = EditClass.FetchClientData();
            QueuedItemList.QueuedItemsBindingList.AddRange(editItemList);
        }

        #region DAL

        private void DAL_SaveFunction()
        {
            var repo = new DAL_RepoClass();
            //repo.Save(item); // save an item

            var allItems = repo.GetAllByTransactionId(12345); // load by transaction
            DataGridViewItemLists.DataSource = new BindingList<QueuedItems>(allItems);
        }

        private void DAL_DeleteFunction()
        {
            var selectedItem = (QueuedItems)DataGridViewItemLists.CurrentRow.DataBoundItem;

            if (selectedItem != null)
            {
                QueuedItemList.QueuedItemsBindingList.Remove(selectedItem);

                var repo = new DAL_RepoClass();
                repo.Delete(selectedItem.TransactionId, selectedItem.SessionScheduleDate);
            }
        }

        #endregion
    }
}
