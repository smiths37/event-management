using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblAddressTypes
    {
        public TblAddressTypes()
        {
            TblCompanyAddresses = new HashSet<TblCompanyAddresses>();
            TblPeopleAddresses = new HashSet<TblPeopleAddresses>();
        }

        public int AddressTypeId { get; set; }
        public string AddressTypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCompanyAddresses> TblCompanyAddresses { get; set; }
        public virtual ICollection<TblPeopleAddresses> TblPeopleAddresses { get; set; }
    }
}
