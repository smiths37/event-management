using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassTestsOrders
    {
        public int ClassId { get; set; }
        public string NameOfClass { get; set; }
        public int ClassTestId { get; set; }
        public string TestDescription { get; set; }
        public int ParticipantId { get; set; }
        public int OrderType { get; set; }
        public string TestOrderDescription { get; set; }
        public DateTime? TestDate { get; set; }
        public DateTime? DateCertificatePrinted { get; set; }
        public DateTime? DateTestEvaluationCompleted { get; set; }
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
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public double? TotalPaid { get; set; }
        public int TestOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
    }
}
