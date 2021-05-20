using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassQuestionBankItems
    {
        public int ItemId { get; set; }
        public int QuestionId { get; set; }
        public string ItemDisplay { get; set; }
        public string QuestionItemText { get; set; }
        public string ItemValue { get; set; }
        public bool? CorrectResponse { get; set; }
        public short ItemSortOrder { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassQuestionBank Question { get; set; }
    }
}
