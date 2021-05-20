using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCertificateMeetingCreditsSub
    {
        public int? PersonId { get; set; }
        public string CreditTypeCode { get; set; }
        public double? CreditUnits { get; set; }
        public string CreditTypeDesc { get; set; }
        public string MeetingCode { get; set; }
    }
}
