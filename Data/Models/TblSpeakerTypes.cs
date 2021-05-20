using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSpeakerTypes
    {
        public TblSpeakerTypes()
        {
            TblSpeakers = new HashSet<TblSpeakers>();
        }

        public int SpeakerTypeId { get; set; }
        public string SpeakerTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblSpeakers> TblSpeakers { get; set; }
    }
}
