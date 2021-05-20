using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCongressionalDistricts
    {
        public TblCongressionalDistricts()
        {
            TblCongress = new HashSet<TblCongress>();
        }

        public string DistrictId { get; set; }
        public string DistrictName { get; set; }
        public string DistrictAddress1 { get; set; }
        public string DistrictAddress2 { get; set; }
        public string DistrictCounty { get; set; }
        public string DistrictCity { get; set; }
        public string DistrictState { get; set; }
        public string DistrictZip { get; set; }
        public string DistrictPhone1 { get; set; }
        public string DistrictPhone2 { get; set; }
        public string DistrictFax { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblCongress> TblCongress { get; set; }
    }
}
