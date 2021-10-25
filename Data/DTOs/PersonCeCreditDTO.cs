using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class PersonCeCreditDTO
    {
        public int keyId { get; set; }
        public int? personId { get; set; }
        public DateTime? creditDate { get; set; }
        public string meetingCode { get; set; }
        public string regCode { get; set; }
        public string sessionCode { get; set; }
        public string creditTypeCode { get; set; }
        public double? creditUnits { get; set; }
        public string title { get; set; }
        public bool? selfReported { get; set; }
    }
}
