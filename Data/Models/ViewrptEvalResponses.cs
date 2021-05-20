using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptEvalResponses
    {
        public int ResponseId { get; set; }
        public string ResponseDesc { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int? SpeakerId { get; set; }
        public int? EvalId { get; set; }
        public DateTime? EventDate { get; set; }
        public string EvalDescription { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
    }
}
