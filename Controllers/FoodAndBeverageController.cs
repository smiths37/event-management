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
    public class FoodAndBeverageController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public FoodAndBeverageController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/FoodAndBeverage
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblFbItems>>> GetTblFbItems(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblFbItems>.CreateAsync(_context.TblFbItems, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/FoodAndBeverage/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblFbItems>> GetTblFbItems(int id)
        {
            var tblFbItems = await _context.TblFbItems.FindAsync(id);

            if (tblFbItems == null)
            {
                return NotFound();
            }

            return tblFbItems;
        }

        // PUT: api/FoodAndBeverage/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblFbItems(int id, TblFbItems tblFbItems)
        {
            if (id != tblFbItems.FbId)
            {
                return BadRequest();
            }

            _context.Entry(tblFbItems).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblFbItemsExists(id))
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

        // POST: api/FoodAndBeverage
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblFbItems>> PostTblFbItems(TblFbItems tblFbItems)
        {
            _context.TblFbItems.Add(tblFbItems);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblFbItems", new { id = tblFbItems.FbId }, tblFbItems);
        }

        // DELETE: api/FoodAndBeverage/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblFbItems>> DeleteTblFbItems(int id)
        {
            var tblFbItems = await _context.TblFbItems.FindAsync(id);
            if (tblFbItems == null)
            {
                return NotFound();
            }

            _context.TblFbItems.Remove(tblFbItems);
            await _context.SaveChangesAsync();

            return tblFbItems;
        }

        private bool TblFbItemsExists(int id)
        {
            return _context.TblFbItems.Any(e => e.FbId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblFbItems tblFbItems)
        {
            return _context.TblFbItems.Any(
                e => e.FbDesc == tblFbItems.FbDesc
                && e.FbId != tblFbItems.FbId
            );
        }
    }
}
