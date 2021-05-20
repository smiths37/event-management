using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCommitteeCodes
    {
        public TblCommitteeCodes()
        {
            TblCommitteeMembership = new HashSet<TblCommitteeMembership>();
        }

        public int CommitteeCode { get; set; }
        public string CommitteeDescription { get; set; }
        public DateTime? InceptDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCommitteeMembership> TblCommitteeMembership { get; set; }
    }
}
