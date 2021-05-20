using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptIncomeExpensePlmeetings
    {
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingStartTime { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public DateTime? MeetingEndTime { get; set; }
        public string LongDescription { get; set; }
        public string MeetingLocation { get; set; }
        public string DefaultRegistrationCode { get; set; }
        public double? EarlyCancellationAmt { get; set; }
        public DateTime? CancellationDate { get; set; }
        public double? LateCancellationAmt { get; set; }
        public int? NumberAttending { get; set; }
        public bool UseHousingCosts { get; set; }
        public bool UseItineraryCosts { get; set; }
        public string Comments { get; set; }
        public double? TaxPct { get; set; }
        public double? GratuityPct { get; set; }
        public string SessionBudgetCode { get; set; }
        public string ExhBudgetCode { get; set; }
        public string RegTypeBudgetCode { get; set; }
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
        public int? SponsoredBy { get; set; }
        public string Sponsor { get; set; }
        public bool? AllowWebReg { get; set; }
        public bool? AllowWebGuests { get; set; }
        public bool? AllowWebHousing { get; set; }
        public bool? AllowWebItinerary { get; set; }
        public string MeetingDetailUrl { get; set; }
        public string CalendarMsg { get; set; }
        public double? Gmtoffset { get; set; }
        public int? MeetingTypeId { get; set; }
        public int? MeetingSubjectAreaId { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
