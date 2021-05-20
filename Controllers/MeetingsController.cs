using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingTrak.Data.Models;
using MeetingTrak.Data;

namespace MeetingTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MeetingsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public MeetingsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Meetings
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblMeetings>>> GetTblMeetings(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null, string criteria = null)
        {
            if (criteria == null)
            {
                return await ApiResult<TblMeetings>.CreateAsync(_context.TblMeetings, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
            }
            else
            {
                //only get meetings that are happening now or in the future
                var meetings = this._context.TblMeetings.AsQueryable();
                meetings = meetings.Where(x => x.MeetingStartDate >= System.DateTime.Now.Date && x.MeetingEndDate >= System.DateTime.Now.Date);

                //pass the new data set that has been filtered 
                return await ApiResult<TblMeetings>.CreateAsync(meetings, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
            }
        }

        // GET: api/Meetings/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblMeetings>> GetTblMeetings(string id)
        {
            var tblMeetings = await _context.TblMeetings.FindAsync(id);

            if (tblMeetings == null)
            {
                return NotFound();
            }

            return tblMeetings;
        }

        // PUT: api/Meetings/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblMeetings(string id, TblMeetings tblMeetings)
        {
            if (id != tblMeetings.MeetingCode)
            {
                return BadRequest();
            }

            _context.Entry(tblMeetings).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblMeetingsExists(id))
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

        // POST: api/Meetings
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblMeetings>> PostTblMeetings(TblMeetings tblMeetings)
        {
            _context.TblMeetings.Add(tblMeetings);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblMeetingsExists(tblMeetings.MeetingCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblMeetings", new { id = tblMeetings.MeetingCode }, tblMeetings);
        }

        // DELETE: api/Meetings/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblMeetings>> DeleteTblMeetings(string id)
        {
            var tblMeetings = await _context.TblMeetings.FindAsync(id);
            if (tblMeetings == null)
            {
                return NotFound();
            }

            _context.TblMeetings.Remove(tblMeetings);
            await _context.SaveChangesAsync();

            return tblMeetings;
        }

        private bool TblMeetingsExists(string id)
        {
            return _context.TblMeetings.Any(e => e.MeetingCode == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblMeetings tblMeetings)
        {
            return _context.TblMeetings.Any(
                e => e.MeetingCode == tblMeetings.MeetingCode
            );
        }
    }
}
