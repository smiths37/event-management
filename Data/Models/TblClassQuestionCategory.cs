using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassQuestionCategory
    {
        public TblClassQuestionCategory()
        {
            TblClassEvaluationQuestions = new HashSet<TblClassEvaluationQuestions>();
            TblClassQuestionBank = new HashSet<TblClassQuestionBank>();
            TblClassTestQuestions = new HashSet<TblClassTestQuestions>();
        }

        public int CategoryId { get; set; }
        public string CategoryDesc { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual ICollection<TblClassEvaluationQuestions> TblClassEvaluationQuestions { get; set; }
        public virtual ICollection<TblClassQuestionBank> TblClassQuestionBank { get; set; }
        public virtual ICollection<TblClassTestQuestions> TblClassTestQuestions { get; set; }
    }
}
