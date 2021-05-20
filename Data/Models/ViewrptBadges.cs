using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptBadges
    {
        public int RegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string BadgeName { get; set; }
        public string NameSuffix { get; set; }
        public string CompanyName { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string MeetingDesc { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DateBadgePrinted { get; set; }
    }
}
