using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblGuaranteeTypes
    {
        public int GuaranteeTypeId { get; set; }
        public string GuaranteeTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
