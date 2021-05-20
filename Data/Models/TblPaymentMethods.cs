using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPaymentMethods
    {
        public int PaymentMethodId { get; set; }
        public string PaymentMethodDesc { get; set; }
        public bool? CreditCard { get; set; }
        public bool? AllowOnWeb { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
