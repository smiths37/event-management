using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessionAvitemsSub
    {
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public int AvItemId { get; set; }
        public double? Quantity { get; set; }
        public int? ProvidedBy { get; set; }
        public double? Cost { get; set; }
        public string Notes { get; set; }
        public string ProviderName { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string AvDesc { get; set; }
    }
}
