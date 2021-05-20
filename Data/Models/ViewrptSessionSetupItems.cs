using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessionSetupItems
    {
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string PersonResponsible { get; set; }
        public string Location { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string SetupDesc { get; set; }
        public string CompanyName { get; set; }
        public string RoomSetupSetupDesc { get; set; }
        public int? SetupItemId { get; set; }
        public double? Quantity { get; set; }
        public int? ProvidedBy { get; set; }
        public double? Cost { get; set; }
        public string Notes { get; set; }
        public string SessSetupSessionCode { get; set; }
        public string SessSetupMeetingCode { get; set; }
    }
}
