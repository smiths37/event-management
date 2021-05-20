using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptsubResponseHeader
    {
        public int ResponseId { get; set; }
        public string ResponseDesc { get; set; }
        public int? EvalId { get; set; }
        public DateTime? EventDate { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int? SpeakerId { get; set; }
        public string MeetingDesc { get; set; }
        public string Description { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
    }
}
