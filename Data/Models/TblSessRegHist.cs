using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSessRegHist
    {
        public int SessRegHistId { get; set; }
        public int HistId { get; set; }
        public int RegId { get; set; }
        public int PrimaryRegId { get; set; }
        public int? GuestRegId { get; set; }
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public double? Attending { get; set; }
        public double? Fee { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
