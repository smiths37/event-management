using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblAvItems
    {
        public TblAvItems()
        {
            TblSessionAvItems = new HashSet<TblSessionAvItems>();
        }

        public int AvId { get; set; }
        public string AvDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblSessionAvItems> TblSessionAvItems { get; set; }
    }
}
