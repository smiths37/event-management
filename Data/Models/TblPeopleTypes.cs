using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPeopleTypes
    {
        public TblPeopleTypes()
        {
            TblPeople = new HashSet<TblPeople>();
        }

        public int PeopleTypeId { get; set; }
        public string PeopleTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblPeople> TblPeople { get; set; }
    }
}
