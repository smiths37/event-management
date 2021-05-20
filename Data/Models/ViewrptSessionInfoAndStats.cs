using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessionInfoAndStats
    {
        public string SessionCode { get; set; }
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string MeetingCode { get; set; }
        public string Location { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public double? Fee { get; set; }
        public double? Limit { get; set; }
        public double? Registered { get; set; }
        public double? Ceu { get; set; }
        public string BudgetCode { get; set; }
        public double? Guaranteed { get; set; }
        public bool Ticketed { get; set; }
        public int? SetupId { get; set; }
        public string SetupNotes { get; set; }
        public string PersonResponsible { get; set; }
        public string Comments { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public bool? WaitList { get; set; }
        public int? SponsoredBy { get; set; }
        public string Sponsor { get; set; }
        public bool? AllowWebReg { get; set; }
        public string SessionDetailUrl { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string SetupDesc { get; set; }
    }
}
