using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblChargeTypes
    {
        public int ChargeTypeId { get; set; }
        public string ChargeTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
