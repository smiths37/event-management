using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptTranscriptSelection
    {
        public int PersonId { get; set; }
        public int? AddressTypeId { get; set; }
        public bool? Primary { get; set; }
        public string Zip { get; set; }
        public string CompanyName { get; set; }
        public string AddressTypeDesc { get; set; }
        public int? PeopleTypeId { get; set; }
        public string PeopleTypeDesc { get; set; }
        public string LastName { get; set; }
        public string State { get; set; }
        public string CreditTypeCode { get; set; }
        public string Ssn { get; set; }
        public int? SpecialtyId { get; set; }
        public string Description { get; set; }
    }
}
