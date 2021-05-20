using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblTasksTemplatesHdr
    {
        public int TemplateId { get; set; }
        public string Description { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
    }
}
