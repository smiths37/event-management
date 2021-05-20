using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblUserDefaults
    {
        public string UserId { get; set; }
        public bool ComboDrop { get; set; }
        public bool AutoGeneratePeople { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
