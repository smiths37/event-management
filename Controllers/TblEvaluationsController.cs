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
    public class TblEvaluationsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public TblEvaluationsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/TblEvaluations
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblEvaluations>>> GetTblEvaluations()
        {
            return await _context.TblEvaluations.ToListAsync();
        }

        // GET: api/TblEvaluations/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblEvaluations>> GetTblEvaluations(int id)
        {
            var tblEvaluations = await _context.TblEvaluations.FindAsync(id);

            if (tblEvaluations == null)
            {
                return NotFound();
            }

            return tblEvaluations;
        }

        // PUT: api/TblEvaluations/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblEvaluations(int id, TblEvaluations tblEvaluations)
        {
            if (id != tblEvaluations.EvalId)
            {
                return BadRequest();
            }

            _context.Entry(tblEvaluations).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblEvaluationsExists(id))
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

        // POST: api/TblEvaluations
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblEvaluations>> PostTblEvaluations(TblEvaluations tblEvaluations)
        {
            _context.TblEvaluations.Add(tblEvaluations);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblEvaluations", new { id = tblEvaluations.EvalId }, tblEvaluations);
        }

        // DELETE: api/TblEvaluations/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblEvaluations>> DeleteTblEvaluations(int id)
        {
            var tblEvaluations = await _context.TblEvaluations.FindAsync(id);
            if (tblEvaluations == null)
            {
                return NotFound();
            }

            _context.TblEvaluations.Remove(tblEvaluations);
            await _context.SaveChangesAsync();

            return tblEvaluations;
        }

        private bool TblEvaluationsExists(int id)
        {
            return _context.TblEvaluations.Any(e => e.EvalId == id);
        }
    }
}
