using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblSystemDefaults
    {
        public string CompanyName { get; set; }
        public string BankName { get; set; }
        public string BankAcctNo { get; set; }
        public string MasterCardMerchNo { get; set; }
        public string VisaMerchNo { get; set; }
        public string DinersClubMerchNo { get; set; }
        public string AmexMerchNo { get; set; }
        public string DiscoverMerchNo { get; set; }
        public short? MembershipCycle { get; set; }
        public short? MembershipProcessing { get; set; }
        public DateTime? AnnualStart { get; set; }
        public DateTime? AnnualEnd { get; set; }
        public short? GracePeriod { get; set; }
        public bool Chapters { get; set; }
        public byte[] Logo { get; set; }
        public int? DefaultPaymentMethod { get; set; }
        public DateTime? DefaultEffectiveDate { get; set; }
        public DateTime? DefaultExpireDate { get; set; }
        public bool AutoDropCombos { get; set; }
        public string Department { get; set; }
        public short? OrderType { get; set; }
        public DateTime? ServerRefTablesUpdated { get; set; }
        public bool? EnableCetrak { get; set; }
        public string CetrakVersion { get; set; }
        public string CtctdeveloperApiKey { get; set; }
        public string CtctuserName { get; set; }
        public string Ctctpassword { get; set; }
        public string CtctloginUrl { get; set; }
        public string CtctapiUrl { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? DefaultAddressType { get; set; }
    }
}
