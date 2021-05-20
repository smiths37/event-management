using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCompanyAddresses
    {
        public int AddressId { get; set; }
        public int CompanyId { get; set; }
        public bool Primary { get; set; }
        public string Phone { get; set; }
        public string _800 { get; set; }
        public string Fax { get; set; }
        public int AddressType { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public int? CountryId { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblAddressTypes AddressTypeNavigation { get; set; }
        public virtual TblCompanies Company { get; set; }
        public virtual TblCountries Country { get; set; }
        public virtual TblStates StateNavigation { get; set; }
    }
}
