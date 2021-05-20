using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassParticipationMethods
    {
        public TblClassParticipationMethods()
        {
            TblClass = new HashSet<TblClass>();
        }

        public int ParticipationMethodId { get; set; }
        public string ParticipationMethodDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClass> TblClass { get; set; }
    }
}
