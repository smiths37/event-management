using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblInfoRequestItems
    {
        public int InfoRequestId { get; set; }
        public int InfoCode { get; set; }
        public short? Quantity { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblInfoCodes InfoCodeNavigation { get; set; }
        public virtual TblInformationRequests InfoRequest { get; set; }
    }
}
