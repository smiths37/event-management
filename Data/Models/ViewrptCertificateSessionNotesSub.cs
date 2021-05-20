using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptCertificateSessionNotesSub
    {
        public int? PersonId { get; set; }
        public string CreditTypeCode { get; set; }
        public string Notes { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
    }
}
