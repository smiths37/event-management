using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDupeOrderLines
    {
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public int? QtyShipped { get; set; }
        public bool Taxable { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
