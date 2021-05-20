using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblInformationRequests
    {
        public TblInformationRequests()
        {
            TblInfoRequestItems = new HashSet<TblInfoRequestItems>();
        }

        public int InfoRequestId { get; set; }
        public int PersonId { get; set; }
        public DateTime DateRequested { get; set; }
        public DateTime? DateFulfilled { get; set; }
        public DateTime? LabelPrinted { get; set; }
        public int? RepId { get; set; }
        public DateTime? NextContactDate { get; set; }
        public string Comments { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblPeople Person { get; set; }
        public virtual ICollection<TblInfoRequestItems> TblInfoRequestItems { get; set; }
    }
}
