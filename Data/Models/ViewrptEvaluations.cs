using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptEvaluations
    {
        public int EvalId { get; set; }
        public string EvalDescription { get; set; }
        public int? SectionNumber { get; set; }
        public string SectionTitle { get; set; }
        public int? QuestionNumber { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public int? ResponseType { get; set; }
        public string ChoiceDisplay { get; set; }
    }
}
