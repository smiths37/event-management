using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblBroadcastLetters
    {
        public string LetterName { get; set; }
        public string Header { get; set; }
        public string Body { get; set; }
        public string Footer { get; set; }
        public string Notes { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string Attachment { get; set; }
    }
}
