using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPaymentsHist
    {
        public int HistId { get; set; }
        public int PaymentId { get; set; }
        public int RegId { get; set; }
        public DateTime PaymentDate { get; set; }
        public string PaymentType { get; set; }
        public string PaymentMethod { get; set; }
        public string Number { get; set; }
        public DateTime? Expires { get; set; }
        public string Approval { get; set; }
        public double? Amount { get; set; }
        public DateTime? DateProcessed { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblRegHistory TblRegHistory { get; set; }
    }
}
