using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTestQuestions
    {
        public TblClassTestQuestions()
        {
            TblClassTestOrderResponses = new HashSet<TblClassTestOrderResponses>();
            TblClassTestQuestionsItems = new HashSet<TblClassTestQuestionsItems>();
        }

        public int TestQuestionId { get; set; }
        public int ClassTestId { get; set; }
        public int? QuestionId { get; set; }
        public string QuestionNumberDisplay { get; set; }
        public string QuestionText { get; set; }
        public string QuestionAnswer { get; set; }
        public double QuestionWeight { get; set; }
        public int? CategoryId { get; set; }
        public int? TypeId { get; set; }
        public string Comment { get; set; }
        public bool? WebDisplayComment { get; set; }
        public short? WebSortOrder { get; set; }
        public bool IncludeInScore { get; set; }
        public bool AnswerRequired { get; set; }
        public string ImageUrl { get; set; }
        public string ThumbnailUrl { get; set; }
        public int ResponseTypeId { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassQuestionCategory Category { get; set; }
        public virtual TblClassTests ClassTest { get; set; }
        public virtual TblClassQuestionDisplayType Type { get; set; }
        public virtual ICollection<TblClassTestOrderResponses> TblClassTestOrderResponses { get; set; }
        public virtual ICollection<TblClassTestQuestionsItems> TblClassTestQuestionsItems { get; set; }
    }
}
