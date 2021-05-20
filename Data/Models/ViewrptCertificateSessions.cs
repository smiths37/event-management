using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCertificateSessions
    {
        public int? PersonId { get; set; }
        public string MeetingCode { get; set; }
        public int? SpecialtyId { get; set; }
        public string SessionCode { get; set; }
        public string CreditTypeCode { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public double? CreditUnits { get; set; }
        public string Location { get; set; }
        public string MeetingLocation { get; set; }
        public string Notes { get; set; }
        public string Title { get; set; }
        public int KeyId { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? CreditDate { get; set; }
        public string CreditTypeDesc { get; set; }
    }
}
