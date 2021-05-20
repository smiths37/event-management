using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassFaq
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public string QuestionNumberDisplay { get; set; }
        public string QuestionPrompt { get; set; }
        public string QuestionText { get; set; }
        public string AnswerPrompt { get; set; }
        public string QuestionAnswer { get; set; }
        public short? WebSortOrder { get; set; }
        public string UrlhelpLink { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClass Class { get; set; }
    }
}
