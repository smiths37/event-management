using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCertificateMeetingNotesSub
    {
        public int? PersonId { get; set; }
        public string CreditTypeCode { get; set; }
        public string Notes { get; set; }
        public string MeetingCode { get; set; }
    }
}
