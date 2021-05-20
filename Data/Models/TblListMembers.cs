using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblListMembers
    {
        public string ListCode { get; set; }
        public int PersonId { get; set; }
        public int PersonAddressId { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string Type { get; set; }
        public string Destination { get; set; }
        public string Message { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblLists ListCodeNavigation { get; set; }
        public virtual TblPeople Person { get; set; }
        public virtual TblPeopleAddresses PersonAddress { get; set; }
    }
}
