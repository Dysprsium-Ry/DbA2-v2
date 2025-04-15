using _3_13_25.D2.Classes;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.IdFetcherClasses;
using _3_13_25.D2.QueryStorage;
using _3_13_25.D2.View.D2.MainFormV;
using BienvenidoOnlineTutorServices.D2.Classes;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using static BienvenidoOnlineTutorServices.D2.Objects.ObjectModels;

namespace BienvenidoOnlineTutorServices.D2.Forms
{
    public partial class MainForm : Form
    {
        private TransactionStatus transactionStatus = new TransactionStatus();

        public MainForm()
        {
            InitializeComponent();
            dateTimeValueSetter();
            refresh();
            PlaceholderSetter(SearchBoxBilling);

            transactionStatus.TransactionState();
            TransactionStatus.RefreshRequested += RefreshTransactionGrid;

            dataGridViewTutorInTheSubject.RowHeaderMouseClick += (s, e) =>
            {
                EnrollmentClass.TemporalDataSelectedValue(dataGridViewTutorInTheSubject); //The you know
            };
        }
        private void mainForm_Load(object sender, EventArgs e)
        {
            reportViewerReceipt.RefreshReport();
            PlaceholderForSearchBox(SearchBoxBilling);
        }

        #region Initialization and Refresh

