using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCreditMemoLines
    {
        public int CreditMemoId { get; set; }
        public int ProductId { get; set; }
        public int OrderId { get; set; }
        public int? QtyReturned { get; set; }
        public decimal? Price { get; set; }
        public bool Taxable { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCreditMemo TblCreditMemo { get; set; }
    }
}
