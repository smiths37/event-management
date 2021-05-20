using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassInstructors
    {
        public int Id { get; set; }
        public int InstructorId { get; set; }
        public int ClassId { get; set; }
        public bool AllowOnWeb { get; set; }
        public short? WebSortOrder { get; set; }
        public string Comments { get; set; }
        public bool? WebDisplayComment { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
