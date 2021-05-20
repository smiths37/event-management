using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblErrorLog
    {
        public int Id { get; set; }
        public DateTime? DateTime { get; set; }
        public string Procedure { get; set; }
        public int? SystemNumber { get; set; }
        public string SystemDescription { get; set; }
        public string Comments { get; set; }
        public string Process { get; set; }
        public string Category { get; set; }
        public string User { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
