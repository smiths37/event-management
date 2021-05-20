using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMembershipProducts
    {
        public int Id { get; set; }
        public int? MembershipTypeCode { get; set; }
        public int? ProductId { get; set; }
        public decimal? Price { get; set; }
        public bool? Optional { get; set; }
        public bool? AllowPriceChange { get; set; }
        public int? SortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblMembershipTypeCodes MembershipTypeCodeNavigation { get; set; }
        public virtual TblProducts Product { get; set; }
    }
}
