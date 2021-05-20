using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class PeopleDTO
    {
        public PeopleDTO() { }

        public int PersonId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string ssn { get; set; }
        public int CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public int AddressId { get; set; }
        public bool PrimaryContact { get; set; }
        public bool SellName { get; set; }
        public bool IncludeInDirectory { get; set; }
        public bool IncludeInMemDirectory { get; set; }
        public string BadgeName { get; set; }
        public string Salutation { get; set; }
        public int PeopleType { get; set; }
        public int ContactType { get; set; }
        public int SourceId { get; set; }
        public string Email { get; set; }
        public string MailPref { get; set; }
        public bool DoNotMail { get; set; }
        public string CellPhone { get; set; }
        public string Updated { get; set; }     //user1 
        public string Assocation { get; set; }  //user2
        public string Level { get; set; }      //user3
        public string AppointedElectedHired { get; set; } //user4
        public string AssumedOffice { get; set; }   //user5
        public string ResignedTerminated { get; set; }  //user6
        public string FormalTitle { get; set; }
        public string JudgeId { get; set; }
        public DateTime Basic { get; set; }
        public DateTime Advance { get; set; }
        public DateTime Distinguished { get; set; }
        public DateTime Outstanding { get; set; }
        public DateTime SctNjc { get; set; }
        public DateTime Ccmdate { get; set; }
        public DateTime Ccedate { get; set; }
        public DateTime Cedpdate { get; set; }
        public string Icmreport { get; set; }
        public DateTime Faculty { get; set; }
        public string peopleTypeDesc { get; set; }
        public string contactTypeDesc { get; set; }

    }
}
