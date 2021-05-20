using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalResponseEntry
    {
        public int EntryId { get; set; }
        public int? ResponseId { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
