using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCreditStatsUnionMeetings
    {
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public string MeetingLocation { get; set; }
        public string DefaultRegistrationCode { get; set; }
        public double? EarlyCancellationAmt { get; set; }
        public DateTime? CancellationDate { get; set; }
        public double? LateCancellationAmt { get; set; }
        public int? NumberAttending { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
