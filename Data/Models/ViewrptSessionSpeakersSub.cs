using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSessionSpeakersSub
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public string TitleOfTalk { get; set; }
        public int PersonId { get; set; }
    }
}
