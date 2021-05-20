using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSessionsHist
    {
        public string SessionCode { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string MeetingCode { get; set; }
        public string Location { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? Fee { get; set; }
        public double? Limit { get; set; }
        public double? Registered { get; set; }
        public double? Ceu { get; set; }
        public string BudgetCode { get; set; }
        public bool Ticketed { get; set; }
        public int? SetupId { get; set; }
        public string SetupNotes { get; set; }
        public string PersonResponsible { get; set; }
        public string Comments { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblMeetingsHist MeetingCodeNavigation { get; set; }
    }
}
