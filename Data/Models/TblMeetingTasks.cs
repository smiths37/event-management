using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblMeetingTasks
    {
        public string MeetingCode { get; set; }
        public int? TemplateId { get; set; }
        public int? DetailId { get; set; }
        public int? DaysOut { get; set; }
        public DateTime? DateDue { get; set; }
        public DateTime? TimeDue { get; set; }
        public string PersonResponsible { get; set; }
        public string Task { get; set; }
        public DateTime? DateCompleted { get; set; }
        public DateTime? TimeCompleted { get; set; }
        public int MeetingTaskId { get; set; }
    }
}
