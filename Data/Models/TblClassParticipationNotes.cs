using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblClassParticipationNotes
    {
        public int NoteId { get; set; }
        public int ParticipantId { get; set; }
        public DateTime? NoteDate { get; set; }
        public string Notes { get; set; }
        public byte[] UpsizeTs { get; set; }
    }
}
