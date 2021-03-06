using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewfrmMembership
    {
        public int MembershipId { get; set; }
        public int? PersonId { get; set; }
        public int? CompanyId { get; set; }
        public int? OrderId { get; set; }
        public int? ParentMembershipId { get; set; }
        public string RefId { get; set; }
        public int MembershipTypeCode { get; set; }
        public short? RenewalInterval { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime ValidTo { get; set; }
        public bool Status { get; set; }
        public DateTime? StatusDate { get; set; }
        public DateTime? MemberSince { get; set; }
        public bool Chapter { get; set; }
        public DateTime? RenewalNoticeSent { get; set; }
        public DateTime? DateRenewed { get; set; }
        public short? AssociateMemberCount { get; set; }
        public DateTime? DateRenewalLetterSent { get; set; }
        public short? LastRenewalLetterSent { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string CancelReason { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string MembershipTypeDescription { get; set; }
        public short? MembershipGroup { get; set; }
        public short? AssociateMembers { get; set; }
        public string CompanyName { get; set; }
        public int? ParentMembershipCompanyId { get; set; }
        public string ParentMembershipCompanyName { get; set; }
    }
}
