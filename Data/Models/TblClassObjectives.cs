using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassObjectives
    {
        public int ObjectiveId { get; set; }
        public int ClassId { get; set; }
        public string ObjectiveDesc { get; set; }
        public string Comments { get; set; }
        public short? WebSortOrder { get; set; }
        public bool? WebDisplayComment { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
