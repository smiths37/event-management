using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptMeetingSetupRegTypeLetterText
    {
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public string RegDesc { get; set; }
        public double? RegistrationFee { get; set; }
        public DateTime? LateFeeDate { get; set; }
        public byte[] UpsizeTs { get; set; }
        public double? WebSortOrder { get; set; }
        public bool? AllowWebReg { get; set; }
        public string BudgetCode { get; set; }
        public double? ExpectedRegCount { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public bool Default { get; set; }
        public double? LateRegFee { get; set; }
        public string ConfHeaderNotes { get; set; }
        public string ConfFooterNotes { get; set; }
        public short? LetterTypeId { get; set; }
        public DateTime? MeetingStartDate { get; set; }
    }
}
