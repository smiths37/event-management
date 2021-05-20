using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblHousing
    {
        public TblHousing()
        {
            TblRoommates = new HashSet<TblRoommates>();
        }

        public int AccomId { get; set; }
        public int RegId { get; set; }
        public string MeetingCode { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartDate { get; set; }
        public int HotelId { get; set; }
        public string RoomType { get; set; }
        public double? RoomRate { get; set; }
        public int? ChargeType { get; set; }
        public int? Guarantee { get; set; }
        public string CardNo { get; set; }
        public string ExpireDate { get; set; }
        public string NameOnCard { get; set; }
        public bool NonSmoking { get; set; }
        public bool Disabled { get; set; }
        public string DisabledDesc { get; set; }
        public string SpecialRequests { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblRegistration Reg { get; set; }
        public virtual ICollection<TblRoommates> TblRoommates { get; set; }
    }
}
