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
    public class CompanyEmailsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public CompanyEmailsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/CompanyEmails
        [HttpGet]
        public async Task<ActionResult<ApiResult<CompanyEmailDTO>>> GetTblCompanyEmails(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            
            return await ApiResult<CompanyEmailDTO>.CreateAsync(_context.TblCompanyEmails.Select(e => new CompanyEmailDTO() { companyId = e.CompanyId, EmailAddress = e.EmailAddress, emailId = e.EmailId, emailTypeDesc = e.EmailTypeNavigation.EmailTypeDesc, emailType = e.EmailType }), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/CompanyEmails/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCompanyEmails>> GetTblCompanyEmails(int id)
        {
            var tblCompanyEmails = await _context.TblCompanyEmails.FindAsync(id);

            if (tblCompanyEmails == null)
            {
                return NotFound();
            }

            return tblCompanyEmails;
        }

        // PUT: api/CompanyEmails/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCompanyEmails(int id, TblCompanyEmails tblCompanyEmails)
        {
            if (id != tblCompanyEmails.EmailId)
            {
                return BadRequest();
            }

            _context.Entry(tblCompanyEmails).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCompanyEmailsExists(id))
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

        // POST: api/CompanyEmails
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCompanyEmails>> PostTblCompanyEmails(TblCompanyEmails tblCompanyEmails)
        {
            _context.TblCompanyEmails.Add(tblCompanyEmails);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCompanyEmails", new { id = tblCompanyEmails.EmailId }, tblCompanyEmails);
        }

        // DELETE: api/CompanyEmails/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCompanyEmails>> DeleteTblCompanyEmails(int id)
        {
            var tblCompanyEmails = await _context.TblCompanyEmails.FindAsync(id);
            if (tblCompanyEmails == null)
            {
                return NotFound();
            }

            _context.TblCompanyEmails.Remove(tblCompanyEmails);
            await _context.SaveChangesAsync();

            return tblCompanyEmails;
        }

        private bool TblCompanyEmailsExists(int id)
        {
            return _context.TblCompanyEmails.Any(e => e.EmailId == id);
        }
    }
}
