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
    public class StatesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public StatesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/States
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblStates>>> GetTblStates(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblStates>.CreateAsync(_context.TblStates, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/States/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblStates>> GetTblStates(string id)
        {
            var tblStates = await _context.TblStates.FindAsync(id);

            if (tblStates == null)
            {
                return NotFound();
            }

            return tblStates;
        }

        // PUT: api/States/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblStates(string id, TblStates tblStates)
        {
            if (id != tblStates.StateCode)
            {
                return BadRequest();
            }

            _context.Entry(tblStates).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblStatesExists(id))
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

        // POST: api/States
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblStates>> PostTblStates(TblStates tblStates)
        {
            _context.TblStates.Add(tblStates);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblStatesExists(tblStates.StateCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblStates", new { id = tblStates.StateCode }, tblStates);
        }

        // DELETE: api/States/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblStates>> DeleteTblStates(string id)
        {
            var tblStates = await _context.TblStates.FindAsync(id);
            if (tblStates == null)
            {
                return NotFound();
            }

            _context.TblStates.Remove(tblStates);
            await _context.SaveChangesAsync();

            return tblStates;
        }

        private bool TblStatesExists(string id)
        {
            return _context.TblStates.Any(e => e.StateCode == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblStates tblStates)
        {
            return _context.TblStates.Any(
                e => e.StateName == tblStates.StateName
                && e.StateCode == tblStates.StateCode
                && e.StateId != tblStates.StateId
            );
        }
    }
}
