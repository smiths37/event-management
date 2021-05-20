using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblCongressComments
    {
        public int CommentId { get; set; }
        public DateTime? CommentDate { get; set; }
        public int? RepId { get; set; }
        public string Comments { get; set; }
        public int? StatusCode { get; set; }
        public int? CommentTaker { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
