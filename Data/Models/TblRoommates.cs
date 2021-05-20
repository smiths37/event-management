using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRoommates
    {
        public int RoommateId { get; set; }
        public int? AccomId { get; set; }
        public int? PersonId { get; set; }
        public string Name { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblHousing Accom { get; set; }
    }
}
