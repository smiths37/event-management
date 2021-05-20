using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptHistoryLabels
    {
        public int? PersonId { get; set; }
        public int RegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime? RegDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public bool AttendeeList { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string BadgeName { get; set; }
        public string CompanyName { get; set; }
        public string CountryName { get; set; }
        public string RegCode { get; set; }
        public DateTime? DatePostedToHistory { get; set; }
        public DateTime? DateEntered { get; set; }
    }
}
