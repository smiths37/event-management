using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblPassword
    {
        public int PersonId { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
