using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCompanyTypes
    {
        public TblCompanyTypes()
        {
            TblCompanies = new HashSet<TblCompanies>();
        }

        public int CompanyTypeId { get; set; }
        public string CompanyTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCompanies> TblCompanies { get; set; }
    }
}
