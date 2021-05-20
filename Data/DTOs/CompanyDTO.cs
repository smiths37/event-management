using MeetingTrak.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MeetingTrak.Data.DTOs
{
    public class CompanyDTO
    {
        public CompanyDTO() { }

        public int companyId { get; set; }
        public string companyName { get; set; }
        public int parentCompanyId { get; set; }
        public string alphaIndexName { get; set; }
        public int companyType { get; set; }
        public int addressId { get; set; }
        public int sourceId { get; set; }
        public List<TblCompanyAddresses> addresses { get; set; }        //do i need this?
    }
}
