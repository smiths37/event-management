using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessWaitList
    {
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public string SessionCode { get; set; }
        public string Description { get; set; }
        public int? GuestId { get; set; }
        public int RegId { get; set; }
        public string GuestFirstName { get; set; }
        public string FirstName { get; set; }
        public string CompanyName { get; set; }
        public string GuestLastName { get; set; }
        public string LastName { get; set; }
        public string LongDescription { get; set; }
        public DateTime? StartTime { get; set; }
        public string Ssn { get; set; }
        public int WaitListId { get; set; }
        public int? PrimaryId { get; set; }
        public DateTime? DateAdded { get; set; }
        public int? Priority { get; set; }
        public DateTime? SessionDate { get; set; }
        public string Location { get; set; }
        public DateTime? DateCancelled { get; set; }
    }
}
