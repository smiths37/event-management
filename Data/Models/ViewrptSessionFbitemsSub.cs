using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessionFbitemsSub
    {
        public string FbDesc { get; set; }
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public int FbItemId { get; set; }
        public double? Quantity { get; set; }
        public int? ProvidedBy { get; set; }
        public double? Cost { get; set; }
        public string Notes { get; set; }
        public string ProviderName { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
