using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSponsors
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public int? ParentCompanyId { get; set; }
        public int? AddressId { get; set; }
        public bool? Primary { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string _800Number { get; set; }
        public string CountryName { get; set; }
        public int? PersonId { get; set; }
        public int? CompId { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public bool? PrimaryContact { get; set; }
        public string Salutation { get; set; }
    }
}
