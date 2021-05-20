using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCommitteeMembership
    {
        public int PersonId { get; set; }
        public int CommitteeCode { get; set; }
        public DateTime EffectiveDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int PositionCode { get; set; }
        public int? PersonAddressId { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCommitteeCodes CommitteeCodeNavigation { get; set; }
        public virtual TblPeople Person { get; set; }
        public virtual TblCommitteePositionCodes PositionCodeNavigation { get; set; }
    }
}
