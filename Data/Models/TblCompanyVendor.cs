using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCompanyVendor
    {
        public int CompanyId { get; set; }
        public string VendorType { get; set; }
        public int? VendorTypeId { get; set; }
        public string TaxId { get; set; }
        public string VendorNotes { get; set; }
        public bool Print1099Forms { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblCompanies Company { get; set; }
    }
}
