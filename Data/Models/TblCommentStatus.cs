using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCommentStatus
    {
        public int StatusCode { get; set; }
        public string Status { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