        private void RefreshTransactionGrid()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshTransactionGrid));
            }
            else
            {
                refresh();
            }
        }

        private void refresh()
        {
            foreach (Control control in this.Controls)
            {
                if (control is DataGridView dataGridView && dataGridView != null)
                {
                    dataGridView.Refresh();
                }
                else
                {
                    DtEstablisher.TransactionList(DataGridViewTransactionList);
                    ComboBoxEnrollmentSubject.DataSource = SubjectClass.FetchSubjects();
                    //OpsAndCalcs.SearchBar(DataGridViewStudentList, Queries.studListSbar, TextBoxEnrollmentStudName.Text);
                    comboBoxExpertise.DataSource = SubjectClass.FetchSubjects();
                    SubjectClass.FetchSubjects();
                    DtEstablisher.TCDispTut(dataGridViewTutorManagement);
                    SubjectClass.ShowSubjects(dataGridViewSubjects);
                    BillingClass.ShowBilling(DataGridViewPendingPayment);
                    //BillingClass.ShowPartialBilling(DataGridViewPartialPayment);
                    //BillingClass.ShowPaidBilling(DataGridViewPaidPayment);
                }
            }

            if (TemporalData.SubjectList.Count > 0) { ButtonEnrollStudent.Enabled = true; } else { ButtonEnrollStudent.Enabled = false; }
        }

        private void dateTimeValueSetter()
        {
            DateTime today = DateTime.Now.Date;
            int minimumHour = 8;
            int maximumHour = 17;
            DateTime minDateTime = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0);
            DateTime maxDateTime = new DateTime(today.Year, today.Month, today.Day, maximumHour, 0, 0);

            DatePickerSessionSchedule.MinDate = DateTime.Today;
            TimePickerSessionSchedule.MinDate = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0);
            TimePickerSessionSchedule.MaxDate = new DateTime(today.Year, today.Month, today.Day, maximumHour, 0, 0);

            DatePickerSessionSchedule.ValueChanged += (s, e) =>
            {
                if (DatePickerSessionSchedule.Value > DateTime.Now) { TimePickerSessionSchedule.MinDate = new DateTime(today.Year, today.Month, today.Day, minimumHour, 0, 0); }
                else { TimePickerSessionSchedule.MinDate = DateTime.Now; }
            };

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


        private void PlaceholderSetter(TextBox textBox)
        {
            textBox.Text = "Search";
            textBox.ForeColor = Color.Gray;
        }

        private void PlaceholderForSearchBox(TextBox textBox)
        {
            textBox.GotFocus += (s, e) =>
            {
                if (textBox.Text == "Search")
                {
                    textBox.Clear();
                    textBox.ForeColor = Color.Black;
                }
            };

            textBox.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(textBox.Text) || textBox.Text == "Search")
                {
                    textBox.Clear();
                    textBox.Text = "Search";
                    textBox.ForeColor = Color.Gray;
                }
            };
        }
        #endregion

        #region Operation Functions

        #region Universal Event Handlers
        private void TextBoxNumerical_KeyPress(object sender, KeyPressEventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b' && e.KeyChar != '.')
            {
                e.Handled = true;
                return;
            }

            if (e.KeyChar == '.' && textBox.Text.Contains("."))
            {
                e.Handled = true;
                return;
            }

            HandleInputDisplay(e);
        }

        private void HandleInputDisplay(KeyPressEventArgs e)
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox textBox && textBox.Focused)
                {
                    if (string.IsNullOrWhiteSpace(textBox.Text))
                    {
                        textBox.Text = "0";
                    }

                    if (e.KeyChar == '\b')
                    {
                        textBox.Text = "0";
                        e.Handled = true;
                        return;
                    }

                    if (textBox.Text == "0")
                    {
                        if (e.KeyChar != '0')
                        {
                            textBox.Text = e.KeyChar.ToString();
                        }
                        e.Handled = true;
                    }
                    textBox.SelectionStart = textBox.Text.Length;
                }
            }
        }

        private void tabControlMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            refresh();
        }
        #endregion

        #region Enrollment Event Handlers
        private void buttonEnrollStudent_Click(object sender, EventArgs e) //purpose of this is to pass the data to the class that will handle the enrollment
        {
            //if (TemporalData.SubjectList.Count > 0)
            //{
            //    foreach (var transaction in TemporalData.SubjectList)
            //    {
            //        Enrollment.TransactionId = transaction.TransactionId;
            //        Enrollment.StudentName = transaction.StudentName;
            //        EnrollmentClass.EnrollStudent();
            //        Enrollment.StudentId = IdFetcher.StudentId();
            //        Enrollment.TutorName = transaction.TutorName;
            //        Enrollment.TutorId = transaction.TutorId;
            //        Enrollment.Subject = transaction.Subject;
            //        Enrollment.SubjectId = transaction.SubjectId;
            //        Enrollment.SessionScheduleDate = transaction.SessionScheduleDate;
            //        Enrollment.SessionDuration = transaction.SessionDuration;
            //        Enrollment.SessionEndSchedule = transaction.SessionEndSchedule;
            //        Enrollment.HourlyRate = transaction.HourlyRate;
            //        Enrollment.TotalFee = transaction.TotalFee;
            //        Enrollment.RemainingFee = transaction.RemainingFee;
            //        Enrollment.PaymentFee = transaction.PaymentFee;
            //        Enrollment.PaymentStatus = "Pending";

            //        MessageBox.Show($"Subject {transaction.Subject} has been registered successfully", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        BillingClass.TransactionRegistration();

            //        TemporalData.OverallTotalFee = decimal.Parse(textBoxOverallTotalFee.Text);

            //        BillingClass.BillingRecord();
            //    }
            //    MessageBox.Show("Student enrolled successfully", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    dataGridViewPreferredSubjects.DataSource = null;
            //    TemporalData.SubjectList.Clear();
            //    refresh();
            //}
            //else
            //{
            //    MessageBox.Show("Empty registry, aborting operation.", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}
        }
        private void TextBoxEnrollmentStudName_TextChanged(object sender, EventArgs e)
        {

        }
        private void buttonRegisterPrefSub_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageEnroll.Controls)
            {
                if (control is TextBox textBox && string.IsNullOrWhiteSpace(textBox.Text) && textBox != textBoxOverallTotalFee)
                {
                    MessageBox.Show("Field cannot be empty", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }

            TemporalData.TransactionId = long.Parse(TextBoxTransactionID.Text);
            TemporalData.StudentName = TextBoxEnrollmentStudName.Text;
            TemporalData.StudentEmail = TextBoxStudEmail.Text;
            TemporalData.Subject = ComboBoxEnrollmentSubject.Text;
            TemporalData.SessionScheduleDate = DatePickerSessionSchedule.Value.Date;
            TemporalData.SessionScheduleTime = TimePickerSessionSchedule.Value.TimeOfDay;
            TemporalData.SessionDuration = int.Parse(textBoxSessionDuration.Text);

            EnrollmentClass.TemporalDataSelectedValue(dataGridViewTutorInTheSubject);

            var transactions = new PreferredSubject
            {
                TransactionId = TemporalData.TransactionId,
                StudentName = TemporalData.StudentName,
                Subject = TemporalData.Subject,
                SubjectId = IdFetcher.SubjectId(),
                TutorName = TemporalData.TutorName,
                TutorId = IdFetcher.TutorId(),
                SessionScheduleDate = OpsAndCalcs.CombineDateAndTime(TemporalData.SessionScheduleDate, TemporalData.SessionScheduleTime),
                SessionDuration = TemporalData.SessionDuration,
                SessionEndSchedule = OpsAndCalcs.SessessionEndSchedule(DatePickerSessionSchedule.Value.Date, TimePickerSessionSchedule.Value.TimeOfDay, int.Parse(textBoxSessionDuration.Text)),
                HourlyRate = TemporalData.HourlyRate,
                TotalFee = OpsAndCalcs.CalculateTotalFee(int.Parse(textBoxSessionDuration.Text), TemporalData.HourlyRate),
                PaymentFee = 0,
                RemainingFee = OpsAndCalcs.CalculateTotalFee(int.Parse(textBoxSessionDuration.Text), TemporalData.HourlyRate),
                PaymentStatus = OpsAndCalcs.PaymentStatus(BillingObj.RemainingBalance, BillingObj.PayFee)
            };

            if (OpsAndCalcs.IfScheduleExist(DatePickerSessionSchedule.Value, TimePickerSessionSchedule.Value.TimeOfDay))
            {
                MessageBox.Show("Date and Time is occupied, pick another schedule date.", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (!TemporalData.SubjectList.Contains(transactions))
            {
                DateTime schedNow = DatePickerSessionSchedule.Value.Date + TimePickerSessionSchedule.Value.TimeOfDay;
                bool exist = TemporalData.SubjectList.Any(b => schedNow <= b.SessionEndSchedule);

                if (exist)
                {
                    MessageBox.Show("This Schedule date is already occupied", "Schedule Occupied", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                TemporalData.SubjectList.Add(transactions);

                dataGridViewPreferredSubjects.DataSource = null;
                dataGridViewPreferredSubjects.DataSource = TemporalData.SubjectList.Select(s => new { s.StudentName, s.Subject, s.TutorName, s.SessionDuration, s.SessionScheduleDate, s.SessionEndSchedule, s.TotalFee }).ToList();

                textBoxOverallTotalFee.Text = TemporalData.SubjectList.Sum(transactions => transactions.TotalFee).ToString();
            }
            refresh();
        }
        private void comboBoxPreferredSubjects_SelectedValueChanged(object sender, EventArgs e)
        {
            TemporalData.Subject = ComboBoxEnrollmentSubject.Text;
            DtEstablisher.ECDispTut(dataGridViewTutorInTheSubject, Queries.ECDispTut, TemporalData.Subject);
        }

        private void buttonRemoveSub_Click(object sender, EventArgs e)
        {
            if (TemporalData.SubjectList.Count > 0)
            {
                foreach (Control control in tabPageEnroll.Controls)
                {
                    if (control is TextBox textBox)
                    {
                        textBox.Clear();
                    }
                }
                dataGridViewPreferredSubjects.DataSource = null;
                TemporalData.SubjectList.Clear();
            }
            refresh();
        }
        #endregion

        #region Subject Management Event Handlers
        private void buttonAddISubject_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectLib.Text))
            {
                TemporalData.Subject = textBoxSubjectLib.Text;
                SubjectClass.AddSub();
                refresh();
            }
            else
            {
                MessageBox.Show("Textbox Value is invalid. Action aborted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void buttonDeleteToolInventory_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxSubjectLib.Text))
            {
                TemporalData.Subject = textBoxSubjectLib.Text;
                SubjectClass.DeleteSub();
                refresh();
            }
            else
            {
                MessageBox.Show("Textbox Value is invalid. Action aborted.", "Invalid Action", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void dataGridViewSubjects_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < dataGridViewSubjects.Rows.Count)
            {
                var Expertise = dataGridViewSubjects.Rows[e.RowIndex].Cells[0].Value;

                if (Expertise != null)
                {
                    textBoxSubjectLib.Text = Convert.ToString(Expertise);
                }
                else
                {
                    MessageBox.Show("Selected row contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Selected row index is out of range.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Tutor Management Event Handlers
        private void buttonRegisterTutor_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageTutorRegistration.Controls)
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
            refresh();
        }

        private void textBoxTutorName_TextChanged(object sender, EventArgs e)
        {
            //OpsAndCalcs.SearchBar(dataGridViewTutorManagement, Queries.tutListSbar, textBoxTutorName.Text);
            dataGridViewTutorManagement.Refresh();
        }

        private void textBoxTutorinServiceLib_TextChanged(object sender, EventArgs e)
        {
            //OpsAndCalcs.SearchBar(dataGridViewTutorPerSubject, Queries.tutSubSBar, textBoxSubjectLib.Text);
            dataGridViewTutorPerSubject.Refresh();
        }

        private void buttonTutorDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Do you wish to proceed? \nAction cannot be undone", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                TutorClass.DeleteTutor();
            }
        }
        #endregion

        #region Billing Management Event Handlers
        private void buttonPaid_Click(object sender, EventArgs e)
        {
            foreach (Control control in tabPageBilling.Controls)
            {
                if (control is DataGridView datagrid && datagrid.SelectedRows.Count < 0)
                {
                    MessageBox.Show("Select a single row before proceeding payment.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
            if (string.IsNullOrEmpty(textBoxPayment.Text))
            {
                return;
            }

            BillingObj.Pay = decimal.Parse(textBoxPayment.Text);

            if (OpsAndCalcs.SumPaidFee(BillingObj.PayFee, BillingObj.Pay) <= BillingObj.TotalFee)
            {
                BillingClass.UpdatePayment();
                refresh();
            }
            else { MessageBox.Show("Excess Pay Fee!\nPay for the appropriate remaining amount left only", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning); }

            ReceiptReportClass.ReceiptSetup(reportViewerReceipt);
        }

        private void DataGridViewPendingPayment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BillingClass.SelectedValue(DataGridViewPendingPayment);
        }

        private void DataGridViewPartialPayment_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            BillingClass.SelectedValue(DataGridViewPartialPayment);
        }
        #endregion

        #endregion

        private void buttonNew_Click(object sender, EventArgs e)
        {
            NewTransactionForm OpenNew = new NewTransactionForm();
            OpenNew.ShowDialog();
        }

        private void textBoxSearchBar_TextChanged(object sender, EventArgs e)
        {
            DataTable SearchResult = DtEstablisher.SearchTransactions(textBoxSearchBar.Text.Trim());
            DataGridViewTransactionList.DataSource = SearchResult;
        }
    }
}