using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ZzzRelations
    {
        public string SzReferencedObject { get; set; }
        public string SzReferencedColumn { get; set; }
        public string SzObject { get; set; }
        public string SzColumn { get; set; }
        public int? Id { get; set; }
        public int? Ccolumn { get; set; }
        public int? Icolumn { get; set; }
        public string SzRelationship { get; set; }
        public bool Change { get; set; }
        public int? ChangeTo { get; set; }
        public string Notes { get; set; }
    }
}
