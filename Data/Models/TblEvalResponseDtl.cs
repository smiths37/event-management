using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalResponseDtl
    {
        public int ResponseDetailId { get; set; }
        public int? EntryId { get; set; }
        public int? ResponseId { get; set; }
        public int? QuestionId { get; set; }
        public int? ResponseNumber { get; set; }
        public string ResponseMemo { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
