using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCreditTypes
    {
        public TblCreditTypes()
        {
            TblMeetingCredits = new HashSet<TblMeetingCredits>();
            TblPeopleCreditTypes = new HashSet<TblPeopleCreditTypes>();
            TblSessionCredits = new HashSet<TblSessionCredits>();
        }

        public string CreditTypeCode { get; set; }
        public int CreditTypeId { get; set; }
        public string CreditTypeDesc { get; set; }
        public string Notes { get; set; }
        public bool? AllowOnWeb { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblMeetingCredits> TblMeetingCredits { get; set; }
        public virtual ICollection<TblPeopleCreditTypes> TblPeopleCreditTypes { get; set; }
        public virtual ICollection<TblSessionCredits> TblSessionCredits { get; set; }
    }
}
