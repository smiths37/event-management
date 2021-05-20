using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalSections
    {
        public int SectionId { get; set; }
        public int EvalId { get; set; }
        public int? SectionNumber { get; set; }
        public string SectionTitle { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
