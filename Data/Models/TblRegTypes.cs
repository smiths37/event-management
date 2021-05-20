using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblRegTypes
    {
        public TblRegTypes()
        {
            TblRegistration = new HashSet<TblRegistration>();
        }

        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public string RegDesc { get; set; }
        public double? RegistrationFee { get; set; }
        public DateTime? LateFeeDate { get; set; }
        public double? LateRegFee { get; set; }
        public bool Default { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public double? ExpectedRegCount { get; set; }
        public string BudgetCode { get; set; }
        public bool? AllowWebReg { get; set; }
        public double? WebSortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblMeetings MeetingCodeNavigation { get; set; }
        public virtual ICollection<TblRegistration> TblRegistration { get; set; }
    }
}
