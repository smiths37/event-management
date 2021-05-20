using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDefaultRenewalLetterSetup
    {
        public int RenewalSetupId { get; set; }
        public string HeaderText { get; set; }
        public string FooterText { get; set; }
        public bool ChangeOfAddress { get; set; }
        public bool RenewalTypes { get; set; }
        public short Reminder { get; set; }
        public short MembershipGroup { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
