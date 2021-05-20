using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblNamePrefixes
    {
        public int Id { get; set; }
        public string Prefix { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
