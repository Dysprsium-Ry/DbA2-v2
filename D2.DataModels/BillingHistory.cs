using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_13_25.D2.DataModels
{
    public class BillingHistory
    {
        public long TransactionId { get; set; }
        public decimal TotalValue { get; set; }
        public decimal Amount { get; set; }
        public string Status { get; set; }
        public DateTime TransactionDate { get; set; }
    }
}
