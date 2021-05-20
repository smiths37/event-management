using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTestCredits
    {
        public int TypeId { get; set; }
        public int ClassTestId { get; set; }
        public string CreditTypeCode { get; set; }
        public double CreditUnits { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassTests ClassTest { get; set; }
    }
}
