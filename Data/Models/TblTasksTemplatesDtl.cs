using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblTasksTemplatesDtl
    {
        public int DetailId { get; set; }
        public int? TemplateId { get; set; }
        public int? DaysOut { get; set; }
        public string PersonResponsible { get; set; }
        public string Task { get; set; }
    }
}
