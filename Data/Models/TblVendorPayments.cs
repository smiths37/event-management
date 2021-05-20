using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblVendorPayments
    {
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
