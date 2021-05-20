using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblHotelCounts
    {
        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public string RoomType { get; set; }
        public int? Count { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
