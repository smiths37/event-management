using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptVendorInvoice
    {
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public double? Paid { get; set; }
        public string InvoiceNumber { get; set; }
        public double? Invoice { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryName { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Terms { get; set; }
        public DateTime? DueDate { get; set; }
        public double? InvoiceAmount { get; set; }
        public string Notes { get; set; }
        public bool? Primary { get; set; }
    }
}
