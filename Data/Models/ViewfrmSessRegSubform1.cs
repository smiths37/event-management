using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewfrmSessRegSubform1
    {
        public int SessRegId { get; set; }
        public int PrimaryRegId { get; set; }
        public int RegId { get; set; }
        public string MeetingCode { get; set; }
        public string Description { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string SessionCode { get; set; }
        public double? Available { get; set; }
        public double? Attending { get; set; }
        public double? Fee { get; set; }
    }
}
