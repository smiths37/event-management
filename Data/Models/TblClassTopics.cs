using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTopics
    {
        public int TopicId { get; set; }
        public int ClassId { get; set; }
        public string TopicDesc { get; set; }
        public string TopicLongDesc { get; set; }
        public short? WebSortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
