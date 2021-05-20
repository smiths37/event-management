using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptItineraryArrival
    {
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public int? Type { get; set; }
        public string ToCity { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public string Airline { get; set; }
        public int? FlightNumber { get; set; }
        public int RegId { get; set; }
        public string MeetingCode { get; set; }
        public DateTime? FlightDate { get; set; }
        public bool Cancelled { get; set; }
        public int ItineraryId { get; set; }
        public string FrmCity { get; set; }
        public DateTime? DateCancelled { get; set; }
    }
}
