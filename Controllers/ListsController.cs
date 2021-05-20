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
    public class ListsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public ListsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Lists
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblLists>>> GetTblLists(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblLists>.CreateAsync(_context.TblLists, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/Lists/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblLists>> GetTblLists(string id)
        {
            var tblLists = await _context.TblLists.FindAsync(id);

            if (tblLists == null)
            {
                return NotFound();
            }

            return tblLists;
        }

        // PUT: api/Lists/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblLists(string id, TblLists tblLists)
        {
            if (id != tblLists.ListCode)
            {
                return BadRequest();
            }

            _context.Entry(tblLists).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblListsExists(id))
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

        // POST: api/Lists
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblLists>> PostTblLists(TblLists tblLists)
        {
            _context.TblLists.Add(tblLists);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblListsExists(tblLists.ListCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblLists", new { id = tblLists.ListCode }, tblLists);
        }

        // DELETE: api/Lists/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblLists>> DeleteTblLists(string id)
        {
            var tblLists = await _context.TblLists.FindAsync(id);
            if (tblLists == null)
            {
                return NotFound();
            }

            _context.TblLists.Remove(tblLists);
            await _context.SaveChangesAsync();

            return tblLists;
        }

        private bool TblListsExists(string id)
        {
            return _context.TblLists.Any(e => e.ListCode == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblLists tblLists)
        {
            return _context.TblLists.Any(
                e => e.ListName == tblLists.ListName
                && e.ListCode == tblLists.ListCode
                && e.ListId != tblLists.ListId
            );
        }
    }
}
