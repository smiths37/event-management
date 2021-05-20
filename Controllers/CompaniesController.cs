using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingTrak.Data.Models;
using MeetingTrak.Data;
using MeetingTrak.Data.DTOs;

namespace MeetingTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompaniesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public CompaniesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Companies
        //GET: api/Companies/?pageIndex=0&pageSize=10
        //GET: api/Companies/?pageIndex=0&pageSize=10&sortColumn=name&sortOrder=asc
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblCompanies>>> GetTblCompanies(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblCompanies>.CreateAsync(_context.TblCompanies, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/Companies/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCompanies>> GetTblCompanies(int id)
        {
            var tblCompanies = await _context.TblCompanies.FindAsync(id);

            if (tblCompanies == null)
            {
                return NotFound();
            }

            return tblCompanies;
        }

        // PUT: api/Companies/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCompanies(int id, TblCompanies tblCompanies)
        {
            if (id != tblCompanies.CompanyId)
            {
                return BadRequest();
            }

            _context.Entry(tblCompanies).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCompaniesExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Companies
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCompanies>> PostTblCompanies(TblCompanies tblCompanies)
        {
            _context.TblCompanies.Add(tblCompanies);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCompanies", new { id = tblCompanies.CompanyId }, tblCompanies);
        }

        // DELETE: api/Companies/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCompanies>> DeleteTblCompanies(int id)
        {
            var tblCompanies = await _context.TblCompanies.FindAsync(id);
            if (tblCompanies == null)
            {
                return NotFound();
            }

            _context.TblCompanies.Remove(tblCompanies);
            await _context.SaveChangesAsync();

            return tblCompanies;
        }

        private bool TblCompaniesExists(int id)
        {
            return _context.TblCompanies.Any(e => e.CompanyId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblCompanies tblCompanies)
        {
            return _context.TblCompanies.Any(
                e => e.CompanyName == tblCompanies.CompanyName
                && e.CompanyId != tblCompanies.CompanyId
            );
        }

        [HttpGet]
        [Route("getAddresses/{id}")]
        public ActionResult<List<MeetingTrak.Data.DTOs.CompanyAddressDTO>> getAddresses(int id)
        {
            List<MeetingTrak.Data.DTOs.CompanyAddressDTO> addresses = _context.TblCompanyAddresses.Select(e => new MeetingTrak.Data.DTOs.CompanyAddressDTO()
            {
                addressId = e.AddressId,
                companyId = e.CompanyId,
                primary = e.Primary,
                phone = e.Phone,
                _800 = e._800,
                fax = e.Fax, 
                addressTypeDesc = e.AddressTypeNavigation.AddressTypeDesc,
                address1 = e.Address1,
                address2 = e.Address2,
                city = e.City,
                stateName = e.StateNavigation.StateName,
                countryName = e.Country.CountryName,
                zip = e.Zip

            }).Where(e => e.companyId == id).ToList();
            
            //List<TblCompanyAddresses> Addresses = _context.TblCompanyAddresses.Where(e => e.CompanyId == id).ToList();
            return addresses;
        }

        [HttpGet]
        [Route("getEmails/{id}")]
        public ActionResult<List<MeetingTrak.Data.DTOs.CompanyEmailDTO>> getEmails(int id)
        {
            List<MeetingTrak.Data.DTOs.CompanyEmailDTO> emails = _context.TblCompanyEmails.Select(e => new MeetingTrak.Data.DTOs.CompanyEmailDTO()
            {
                companyId = e.CompanyId,
                EmailAddress = e.EmailAddress,
                emailId = e.EmailId,
                emailTypeDesc = e.EmailTypeNavigation.EmailTypeDesc
            }).Where(e => e.companyId == id).ToList();


            //List<TblCompanyEmails> emails = _context.TblCompanyEmails.Where(e => e.CompanyId == id).ToList();
            return emails;
        }

        [HttpGet]
        [Route("getCompanyPeople/{companyId}")]
        public ActionResult<List<CompanyPeopleDTO>> getCompanyPeople(int companyId)
        {
            //have to add all of the company Ids to an array because there can be nulls in the Company Id column of tblPeople
            int[] companyIds = _context.TblCompanyAddresses.Select(i => i.CompanyId).ToArray();

            List<CompanyPeopleDTO> companyPeople = _context.TblPeople
                .Where(e => e.CompanyId == companyId)
                .Select(e => new CompanyPeopleDTO()
            {
                PersonId = e.PersonId,
                CompanyId = e.CompanyId,
                NamePrefix = e.NamePrefix,
                FirstName = e.FirstName,
                LastName = e.LastName,
                NameSuffix = e.NameSuffix,
                peopleTypeDesc = e.PeopleTypeNavigation.PeopleTypeDesc,
                contactTypeDesc = e.ContactTypeNavigation.ContactTypeDesc
            }).ToList();


            //companyPeople = companyPeople.Where(e => e.CompanyId == companyId).ToList();

            return companyPeople;
        }

        [HttpGet]
        [Route("getCompanyExhibitors/{companyId}")]
        public ActionResult<List<CompanyExhibitorDTO>> getcompanyExhibitors(int companyId)
        {
            List<CompanyExhibitorDTO> companyExhibitors = _context.TblExhibitors.Select(e => new CompanyExhibitorDTO()
            {
                exhibitorId = e.ExhibitorId,
                companyId = e.CompanyId,
                meetingCode = e.MeetingCode,
                numberOfBooths = Convert.ToDouble(e.NumberOfBooths),
                costPerBooth = Convert.ToDouble(e.CostPerBooth),
                totalCost = Convert.ToDouble(e.NumberOfBooths * e.CostPerBooth),
                depositAmount = Convert.ToDouble(e.DepositAmount),
                balanceDue = Convert.ToDouble(e.TotalCost - e.DepositAmount),
                meetingStartDate = e.MeetingCodeNavigation.MeetingStartDate,
                meetingEndDate = e.MeetingCodeNavigation.MeetingEndDate,
                meetingShortDesc = e.MeetingCodeNavigation.MeetingDesc,
                meetingLocation = e.MeetingCodeNavigation.MeetingLocation
            }).Where(e => e.companyId == companyId).ToList();

            return companyExhibitors;
        }
    }
}
