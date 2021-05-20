using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data
{
    public class ExhibitorDTO
    {
        public ExhibitorDTO () { }

        public string meetingCode { get; set; }
        public double numberOfBooths { get; set; }
        public double costPerBooth { get; set; }
        public double totalCost { get; set; }
        public double depositAmount { get; set; }
        public double balanceDue { get; set; }
        public string boothLoc1 { get; set; }
        public string boothLoc2 { get; set; }
        public string boothLoc3 { get; set; }
        public string boothLoc4 { get; set; }
        public string sponsoredEvents { get; set; }
        public DateTime depositReceived { get; set; }
        public DateTime confirmationSent { get; set; }
        public string profile { get; set; }
        public int sourceId { get; set; }
        public string sourceDesc { get; set; }
        public int companyId { get; set; }
        public string companyName { get; set; }
        public int personId { get; set; }
        public string personFirstName { get; set; }
        public string personLastName { get; set; }
        public int exhibitorId { get; set; }
        public string meetingCodeDesc { get; set; }
    }
}
