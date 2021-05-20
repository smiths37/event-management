using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class CompanyExhibitorDTO
    {
        public CompanyExhibitorDTO() { }

        public int companyId { get; set; }
        public string meetingCode { get; set; }
        public double numberOfBooths { get; set; }
        public double costPerBooth { get; set; }
        public double totalCost { get; set; }      //this is getting calculated, not stored or retrieved from the DB
        public double depositAmount { get; set; }
        public double balanceDue { get; set; }     //this is getting calculated, not stored or retrieved from the DB
        public DateTime? meetingStartDate { get; set; }
        public DateTime? meetingEndDate { get; set; }
        public string meetingShortDesc { get; set; }
        public string meetingLocation { get; set; }
        public int exhibitorId { get; set; }
    }
}
