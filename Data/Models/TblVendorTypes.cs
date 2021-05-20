using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblVendorTypes
    {
        public int VendorTypeId { get; set; }
        public string VendorType { get; set; }
        public string Description { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
