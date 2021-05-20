using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSpeakers
    {
        public int PersonId { get; set; }
        public int? SpeakerType { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public string TitleOfTalk { get; set; }
        public string SubjectArea { get; set; }
        public double? Honorarium { get; set; }
        public double? TravelAllowance { get; set; }
        public DateTime? ConfirmationSent { get; set; }
        public DateTime? AcceptanceReceived { get; set; }
        public bool Handouts { get; set; }
        public bool Received { get; set; }
        public double? NumberCopies { get; set; }
        public bool Biography { get; set; }
        public bool Picture { get; set; }
        public string AVNeeds { get; set; }
        public string Comments { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblPeople Person { get; set; }
        public virtual TblSpeakerTypes SpeakerTypeNavigation { get; set; }
    }
}
