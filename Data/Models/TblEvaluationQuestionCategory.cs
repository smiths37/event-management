using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluationQuestionCategory
    {
        public TblEvaluationQuestionCategory()
        {
            TblEvaluationQuestionBank = new HashSet<TblEvaluationQuestionBank>();
            TblEvaluationQuestions = new HashSet<TblEvaluationQuestions>();
        }

        public int CategoryId { get; set; }
        public string CategoryDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblEvaluationQuestionBank> TblEvaluationQuestionBank { get; set; }
        public virtual ICollection<TblEvaluationQuestions> TblEvaluationQuestions { get; set; }
    }
}
