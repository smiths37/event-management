using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPaymentTypes
    {
        public int PaymentTypeId { get; set; }
        public string PaymentTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
