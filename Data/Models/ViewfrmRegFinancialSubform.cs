using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewfrmRegFinancialSubform
    {
        public string RegDesc { get; set; }
        public double? HousingCharges { get; set; }
        public double? SessionFees { get; set; }
        public double? GuestFees { get; set; }
        public double? GuestSessionFees { get; set; }
        public double? PaymentAmt { get; set; }
        public int RegId { get; set; }
        public double? RegistrationFee { get; set; }
        public double? RegFee { get; set; }
        public double? CancellationFee { get; set; }
        public DateTime? DateCancelled { get; set; }
        public double? RefundAmount { get; set; }
        public DateTime? DateRefundProcessed { get; set; }
    }
}
