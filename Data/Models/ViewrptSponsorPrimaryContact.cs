using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptSponsorPrimaryContact
    {
        public int PersonId { get; set; }
        public int? CompanyId { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public bool PrimaryContact { get; set; }
        public string Salutation { get; set; }
    }
}
