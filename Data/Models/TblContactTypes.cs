using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblContactTypes
    {
        public TblContactTypes()
        {
            TblPeople = new HashSet<TblPeople>();
        }

        public int ContactTypeId { get; set; }
        public string ContactTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblPeople> TblPeople { get; set; }
    }
}
