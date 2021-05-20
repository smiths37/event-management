using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassMediaTypes
    {
        public TblClassMediaTypes()
        {
            TblClassRequiredMediaTypes = new HashSet<TblClassRequiredMediaTypes>();
        }

        public int MediaTypeId { get; set; }
        public string MediaTypeDesc { get; set; }
        public string MediaDownLoadUrl { get; set; }
        public string LongDesc { get; set; }
        public string ImageUrl { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClassRequiredMediaTypes> TblClassRequiredMediaTypes { get; set; }
    }
}
