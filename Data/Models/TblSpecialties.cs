using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSpecialties
    {
        public TblSpecialties()
        {
            TblPeople = new HashSet<TblPeople>();
        }

        public int SpecialtyId { get; set; }
        public string Description { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblPeople> TblPeople { get; set; }
    }
}
