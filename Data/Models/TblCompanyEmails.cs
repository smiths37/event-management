using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCompanyEmails
    {
        public int EmailId { get; set; }
        public int CompanyId { get; set; }
        public int? EmailType { get; set; }
        public string EmailAddress { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCompanies Company { get; set; }
        public virtual TblEmailTypes EmailTypeNavigation { get; set; }
    }
}
