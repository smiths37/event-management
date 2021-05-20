using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptPeople
    {
        public int PersonId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Ssn { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public string RefId { get; set; }
        public bool PrimaryContact { get; set; }
        public bool SellName { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Photo { get; set; }
        public int? DirectorySortOrder { get; set; }
        public bool IncludeInDirectory { get; set; }
        public bool IncludeInMemDirectory { get; set; }
        public int? MemSortOrder { get; set; }
        public string BadgeName { get; set; }
        public string Salutation { get; set; }
        public int? PeopleType { get; set; }
        public int? ContactType { get; set; }
        public int? SourceId { get; set; }
        public int? SpecialtyId { get; set; }
        public string Email { get; set; }
        public string MailPref { get; set; }
        public bool DoNotMail { get; set; }
        public string CellPhone { get; set; }
        public string Pager { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? AddressId { get; set; }
        public bool? Primary { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string PeopleTypeDesc { get; set; }
        public string SpecialtyDesc { get; set; }
        public string AddressTypeDesc { get; set; }
        public string StateName { get; set; }
        public int? AddressType { get; set; }
        public string SourceDesc { get; set; }
    }
}
