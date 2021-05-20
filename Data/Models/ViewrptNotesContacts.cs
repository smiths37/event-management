using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class ViewrptNotesContacts
    {
        public string PersonResponsible { get; set; }
        public int? RegId { get; set; }
        public int? PersonId { get; set; }
        public DateTime? FollowUpDate { get; set; }
        public DateTime? DateCompleted { get; set; }
        public string CompletedBy { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string Middle { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Phone { get; set; }
        public string Extension { get; set; }
        public string Fax { get; set; }
        public int? PeopleType { get; set; }
        public string PeopleTypeDesc { get; set; }
        public string MeetingCode { get; set; }
        public int? AddressId { get; set; }
        public int NoteId { get; set; }
        public string Notes { get; set; }
        public bool? Primary { get; set; }
    }
}
