using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassEvaluations
    {
        public string NameOfClass { get; set; }
        public string MeetingCode { get; set; }
        public string SessionCode { get; set; }
        public int ClassEvaluationId { get; set; }
        public int ClassId { get; set; }
        public string EvaluationDescription { get; set; }
        public bool AllowOnWeb { get; set; }
        public bool Active { get; set; }
    }
}
