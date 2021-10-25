using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class PersonCreditTypeDTO
    {
        public int id { get; set; }
        public int personId { get; set; }
        public string creditTypeCode { get; set; }
        public string creditTypeDesc { get; set; }
    }
}
