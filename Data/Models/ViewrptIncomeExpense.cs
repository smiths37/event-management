using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptIncomeExpense
    {
        public string MeetingDesc { get; set; }
        public string BudgetDesc { get; set; }
        public string ServiceCode { get; set; }
        public string VendorType { get; set; }
        public int? VendorTypeId { get; set; }
        public string ServiceDesc { get; set; }
        public string Description { get; set; }
        public int ExpenseId { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int? ServiceId { get; set; }
        public int? CompanyId { get; set; }
        public string BudgetCode { get; set; }
        public string LongDescription { get; set; }
        public string LongDescription2 { get; set; }
        public string ExpenseDesc { get; set; }
        public bool LinkToReg { get; set; }
        public double? BudgetQty { get; set; }
        public double? BudgetAmount { get; set; }
        public double? ActualQty { get; set; }
        public double? ActualAmount { get; set; }
        public bool Taxable { get; set; }
        public double? TaxRate { get; set; }
        public bool Gratuity { get; set; }
        public double? GratuityRate { get; set; }
        public double? BudgetGratuityAmt { get; set; }
        public double? ActualGratuityAmt { get; set; }
        public double? AmountPaid { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
