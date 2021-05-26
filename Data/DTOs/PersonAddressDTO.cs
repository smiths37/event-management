using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class PersonAddressDTO
    {
        public int addressId { get; set; }
        public int personId { get; set; }
        public int? companyId { get; set; }
        public bool primary { get; set; }
        public string phone { get; set; }
        public string extension { get; set; }
        public string fax { get; set; }
        public string addressTypeDesc { get; set; }
        public string address1 { get; set; }
        public string address2 { get; set; }
        public string city { get; set; }
        public string stateName { get; set; }
        public string countryName { get; set; }
        public string zip { get; set; }
    }
}
