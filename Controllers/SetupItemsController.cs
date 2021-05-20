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
    public class SetupItemsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public SetupItemsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/SetupItems
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblSetupItems>>> GetTblSetupItems(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblSetupItems>.CreateAsync(_context.TblSetupItems, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/SetupItems/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblSetupItems>> GetTblSetupItems(int id)
        {
            var tblSetupItems = await _context.TblSetupItems.FindAsync(id);

            if (tblSetupItems == null)
            {
                return NotFound();
            }

            return tblSetupItems;
        }

        // PUT: api/SetupItems/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblSetupItems(int id, TblSetupItems tblSetupItems)
        {
            if (id != tblSetupItems.SetupId)
            {
                return BadRequest();
            }

            _context.Entry(tblSetupItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblSetupItemsExists(id))
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

        // POST: api/SetupItems
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblSetupItems>> PostTblSetupItems(TblSetupItems tblSetupItems)
        {
            _context.TblSetupItems.Add(tblSetupItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblSetupItems", new { id = tblSetupItems.SetupId }, tblSetupItems);
        }

        // DELETE: api/SetupItems/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblSetupItems>> DeleteTblSetupItems(int id)
        {
            var tblSetupItems = await _context.TblSetupItems.FindAsync(id);
            if (tblSetupItems == null)
            {
                return NotFound();
            }

            _context.TblSetupItems.Remove(tblSetupItems);
            await _context.SaveChangesAsync();

            return tblSetupItems;
        }

        private bool TblSetupItemsExists(int id)
        {
            return _context.TblSetupItems.Any(e => e.SetupId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblSetupItems tblSetupItems)
        {
            return _context.TblSetupItems.Any(
                e => e.SetupDesc == tblSetupItems.SetupDesc
                && e.SetupId != tblSetupItems.SetupId
            );
        }
    }
}
