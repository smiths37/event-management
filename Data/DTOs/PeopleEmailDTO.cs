using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class PeopleEmailDTO
    {
        public int personId { get; set; }
        public string emailTypeDesc { get; set; }
        public string emailAddress { get; set; }
        public int emailId { get; set; }
        public int? emailType { get; set; }
    }
}
