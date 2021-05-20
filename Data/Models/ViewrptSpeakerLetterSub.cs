using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSpeakerLetterSub
    {
        public string Description { get; set; }
        public string LongDescription { get; set; }
        public string Location { get; set; }
        public string TitleOfTalk { get; set; }
        public string SubjectArea { get; set; }
        public string SpeakerTypeDesc { get; set; }
        public DateTime? SessionDate { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public int PersonId { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
    }
}
