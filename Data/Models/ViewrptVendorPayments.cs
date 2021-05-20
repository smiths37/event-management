using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptVendorPayments
    {
        public string CompanyName { get; set; }
        public string PaymentTypeDesc { get; set; }
        public double? Invoice { get; set; }
        public double? Paid { get; set; }
        public DateTime? InvoiceDate { get; set; }
        public int PaymentId { get; set; }
        public int CompanyId { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentTypeId { get; set; }
        public string InvoiceNumber { get; set; }
        public double? PaymentAmount { get; set; }
        public string CheckNumber { get; set; }
        public string Notes { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
