using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRegistration
    {
        public TblRegistration()
        {
            TblGuestReg = new HashSet<TblGuestReg>();
            TblHousing = new HashSet<TblHousing>();
            TblItinerary = new HashSet<TblItinerary>();
            TblPayments = new HashSet<TblPayments>();
        }

        public int? PersonId { get; set; }
        public int RegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Ssn { get; set; }
        public string Dept { get; set; }
        public string BadgeName { get; set; }
        public string Title { get; set; }
        public string Salutation { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public int? Source { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public int? PeopleType { get; set; }
        public string PreOrOnSite { get; set; }
        public bool AttendeeList { get; set; }
        public bool UseCompanyName { get; set; }
        public DateTime? RegDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public double? RegFee { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public int? AddressId { get; set; }
        public string AddressType { get; set; }
        public bool UseHousingCosts { get; set; }
        public bool UseItineraryCosts { get; set; }
        public DateTime? DateBadgePrinted { get; set; }
        public DateTime? DatePostedToHistory { get; set; }
        public DateTime? DateCancelled { get; set; }
        public double? CancellationFee { get; set; }
        public DateTime? DateCancellationProcessed { get; set; }
        public double? RefundAmount { get; set; }
        public bool Attended { get; set; }
        public DateTime? DateCreditsPosted { get; set; }
        public string Email { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public int? SpecialtyId { get; set; }
        public string MailPref { get; set; }
        public DateTime? DateRefundProcessed { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public DateTime? AttendanceTimeStamp { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string Location { get; set; }
        public string FormalTitle { get; set; }
        public bool? UseFormalTitle { get; set; }

        public virtual TblRegTypes TblRegTypes { get; set; }
        public virtual ICollection<TblGuestReg> TblGuestReg { get; set; }
        public virtual ICollection<TblHousing> TblHousing { get; set; }
        public virtual ICollection<TblItinerary> TblItinerary { get; set; }
        public virtual ICollection<TblPayments> TblPayments { get; set; }
    }
}
