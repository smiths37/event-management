using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblHotelTypes
    {
        public TblHotelTypes()
        {
            TblHotels = new HashSet<TblHotels>();
        }

        public int HotelTypeId { get; set; }
        public string HotelTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblHotels> TblHotels { get; set; }
    }
}
