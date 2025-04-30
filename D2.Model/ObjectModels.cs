using _3_13_25.D2.DataModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlTypes;
using System.Linq;
using System.Runtime.CompilerServices;

namespace BienvenidoOnlineTutorServices.D2.Objects
{
    public class ObjectModels
    {
        public class DataId
        {
            public static long StudentId { get; set; }
            public static long TutorId { get; set; }
            public static long SubjectId { get; set; }
        }
        public class Enrollment
        {
            public static long TransactionId { get; set; }
            public static string StudentName { get; set; }
            public static string StudentEmail { get; set; }
            public static string TutorName { get; set; }
            public static string Subject { get; set; }
            public static DateTime SessionScheduleDate { get; set; }
            public static TimeSpan StartSchedule { get; set; }
            public static TimeSpan EndSchedule { get; set; }
            public static decimal HourlyRate { get; set; }
            public static decimal TotalFee { get; set; }
            public static string TransactionState { get; set; }
        }
        public class PreferredSubject
        {
            public long TransactionId { get; set; }
            public string StudentName { get; set; }
            public long StudentId { get; set; }
            public string TutorName { get; set; }
            public long TutorId { get; set; }
            public string Subject { get; set; }
            public long SubjectId { get; set; }
            public DateTime SessionScheduleDate { get; set; }
            public TimeSpan SessionScheduleTime { get; set; }
            public int SessionDuration { get; set; }
            public DateTime SessionEndSchedule { get; set; }
            public decimal HourlyRate { get; set; }
            public decimal TotalFee { get; set; }
            public decimal PaymentFee { get; set; }
            public decimal RemainingFee { get; set; }
            public string PaymentStatus { get; set; }
            public override bool Equals(object obj)
            {
                if (obj == null || GetType() != obj.GetType())
                {
                    return false;
                }
                PreferredSubject other = (PreferredSubject)obj;

                return Subject == other.Subject && SessionScheduleDate == other.SessionScheduleDate;
                //&& BookedDate == other.BookedDate; && RentedDuration == other.RentedDuration && HourlyRate == other.HourlyRate && TotalFee == other.TotalFee;
            }
            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + (Subject?.GetHashCode() ?? 0);
                    hash = hash * 23 + SessionScheduleDate.GetHashCode();
                    return hash;
                }
            }
        }
        public class TemporalData
        {
            public static List<PreferredSubject> SubjectList = new List<PreferredSubject>();
            public static long TransactionId { get; set; }
            public static string Status { get; set; }
            public static string StudentLUserN { get; set; }
            public static string StudentFirstName { get; set; }
            public static string StudentLastName { get; set; }
            public static long StudentId { get; set; }
            public static string StudentEmail { get; set; }
            public static string StudentLevel { get; set; }
            public static string TutorName { get; set; }
            public static long TutorId { get; set; }
            public static string TutorEmail { get; set; }
            public static string Subject { get; set; }
            public static long SubjectId { get; set; }
            public static DateTime SessionScheduleDate { get; set; }
            public static TimeSpan SessionScheduleTime { get; set; }
            public static int SessionDuration { get; set; }
            public static DateTime SessionEndSchedule { get; set; }
            public static decimal HourlyRate { get; set; }
            public static decimal SessionTotal { get; set; }
            public static decimal TotalFee { get; set; }
            public static decimal OverallTotalFee { get; set; }
            public static decimal PaymentFee { get; set; }
            public static decimal RemainingFee { get; set; }
            public static string PaymentStatus { get; set; }
            public static TimeSpan InTime { get; set; }
            public static TimeSpan OutTime { get; set; }

            public static void Clear()
            {
                SubjectList.Clear();
                TransactionId = 0;
                Status = null;
                StudentLUserN = null;
                StudentId = 0;
                StudentEmail = null;
                TutorName = null;
                TutorId = 0;
                TutorEmail = null;
                Subject = null;
                SubjectId = 0;
                SessionScheduleDate = default;
                SessionScheduleTime = default;
                SessionDuration = 0;
                SessionEndSchedule = default;
                HourlyRate = 0;
                SessionTotal = 0;
                TotalFee = 0;
                OverallTotalFee = 0;
                PaymentFee = 0;
                RemainingFee = 0;
                PaymentStatus = null;
                InTime = default;
                OutTime = default;
            }
        }
        public class TransacObj
        {
            public static long TransacId { get; set; }
            public static decimal PayFee { get; set; }
            public static decimal TotalFee { get; set; }
            public static decimal RemainingFee { get; set; }
            public static string Student { get; set; }
            public static string Subject { get; set; }
            public static string Tutor { get; set; }
        }
        public class BillingObj
        {
            public static long TransactionId { get; set; }
            public static long EnrollmentId { get; set; }
            public static long SubjectId { get; set; }
            public static decimal Pay { get; set; }
            public static decimal PayFee { get; set; }
            public static decimal RemainingBalance { get; set; }
            public static decimal TotalFee { get; set; }
            public static String Tutor { get; set; }
            public static String Subject { get; set; }
            public static String Student { get; set; }
            public static DateTime SessionSchedule { get; set; }
        }

        public class ReceiptObject
        {
            public long TransactionId { get; set; }
            public string Student { get; set; }
            public string Subject { get; set; }
            public string Tutor { get; set; }
            public decimal TotalFee { get; set; }
            public decimal TotalAmountFee { get; set; }
            public decimal PaidAmount { get; set; }
            public DateTime ScheduledDate { get; set; }
        }

        public class TutorDetails
        {
            public string TutorName { get; set; }
            public string Expertise { get; set; }
            public decimal HourlyRate { get; set; }
            public TimeSpan InTime { get; set; }
            public TimeSpan OutTime { get; set; }
        }

        public class ReceiptStaticClass
        {
            public static List<ReceiptObject> ReceiptList = new List<ReceiptObject>();
            public static long TransactionId { get; set; }
            public static string StudentName { get; set; }
            public static string Subject { get; set; }
            public static string TutorName { get; set; }
            public static SqlMoney TotalAmountFee { get; set; }
            public static SqlMoney PaidAmount { get; set; }
            public static string Status { get; set; }
        }

        public class QueuedItems : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            private long _transactionId;
            private string _subject;
            private string _tutor;
            private decimal _hourlyRate;
            private DateTime _sessionScheduleDate;
            private TimeSpan _startSchedule;
            private TimeSpan _endSchedule;
            private string _status;

            public long TransactionId
            {
                get => _transactionId;
                set
                {
                    if (_transactionId != value)
                    {
                        _transactionId = value;
                        OnPropertyChanged();
                    }
                }
            }

            public string Subject
            {
                get => _subject;
                set
                {
                    if (_subject != value)
                    {
                        _subject = value;
                        OnPropertyChanged();
                    }
                }
            }

            public string Tutor
            {
                get => _tutor;
                set
                {
                    if (_tutor != value)
                    {
                        _tutor = value;
                        OnPropertyChanged();
                    }
                }
            }

            public decimal HourlyRate
            {
                get => _hourlyRate;
                set
                {
                    if (_hourlyRate != value)
                    {
                        _hourlyRate = value;
                        OnPropertyChanged();
                    }
                }
            }

            public DateTime SessionScheduleDate
            {
                get => _sessionScheduleDate;
                set
                {
                    if (_sessionScheduleDate != value)
                    {
                        _sessionScheduleDate = value;
                        OnPropertyChanged();
                    }
                }
            }

            public TimeSpan StartSchedule
            {
                get => _startSchedule;
                set
                {
                    if (_startSchedule != value)
                    {
                        _startSchedule = value;
                        OnPropertyChanged();
                    }
                }
            }

            public TimeSpan EndSchedule
            {
                get => _endSchedule;
                set
                {
                    if (_endSchedule != value)
                    {
                        _endSchedule = value;
                        OnPropertyChanged();
                    }
                }
            }

            public string Status
            {
                get => _status;
                set
                {
                    if (_status != value)
                    {
                        _status = value;
                        OnPropertyChanged();
                    }
                }
            }

            public override bool Equals(object obj)
            {
                if (obj is not QueuedItems other)
                    return false;

                return TransactionId == other.TransactionId &&
                       Subject == other.Subject &&
                       Tutor == other.Tutor &&
                       HourlyRate == other.HourlyRate &&
                       SessionScheduleDate == other.SessionScheduleDate &&
                       StartSchedule == other.StartSchedule &&
                       EndSchedule == other.EndSchedule &&
                       Status == other.Status;
            }

            public override int GetHashCode()
            {
                unchecked
                {
                    int hash = 17;
                    hash = hash * 23 + TransactionId.GetHashCode();
                    hash = hash * 23 + (Subject?.GetHashCode() ?? 0);
                    hash = hash * 23 + (Tutor?.GetHashCode() ?? 0);
                    hash = hash * 23 + HourlyRate.GetHashCode();
                    hash = hash * 23 + SessionScheduleDate.GetHashCode();
                    hash = hash * 23 + StartSchedule.GetHashCode();
                    hash = hash * 23 + EndSchedule.GetHashCode();
                    hash = hash * 23 + (Status?.GetHashCode() ?? 0);
                    return hash;
                }
            }
        }

        public class QueuedItemList : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            protected void OnPropertyChanged(string propertyName)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }

            public static BindingList<QueuedItems> QueuedItemsBindingList = new BindingList<QueuedItems>();

            public static Dictionary<long, BindingList<QueuedItems>> TransactionQueues = new();
            public static BindingList<QueuedItems>GetQueueForDate(long Transaction_Id)
            {
                if (!TransactionQueues.ContainsKey(Transaction_Id))
                {
                    TransactionQueues[Transaction_Id] = new BindingList<QueuedItems>();
                }
                return TransactionQueues[Transaction_Id];
            }
        }

        #region editModels

        public class EditItemList
        {
            public long TransactionId { get; set; }
            public string Subject { get; set; }
            public string Tutor { get; set; }
            public decimal EditHourlyRate { get; set; }
            public TimeSpan EditStartTime { get; set; }
            public TimeSpan EditEndTime { get; set; }
            public DateTime EditScheduleDate { get; set; }
        }

        public class EditItemListCollection
        {
            public static List<EditItemList> EditItemsList = new List<EditItemList>();
            public static string EditSubject { get; set; }
            public static string EditTutor { get; set; }
            public static decimal EditHourlyRate { get; set; }
            public static TimeSpan EditStartTime { get; set; }
            public static TimeSpan EditEndTime { get; set; }
            public static DateTime EditScheduleDate { get; set; }
        }

        #endregion

        #region FilterableBindingList

        public class FilterableBindingList<T> : BindingList<T>
        {
            private List<T> _originalList;
            private Func<T, bool> _filter;

            public FilterableBindingList(IEnumerable<T> items) : base(new List<T>(items))
            {
                _originalList = new List<T>(items);
            }

            public void ApplyFilter(Func<T, bool> predicate)
            {
                _filter = predicate;
                RaiseListChangedEvents = false;
                ClearItems();
                foreach (var item in _originalList.Where(_filter))
                {
                    Add(item);
                }
                RaiseListChangedEvents = true;
                ResetBindings();
            }

            public void ClearFilter()
            {
                ApplyFilter(x => true);
            }

            public void RefreshFilter()
            {
                if (_filter != null)
                    ApplyFilter(_filter);
            }

            public void AddOriginal(T item)
            {
                _originalList.Add(item);
                if (_filter == null || _filter(item))
                    Add(item);
            }
        }

        #endregion
    }
}
