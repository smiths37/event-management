using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptTranscriptMain
    {
        public int? PersonId { get; set; }
        public string SessionCode { get; set; }
        public string Title { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Ssn { get; set; }
        public string CompanyName { get; set; }
        public DateTime? CreditDate { get; set; }
        public string MeetingCode { get; set; }
        public string CreditTypeCode { get; set; }
    }
}
