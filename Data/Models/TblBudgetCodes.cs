using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblBudgetCodes
    {
        public TblBudgetCodes()
        {
            TblExpenses = new HashSet<TblExpenses>();
            TblIncome = new HashSet<TblIncome>();
        }

        public string BudgetCode { get; set; }
        public string BudgetDesc { get; set; }
        public string BudgetType { get; set; }
        public int? DepartmentId { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblExpenses> TblExpenses { get; set; }
        public virtual ICollection<TblIncome> TblIncome { get; set; }
    }
}
