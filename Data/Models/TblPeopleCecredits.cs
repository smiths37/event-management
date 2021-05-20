using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPeopleCecredits
    {
        public int KeyId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? SortDate { get; set; }
        public DateTime? CreditDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public string SessionCode { get; set; }
        public string CreditTypeCode { get; set; }
        public int? CreditTypeId { get; set; }
        public DateTime? DateCertificatePrinted { get; set; }
        public double? CreditUnits { get; set; }
        public string Title { get; set; }
        public bool? SelfReported { get; set; }
        public int? TestOrderId { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
