using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDupeContacts
    {
        public int ContactId { get; set; }
        public int? PersonId { get; set; }
        public int? MembershipId { get; set; }
        public int? ContactMethodCode { get; set; }
        public int ContactTypeCode { get; set; }
        public DateTime ContactDate { get; set; }
        public int? RepId { get; set; }
        public DateTime? NextContactDate { get; set; }
        public string Comments { get; set; }
        public string Commitments { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public bool MembershipRenewalContact { get; set; }
        public int? StatusId { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
