using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptIncomeExpensePlmeetingIncomeSub
    {
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public double? BudgetQty { get; set; }
        public double? BudgetAmount { get; set; }
        public int IncomeId { get; set; }
        public string RegCode { get; set; }
        public string SessionCode { get; set; }
        public string BudgetCode { get; set; }
        public string Description { get; set; }
        public double? ActualQty { get; set; }
        public double? TotalActualAmount { get; set; }
        public bool SystemGenerated { get; set; }
        public bool MeetingBudget { get; set; }
        public bool ExhibitorBudget { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string SessDescription { get; set; }
        public string BudgetDesc { get; set; }
    }
}
