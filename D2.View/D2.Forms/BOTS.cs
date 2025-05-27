using _3_13_25.D2.Classes;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.dbEstablisher;
using _3_13_25.D2.IdFetcherClasses;
using _3_13_25.D2.QueryStorage;
using _3_13_25.D2.View;
using _3_13_25.D2.View.D2.MainFormV;
using _3_13_25.D2.View.D2.UserControlCapsules;
using _3_13_25.D2.View.D2.UserControlViews;
using _3_13_25.D2.ViewModel.D2.AutomotiveExecQuery;
using _3_13_25.D2.ViewModel.D2.MainFormVM.D2.BusinessLogics_MFVM_;
using BienvenidoOnlineTutorServices.D2.Classes;
using BienvenidoOnlineTutorServices.D2.Objects;
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
        TransactionForm newForm = new TransactionForm();

        UserControlTransactionList transactionPage = new UserControlTransactionList();
        UserControlStudentEnrollment studentPage = new UserControlStudentEnrollment();
        UserControlTutorRegistration tutorPage = new UserControlTutorRegistration();
        UserControlSubjectLibrary subjectPage = new UserControlSubjectLibrary();
        UserControlTransactionBilling billingPage = new UserControlTransactionBilling();
        UserControlReceipt receiptPage = new UserControlReceipt();
        UserControlBillHistory billHistoryPage = new UserControlBillHistory();

        public MainForm()
        {
            InitializeComponent();

            newForm.FormClosed += (s, e) => { Refresh(); };  

            transactionStatus.TransactionState();
            TransactionStatus.RefreshRequested += RefreshTransactionGrid;
        }

        private void mainForm_Load(object sender, EventArgs e)
        {
            
        }

        #region Initialization and Refresh

        private void RefreshTransactionGrid()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(RefreshTransactionGrid));
            }
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

        private void RefreshControls(UserControl control)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(control);
            if (control is IRefreshableControl refreshable)
            {
                refreshable.RefreshControl();
            }
            OnFocus();
        }

        private void TransactionListPage_Click(object sender, EventArgs e)
        {
            RefreshControls(transactionPage);
        }

        private void buttonStudentEnrollmentPage_Click(object sender, EventArgs e)
        {
            RefreshControls(studentPage);
        }

        private void buttonTutorRegistrationPage_Click(object sender, EventArgs e)
        {
            RefreshControls(tutorPage);
        }

        private void buttonSubjectLibraryPage_Click(object sender, EventArgs e)
        {
            RefreshControls(subjectPage);
        }

        private void buttonTransactionBillingPage_Click(object sender, EventArgs e)
        {
            RefreshControls(billingPage);
        }

        private void buttonReceiptPage_Click(object sender, EventArgs e)
        {
            RefreshControls(receiptPage);
        }
        private void buttonTransactionHistory_Click(object sender, EventArgs e)
        {
            RefreshControls(billHistoryPage);
        }

        private void OnFocusHandler()
        {
            foreach (Control control in SidePanel.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.FromArgb(249, 250, 251);
                    button.ForeColor = Color.FromArgb(43, 50, 85);
                }
            }
        }

        private void OnFocus()
        {
            var currentControl = panelMainField.Controls.OfType<UserControl>().FirstOrDefault();

            switch (currentControl)
            {
                case UserControlTransactionList:
                    buttonTransactionListPage.BackColor = Color.FromArgb(93, 155, 155);
                    buttonTransactionListPage.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                case UserControlStudentEnrollment:
                    buttonStudentEnrollmentPage.BackColor = Color.FromArgb(93, 155, 155);
                    buttonStudentEnrollmentPage.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                case UserControlTutorRegistration:
                    buttonTutorRegistrationPage.BackColor = Color.FromArgb(93, 155, 155);
                    buttonTutorRegistrationPage.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                case UserControlTutorLedger:
                    //buttonTutorProfileLedgerPage.BackColor = Color.FromArgb(43, 50, 85);
                    break;
                case UserControlSubjectLibrary:
                    buttonSubjectLibraryPage.BackColor = Color.FromArgb(93, 155, 155);
                    buttonSubjectLibraryPage.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                case UserControlTransactionBilling:
                    buttonTransactionBillingPage.BackColor = Color.FromArgb(93, 155, 155);
                    buttonTransactionBillingPage.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                case UserControlReceipt:
                    buttonReceiptPage.BackColor = Color.FromArgb(93, 155, 155);
                    buttonReceiptPage.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                case UserControlBillHistory:
                    buttonBillHistory.BackColor = Color.FromArgb(93, 155, 155);
                    buttonBillHistory.ForeColor = Color.FromArgb(249, 250, 251);
                    break;
                default:
                    break;
            }
        }

        private void panelMainField_ControlRemoved(object sender, ControlEventArgs e)
        {
            transactionPage.Refresh();
            studentPage.Refresh();
            tutorPage.Refresh();
            subjectPage.Refresh();
            receiptPage.Refresh();
            billingPage.Refresh();
        }
    }
}