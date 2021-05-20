using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassEvaluationsEvaluationQuestions
    {
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int ClassId { get; set; }
        public string NameOfClass { get; set; }
        public string EvaluationDescription { get; set; }
        public int EvaluationQuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionNumberDisplay { get; set; }
        public short? WebSortOrder { get; set; }
        public int ClassEvaluationId { get; set; }
        public int ResponseTypeId { get; set; }
    }
}
