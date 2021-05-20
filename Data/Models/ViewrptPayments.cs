using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptPayments
    {
        public string CompanyName { get; set; }
        public string MeetingCode { get; set; }
        public int RegId { get; set; }
        public string Number { get; set; }
        public DateTime? Expires { get; set; }
        public double? Amount { get; set; }
        public DateTime PaymentDate { get; set; }
        public int PaymentTypeId { get; set; }
        public string PaymentTypeDesc { get; set; }
        public int PaymentMethodId { get; set; }
        public string PaymentMethodDesc { get; set; }
        public DateTime? DateProcessed { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string BankName { get; set; }
        public string BankAcctNo { get; set; }
        public string WhoPaidName { get; set; }
        public string WhoPaid { get; set; }
        public string MasterCardMerchNo { get; set; }
        public string VisaMerchNo { get; set; }
        public string DinersClubMerchNo { get; set; }
        public string AmexMerchNo { get; set; }
        public string DiscoverMerchNo { get; set; }
        public string Approval { get; set; }
        public int PaymentId { get; set; }
        public bool? CreditCard { get; set; }
        public string EnteredBy { get; set; }
        public string Pnref { get; set; }
        public int? PersonId { get; set; }
        public string MeetingDesc { get; set; }
    }
}
