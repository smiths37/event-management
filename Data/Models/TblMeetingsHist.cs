using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMeetingsHist
    {
        public TblMeetingsHist()
        {
            TblRegHistory = new HashSet<TblRegHistory>();
            TblRegTypesHist = new HashSet<TblRegTypesHist>();
            TblSessionsHist = new HashSet<TblSessionsHist>();
        }

        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public string LongDescription { get; set; }
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
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblRegHistory> TblRegHistory { get; set; }
        public virtual ICollection<TblRegTypesHist> TblRegTypesHist { get; set; }
        public virtual ICollection<TblSessionsHist> TblSessionsHist { get; set; }
    }
}
