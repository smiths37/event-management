using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassRelatedClasses
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int RelatedClassId { get; set; }
        public string Urllink { get; set; }
        public string Comment { get; set; }
        public bool? WebDisplayComment { get; set; }
        public short? WebSortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
