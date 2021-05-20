using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblLists
    {
        public TblLists()
        {
            TblListMembers = new HashSet<TblListMembers>();
        }

        public string ListCode { get; set; }
        public string ParentList { get; set; }
        public string ListName { get; set; }
        public string ListDescription { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int ListId { get; set; }

        public virtual ICollection<TblListMembers> TblListMembers { get; set; }
    }
}
