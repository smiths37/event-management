using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTestOrder
    {
        public TblClassTestOrder()
        {
            TblClassTestOrderPayments = new HashSet<TblClassTestOrderPayments>();
            TblClassTestOrderResponses = new HashSet<TblClassTestOrderResponses>();
        }

        public int TestOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ParticipantId { get; set; }
        public int ClassTestId { get; set; }
        public int OrderType { get; set; }
        public string TestOrderDescription { get; set; }
        public DateTime? TestDate { get; set; }
        public DateTime? DateCertificatePrinted { get; set; }
        public DateTime? DateTestEvaluationCompleted { get; set; }
        public int? EvaluationOrderId { get; set; }
        public double? FinalTestScore { get; set; }
        public double? MaxPossiblePoints { get; set; }
        public double? MinPossiblePoints { get; set; }
        public bool? Pass { get; set; }
        public string Comments { get; set; }
        public double? Fees { get; set; }
        public double? OtherFees { get; set; }
        public string OtherFeesDesc { get; set; }
        public double? DiscountFees { get; set; }
        public string DiscountReason { get; set; }
        public double? RefundAmount { get; set; }
        public string RefundReason { get; set; }
        public DateTime? DatePosted { get; set; }
        public DateTime? DateCreditsPosted { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? MailInPrintDate { get; set; }
        public DateTime? DateEntered { get; set; }
        public string UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassTests ClassTest { get; set; }
        public virtual TblClassParticipation Participant { get; set; }
        public virtual ICollection<TblClassTestOrderPayments> TblClassTestOrderPayments { get; set; }
        public virtual ICollection<TblClassTestOrderResponses> TblClassTestOrderResponses { get; set; }
    }
}
