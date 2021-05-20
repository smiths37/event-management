using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptTasks
    {
        public string MeetingDesc { get; set; }
        public DateTime? MeetingStartDate { get; set; }
        public DateTime? MeetingStartTime { get; set; }
        public DateTime? MeetingEndTime { get; set; }
        public DateTime? MeetingEndDate { get; set; }
        public string LongDescription { get; set; }
        public string MeetingLocation { get; set; }
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
