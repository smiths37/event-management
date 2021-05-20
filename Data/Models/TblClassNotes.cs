using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassNotes
    {
        public int NoteId { get; set; }
        public int ClassId { get; set; }
        public DateTime? NoteDate { get; set; }
        public string Notes { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
