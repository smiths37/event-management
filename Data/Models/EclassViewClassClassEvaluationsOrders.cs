using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EclassViewClassClassEvaluationsOrders
    {
        public int ClassId { get; set; }
        public string NameOfClass { get; set; }
        public int ClassEvaluationId { get; set; }
        public string EvaluationDescription { get; set; }
        public int EvaluationOrderId { get; set; }
        public DateTime OrderDate { get; set; }
        public int ParticipantId { get; set; }
        public int OrderType { get; set; }
        public string EvaluationOrderDescription { get; set; }
        public DateTime? EvaluationDate { get; set; }
        public string Comments { get; set; }
        public DateTime? DatePosted { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Dept { get; set; }
        public string Title { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public string CountryName { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
    }
}
