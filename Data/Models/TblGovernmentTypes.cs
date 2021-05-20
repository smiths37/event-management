using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblGovernmentTypes
    {
        public TblGovernmentTypes()
        {
            TblCongress = new HashSet<TblCongress>();
        }

        public int GovTypeCode { get; set; }
        public string GovTypeDesc { get; set; }
        public bool Vote { get; set; }
        public int? TermLength { get; set; }
        public int? NoTermAllowed { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCongress> TblCongress { get; set; }
    }
}
