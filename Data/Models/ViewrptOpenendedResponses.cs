using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptOpenendedResponses
    {
        public int EvalId { get; set; }
        public int? ResponseId { get; set; }
        public int? SectionNumber { get; set; }
        public int? QuestionNumber { get; set; }
        public string ResponseDesc { get; set; }
        public string QuestionTitle { get; set; }
        public int? ResponseNumber { get; set; }
        public string EvalDescription { get; set; }
        public string SectionTitle { get; set; }
        public int QuestionId { get; set; }
        public string Question { get; set; }
        public string ResponseMemo { get; set; }
    }
}
