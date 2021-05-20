using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblUserFields
    {
        public int UserFieldId { get; set; }
        public bool Default { get; set; }
        public string MeetingCode { get; set; }
        public string FieldGroup { get; set; }
        public string FieldName { get; set; }
        public string LabelCaption { get; set; }
        public string Choices { get; set; }
    }
}
