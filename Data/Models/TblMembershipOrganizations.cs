using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMembershipOrganizations
    {
        public int MembOrgId { get; set; }
        public string MembOrgDescription { get; set; }
        public bool Chapter { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
