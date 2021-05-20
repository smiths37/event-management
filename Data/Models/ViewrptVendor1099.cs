using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptVendor1099
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryName { get; set; }
        public string Description { get; set; }
        public string TaxId { get; set; }
        public string VendorNotes { get; set; }
        public double? PaymentAmount { get; set; }
        public bool Print1099Forms { get; set; }
        public DateTime? PaymentDate { get; set; }
        public bool? Primary { get; set; }
    }
}
