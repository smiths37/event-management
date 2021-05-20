using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDefaultMeetings
    {
        public string UserName { get; set; }
        public string MeetingCode { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
