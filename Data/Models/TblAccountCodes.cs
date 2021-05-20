using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblAccountCodes
    {
        public int AccountId { get; set; }
        public string GlaccountDescription { get; set; }
        public string GlaccountCode { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
