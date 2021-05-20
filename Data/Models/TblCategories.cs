using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCategories
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool AllowDelete { get; set; }
        public short? ProductOrService { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
