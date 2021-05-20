using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewCtctregistrationCriteria
    {
        public string EmailAddress { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string JobTitle { get; set; }
        public string CompanyName { get; set; }
        public string HomePhone { get; set; }
        public string WorkPhone { get; set; }
        public string Addr1 { get; set; }
        public string Addr2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string CountryName { get; set; }
        public string PostalCode { get; set; }
        public string CustomField1 { get; set; }
        public int? CustomField2 { get; set; }
        public int CustomField3 { get; set; }
        public int? PersonId { get; set; }
        public int RegId { get; set; }
        public string MeetingCode { get; set; }
        public DateTime? DateCancelled { get; set; }
    }
}
