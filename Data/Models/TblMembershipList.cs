using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMembershipList
    {
        public int PersonId { get; set; }
        public int MembershipTypeCode { get; set; }
        public int? CompanyId { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
