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
    public class PeopleCreditTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleCreditTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PeopleCreditTypes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TblPeopleCreditTypes>>> GetTblPeopleCreditTypes()
        {
            return await _context.TblPeopleCreditTypes.ToListAsync();
        }

        // GET: api/PeopleCreditTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeopleCreditTypes>> GetTblPeopleCreditTypes(int id)
        {
            var tblPeopleCreditTypes = await _context.TblPeopleCreditTypes.FindAsync(id);

            if (tblPeopleCreditTypes == null)
            {
                return NotFound();
            }

            return tblPeopleCreditTypes;
        }

        // PUT: api/PeopleCreditTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeopleCreditTypes(int id, TblPeopleCreditTypes tblPeopleCreditTypes)
        {
            if (id != tblPeopleCreditTypes.PersonId)
            {
                return BadRequest();
            }

            _context.Entry(tblPeopleCreditTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleCreditTypesExists(id))
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

        // POST: api/PeopleCreditTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblPeopleCreditTypes>> PostTblPeopleCreditTypes(TblPeopleCreditTypes tblPeopleCreditTypes)
        {
            _context.TblPeopleCreditTypes.Add(tblPeopleCreditTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblPeopleCreditTypesExists(tblPeopleCreditTypes.PersonId))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblPeopleCreditTypes", new { id = tblPeopleCreditTypes.PersonId }, tblPeopleCreditTypes);
        }

        // DELETE: api/PeopleCreditTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblPeopleCreditTypes(int id)
        {
            var tblPeopleCreditTypes = await _context.TblPeopleCreditTypes.FindAsync(id);
            if (tblPeopleCreditTypes == null)
            {
                return NotFound();
            }

            _context.TblPeopleCreditTypes.Remove(tblPeopleCreditTypes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblPeopleCreditTypesExists(int id)
        {
            return _context.TblPeopleCreditTypes.Any(e => e.PersonId == id);
        }
    }
}
