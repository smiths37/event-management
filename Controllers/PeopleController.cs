using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingTrak.Data.Models;
using MeetingTrak.Data;
using SQLitePCL;
using MeetingTrak.Data.DTOs;

namespace MeetingTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PeopleController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/People
        [HttpGet]
        //public async Task<ActionResult<ApiResult<TblPeople>>> GetTblPeople(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        //{
        //    return await ApiResult<TblPeople>.CreateAsync(_context.TblPeople, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        //}

        public async Task<ActionResult<ApiResult<PeopleDTO>>> GetTblPeople(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<PeopleDTO>.CreateAsync(_context.TblPeople.Select(e => new PeopleDTO()
            {
                PersonId = e.PersonId,
                FirstName = e.FirstName,
                LastName = e.LastName,
                CompanyName = e.CompanyName
            }).Where(e => !e.LastName.Contains("inactive")), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/People/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeople>> GetTblPeople(int id)
        {
            var tblPeople = await _context.TblPeople.FindAsync(id);

            if (tblPeople == null)
            {
                return NotFound();
            }

            return tblPeople;
        }

        // PUT: api/People/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeople(int id, TblPeople tblPeople)
        {
            if (id != tblPeople.PersonId)
            {
                return BadRequest();
            }

            _context.Entry(tblPeople).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleExists(id))
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

        // POST: api/People
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblPeople>> PostTblPeople(TblPeople tblPeople)
        {
            _context.TblPeople.Add(tblPeople);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPeople", new { id = tblPeople.PersonId }, tblPeople);
        }

        // DELETE: api/People/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPeople>> DeleteTblPeople(int id)
        {
            var tblPeople = await _context.TblPeople.FindAsync(id);
            if (tblPeople == null)
            {
                return NotFound();
            }

            _context.TblPeople.Remove(tblPeople);
            await _context.SaveChangesAsync();

            return tblPeople;
        }

        private bool TblPeopleExists(int id)
        {
            return _context.TblPeople.Any(e => e.PersonId == id);
        }

        [HttpGet]
        [Route("getAddresses/{id}")]
        public ActionResult<List<MeetingTrak.Data.DTOs.PersonAddressDTO>> getAddresses(int id)
        {
            List<MeetingTrak.Data.DTOs.PersonAddressDTO> addresses = _context.TblPeopleAddresses.Where(e => e.PersonId == id).Select(e => new MeetingTrak.Data.DTOs.PersonAddressDTO()
            {
                addressId = e.AddressId,
                companyId = e.CompanyId,
                primary = e.Primary,
                phone = e.Phone,
                extension = e.Extension,
                fax = e.Fax,
                addressTypeDesc = e.AddressTypeNavigation.AddressTypeDesc,
                address1 = e.Address1,
                address2 = e.Address2,
                city = e.City,
                stateName = e.StateNavigation.StateName,
                countryName = e.Country.CountryName,
                zip = e.Zip
            }).ToList();

            return addresses;
        }

        [HttpGet]
        [Route("getEmails/{id}")]
        public ActionResult<List<MeetingTrak.Data.DTOs.PeopleEmailDTO>> getEmails(int id)
        {
            List<MeetingTrak.Data.DTOs.PeopleEmailDTO> emails = _context.TblPeopleEmails.Select(e => new MeetingTrak.Data.DTOs.PeopleEmailDTO()
            {
                personId = e.PersonId,
                emailAddress = e.EmailAddress,
                emailId = e.emailId,
                emailTypeDesc = e.EmailTypeNavigation.EmailTypeDesc
            }).Where(e => e.personId == id).ToList();

            return emails;
        }
        [HttpGet]
        [Route("getCreditTypes/{id}")]
        public ActionResult<List<PersonCreditTypeDTO>> getCreditTypes(int id)
        {
            List<PersonCreditTypeDTO> personCreditTypes = _context.TblPeopleCreditTypes.Select(e => new PersonCreditTypeDTO()
            {
                id = e.ID,
                personId = e.PersonId,
                creditTypeCode = e.CreditTypeCode,
                creditTypeDesc = e.CreditTypeCodeNavigation.CreditTypeDesc
            }).Where(e => e.personId == id).ToList();
            return personCreditTypes;
        }

        [HttpGet]
        [Route("getCeCredits/{id}")]
        public ActionResult<List<PersonCeCreditDTO>> getCeCredits(int id)
        {
            List<PersonCeCreditDTO> peopleCeCredits = _context.TblPeopleCecredits.Select(e => new PersonCeCreditDTO()
            {
                keyId = e.KeyId,
                personId = e.PersonId,
                creditDate = e.CreditDate,
                meetingCode = e.MeetingCode,
                regCode = e.RegCode,
                sessionCode = e.SessionCode,
                creditTypeCode = e.CreditTypeCode,
                creditUnits = e.CreditUnits,
                title = e.Title,
                selfReported = e.SelfReported
            }).Where(e => e.personId == id).ToList();
            return peopleCeCredits;
        }
    }
}
