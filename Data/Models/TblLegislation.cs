using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblLegislation
    {
        public int BillId { get; set; }
        public string BillTitle { get; set; }
        public string BillDescription { get; set; }
        public DateTime? DateVoted { get; set; }
        public string Status { get; set; }
        public bool VoteDesired { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
