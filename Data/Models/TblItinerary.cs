using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblItinerary
    {
        public int ItineraryId { get; set; }
        public int? RegId { get; set; }
        public int? Type { get; set; }
        public string Airline { get; set; }
        public int? FlightNumber { get; set; }
        public string ServiceClass { get; set; }
        public DateTime? FlightDate { get; set; }
        public string FromCity { get; set; }
        public string ToCity { get; set; }
        public string Status { get; set; }
        public DateTime? DepartureTime { get; set; }
        public DateTime? ArrivalTime { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public bool Cancelled { get; set; }
        public DateTime? DateCancelled { get; set; }
        public string CancelledBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblRegistration Reg { get; set; }
    }
}
