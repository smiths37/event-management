using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblHotelRoomTypes
    {
        public int HotelId { get; set; }
        public string RoomType { get; set; }
        public string MeetingCode { get; set; }
        public double? RoomRate { get; set; }
        public double? NumInBlock { get; set; }
        public double? NumAssigned { get; set; }
        public string GlCreditAccountCode { get; set; }
        public string GlDebitAccountCode { get; set; }
        public string GlcreditReceipt { get; set; }
        public string GldebitReceipt { get; set; }
        public bool? AllowOnWeb { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblHotels Hotel { get; set; }
        public virtual TblMeetings MeetingCodeNavigation { get; set; }
    }
}
