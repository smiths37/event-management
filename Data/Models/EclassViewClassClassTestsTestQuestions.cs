using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassTestsTestQuestions
    {
        public int ClassTestId { get; set; }
        public string TestDescription { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public string QuestionNumberDisplay { get; set; }
        public string QuestionText { get; set; }
        public int ResponseTypeId { get; set; }
        public short? WebSortOrder { get; set; }
        public int ClassId { get; set; }
        public int TestQuestionId { get; set; }
        public string NameOfClass { get; set; }
    }
}
