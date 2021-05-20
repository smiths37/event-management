using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCreditMemo
    {
        public TblCreditMemo()
        {
            TblCreditMemoLines = new HashSet<TblCreditMemoLines>();
        }

        public int CreditMemoId { get; set; }
        public int OrderId { get; set; }
        public DateTime? CreditDate { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblOrders Order { get; set; }
        public virtual ICollection<TblCreditMemoLines> TblCreditMemoLines { get; set; }
    }
}
