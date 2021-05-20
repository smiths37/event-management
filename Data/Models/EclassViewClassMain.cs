using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassMain
    {
        public string MeetingCode { get; set; }
        public string MeetingDesc { get; set; }
        public string SessionCode { get; set; }
        public string Description { get; set; }
        public string SubjectAreaDesc { get; set; }
        public string ParticipationMethodDesc { get; set; }
        public string AudienceTypeDesc { get; set; }
        public int ClassId { get; set; }
        public string NameOfClass { get; set; }
        public string LongDesc { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DateOriginalRelease { get; set; }
        public DateTime? WebExpirationDate { get; set; }
        public string StatementOfIntent { get; set; }
        public bool AllowOnWeb { get; set; }
        public bool Active { get; set; }
        public bool WebDisplayObjectives { get; set; }
        public bool WebDisplayRelatedClasses { get; set; }
        public bool WebDisplayRequiredMedia { get; set; }
        public bool WebDisplayFaq { get; set; }
        public bool WebDisplayInstructors { get; set; }
        public bool? WebDisplayTopics { get; set; }
        public bool? WebDisplayCourseMediaLinks { get; set; }
    }
}
