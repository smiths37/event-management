using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TempPeopleCecredits
    {
        public int? KeyId { get; set; }
        public int? PersonId { get; set; }
        public int? RegId { get; set; }
        public DateTime? SortDate { get; set; }
        public DateTime? CreditDate { get; set; }
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public string SessionCode { get; set; }
        public string CreditTypeCode { get; set; }
        public int? CreditTypeId { get; set; }
        public double? CreditUnits { get; set; }
        public string Title { get; set; }
        public string User { get; set; }
    }
}
