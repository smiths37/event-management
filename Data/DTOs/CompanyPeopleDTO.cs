using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class CompanyPeopleDTO
    {
        public CompanyPeopleDTO() { }
        public int PersonId { get; set; }
        public int? CompanyId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public int PeopleType { get; set; }
        public int ContactType { get; set; }
        public string peopleTypeDesc { get; set; }
        public string contactTypeDesc { get; set; }
    }
}
