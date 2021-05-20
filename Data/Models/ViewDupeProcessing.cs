using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewDupeProcessing
    {
        public int PersonId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public bool? Primary { get; set; }
    }
}
