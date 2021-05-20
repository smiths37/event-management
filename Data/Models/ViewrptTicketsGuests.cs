using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptTicketsGuests
    {
        public int SessRegId { get; set; }
        public int PrimaryRegId { get; set; }
        public int RegId { get; set; }
        public int? GuestRegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string RegNamePrefix { get; set; }
        public string RegFirstName { get; set; }
        public string RegMiddleName { get; set; }
        public string RegLastName { get; set; }
        public string RegNameSuffix { get; set; }
        public string CompanyName { get; set; }
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public string RegCode { get; set; }
        public string RegDesc { get; set; }
        public string SessionCode { get; set; }
        public string SessionDesc { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? Attending { get; set; }
        public double? Fee { get; set; }
        public string Location { get; set; }
        public bool Ticketed { get; set; }
        public DateTime? DateCancelled { get; set; }
    }
}
