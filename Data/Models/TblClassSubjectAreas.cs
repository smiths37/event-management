using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassSubjectAreas
    {
        public TblClassSubjectAreas()
        {
            TblClass = new HashSet<TblClass>();
        }

        public int SubjectAreaId { get; set; }
        public string SubjectAreaDesc { get; set; }
        public string LongDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClass> TblClass { get; set; }
    }
}
