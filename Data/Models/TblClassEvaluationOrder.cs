using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassEvaluationOrder
    {
        public TblClassEvaluationOrder()
        {
            TblClassEvaluationOrderResponses = new HashSet<TblClassEvaluationOrderResponses>();
        }

        public int EvaluationOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ParticipantId { get; set; }
        public int ClassEvaluationId { get; set; }
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

        public virtual TblClassEvaluations ClassEvaluation { get; set; }
        public virtual TblClassParticipation Participant { get; set; }
        public virtual ICollection<TblClassEvaluationOrderResponses> TblClassEvaluationOrderResponses { get; set; }
    }
}
