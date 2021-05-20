using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptHistoryParticipant
    {
        public int? PersonId { get; set; }
        public int RegId { get; set; }
        public double? TotalFees { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DatePostedToHistory { get; set; }
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public string RegCode { get; set; }
        public string RegDesc { get; set; }
        public double? RegFee { get; set; }
    }
}
