using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCommitteePositionCodes
    {
        public TblCommitteePositionCodes()
        {
            TblCommitteeMembership = new HashSet<TblCommitteeMembership>();
        }

        public int PositionCode { get; set; }
        public string PositionDescription { get; set; }
        public short? PositionOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCommitteeMembership> TblCommitteeMembership { get; set; }
    }
}
