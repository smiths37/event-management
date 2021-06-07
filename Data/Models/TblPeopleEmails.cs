using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPeopleEmails
    {
        public int PersonId { get; set; }
        public int? EmailType { get; set; }
        public string EmailAddress { get; set; }
        public int emailId { get; set; }

        public virtual TblEmailTypes EmailTypeNavigation { get; set; }
        public virtual TblPeople Person { get; set; }
    }
}
