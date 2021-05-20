using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassEvaluationQuestions
    {
        public TblClassEvaluationQuestions()
        {
            TblClassEvaluationQuestionsItems = new HashSet<TblClassEvaluationQuestionsItems>();
        }

        public int EvaluationQuestionId { get; set; }
        public int ClassEvaluationId { get; set; }
        public int? QuestionId { get; set; }
        public string QuestionText { get; set; }
        public string QuestionNumberDisplay { get; set; }
        public int? CategoryId { get; set; }
        public int? TypeId { get; set; }
        public string Comment { get; set; }
        public bool? WebDisplayComment { get; set; }
        public short? WebSortOrder { get; set; }
        public int ResponseTypeId { get; set; }
        public bool AnswerRequired { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassQuestionCategory Category { get; set; }
        public virtual TblClassEvaluations ClassEvaluation { get; set; }
        public virtual TblClassQuestionDisplayType Type { get; set; }
        public virtual ICollection<TblClassEvaluationQuestionsItems> TblClassEvaluationQuestionsItems { get; set; }
    }
}
