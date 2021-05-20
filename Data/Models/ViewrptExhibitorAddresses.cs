using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptExhibitorAddresses
    {
        public string Company { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public bool? CompanyPrimary { get; set; }
        public string CompanyPhone { get; set; }
        public string CompanyFax { get; set; }
        public int? PersonRegId { get; set; }
        public double? NumberOfBooths { get; set; }
        public double? CostPerBooth { get; set; }
        public double? DepositAmount { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string CountryName { get; set; }
        public int CompanyId { get; set; }
        public int? PersonId { get; set; }
        public string MeetingCode { get; set; }
        public double? BalanceDue { get; set; }
        public double? TotalCost { get; set; }
        public string BoothLoc1 { get; set; }
        public string BoothLoc2 { get; set; }
        public string BoothLoc3 { get; set; }
        public string BoothLoc4 { get; set; }
        public string SponsoredEvents { get; set; }
        public DateTime? DepositReceived { get; set; }
        public DateTime? PacketSent { get; set; }
        public DateTime? ConfirmationSent { get; set; }
        public string Profile { get; set; }
        public string BadgeName { get; set; }
    }
}
