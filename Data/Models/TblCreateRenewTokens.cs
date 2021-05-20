using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCreateRenewTokens
    {
        public int TokenId { get; set; }
        public short? Position { get; set; }
        public string Creator { get; set; }
        public DateTime? Timestamp { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
