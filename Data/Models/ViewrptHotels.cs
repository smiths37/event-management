using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptHotels
    {
        public int HotelId { get; set; }
        public int? HotelType { get; set; }
        public string MeetingCode { get; set; }
        public string RoomType { get; set; }
        public string HotelName { get; set; }
        public string HotelTypeDesc { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Fax { get; set; }
        public string Phone { get; set; }
        public string HotelNotes { get; set; }
        public string MeetingDesc { get; set; }
    }
}
