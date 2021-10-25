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
    public class PeopleCeCreditsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleCeCreditsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PeopleCeCredits
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblPeopleCecredits>>> GetTblPeopleCecredits(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblPeopleCecredits>.CreateAsync(_context.TblPeopleCecredits, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PeopleCeCredits/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeopleCecredits>> GetTblPeopleCecredits(int id)
        {
            var tblPeopleCecredits = await _context.TblPeopleCecredits.FindAsync(id);

            if (tblPeopleCecredits == null)
            {
                return NotFound();
            }

            return tblPeopleCecredits;
        }

        // PUT: api/PeopleCeCredits/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeopleCecredits(int id, TblPeopleCecredits tblPeopleCecredits)
        {
            if (id != tblPeopleCecredits.KeyId)
            {
                return BadRequest();
            }

            _context.Entry(tblPeopleCecredits).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleCecreditsExists(id))
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

        // POST: api/PeopleCeCredits
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblPeopleCecredits>> PostTblPeopleCecredits(TblPeopleCecredits tblPeopleCecredits)
        {
            _context.TblPeopleCecredits.Add(tblPeopleCecredits);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPeopleCecredits", new { id = tblPeopleCecredits.KeyId }, tblPeopleCecredits);
        }

        // DELETE: api/PeopleCeCredits/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblPeopleCecredits(int id)
        {
            var tblPeopleCecredits = await _context.TblPeopleCecredits.FindAsync(id);
            if (tblPeopleCecredits == null)
            {
                return NotFound();
            }

            _context.TblPeopleCecredits.Remove(tblPeopleCecredits);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblPeopleCecreditsExists(int id)
        {
            return _context.TblPeopleCecredits.Any(e => e.KeyId == id);
        }
    }
}
