using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRenewalTypes
    {
        public int MembershipTypeCode { get; set; }
        public int RenewalTypeCode { get; set; }
        public decimal? RenewalPrice { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblMembershipTypeCodes MembershipTypeCodeNavigation { get; set; }
        public virtual TblMembershipTypeCodes RenewalTypeCodeNavigation { get; set; }
    }
}
