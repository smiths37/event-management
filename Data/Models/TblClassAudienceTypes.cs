using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassAudienceTypes
    {
        public TblClassAudienceTypes()
        {
            TblClass = new HashSet<TblClass>();
        }

        public int AudienceTypeId { get; set; }
        public string AudienceTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClass> TblClass { get; set; }
    }
}
