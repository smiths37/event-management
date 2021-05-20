using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSources
    {
        public TblSources()
        {
            TblPeople = new HashSet<TblPeople>();
        }

        public int SourceId { get; set; }
        public string SourceDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? SourceCount { get; set; }
        public DateTime? SourceDate { get; set; }
        public double? SourceCost { get; set; }

        public virtual ICollection<TblPeople> TblPeople { get; set; }
    }
}
