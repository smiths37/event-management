using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblGuestReg
    {
        public int RegId { get; set; }
        public int? GuestPersonId { get; set; }
        public int GuestRegId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Suffix { get; set; }
        public string BadgeName { get; set; }
        public int? GuestType { get; set; }
        public string Sex { get; set; }
        public double? Age { get; set; }
        public DateTime? RegDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public double? RegFee { get; set; }
        public DateTime? ArrivalDate { get; set; }
        public DateTime? DepartureDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblRegistration Reg { get; set; }
    }
}
