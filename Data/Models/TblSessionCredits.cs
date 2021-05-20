using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSessionCredits
    {
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public string CreditTypeCode { get; set; }
        public double? CreditUnits { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCreditTypes CreditTypeCodeNavigation { get; set; }
        public virtual TblSessions TblSessions { get; set; }
    }
}
