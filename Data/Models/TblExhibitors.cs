using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblExhibitors
    {
        public int CompanyId { get; set; }
        public int? PersonId { get; set; }
        public string MeetingCode { get; set; }
        public double? NumberOfBooths { get; set; }
        public double? CostPerBooth { get; set; }
        public double? TotalCost { get; set; }
        public double? DepositAmount { get; set; }
        public double? BalanceDue { get; set; }
        public string BoothLoc1 { get; set; }
        public string BoothLoc2 { get; set; }
        public string BoothLoc3 { get; set; }
        public string BoothLoc4 { get; set; }
        public string SponsoredEvents { get; set; }
        public DateTime? DepositReceived { get; set; }
        public DateTime? PacketSent { get; set; }
        public DateTime? ConfirmationSent { get; set; }
        public string Profile { get; set; }
        public int? SourceId { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int ExhibitorId { get; set; }

        public virtual TblCompanies Company { get; set; }
        public virtual TblMeetings MeetingCodeNavigation { get; set; }
    }
}
