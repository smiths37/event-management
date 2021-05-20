using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMembershipHistory
    {
        public int MembHistId { get; set; }
        public int MembershipId { get; set; }
        public int? PersonId { get; set; }
        public int? CompanyId { get; set; }
        public int? ParentMembershipId { get; set; }
        public int MembershipTypeCode { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public decimal? TotalDue { get; set; }
        public decimal? AmountPaid { get; set; }
        public short? Term { get; set; }
        public DateTime? DateRenewalLetterSent { get; set; }
        public short? LastRenewalLetterSent { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
