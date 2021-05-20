using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPeopleSourceCodes
    {
        public int PeopleSourceCode { get; set; }
        public string PeopleSourceDescription { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
