using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptTranscript
    {
        public int? PersonId { get; set; }
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public string SessionCode { get; set; }
        public int? CreditTypeId { get; set; }
        public string CreditTypeDesc { get; set; }
        public string Title { get; set; }
        public string CreditTypeCode { get; set; }
        public double? CreditUnits { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Ssn { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreditDate { get; set; }
        public string Company { get; set; }
        public int? PeopleTypeId { get; set; }
        public string PeopleTypeDesc { get; set; }
        public int? PeopleType { get; set; }
        public int? AddressId { get; set; }
        public int? AddressType { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? SpecialtyId { get; set; }
        public int KeyId { get; set; }
    }
}
