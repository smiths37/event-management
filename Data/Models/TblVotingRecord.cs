using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblVotingRecord
    {
        public int RepId { get; set; }
        public int BillId { get; set; }
        public string Vote { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCongress Rep { get; set; }
    }
}
