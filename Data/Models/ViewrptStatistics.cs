using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptStatistics
    {
        public int? PersonId { get; set; }
        public int RegId { get; set; }
        public string CompanyName { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public int? Source { get; set; }
        public string RegDesc { get; set; }
        public string MeetingDesc { get; set; }
        public string LongDescription { get; set; }
        public string MeetingLocation { get; set; }
        public string CountryName { get; set; }
        public string State { get; set; }
        public string SourceDesc { get; set; }
        public string StateName { get; set; }
    }
}
