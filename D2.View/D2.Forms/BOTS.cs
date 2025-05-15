using _3_13_25.D2.Classes;
using _3_13_25.D2.DbConn;
using _3_13_25.D2.IdFetcherClasses;
using _3_13_25.D2.QueryStorage;
using _3_13_25.D2.View.D2.MainFormV;
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
        UserControlTutorLedger tutorLedgerPage = new UserControlTutorLedger();
        UserControlSubjectLibrary subjectPage = new UserControlSubjectLibrary();
        UserControlTransactionBilling billingPage = new UserControlTransactionBilling();
        UserControlReceipt receiptPage = new UserControlReceipt();

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

        private void TransactionListPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(transactionPage);
            OnFocus();
        }

        private void buttonStudentEnrollmentPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(studentPage);
            OnFocus();
        }

        private void buttonTutorRegistrationPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(tutorPage);
            OnFocus();
        }

        private void buttonTutorProfileLedgerPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(tutorLedgerPage);
            OnFocus();
        }

        private void buttonSubjectLibraryPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(subjectPage);
            OnFocus();
        }

        private void buttonTransactionBillingPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(billingPage);
            OnFocus();
        }

        private void buttonReceiptPage_Click(object sender, EventArgs e)
        {
            OnFocusHandler();
            panelMainField.Controls.Clear();
            panelMainField.Controls.Add(receiptPage);
            OnFocus();
        }

        private void OnFocusHandler()
        {
            foreach (Control control in SidePanel.Controls)
            {
                if (control is Button button)
                {
                    button.BackColor = Color.PaleTurquoise;
                }
            }
        }

        private void OnFocus()
        {
            var currentControl = panelMainField.Controls.OfType<UserControl>().FirstOrDefault();

            switch (currentControl)
            {
                case UserControlTransactionList:
                    buttonTransactionListPage.BackColor = Color.DarkTurquoise;
                    break;
                case UserControlStudentEnrollment:
                    buttonStudentEnrollmentPage.BackColor = Color.DarkTurquoise;
                    break;
                case UserControlTutorRegistration:
                    buttonTutorRegistrationPage.BackColor = Color.DarkTurquoise;
                    break;
                case UserControlTutorLedger:
                    //buttonTutorProfileLedgerPage.BackColor = Color.DarkTurquoise;
                    break;
                case UserControlSubjectLibrary:
                    buttonSubjectLibraryPage.BackColor = Color.DarkTurquoise;
                    break;
                case UserControlTransactionBilling:
                    buttonTransactionBillingPage.BackColor = Color.DarkTurquoise;
                    break;
                case UserControlReceipt:
                    buttonReceiptPage.BackColor = Color.DarkTurquoise;
                    break;
                default:
                    break;
            }
        }
    }
}