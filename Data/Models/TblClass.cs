using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClass
    {
        public TblClass()
        {
            TblClassEvaluations = new HashSet<TblClassEvaluations>();
            TblClassFaq = new HashSet<TblClassFaq>();
            TblClassParticipation = new HashSet<TblClassParticipation>();
        }

        public int ClassId { get; set; }
        public string NameOfClass { get; set; }
        public string LongDesc { get; set; }
        public string MeetingCode { get; set; }
        public string RelatedMeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int? SubjectAreaId { get; set; }
        public string SubmittedBy { get; set; }
        public DateTime? DateSubmitted { get; set; }
        public DateTime? DateOriginalRelease { get; set; }
        public DateTime? WebExpirationDate { get; set; }
        public string StatementOfIntent { get; set; }
        public int? ParticipationMethodId { get; set; }
        public int? AudienceTypeId { get; set; }
        public bool AllowOnWeb { get; set; }
        public bool Active { get; set; }
        public bool WebDisplayObjectives { get; set; }
        public bool WebDisplayRelatedClasses { get; set; }
        public bool WebDisplayRequiredMedia { get; set; }
        public bool WebDisplayFaq { get; set; }
        public bool WebDisplayInstructors { get; set; }
        public bool? WebDisplayTopics { get; set; }
        public bool? WebDisplayCourseMediaLinks { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string ClassMaterialInstruction { get; set; }
        public string ClassDetailInstructions { get; set; }
        public string ClassMinSysRequirements { get; set; }
        public string ClassTestInstructions { get; set; }
        public string Classcode { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassAudienceTypes AudienceType { get; set; }
        public virtual TblMeetings MeetingCodeNavigation { get; set; }
        public virtual TblClassParticipationMethods ParticipationMethod { get; set; }
        public virtual TblClassSubjectAreas SubjectArea { get; set; }
        public virtual ICollection<TblClassEvaluations> TblClassEvaluations { get; set; }
        public virtual ICollection<TblClassFaq> TblClassFaq { get; set; }
        public virtual ICollection<TblClassParticipation> TblClassParticipation { get; set; }
    }
}
