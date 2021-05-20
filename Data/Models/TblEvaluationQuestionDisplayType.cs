using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluationQuestionDisplayType
    {
        public TblEvaluationQuestionDisplayType()
        {
            TblEvaluationQuestionBank = new HashSet<TblEvaluationQuestionBank>();
            TblEvaluationQuestions = new HashSet<TblEvaluationQuestions>();
        }

        public int TypeId { get; set; }
        public string TypeDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblEvaluationQuestionBank> TblEvaluationQuestionBank { get; set; }
        public virtual ICollection<TblEvaluationQuestions> TblEvaluationQuestions { get; set; }
    }
}
