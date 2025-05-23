using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_25.D2.Model
{
    public class WeeklyScheduleSource
    {
        public long TransactionId { get; set; }
        public long SubjectId { get; set; }
        public string Subject { get; set; }
        public long TutorId { get; set; }
        public string TutorName { get; set; }
        public decimal HourlyRate { get; set; }
        public DateTime SessionScheduleDate { get; set; }
        public TimeSpan StartSchedule { get; set; }
        public TimeSpan EndSchedule { get; set; }
        public string Status { get; set; }
    }
}
