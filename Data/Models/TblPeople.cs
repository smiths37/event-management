using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPeople
    {
        public TblPeople()
        {
            TblClassParticipation = new HashSet<TblClassParticipation>();
            TblCommitteeMembership = new HashSet<TblCommitteeMembership>();
            TblContacts = new HashSet<TblContacts>();
            TblEvaluationOrder = new HashSet<TblEvaluationOrder>();
            TblInformationRequests = new HashSet<TblInformationRequests>();
            TblInterests = new HashSet<TblInterests>();
            TblListMembers = new HashSet<TblListMembers>();
            TblPeopleAddresses = new HashSet<TblPeopleAddresses>();
            TblPeopleEmails = new HashSet<TblPeopleEmails>();
            TblSpeakers = new HashSet<TblSpeakers>();
        }

        public int PersonId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Ssn { get; set; }
        public int? CompanyId { get; set; }
        public string CompanyName { get; set; }
        public string Title { get; set; }
        public string Dept { get; set; }
        public int? AddressId { get; set; }
        public string RefId { get; set; }
        public bool PrimaryContact { get; set; }
        public bool SellName { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] Photo { get; set; }
        public int? DirectorySortOrder { get; set; }
        public bool IncludeInDirectory { get; set; }
        public bool IncludeInMemDirectory { get; set; }
        public int? MemSortOrder { get; set; }
        public string BadgeName { get; set; }
        public string Salutation { get; set; }
        public int? PeopleType { get; set; }
        public int? ContactType { get; set; }
        public int? SourceId { get; set; }
        public int? SpecialtyId { get; set; }
        public string Email { get; set; }
        public string MailPref { get; set; }
        public bool DoNotMail { get; set; }
        public string CellPhone { get; set; }
        public string Pager { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public DateTime? DisclaimerExpDate { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? PeopleSourceCode { get; set; }
        public string FormalTitle { get; set; }
        public string JudgeId { get; set; }
        public DateTime? Basic { get; set; }
        public DateTime? Advance { get; set; }
        public DateTime? Distinguished { get; set; }
        public DateTime? Outstanding { get; set; }
        public DateTime? SctNjc { get; set; }
        public DateTime? Ccmdate { get; set; }
        public DateTime? Ccedate { get; set; }
        public DateTime? Cedpdate { get; set; }
        public string Icmreport { get; set; }
        public DateTime? Faculty { get; set; }

        public virtual TblCompanies Company { get; set; }
        public virtual TblContactTypes ContactTypeNavigation { get; set; }
        public virtual TblPeopleTypes PeopleTypeNavigation { get; set; }
        public virtual TblSources Source { get; set; }
        public virtual TblSpecialties Specialty { get; set; }
        public virtual ICollection<TblClassParticipation> TblClassParticipation { get; set; }
        public virtual ICollection<TblCommitteeMembership> TblCommitteeMembership { get; set; }
        public virtual ICollection<TblContacts> TblContacts { get; set; }
        public virtual ICollection<TblEvaluationOrder> TblEvaluationOrder { get; set; }
        public virtual ICollection<TblInformationRequests> TblInformationRequests { get; set; }
        public virtual ICollection<TblInterests> TblInterests { get; set; }
        public virtual ICollection<TblListMembers> TblListMembers { get; set; }
        public virtual ICollection<TblPeopleAddresses> TblPeopleAddresses { get; set; }
        public virtual ICollection<TblPeopleEmails> TblPeopleEmails { get; set; }
        public virtual ICollection<TblSpeakers> TblSpeakers { get; set; }
    }
}
