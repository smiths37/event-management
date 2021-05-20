using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPaymentNumFormats
    {
        public int PaymentTypeId { get; set; }
        public short NumberLength { get; set; }
        public string FormatString { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
