using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptOrigPaymentInfoSub
    {
        public DateTime PaymentDate { get; set; }
        public int PaymentTypeId { get; set; }
        public int PaymentMethodId { get; set; }
        public string Number { get; set; }
        public DateTime? Expires { get; set; }
        public string Approval { get; set; }
        public double? Amount { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string WhoPaid { get; set; }
        public string WhoPaidName { get; set; }
        public string PaymentMethodDesc { get; set; }
        public string PaymentTypeDesc { get; set; }
        public int PaymentId { get; set; }
        public int RegId { get; set; }
    }
}
