using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCompany
    {
        public int CompanyId { get; set; }
        public string RefId { get; set; }
        public string CompanyName { get; set; }
        public int? ParentCompanyId { get; set; }
        public string ParentName { get; set; }
        public string AlphaIndexName { get; set; }
        public string CorporateBilling { get; set; }
        public int? RepId { get; set; }
        public string InternetDomain { get; set; }
        public string CompanyEmail { get; set; }
        public int? CompanyType { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public int? AddressId { get; set; }
        public int? SourceId { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string User6 { get; set; }
        public string User5 { get; set; }
        public string User4 { get; set; }
        public string User3 { get; set; }
        public string CompanyTypeDesc { get; set; }
        public int? CompanyAddressId { get; set; }
        public bool? Primary { get; set; }
        public string Phone { get; set; }
        public string _800 { get; set; }
        public string Fax { get; set; }
        public int? AddressType { get; set; }
        public string AddressTypeDesc { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string StateName { get; set; }
        public int? PeopleCount { get; set; }
        public string SourceDesc { get; set; }
    }
}
