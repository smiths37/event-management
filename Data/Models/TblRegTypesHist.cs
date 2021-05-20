using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRegTypesHist
    {
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public string RegDesc { get; set; }
        public double? RegistrationFee { get; set; }
        public DateTime? LateFeeDate { get; set; }
        public double? LateRegFee { get; set; }
        public bool Default { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblMeetingsHist MeetingCodeNavigation { get; set; }
    }
}
