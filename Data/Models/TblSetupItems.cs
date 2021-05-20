using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSetupItems
    {
        public TblSetupItems()
        {
            TblSessionSetupItems = new HashSet<TblSessionSetupItems>();
        }

        public int SetupId { get; set; }
        public string SetupDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblSessionSetupItems> TblSessionSetupItems { get; set; }
    }
}
