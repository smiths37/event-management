using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCountries
    {
        public TblCountries()
        {
            TblCompanyAddresses = new HashSet<TblCompanyAddresses>();
            TblPeopleAddresses = new HashSet<TblPeopleAddresses>();
        }

        public int CountryId { get; set; }
        public string CountryName { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCompanyAddresses> TblCompanyAddresses { get; set; }
        public virtual ICollection<TblPeopleAddresses> TblPeopleAddresses { get; set; }
    }
}
