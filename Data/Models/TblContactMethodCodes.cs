using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblContactMethodCodes
    {
        public TblContactMethodCodes()
        {
            TblContacts = new HashSet<TblContacts>();
        }

        public int ContactMethodCode { get; set; }
        public string ContactMethodDescription { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblContacts> TblContacts { get; set; }
    }
}
