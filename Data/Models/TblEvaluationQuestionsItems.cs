using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluationQuestionsItems
    {
        public int QuestionItemId { get; set; }
        public int EvaluationQuestionId { get; set; }
        public string ItemDisplay { get; set; }
        public string QuestionItemText { get; set; }
        public string ItemValue { get; set; }
        public short ItemSortOrder { get; set; }
        public string ItemComment { get; set; }
        public bool? WebDisplayItemComment { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblEvaluationQuestions EvaluationQuestion { get; set; }
    }
}
