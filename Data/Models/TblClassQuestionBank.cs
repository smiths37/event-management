using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassQuestionBank
    {
        public TblClassQuestionBank()
        {
            TblClassQuestionBankItems = new HashSet<TblClassQuestionBankItems>();
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

        public virtual TblClassQuestionCategory Category { get; set; }
        public virtual TblClassQuestionDisplayType Type { get; set; }
        public virtual ICollection<TblClassQuestionBankItems> TblClassQuestionBankItems { get; set; }
    }
}
