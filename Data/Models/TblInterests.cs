using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblInterests
    {
        public int PersonId { get; set; }
        public int InterestCode { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblInterestCodes InterestCodeNavigation { get; set; }
        public virtual TblPeople Person { get; set; }
    }
}
