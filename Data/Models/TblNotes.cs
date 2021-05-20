using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblNotes
    {
        public int NoteId { get; set; }
        public DateTime? NoteDate { get; set; }
        public string PersonResponsible { get; set; }
        public int? RegId { get; set; }
        public string MeetingCode { get; set; }
        public int? PersonId { get; set; }
        public string Notes { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string CompletedBy { get; set; }
        public DateTime? DateEntered { get; set; }
        public string EnteredBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public string UpdatedBy { get; set; }
        public string Topic { get; set; }
        public byte[] UpsizeTs { get; set; }
        public int? ExhibitorId { get; set; }
        public int? MeetingId { get; set; }
        public int? CompanyId { get; set; }
    }
}
