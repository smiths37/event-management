using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblHotelContacts
    {
        public int HotelId { get; set; }
        public string Contact { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Ext { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblHotels Hotel { get; set; }
    }
}
