using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTestQuestionsItems
    {
        public int QuestionItemId { get; set; }
        public int TestQuestionId { get; set; }
        public string ItemDisplay { get; set; }
        public string QuestionItemText { get; set; }
        public string ItemValue { get; set; }
        public bool? CorrectResponse { get; set; }
        public short ItemSortOrder { get; set; }
        public string ItemComment { get; set; }
        public bool? WebDisplayItemComment { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassTestQuestions TestQuestion { get; set; }
    }
}
