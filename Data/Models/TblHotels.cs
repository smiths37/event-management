using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblHotels
    {
        public TblHotels()
        {
            TblHotelContacts = new HashSet<TblHotelContacts>();
            TblHotelRoomTypes = new HashSet<TblHotelRoomTypes>();
        }

        public int HotelId { get; set; }
        public string HotelName { get; set; }
        public int? HotelType { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string HotelNotes { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string HotelUrl { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblHotelTypes HotelTypeNavigation { get; set; }
        public virtual ICollection<TblHotelContacts> TblHotelContacts { get; set; }
        public virtual ICollection<TblHotelRoomTypes> TblHotelRoomTypes { get; set; }
    }
}
