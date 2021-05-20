using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblFbItems
    {
        public TblFbItems()
        {
            TblSessionFbItems = new HashSet<TblSessionFbItems>();
        }

        public int FbId { get; set; }
        public string FbDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblSessionFbItems> TblSessionFbItems { get; set; }
    }
}
