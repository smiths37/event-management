using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MeetingTrak.Data.Models;

namespace MeetingTrak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RegistrationsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public RegistrationsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Registrations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblRegistration>>> GetTblRegistration()
        {
            return await _context.TblRegistration.ToListAsync();
        }

        // GET: api/Registrations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblRegistration>> GetTblRegistration(int id)
        {
            var tblRegistration = await _context.TblRegistration.FindAsync(id);

            if (tblRegistration == null)
            {
                return NotFound();
            }

            return tblRegistration;
        }

        // PUT: api/Registrations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblRegistration(int id, TblRegistration tblRegistration)
        {
            if (id != tblRegistration.RegId)
            {
                return BadRequest();
            }

            _context.Entry(tblRegistration).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblRegistrationExists(id))
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

        // POST: api/Registrations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblRegistration>> PostTblRegistration(TblRegistration tblRegistration)
        {
            _context.TblRegistration.Add(tblRegistration);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblRegistration", new { id = tblRegistration.RegId }, tblRegistration);
        }

        // DELETE: api/Registrations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblRegistration>> DeleteTblRegistration(int id)
        {
            var tblRegistration = await _context.TblRegistration.FindAsync(id);
            if (tblRegistration == null)
            {
                return NotFound();
            }

            _context.TblRegistration.Remove(tblRegistration);
            await _context.SaveChangesAsync();

            return tblRegistration;
        }

        private bool TblRegistrationExists(int id)
        {
            return _context.TblRegistration.Any(e => e.RegId == id);
        }
    }
}
