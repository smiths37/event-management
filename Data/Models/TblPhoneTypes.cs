using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPhoneTypes
    {
        public int PhoneTypeId { get; set; }
        public string PhoneTypeDescription { get; set; }
        public bool VoiceLine { get; set; }
        public bool AllowDelete { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
