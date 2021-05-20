using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCongressCommitteeAssignments
    {
        public int RepId { get; set; }
        public int Committee { get; set; }
        public int? Position { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCongressCommittees CommitteeNavigation { get; set; }
        public virtual TblCongress Rep { get; set; }
    }
}
