using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblStates
    {
        public TblStates()
        {
            TblCompanyAddresses = new HashSet<TblCompanyAddresses>();
            TblPeopleAddresses = new HashSet<TblPeopleAddresses>();
        }

        public string StateCode { get; set; }
        public string StateName { get; set; }
        public string ZipFrom { get; set; }
        public string ZipTo { get; set; }
        public float? SalesTaxRate { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int StateId { get; set; }

        public virtual ICollection<TblCompanyAddresses> TblCompanyAddresses { get; set; }
        public virtual ICollection<TblPeopleAddresses> TblPeopleAddresses { get; set; }
    }
}
