using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassEvaluationOrderResponses
    {
        public int ResponseId { get; set; }
        public int EvaluationOrderId { get; set; }
        public int EvaluationQuestionId { get; set; }
        public string SelectedAnswer { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassEvaluationOrder EvaluationOrder { get; set; }
    }
}
