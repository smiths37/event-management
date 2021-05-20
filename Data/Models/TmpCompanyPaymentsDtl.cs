using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TmpCompanyPaymentsDtl
    {
        public int? RegId { get; set; }
        public string Name { get; set; }
        public int? CompanyId { get; set; }
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public DateTime? RegDate { get; set; }
        public decimal? TotalAmtDue { get; set; }
        public decimal? PaidToDate { get; set; }
        public decimal? BalanceDue { get; set; }
        public decimal? PaymentAmt { get; set; }
        public bool? Pay { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
    }
}
