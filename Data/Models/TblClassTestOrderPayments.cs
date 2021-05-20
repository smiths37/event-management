using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTestOrderPayments
    {
        public int PaymentId { get; set; }
        public int TestOrderId { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentTypeId { get; set; }
        public int PaymentMethodId { get; set; }
        public double? Amount { get; set; }
        public string Number { get; set; }
        public DateTime? Expires { get; set; }
        public string ExpMonth { get; set; }
        public string ExpYear { get; set; }
        public string Approval { get; set; }
        public string WhoPaid { get; set; }
        public string WhoPaidName { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string Pnref { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassTestOrder TestOrder { get; set; }
    }
}
