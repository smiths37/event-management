using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassLinks
    {
        public int LinkId { get; set; }
        public int ClassId { get; set; }
        public int LinkTypeId { get; set; }
        public string LinkWebDesc { get; set; }
        public string LinkComment { get; set; }
        public bool? DisplayWebComment { get; set; }
        public string LinkUrl { get; set; }
        public string UrllinkDisplayText { get; set; }
        public short? WebSortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassLinkTypes LinkType { get; set; }
    }
}
