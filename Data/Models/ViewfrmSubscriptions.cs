using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewfrmSubscriptions
    {
        public int SubscriptionId { get; set; }
        public int? OrderId { get; set; }
        public int? ProductId { get; set; }
        public int? Qty { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? PersonId { get; set; }
        public int? ShipToCompanyId { get; set; }
        public int? AddressId { get; set; }
        public string CompanyName { get; set; }
        public string Description { get; set; }
        public int? BillToCompanyId { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateModified { get; set; }
        public string ModifiedBy { get; set; }
        public double? NumIssues { get; set; }
        public double? IssuesMailed { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string NamePrefix { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
    }
}
