using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRoomSetups
    {
        public TblRoomSetups()
        {
            TblSessions = new HashSet<TblSessions>();
        }

        public int SetupId { get; set; }
        public string SetupDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblSessions> TblSessions { get; set; }
    }
}
