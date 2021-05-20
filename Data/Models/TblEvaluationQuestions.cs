using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluationQuestions
    {
        public TblEvaluationQuestions()
        {
            TblEvaluationQuestionsItems = new HashSet<TblEvaluationQuestionsItems>();
        }

        public int EvaluationQuestionId { get; set; }
        public int EvaluationId { get; set; }
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

        public virtual TblEvaluationQuestionCategory Category { get; set; }
        public virtual TblEvaluation Evaluation { get; set; }
        public virtual TblEvaluationQuestionDisplayType Type { get; set; }
        public virtual ICollection<TblEvaluationQuestionsItems> TblEvaluationQuestionsItems { get; set; }
    }
}
