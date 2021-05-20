using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalQuestions
    {
        public int QuestionId { get; set; }
        public int SectionId { get; set; }
        public int? QuestionNumber { get; set; }
        public string QuestionTitle { get; set; }
        public string QuestionType { get; set; }
        public string Question { get; set; }
        public int? ResponseType { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
