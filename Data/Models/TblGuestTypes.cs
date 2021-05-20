using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblGuestTypes
    {
        public int GuestTypeId { get; set; }
        public string GuestTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
