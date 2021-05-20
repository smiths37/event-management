using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingTrak.Data.Models;
using MeetingTrak.Data;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;

namespace MeetingTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExhibitorsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public ExhibitorsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Exhibitors
        [HttpGet]
        //public async Task<ActionResult<ApiResult<TblExhibitors>>> GetTblExhibitors(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        //{
        //    return await ApiResult<TblExhibitors>.CreateAsync(_context.TblExhibitors, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        //}
        public async Task<ActionResult<ApiResult<ExhibitorDTO>>> GetTblExhibitors(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<ExhibitorDTO>.CreateAsync(_context.TblExhibitors.Select(e => new ExhibitorDTO()
            {
                meetingCode = e.MeetingCode,
                companyName = e.Company.CompanyName,
                companyId = e.CompanyId,
                personFirstName = e.Company.TblPeople.Where(i => i.PersonId == e.PersonId).Select(i => i.FirstName).First(),
                personLastName = e.Company.TblPeople.Where(i => i.PersonId == e.PersonId).Select(i => i.LastName).First(),
                exhibitorId = e.ExhibitorId
            }), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/Exhibitors/5
        [HttpGet("{companyId}/{meetingCode}")]
        public async Task<ActionResult<TblExhibitors>> GetTblExhibitors(int companyId, string meetingCode)
        {
            var tblExhibitors = await _context.TblExhibitors.FindAsync(companyId, meetingCode);

            tblExhibitors.ExhibitorId = tblExhibitors.ExhibitorId;

            if (tblExhibitors == null)
            {
                return NotFound();
            }

            return tblExhibitors;
        }

        // PUT: api/Exhibitors/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{companyId}/{meetingCode}")]
        public async Task<IActionResult> PutTblExhibitors(int companyId, string meetingCode, TblExhibitors tblExhibitors)
        {
            if (companyId != tblExhibitors.CompanyId && meetingCode != tblExhibitors.MeetingCode)
            {
                return BadRequest();
            }

            _context.Entry(tblExhibitors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblExhibitorsExists(companyId, meetingCode))
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

        // POST: api/Exhibitors
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblExhibitors>> PostTblExhibitors(TblExhibitors tblExhibitors)
        {
            _context.TblExhibitors.Add(tblExhibitors);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblExhibitorsExists(tblExhibitors.CompanyId, tblExhibitors.MeetingCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblExhibitors", new { exhibitorId = tblExhibitors.ExhibitorId }, tblExhibitors);
        }

        // DELETE: api/Exhibitors/5
        [HttpDelete("{companyId}/{meetingCode}")]
        public async Task<ActionResult<TblExhibitors>> DeleteTblExhibitors(int companyId, string meetingCode)
        {
            var tblExhibitors = await _context.TblExhibitors.FindAsync(companyId, meetingCode);
            if (tblExhibitors == null)
            {
                return NotFound();
            }

            _context.TblExhibitors.Remove(tblExhibitors);
            await _context.SaveChangesAsync();

            return tblExhibitors;
        }

        private bool TblExhibitorsExists(int companyId, string meetingCode)
        {
            return _context.TblExhibitors.Any(e => e.CompanyId == companyId && e.MeetingCode == meetingCode);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblExhibitors tblExhibitors)
        {
            return _context.TblExhibitors.Any(
                e => e.CompanyId == tblExhibitors.CompanyId
                && e.MeetingCode == tblExhibitors.MeetingCode
                && e.ExhibitorId != tblExhibitors.ExhibitorId
            );
        }
    }
}
