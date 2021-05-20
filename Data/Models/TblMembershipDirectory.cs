using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMembershipDirectory
    {
        public int DirectoryId { get; set; }
        public int MembershipId { get; set; }
        public string MembershipDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
