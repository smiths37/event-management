using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblLetterSetup
    {
        public int LetterNoteId { get; set; }
        public string MeetingCode { get; set; }
        public string RegCode { get; set; }
        public short LetterTypeId { get; set; }
        public string ConfHeaderNotes { get; set; }
        public string ConfFooterNotes { get; set; }
        public bool ConfUseSessions { get; set; }
        public bool ConfUseHousing { get; set; }
        public bool ConfUseFinancial { get; set; }
        public string DupeCheck { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string DefaultLetterName { get; set; }

        public virtual TblMeetings MeetingCodeNavigation { get; set; }
    }
}
