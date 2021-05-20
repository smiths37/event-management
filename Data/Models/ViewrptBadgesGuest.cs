using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptBadgesGuest
    {
        public int RegId { get; set; }
        public int GuestRegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string BadgeName { get; set; }
        public string Suffix { get; set; }
        public string MeetingDesc { get; set; }
        public DateTime? DateCancelled { get; set; }
    }
}
