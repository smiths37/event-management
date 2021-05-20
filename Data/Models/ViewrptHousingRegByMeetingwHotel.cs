using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptHousingRegByMeetingwHotel
    {
        public DateTime? DateCancelled { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public DateTime? RegDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegistrationCode { get; set; }
        public string RegDesc { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public int RegId { get; set; }
        public bool AttendeeList { get; set; }
        public string MeetingDesc { get; set; }
        public string MeetingLocation { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public string BadgeName { get; set; }
        public string CountryName { get; set; }
        public string HotelName { get; set; }
        public string RoomType { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public DateTime? DepartDate { get; set; }
        public int HotelId { get; set; }
    }
}
