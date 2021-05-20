using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvaluationQuestionBank
    {
        public TblEvaluationQuestionBank()
        {
            TblEvaluationQuestionBankItems = new HashSet<TblEvaluationQuestionBankItems>();
        }

        public int QuestionId { get; set; }
        public string QuestionText { get; set; }
        public int? CategoryId { get; set; }
        public int? TypeId { get; set; }
        public string QuestionAnswer { get; set; }
        public double QuestionWeight { get; set; }
        public string Comment { get; set; }
        public decimal? BankSortOrder { get; set; }
        public int ResponseTypeId { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblEvaluationQuestionCategory Category { get; set; }
        public virtual TblEvaluationQuestionDisplayType Type { get; set; }
        public virtual ICollection<TblEvaluationQuestionBankItems> TblEvaluationQuestionBankItems { get; set; }
    }
}
