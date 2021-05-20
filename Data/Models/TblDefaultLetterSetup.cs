using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblDefaultLetterSetup
    {
        public short LetterTypeId { get; set; }
        public string ConfHeaderNotes { get; set; }
        public string ConfFooterNotes { get; set; }
        public bool ConfUseSessions { get; set; }
        public bool ConfUseHousing { get; set; }
        public bool ConfUseFinancial { get; set; }
        public byte[] UpsizeTs { get; set; }
        public string DefaultLetterName { get; set; }
    }
}
