using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPeopleCreditTypes
    {
        public int PersonId { get; set; }
        public string CreditTypeCode { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCreditTypes CreditTypeCodeNavigation { get; set; }
    }
}
