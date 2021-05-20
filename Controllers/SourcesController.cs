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
    public class SourcesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public SourcesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Sources
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblSources>>> GetTblSources(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblSources>.CreateAsync(_context.TblSources, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/Sources/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblSources>> GetTblSources(int id)
        {
            var tblSources = await _context.TblSources.FindAsync(id);

            if (tblSources == null)
            {
                return NotFound();
            }

            return tblSources;
        }

        // PUT: api/Sources/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblSources(int id, TblSources tblSources)
        {
            if (id != tblSources.SourceId)
            {
                return BadRequest();
            }

            _context.Entry(tblSources).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblSourcesExists(id))
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

        // POST: api/Sources
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblSources>> PostTblSources(TblSources tblSources)
        {
            _context.TblSources.Add(tblSources);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblSources", new { id = tblSources.SourceId }, tblSources);
        }

        // DELETE: api/Sources/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblSources>> DeleteTblSources(int id)
        {
            var tblSources = await _context.TblSources.FindAsync(id);
            if (tblSources == null)
            {
                return NotFound();
            }

            _context.TblSources.Remove(tblSources);
            await _context.SaveChangesAsync();

            return tblSources;
        }

        private bool TblSourcesExists(int id)
        {
            return _context.TblSources.Any(e => e.SourceId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblSources tblSources)
        {
            return _context.TblSources.Any(
                e => e.SourceDesc == tblSources.SourceDesc
                && e.SourceId != tblSources.SourceId
            );
        }
    }
}
