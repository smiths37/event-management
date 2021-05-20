using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class EmailUpdates
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Organization { get; set; }
        public string NewOrganization { get; set; }
        public string Email { get; set; }
        public string NewEmail { get; set; }
        public string EmailAddress { get; set; }
        public string NewEmailAddress { get; set; }
    }
}
