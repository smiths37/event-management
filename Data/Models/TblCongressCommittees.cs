using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCongressCommittees
    {
        public TblCongressCommittees()
        {
            TblCongressCommitteeAssignments = new HashSet<TblCongressCommitteeAssignments>();
        }

        public int CommitteeId { get; set; }
        public string CommitteeName { get; set; }
        public string CommitteeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCongressCommitteeAssignments> TblCongressCommitteeAssignments { get; set; }
    }
}
