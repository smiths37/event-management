using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEmailTypes
    {
        public TblEmailTypes()
        {
            TblCompanyEmails = new HashSet<TblCompanyEmails>();
            TblPeopleEmails = new HashSet<TblPeopleEmails>();
        }

        public int EmailTypeId { get; set; }
        public string EmailTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCompanyEmails> TblCompanyEmails { get; set; }
        public virtual ICollection<TblPeopleEmails> TblPeopleEmails { get; set; }
    }
}
