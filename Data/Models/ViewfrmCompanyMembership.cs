using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewfrmCompanyMembership
    {
        public int CompanyId { get; set; }
        public int? MembershipId { get; set; }
        public int? ParentMembershipId { get; set; }
        public short? RenewalInterval { get; set; }
        public DateTime? ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public bool? Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? MemberSince { get; set; }
        public DateTime? RenewalNoticeSent { get; set; }
        public DateTime? DateRenewed { get; set; }
        public short? AssociateMemberCount { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public int? MembershipTypeCode { get; set; }
        public string MembershipTypeDescription { get; set; }
        public short? AssociateMembers { get; set; }
        public DateTime? DateRenewalLetterSent { get; set; }
        public short? LastRenewalLetterSent { get; set; }
        public string CancelReason { get; set; }
        public int? PersonId { get; set; }
    }
}
