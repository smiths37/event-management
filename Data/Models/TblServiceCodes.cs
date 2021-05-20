using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblServiceCodes
    {
        public TblServiceCodes()
        {
            TblExpenses = new HashSet<TblExpenses>();
        }

        public int ServiceId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceDesc { get; set; }
        public bool TaxA { get; set; }
        public bool TaxB { get; set; }
        public bool TaxC { get; set; }
        public bool Gratuity { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblExpenses> TblExpenses { get; set; }
    }
}
