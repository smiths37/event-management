using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCompanyDirectory
    {
        public int DirectoryId { get; set; }
        public int CompanyId { get; set; }
        public string CompanyDescription { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCompanies Company { get; set; }
    }
}
