using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblReps
    {
        public TblReps()
        {
            TblCompanies = new HashSet<TblCompanies>();
        }

        public int RepId { get; set; }
        public string RepFirstName { get; set; }
        public string RepLastName { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCompanies> TblCompanies { get; set; }
    }
}
