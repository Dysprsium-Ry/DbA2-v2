using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_25.D2.QueryStorage
{
    public class Queries
    {

        #region SearchBarFunction

        public static string studListSbar
        {
            get => "SELECT StudentName, StudentEmail FROM D2.Students WHERE (@item IS NULL OR @item = '' OR @item = ' ') OR StudentName LIKE @item";
            set { }
        }

        public static string tutSubSBar
        {
            get => "SELECT TutorName, HourlyRate FROM D2.Tutor WHERE (@item IS NULL OR @item = '' OR @item = ' ') OR Expertise LIKE @item";
            set { }
        }

        public static string tutListSbar
        {
            get => "SELECT TutorName, Expertise, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE (@item IS NULL OR @item = '' OR @item = ' ') OR TutorName LIKE @item";
            set { }
        }

        public static string transacListBar
        {
            get => "D2.TransactionListSearchBar";
            set { }
        }

        public static string SearchTransactList
        {
            get => "D2.SearchTransactionList";
            set { }
        }

        public static string studentList
        {
            get => "SELECT StudUsername FROM D2.Students";
            set { }
        }

        #endregion

        #region DataGridView

        public static string ECDispTut
        {
            get => "SELECT TutorName, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE Expertise = @item";
            set { }
        }

        public static string TransacListDisp
        {
            get => "SELECT * FROM D2.TransactionList";
            set { }
        }

        #endregion

        #region NewTransactionsQuery

        public static string TransactionIdExisting
        {
            get => "SELECT MAX(Transaction_Id) FROM D2.Transactions WHERE Student_Name = @Student";
            set { }
        }

        public static string TransactionIdNew
        {
            get => "SELECT MAX(Transaction_Id) FROM D2.Transactions";
            set { }
        }

        public static string StudentEmail
        {
            get => "SELECT StudentEmail FROM D2.Students WHERE StudUsername = @StudUsername";
            set { }
        }

        public static string Subjects
        {
            get => "SELECT Subject FROM D2.Subject";
            set { }
        }

        public static string Tutors
        {
            get => "SELECT TutorName, Expertise, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE Expertise = @subject";
            set { }
        }

        #endregion

        #region Enrollment

        public static string RegisterTransaction
        {
            get => "D2.RegisterTransactions";
            set { }
        }

        public static string RegisterTransactionInformation
        {
            get => "D2.RegisterTransactionInformation";
            set { }
        }

        public static string RegisterTransactionBilling
        {
            get => "D2.RegisterTransactionBilling";
            set { }
        }

        public static string SearchTransactionList
        {
            get => "D2.SearchTransactionList";
            set { }
        }
        #endregion

        #region EditFunctions

        public static string FetchTransactionInformation
        {
            get => "SELECT * FROM D2.TransactionInformation WHERE Transaction_Id = @Id";
            set { }
        }

        #endregion
    }
}
