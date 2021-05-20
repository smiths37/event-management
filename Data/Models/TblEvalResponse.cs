using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalResponse
    {
        public int ResponseId { get; set; }
        public string ResponseDesc { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int? SpeakerId { get; set; }
        public int? EvalId { get; set; }
        public DateTime? EventDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
