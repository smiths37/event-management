using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblContactTypeCodes
    {
        public TblContactTypeCodes()
        {
            TblContacts = new HashSet<TblContacts>();
        }

        public int ContactTypeCode { get; set; }
        public string ContactTypeDescription { get; set; }
        public bool AllowDelete { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblContacts> TblContacts { get; set; }
    }
}
