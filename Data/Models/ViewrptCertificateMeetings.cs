using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCertificateMeetings
    {
        public int PersonId { get; set; }
        public int? SpecialtyId { get; set; }
        public string Description { get; set; }
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public string MeetingLocation { get; set; }
        public string CreditTypeCode { get; set; }
        public string NamePrefix { get; set; }
        public string Middle { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public double? CreditUnits { get; set; }
        public string SessionCode { get; set; }
        public string Location { get; set; }
        public int KeyId { get; set; }
        public string Title { get; set; }
        public DateTime? CreditDate { get; set; }
        public DateTime? SessionDate { get; set; }
    }
}
