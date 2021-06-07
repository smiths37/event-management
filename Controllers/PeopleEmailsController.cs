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
    public class PeopleEmailsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleEmailsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PeopleAddresses
        [HttpGet]
        public async Task<ActionResult<ApiResult<PeopleEmailDTO>>> GetTblPeopleEmails(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<PeopleEmailDTO>.CreateAsync(_context.TblPeopleEmails.Select(e => new PeopleEmailDTO() {personId = e.PersonId, emailAddress = e.EmailAddress, emailTypeDesc = e.EmailTypeNavigation.EmailTypeDesc, emailId = e.emailId, emailType = e.EmailType }), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PeopleAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeopleEmails>> GetTblPeopleEmails(int id)
        {
            var TblPeopleEmails = await _context.TblPeopleEmails.FindAsync(id);

            if (TblPeopleEmails == null)
            {
                return NotFound();
            }

            return TblPeopleEmails;
        }

        // PUT: api/PeopleAddresses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeopleEmails(int id, TblPeopleEmails TblPeopleEmails)
        {
            if (id != TblPeopleEmails.emailId)
            {
                return BadRequest();
            }

            _context.Entry(TblPeopleEmails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleEmailsExists(id))
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

        // POST: api/PeopleAddresses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblPeopleEmails>> PostTblPeopleEmails(TblPeopleEmails TblPeopleEmails)
        {
            _context.TblPeopleEmails.Add(TblPeopleEmails);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblPeopleEmailsExists(TblPeopleEmails.emailId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblPeopleEmails", new { id = TblPeopleEmails.emailId }, TblPeopleEmails);
        }

        // DELETE: api/PeopleAddresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPeopleEmails>> DeleteTblPeopleEmails(int id)
        {
            var TblPeopleEmails = await _context.TblPeopleEmails.FindAsync(id);
            if (TblPeopleEmails == null)
            {
                return NotFound();
            }

            _context.TblPeopleEmails.Remove(TblPeopleEmails);
            await _context.SaveChangesAsync();

            return TblPeopleEmails;
        }

        private bool TblPeopleEmailsExists(int id)
        {
            return _context.TblPeopleEmails.Any(e => e.emailId == id);
        }
    }
}
