using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptVendorInvoiceSub
    {
        public int CompanyId { get; set; }
        public string InvoiceNumber { get; set; }
        public double? Invoice { get; set; }
        public double? Paid { get; set; }
        public DateTime? InvoiceDate { get; set; }
    }
}
