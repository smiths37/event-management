using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCompanies
    {
        public TblCompanies()
        {
            TblCompanyAddresses = new HashSet<TblCompanyAddresses>();
            TblCompanyEmails = new HashSet<TblCompanyEmails>();
            TblExhibitors = new HashSet<TblExhibitors>();
            TblMembership = new HashSet<TblMembership>();
            TblPeople = new HashSet<TblPeople>();
        }

        public int CompanyId { get; set; }
        public string RefId { get; set; }
        public string CompanyName { get; set; }
        public int? ParentCompanyId { get; set; }
        public string ParentName { get; set; }
        public string AlphaIndexName { get; set; }
        public string CorporateBilling { get; set; }
        public int? RepId { get; set; }
        public string InternetDomain { get; set; }
        public string CompanyEmail { get; set; }
        public int? CompanyType { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public int? AddressId { get; set; }
        public int? SourceId { get; set; }
        public string User1 { get; set; }
        public string User2 { get; set; }
        public string User3 { get; set; }
        public string User4 { get; set; }
        public string User5 { get; set; }
        public string User6 { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCompanyTypes CompanyTypeNavigation { get; set; }
        public virtual TblReps Rep { get; set; }
        public virtual TblCompanyDirectory TblCompanyDirectory { get; set; }
        public virtual TblCompanyVendor TblCompanyVendor { get; set; }
        public virtual ICollection<TblCompanyAddresses> TblCompanyAddresses { get; set; }
        public virtual ICollection<TblCompanyEmails> TblCompanyEmails { get; set; }
        public virtual ICollection<TblExhibitors> TblExhibitors { get; set; }
        public virtual ICollection<TblMembership> TblMembership { get; set; }
        public virtual ICollection<TblPeople> TblPeople { get; set; }
    }
}
