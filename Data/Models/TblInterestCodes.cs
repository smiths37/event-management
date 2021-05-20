using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblInterestCodes
    {
        public TblInterestCodes()
        {
            TblCongressInterests = new HashSet<TblCongressInterests>();
            TblInterests = new HashSet<TblInterests>();
        }

        public int InterestCode { get; set; }
        public string InterestDescription { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCongressInterests> TblCongressInterests { get; set; }
        public virtual ICollection<TblInterests> TblInterests { get; set; }
    }
}
