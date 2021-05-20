using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblgtpConfig
    {
        public string Unique { get; set; }
        public bool? Enabled { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
