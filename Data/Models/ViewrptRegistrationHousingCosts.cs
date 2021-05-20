using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptRegistrationHousingCosts
    {
        public int RegId { get; set; }
        public double? RoomRate { get; set; }
        public int? NumNights { get; set; }
        public double? HousingCosts { get; set; }
    }
}
