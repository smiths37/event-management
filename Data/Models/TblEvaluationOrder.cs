using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluationOrder
    {
        public TblEvaluationOrder()
        {
            TblEvaluationOrderResponses = new HashSet<TblEvaluationOrderResponses>();
        }

        public int EvaluationOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int PersonId { get; set; }
        public int EvaluationId { get; set; }
        public int OrderType { get; set; }
        public string EvaluationOrderDescription { get; set; }
        public DateTime? EvaluationDate { get; set; }
        public string Comments { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? MailInPrintDate { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblEvaluation Evaluation { get; set; }
        public virtual TblPeople Person { get; set; }
        public virtual ICollection<TblEvaluationOrderResponses> TblEvaluationOrderResponses { get; set; }
    }
}
