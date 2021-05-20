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
    public class AudioVisualItemsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public AudioVisualItemsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/AudioVisualItems
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblAvItems>>> GetTblAvItems(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblAvItems>.CreateAsync(_context.TblAvItems, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/AudioVisualItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblAvItems>> GetTblAvItems(int id)
        {
            var tblAvItems = await _context.TblAvItems.FindAsync(id);

            if (tblAvItems == null)
            {
                return NotFound();
            }

            return tblAvItems;
        }

        // PUT: api/AudioVisualItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblAvItems(int id, TblAvItems tblAvItems)
        {
            if (id != tblAvItems.AvId)
            {
                return BadRequest();
            }

            _context.Entry(tblAvItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblAvItemsExists(id))
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

        // POST: api/AudioVisualItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblAvItems>> PostTblAvItems(TblAvItems tblAvItems)
        {
            _context.TblAvItems.Add(tblAvItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblAvItems", new { id = tblAvItems.AvId }, tblAvItems);
        }

        // DELETE: api/AudioVisualItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblAvItems>> DeleteTblAvItems(int id)
        {
            var tblAvItems = await _context.TblAvItems.FindAsync(id);
            if (tblAvItems == null)
            {
                return NotFound();
            }

            _context.TblAvItems.Remove(tblAvItems);
            await _context.SaveChangesAsync();

            return tblAvItems;
        }

        private bool TblAvItemsExists(int id)
        {
            return _context.TblAvItems.Any(e => e.AvId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblAvItems tblAvItems)
        {
            return _context.TblAvItems.Any(
                e => e.AvDesc == tblAvItems.AvDesc
                && e.AvId != tblAvItems.AvId
            );
        }
    }
}
