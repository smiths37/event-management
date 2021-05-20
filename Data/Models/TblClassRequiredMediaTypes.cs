using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassRequiredMediaTypes
    {
        public int MediaId { get; set; }
        public int ClassId { get; set; }
        public int MediaTypeId { get; set; }
        public short? WebSortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassMediaTypes MediaType { get; set; }
    }
}
