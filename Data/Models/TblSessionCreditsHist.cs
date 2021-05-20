using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSessionCreditsHist
    {
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public string CreditTypeCode { get; set; }
        public double? CreditUnits { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
