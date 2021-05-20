using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDirectoryInfo
    {
        public int DirectoryId { get; set; }
        public string DirectoryDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
