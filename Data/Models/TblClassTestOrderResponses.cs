using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassTestOrderResponses
    {
        public int ResponseId { get; set; }
        public int TestOrderId { get; set; }
        public int TestQuestionId { get; set; }
        public string SelectedAnswer { get; set; }
        public bool? Correct { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public byte[] UpsizeTs { get; set; }

        public virtual TblClassTestOrder TestOrder { get; set; }
        public virtual TblClassTestQuestions TestQuestion { get; set; }
    }
}
