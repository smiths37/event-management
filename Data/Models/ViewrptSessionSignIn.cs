using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessionSignIn
    {
        public int SessRegId { get; set; }
        public int RegId { get; set; }
        public int PrimaryRegId { get; set; }
        public int? GuestRegId { get; set; }
        public string SessionCode { get; set; }
        public string MeetingCode { get; set; }
        public string RegFirstName { get; set; }
        public string RegMiddleName { get; set; }
        public string RegLastName { get; set; }
        public string GuestRegFirstName { get; set; }
        public string GuestRegLastName { get; set; }
        public string SessionDescription { get; set; }
        public string SessionLongDesc { get; set; }
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
        public string SessionComments { get; set; }
        public string MeetingDesc { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingStartTime { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public DateTime? MeetingEndTime { get; set; }
        public string MeetingLongDesc { get; set; }
        public string MeetingLocation { get; set; }
        public string DefaultRegistrationCode { get; set; }
        public double? EarlyCancellationAmt { get; set; }
        public DateTime? CancellationDate { get; set; }
        public double? LateCancellationAmt { get; set; }
        public int? NumberAttending { get; set; }
        public bool UseHousingCosts { get; set; }
        public bool UseItineraryCosts { get; set; }
        public string MeetingComments { get; set; }
        public double? TaxPct { get; set; }
        public double? GratuityPct { get; set; }
        public string SessionBudgetCode { get; set; }
        public string ExhBudgetCode { get; set; }
        public string RegTypeBudgetCode { get; set; }
        public DateTime? DateEntered { get; set; }
        public double? Attending { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DateCancelled { get; set; }
        public bool AttendeeList { get; set; }
        public string Ssn { get; set; }
    }
}
