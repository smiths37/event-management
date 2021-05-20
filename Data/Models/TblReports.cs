using System;
using System.Collections.Generic;

namespace MeetingTrak.Data.Models
{
    public partial class TblReports
    {
        public string ReportGroup { get; set; }
        public string ReportName { get; set; }
        public string ReportLink { get; set; }
        public int ReportID { get; set; }
    }
}
