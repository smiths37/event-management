using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblEvalResponseChoices
    {
        public int ResponseType { get; set; }
        public int ChoiceNumber { get; set; }
        public string ChoiceDesc { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
