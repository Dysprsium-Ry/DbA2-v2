using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_25.D2.Model
{
    public class ExpertiseList : INotifyPropertyChanged
    {
        private long _subjectId;
        private string _subject;
        private decimal _hourlyRate;
        private TimeSpan _inTime;
        private TimeSpan _outTime;

        public long SubjectId
        {
            get => _subjectId;
            set
            {
                if (_subjectId != value)
                {
                    _subjectId = value;
                    OnPropertyChanged(nameof(SubjectId));
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
                    OnPropertyChanged(nameof(Subject));
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
                    if (_hourlyRate == value) return;
                    _hourlyRate = value;
                    OnPropertyChanged(nameof(HourlyRate));
                }
            }
        }

        public TimeSpan InTime
        {
            get => _inTime;
            set
            {
                if (_inTime != value)
                {
                    _inTime = value;
                    OnPropertyChanged(nameof(InTime));
                }
            }
        }

        public TimeSpan OutTime
        {
            get => _outTime;
            set
            {
                if (_outTime != value)
                {
                    _outTime = value;
                    OnPropertyChanged(nameof(OutTime));
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }

    public static class Expertise
    {
        public static BindingList<ExpertiseList> expertiseLists = new BindingList<ExpertiseList>();
    }
}
