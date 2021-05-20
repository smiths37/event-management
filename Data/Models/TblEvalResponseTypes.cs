using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalResponseTypes
    {
        public int ResponseType { get; set; }
        public string ResponseDesc { get; set; }
        public string Heading { get; set; }
        public string ChoiceDisplay { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
