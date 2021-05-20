using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptGuests
    {
        public int RegId { get; set; }
        public int? GuestPersonId { get; set; }
        public int GuestRegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string BadgeName { get; set; }
        public int? GuestType { get; set; }
        public string Sex { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public double? RegFee { get; set; }
        public string RegCode { get; set; }
        public string MeetingCode { get; set; }
        public DateTime? RegDate { get; set; }
        public double? Age { get; set; }
        public string GuestTypeDesc { get; set; }
        public string RegTypeDesc { get; set; }
        public int? SessionCount { get; set; }
        public string RegNamePrefix { get; set; }
        public string RegFirstName { get; set; }
        public string RegMiddle { get; set; }
        public string RegLastName { get; set; }
        public string RegNameSuffix { get; set; }
        public DateTime? DateCancelled { get; set; }
    }
}
