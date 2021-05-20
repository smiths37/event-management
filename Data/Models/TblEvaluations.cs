using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluations
    {
        public int EvalId { get; set; }
        public string EvalDescription { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
