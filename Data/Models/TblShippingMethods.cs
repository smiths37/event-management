using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblShippingMethods
    {
        public int ShippingId { get; set; }
        public string Description { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
