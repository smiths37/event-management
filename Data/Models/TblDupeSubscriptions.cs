using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDupeSubscriptions
    {
        public int SubscriptionId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? RunDate { get; set; }
        public int? PersonId { get; set; }
        public int? AddressId { get; set; }
        public double? NumIssues { get; set; }
        public double? IssuesMailed { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
