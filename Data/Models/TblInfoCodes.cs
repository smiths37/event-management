using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblInfoCodes
    {
        public TblInfoCodes()
        {
            TblInfoRequestItems = new HashSet<TblInfoRequestItems>();
        }

        public int InfoCode { get; set; }
        public string InfoDescription { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblInfoRequestItems> TblInfoRequestItems { get; set; }
    }
}
