using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSessionWaitList
    {
        public int WaitListId { get; set; }
        public int? PrimaryId { get; set; }
        public int RegId { get; set; }
        public int? GuestId { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public DateTime? DateAdded { get; set; }
        public DateTime? TimeAdded { get; set; }
        public int? Priority { get; set; }
        public double? Attending { get; set; }
        public byte[] UpsiteTs { get; set; }
    }
}
