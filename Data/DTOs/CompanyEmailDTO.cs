using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class CompanyEmailDTO
    {
        public CompanyEmailDTO() { }
        public int emailId { get; set; }
        public int companyId { get; set; }
        public string emailTypeDesc { get; set; }
        public string EmailAddress { get; set; }
        public int? emailType { get; set; }

    }
}
