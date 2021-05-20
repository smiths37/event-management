using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblVendorInvoices
    {
        public int CompanyId { get; set; }
        public string InvoiceNumber { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public string Terms { get; set; }
        public DateTime? DueDate { get; set; }
        public double? InvoiceAmount { get; set; }
        public string Notes { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
