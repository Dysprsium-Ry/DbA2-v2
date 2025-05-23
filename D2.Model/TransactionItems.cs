using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_25.D2.Model
{
    public class TransactionItems : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private long _transactionId;
        private long _subjectId;
        private string _subject;
        private long _tutorId;
        private string _tutorName;
        private decimal _hourlyRate;
        private DateTime _sessionScheduleDate;
        private TimeSpan _startSchedule;
        private TimeSpan _endSchedule;
        private string _status;
        private decimal _totalFee;

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

        public long SubjectId
        {
            get => _subjectId;
            set
            {
                if (_subjectId != value)
                {
                    _subjectId = value;
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

        public long Tutor
        {
            get => _tutorId;
            set
            {
                if (_tutorId != value)
                {
                    _tutorId = value;
                    OnPropertyChanged();
                }
            }
        }

        public string TutorName
        {
            get => _tutorName;
            set
            {
                if (_tutorName != value)
                {
                    _tutorName = value;
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

        public decimal TotalFee
        {
            get => _totalFee;
            set
            {
                if (_totalFee != value)
                {
                    _totalFee = value;
                    OnPropertyChanged();
                }
            }
        }

        public override bool Equals(object obj)
        {
            if (obj is not TransactionItems other)
                return false;

            return TransactionId == other.TransactionId &&
                   SubjectId == other.SubjectId &&
                   Subject == other.Subject &&
                   Tutor == other.Tutor &&
                   TutorName == other.TutorName &&
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
                hash = hash * 23 + SubjectId.GetHashCode();
                hash = hash * 23 + (Subject?.GetHashCode() ?? 0);
                hash = hash * 23 + Tutor.GetHashCode();
                hash = hash * 23 + (TutorName?.GetHashCode() ?? 0);
                hash = hash * 23 + HourlyRate.GetHashCode();
                hash = hash * 23 + SessionScheduleDate.GetHashCode();
                hash = hash * 23 + StartSchedule.GetHashCode();
                hash = hash * 23 + EndSchedule.GetHashCode();
                hash = hash * 23 + (Status?.GetHashCode() ?? 0);
                return hash;
            }
        }
    }

    public class TransactionItemList : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public static BindingList<TransactionItems> BindingList = new BindingList<TransactionItems>();

        public static Dictionary<long, BindingList<TransactionItems>> TransactionQueues = new();

        public static BindingList<TransactionItems> DictionaryList(long Transaction_Id)
        {
            if (!TransactionQueues.ContainsKey(Transaction_Id))
            {
                TransactionQueues[Transaction_Id] = new BindingList<TransactionItems>();
            }
            return TransactionQueues[Transaction_Id];
        }
    }
}
