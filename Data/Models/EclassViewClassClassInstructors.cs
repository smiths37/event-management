using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassInstructors
    {
        public int InstructorId { get; set; }
        public string InstructorName { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Degree { get; set; }
        public string Title { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Bio { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string WebSiteUrl { get; set; }
    }
}
