using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptRefundsDue
    {
        public int RegId { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? RegDate { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string Middle { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryName { get; set; }
        public DateTime? DateRefundProcessed { get; set; }
    }
}
