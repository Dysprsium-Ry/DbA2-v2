using _3_13_25.D2.Classes;
using _3_13_25.D2.DAL;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.Model;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.BusinessLogics;
using _3_13_25.D2.ViewModel.D2.MainFormVM.D2.BusinessLogics_MFVM_;
using _3_13_25.D2.ViewModel.D2.RegistrationLogics;
using BienvenidoOnlineTutorServices.D2.Objects;
using System;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;
using static System.Windows.Forms.AxHost;

namespace _3_13_25.D2.View.D2.MainFormV
{
    public partial class TransactionForm : Form
    {
        public TransactionForm()
        {
            InitializeComponent();
            this.FormClosed += (s, e) => { TemporalData.Clear(); Cancel(_bindingList); refreshControls(); _bindingList.Clear(); };
            _sumTotal();
        }

        private BindingList<TransactionItems> _bindingList = new BindingList<TransactionItems>();
        private TransactionItems item;

        private void NewTransactionForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(TemporalData.StudentUserN))
            {
                textBoxStudentName.Text = TemporalData.StudentUserN;
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
            DataGrid_Load(_bindingList);

            if (TemporalData.TotalFee == 0)
            {
                _sumTotal();
            }
            else
            {
                textBoxTotal.Text = TemporalData.TotalFee.ToString();
            }

            if (DataGridViewItemLists.Rows.Count < 2) buttonRemove.Visible = false;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textbox && string.IsNullOrEmpty(textbox.Text) && textbox != textBoxTotal)
                {
                    MessageBox.Show("Username does not match any record", "Invalid Student!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    textBoxStudentName.Focus();
                    textBoxStudentName.SelectAll();
                    textBoxStudentName.Enabled = true;
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

            if (!OpsAndCalcs.IsStudentNameExist(textBoxStudentName.Text))
            {
                return;
            }

            TemporalData.StudentUserN = textBoxStudentName.Text;

            CapsuleForm capsule = new CapsuleForm(_bindingList, CapsuleForm.FormMode.New);
            var result = capsule.ShowDialog();

            while (true)
            {
                switch (result)
                {
                    case DialogResult.Yes:
                        //DataGrid_Load(_bindingList);
                        _sumTotal();
                        if (DataGridViewItemLists.Rows.Count > 1) buttonRemove.Visible = true;
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
            //if (binding is not BindingList<TransactionItems> list) return;

            DataGridViewItemLists.CellFormatting -= DataGridView_CellFormatting;

            DataGridViewItemLists.DataSource = null;
            DataGridViewItemLists.DataSource = binding;

            SetColumnHeaders(DataGridViewItemLists);

            DataGridViewItemLists.CellFormatting += DataGridView_CellFormatting;
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

            if (dgv.Columns.Contains("SubjectId"))
            {
                dgv.Columns["SubjectId"].HeaderText = "Subject Id";
                dgv.Columns["SubjectId"].Visible = false;
            }

            if (dgv.Columns.Contains("Subject"))
                dgv.Columns["Subject"].HeaderText = "Subject";

            if (dgv.Columns.Contains("Tutor"))
            {
                dgv.Columns["Tutor"].HeaderText = "Tutor Id";
                dgv.Columns["Tutor"].Visible = false;
            }

            if (dgv.Columns.Contains("TutorName"))
            {
                dgv.Columns["TutorName"].HeaderText = "Tutor";
                //dgv.Columns["TutorName"].Visible = false;
            }

            if (dgv.Columns.Contains("HourlyRate"))
                dgv.Columns["HourlyRate"].HeaderText = "Hourly Rate";

            if (dgv.Columns.Contains("StartSchedule"))
                dgv.Columns["StartSchedule"].HeaderText = "Start Time";

            if (dgv.Columns.Contains("EndSchedule"))
                dgv.Columns["EndSchedule"].HeaderText = "End Time";

            if (dgv.Columns.Contains("SessionScheduleDate"))
                dgv.Columns["SessionScheduleDate"].HeaderText = "Schedule";

            if (dgv.Columns.Contains("TotalFee"))
            {
                dgv.Columns["TotalFee"].HeaderText = "Total Fee";
                dgv.Columns["TotalFee"].Visible = false;
            }
        }

        private void DataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
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
            DataGridReloader(_bindingList);
            fetchRecords();

            if (string.IsNullOrWhiteSpace(textBoxStudentName.Text))
            {
                TemporalData.Clear();
            }

            TextBoxStudEmail.Text = DbItemFetcher.StudentEmailFetcher(textBoxStudentName.Text);

            TemporalData.StudentUserN = textBoxStudentName.Text;
        }

        private void textBoxStudentName_KeyUp(object sender, KeyEventArgs e)
        {
            if (OpsAndCalcs.IsStudentNameExist(textBoxStudentName.Text))
            {
                TextBoxTransactionID.Text = (DbItemFetcher.MinDraftIdFetcher() != 0 ? DbItemFetcher.MinDraftIdFetcher() : DbItemFetcher.NewTransactionIdFetcher()).ToString();
                TemporalData.TransactionId = Convert.ToInt64(TextBoxTransactionID.Text);
                fetchRecords();
            }
            else { TextBoxTransactionID.Text = (TemporalData.TransactionId = DbItemFetcher.NewTransactionIdFetcher()).ToString(); }
        }

        private bool Register(string State)
        {
            Enrollment.TransactionId = long.Parse(TextBoxTransactionID.Text);
            Enrollment.StudentName = TemporalData.StudentUserN;
            Enrollment.StudentEmail = TextBoxStudEmail.Text;

            if (BookingLogics.IsTransactionsExist())
            {
                BookingLogics.UpdateTransaction(State);
            }
            else
            {
                BookingLogics.RegisterTransaction(State);
            }

            bool atLeastOneSuccess = false;

            foreach (var item in _bindingList)
            {
                if (item.Status == "Enrolled") continue;

                Enrollment.Subject = item.Subject;
                Enrollment.TutorId = item.Tutor;
                Enrollment.HourlyRate = item.HourlyRate;
                Enrollment.StartSchedule = item.StartSchedule;
                Enrollment.EndSchedule = item.EndSchedule;
                Enrollment.SessionScheduleDate = item.SessionScheduleDate;
                Enrollment.TotalFee = _bindingList.Sum(t => t.HourlyRate);

                if (!BookingLogics.IsTutorAvailable(item.Tutor, item.SessionScheduleDate.Date, item.StartSchedule))
                {
                    if (BookingLogics.isTransactionItemExist())
                    {
                        BookingLogics.UpdateTransactionInformation(State, item.Tutor, item.SessionScheduleDate.Date, item.StartSchedule);
                        atLeastOneSuccess = true;
                    }
                    else
                    {
                        BookingLogics.RegisterTransactionInformation(State);
                        atLeastOneSuccess = true;
                    }
                }
                else
                {
                    MessageBox.Show($"This Tutor for Subject: {item.Subject} \n\nIs currently unavailable for booking for the specified date.\n\nYou can modify the date or remove it.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    continue;
                }
            }

            if (atLeastOneSuccess)
            {
                BookingLogics.RegisterTransactionBilling();
                BillingLogics.RecordHistory(Enrollment.TransactionId, Enrollment.TotalFee, 0);
            }
            return atLeastOneSuccess;
        }

        private void DataGridReloader(object binding)
        {
            //if (binding is not BindingList<TransactionItems> List) return;

            //List.Clear();
            DataGridViewItemLists.DataSource = null;
            DataGrid_Load(binding);
        }

        private void Enroll()
        {
            switch (Register("Enrolled"))
            {
                case true:
                    MessageBox.Show("Enrolled Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case false:
                    //MessageBox.Show("Failed to enroll. Please check the tutor's availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                default:
            }
            //MessageBox.Show("Enrolled Successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Cancel(object binding)
        {
            //if (binding is not BindingList<TransactionItems> List) return;

            if (_bindingList.Count > 0)
            {
                DataGridReloader(_bindingList);
            }
            this.Close();
        }

        private void Save()
        {
            switch (Register("Draft"))
            {
                case true:
                    MessageBox.Show("Saved as Draft", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    break;
                case false:
                    MessageBox.Show("Failed to save. Please check the tutor's availability.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    DataGridReloader(_bindingList);
                    return;
                default:
            }
            //MessageBox.Show("Transaction Saved as Draft", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void Remove()
        {
            if (DataGridViewItemLists.SelectedRows.Count == 1 && (DataGridViewItemLists.SelectedRows[0].Cells["Status"].Value?.ToString() == "Draft" || DataGridViewItemLists.SelectedRows[0].Cells["Status"].Value?.ToString() == "" || DataGridViewItemLists.SelectedRows[0].Cells["Status"].Value?.ToString() == null))
            {
                if (MessageBox.Show("Removing items on a saved draft will automatically save changes\n\nDo you wish to proceed?", "Warning!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.Cancel) { return; }

                TemporalData.Subject = Convert.ToString(DataGridViewItemLists.SelectedRows[0].Cells["Subject"].Value ?? string.Empty);
                TemporalData.TutorName = Convert.ToString(DataGridViewItemLists.SelectedRows[0].Cells["Tutor"].Value ?? string.Empty);
                TemporalData.SessionScheduleDate = Convert.ToDateTime(DataGridViewItemLists.SelectedRows[0].Cells["SessionScheduleDate"].Value ?? DateTime.MinValue);

                if (DataGridViewItemLists.SelectedRows.Count > 0 && DataGridViewItemLists.DataSource == _bindingList)
                {
                    if (EditClass.IsItemExist() && DataGridViewItemLists.Rows.Count > 1)
                    {
                        EditClass.RemoveItem();
                        _bindingList.RemoveAt(DataGridViewItemLists.SelectedRows[0].Index);

                        if (_bindingList.Any(t => t.Status == "Enrolled"))
                        {
                            Register("Enrolled"); 
                            BookingLogics.UpdateTransaction("Enrolled");
                        }
                        else { Register("Draft"); }
                    }

                    foreach (DataGridViewRow row in DataGridViewItemLists.SelectedRows)
                    {
                        _bindingList.RemoveAt(row.Index);
                    }
                }
                if (DataGridViewItemLists.Rows.Count < 2) { buttonRemove.Visible = false; }
                DataGrid_Load(_bindingList);
            }
        }

        private void Edit()
        {
            if (DataGridViewItemLists.SelectedRows[0].Index >= 0 && DataGridViewItemLists.Rows.Count > 0)
            {
                int selectedRowIndex = DataGridViewItemLists.SelectedRows[0].Index;
                TransactionItems items = (TransactionItems)DataGridViewItemLists.Rows[selectedRowIndex].DataBoundItem;

                using (var form = new CapsuleForm(_bindingList, CapsuleForm.FormMode.Update, items, selectedRowIndex))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        MessageBox.Show("Update Successfully!");
                    }
                }
            }
        }

        private void _sumTotal()
        {
            _bindingList.ListChanged += (s, e) => 
            {
                decimal value = _bindingList.Sum(t => t.HourlyRate);
                textBoxTotal.Text = value.ToString("0.00");
            };
        }

        private void buttonEnroll_Click(object sender, EventArgs e)
        {
            Enroll();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            Cancel(TransactionItemList.BindingList);
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
            _bindingList.Clear();
            var editItemList = EditClass.FetchClientData();
            _bindingList.AddRange(editItemList);
            textBoxTotal.Text = EditClass.FetchTransactionTotal().ToString("0.00");
        }

        #region DAL

        private void DAL_SaveFunction()
        {
            var repo = new DAL_RepoClass();
            //repo.Save(item); // save an item

            var allItems = repo.GetAllByTransactionId(12345); // load by transaction
            DataGridViewItemLists.DataSource = new BindingList<TransactionItems>(allItems);
        }

        private void DAL_DeleteFunction()
        {
            var selectedItem = (TransactionItems)DataGridViewItemLists.CurrentRow.DataBoundItem;

            if (selectedItem != null)
            {
                TransactionItemList.BindingList.Remove(selectedItem);

                var repo = new DAL_RepoClass();
                repo.Delete(selectedItem.TransactionId, selectedItem.SessionScheduleDate);
            }
        }

        #endregion

        private void DataGridViewItemLists_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && (button == buttonRemove || button == buttonEdit))
                {
                    button.Visible = DataGridViewItemLists.Rows.Count > 1 && e.RowIndex >= 0 && (DataGridViewItemLists.Rows[e.RowIndex].Cells["Status"].Value?.ToString() == "Draft" || string.IsNullOrEmpty(DataGridViewItemLists.Rows[e.RowIndex].Cells["Status"].Value?.ToString()));
                }
                else { }

                if (DataGridViewItemLists.SelectedRows.Count > 0)
                {
                    var cellValue = DataGridViewItemLists.SelectedRows[0].Cells["Status"]?.Value;
                    if (cellValue != null && cellValue.ToString() == "Draft")
                    {
                        if (control is Button Button && (Button == buttonRemove || Button == buttonEdit || Button == buttonEnroll))
                        {
                            Button.Visible = DataGridViewItemLists.Rows.Count > 1 && e.RowIndex >= 0 && (DataGridViewItemLists.Rows[e.RowIndex].Cells["Status"].Value?.ToString() == "Draft" || string.IsNullOrEmpty(DataGridViewItemLists.Rows[e.RowIndex].Cells["Status"].Value?.ToString()));
                        }
                    }
                    else
                    {
                        if (control is Button Button && (Button == buttonEnroll))
                        {
                            Button.Visible = false;
                        }
                    }
                }
            }
        }

        private void TransactionForm_Shown(object sender, EventArgs e)
        {
            textBoxStudentName.AutoCompleteCustomSource = DataLoadCast.studentListFetcher();
        }

        private void textBoxStudentName_Leave(object sender, EventArgs e)
        {
            textBoxStudentName.Text = textBoxStudentName.Text.Trim().ToUpper();
        }
    }
}
