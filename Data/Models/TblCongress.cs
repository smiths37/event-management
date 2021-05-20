using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCongress
    {
        public TblCongress()
        {
            TblCongressCommitteeAssignments = new HashSet<TblCongressCommitteeAssignments>();
            TblCongressInterests = new HashSet<TblCongressInterests>();
            TblVotingRecord = new HashSet<TblVotingRecord>();
        }

        public int RepId { get; set; }
        public string DistrictId { get; set; }
        public int? GovTypeCode { get; set; }
        public DateTime? DateElected { get; set; }
        public int? Term { get; set; }
        public string Prefix { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string Suffix { get; set; }
        public int? Party { get; set; }
        public string CongressionalAddress1 { get; set; }
        public string CongressionalAddress2 { get; set; }
        public string CongressCity { get; set; }
        public string CongressState { get; set; }
        public string CongressZip { get; set; }
        public string Phone1 { get; set; }
        public string Phone2 { get; set; }
        public string Fax { get; set; }
        public string EMailAddress { get; set; }
        public string BldgRoom { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCongressionalDistricts District { get; set; }
        public virtual TblGovernmentTypes GovTypeCodeNavigation { get; set; }
        public virtual TblPartyCodes PartyNavigation { get; set; }
        public virtual ICollection<TblCongressCommitteeAssignments> TblCongressCommitteeAssignments { get; set; }
        public virtual ICollection<TblCongressInterests> TblCongressInterests { get; set; }
        public virtual ICollection<TblVotingRecord> TblVotingRecord { get; set; }
    }
}
