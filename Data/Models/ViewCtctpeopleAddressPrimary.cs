using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewCtctpeopleAddressPrimary
    {
        public int AddressId { get; set; }
        public int PersonId { get; set; }
        public bool Primary { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public int AddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
