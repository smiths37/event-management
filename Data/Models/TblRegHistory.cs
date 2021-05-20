using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRegHistory
    {
        public TblRegHistory()
        {
            TblPaymentsHist = new HashSet<TblPaymentsHist>();
        }

        public int HistId { get; set; }
        public int? PersonId { get; set; }
        public int RegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Dept { get; set; }
        public string BadgeName { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Country { get; set; }
        public int? Source { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string PreOrOnSite { get; set; }
        public bool Attended { get; set; }
        public bool AttendeeList { get; set; }
        public DateTime? RegDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public double? RegFee { get; set; }
        public double? TotalFees { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public int? AddressId { get; set; }
        public string AddressType { get; set; }
        public DateTime? DateBadgePrinted { get; set; }
        public DateTime? DatePostedToHistory { get; set; }
        public DateTime? DateCancelled { get; set; }
        public DateTime? DateCancellationProcessed { get; set; }
        public double? CancellationFee { get; set; }
        public double? RefundAmount { get; set; }
        public double? BalanceDue { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblMeetingsHist MeetingCodeNavigation { get; set; }
        public virtual ICollection<TblPaymentsHist> TblPaymentsHist { get; set; }
    }
}
