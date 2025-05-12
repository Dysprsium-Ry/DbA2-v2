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
            get => "SELECT Username FROM D2.Students";
            set { }
        }

        #endregion

        #region DataProvider

        public static string ECDispTut
        {
            get => "SELECT TutorName, HourlyRate, InTime, OutTime FROM D2.Tutor WHERE Expertise = @item";
            set { }
        }

        public static string TransacListDisp
        {
            get => "SELECT * FROM D2.TransactionList ORDER BY [Created Date]";
            set { }
        }

        #endregion

        #region Transactions

        public static string MaxTransactionIdPerStud
        {
            get => "SELECT MAX(Transaction_Id) FROM D2.Transactions WHERE Student_Name = @Student";
            set { }
        }

        public static string TransactionIdNew
        {
            get => "SELECT MAX(Transaction_Id) FROM D2.Transactions";
            set { }
        }

        public static string MinDraftIdPerStud
        {
            get => "SELECT MIN(Transaction_Id) FROM D2.Transactions WHERE Student_Name = @Student AND Status = 'Draft'";
        }

        public static string MaxDraftId
        {
            get => "SELECT COUNT(1) AS Count FROM D2.Transactions WHERE Student_Name = @Student AND Status = 'Draft'";
        }

        public static string StudentEmail
        {
            get => "SELECT Email FROM D2.Students WHERE Username = @Username";
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

        public static string RegisterTransactions
        {
            get => "D2.RegisterTransactions";
            set { }
        }

        public static string UpdateTransactions
        {
            get => "D2.UpdateTransactions";
            set { }
        }

        public static string RegisterTransactionInformation
        {
            get => "D2.RegisterTransactionInformation";
            set { }
        }

        public static string UpdateTransactionInformation
        {
            get => "D2.UpdateTransactionInformation";
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

        public static string FetchTransactionTotal
        {
            get => "SELECT Total_Value FROM D2.TransactionBilling WHERE Transaction_Id = @Id";
            set { }
        }

        public static string DropItem
        {
            get => "DELETE FROM D2.TransactionInformation where Transaction_Id = @Id AND Subject = @Subject AND Tutor = @Tutor AND Date_Schedule = @Date";
            set { }
        }

        public static string IsTransactionItemExist
        {
            get => "SELECT COUNT(1) FROM D2.TransactionInformation WHERE Transaction_Id = @Id AND Subject = @Subject AND Tutor = @Tutor AND Date_Schedule = @Date";
            set { }
        }
        #endregion

        #region Logics

        public static string IsTutorAvailable
        {
            get => "SELECT COUNT(1) AS Count FROM D2.TransactionInformation WHERE Tutor = @Tutor AND Time_Period_Begin = @inTime AND Time_Period_End = @outTime AND Date_Schedule = @date AND Transaction_State = 'Active'";
        }

        public static string IsTransactionIdExist
        {
            get => "SELECT COUNT(1) FROM D2.Transactions WHERE Transaction_Id = @Id";
            set { }
        }
        public static string IsStudentNameExist
        {
            get => "SELECT COUNT(1) FROM D2.Students WHERE Username = @name";
            set { }
        }
        #endregion
    }
}
