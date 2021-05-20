using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassLinkTypes
    {
        public TblClassLinkTypes()
        {
            TblClassLinks = new HashSet<TblClassLinks>();
        }

        public int LinkTypeId { get; set; }
        public string LinkTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClassLinks> TblClassLinks { get; set; }
    }
}
