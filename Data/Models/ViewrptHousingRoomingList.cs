using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptHousingRoomingList
    {
        public DateTime? DateCancelled { get; set; }
        public int AccomId { get; set; }
        public int RegId { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartDate { get; set; }
        public string HotelName { get; set; }
        public string RoomType { get; set; }
        public double? RoomRate { get; set; }
        public int? ChargeType { get; set; }
        public int? Guarantee { get; set; }
        public string CardNo { get; set; }
        public string ExpireDate { get; set; }
        public string NameOnCard { get; set; }
        public bool NonSmoking { get; set; }
        public string SpecialRequests { get; set; }
        public string DisabledDesc { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public int? CompanyId { get; set; }
        public int HotelId { get; set; }
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public string GuaranteeTypeDesc { get; set; }
        public string ChargeTypeDesc { get; set; }
        public string CompanyName { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
    }
}
