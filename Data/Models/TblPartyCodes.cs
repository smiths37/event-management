using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPartyCodes
    {
        public TblPartyCodes()
        {
            TblCongress = new HashSet<TblCongress>();
        }

        public int PartyId { get; set; }
        public string PartyName { get; set; }
        public string PartyDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCongress> TblCongress { get; set; }
    }
}
