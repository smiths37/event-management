using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblOrderTypes
    {
        public short OrderTypeId { get; set; }
        public string OrderTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
