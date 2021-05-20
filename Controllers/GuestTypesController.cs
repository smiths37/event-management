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
    public class GuestTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public GuestTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/GuestTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblGuestTypes>>> GetTblGuestTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblGuestTypes>.CreateAsync(_context.TblGuestTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/GuestTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblGuestTypes>> GetTblGuestTypes(int id)
        {
            var tblGuestTypes = await _context.TblGuestTypes.FindAsync(id);

            if (tblGuestTypes == null)
            {
                return NotFound();
            }

            return tblGuestTypes;
        }

        // PUT: api/GuestTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblGuestTypes(int id, TblGuestTypes tblGuestTypes)
        {
            if (id != tblGuestTypes.GuestTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblGuestTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblGuestTypesExists(id))
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

        // POST: api/GuestTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblGuestTypes>> PostTblGuestTypes(TblGuestTypes tblGuestTypes)
        {
            _context.TblGuestTypes.Add(tblGuestTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblGuestTypes", new { id = tblGuestTypes.GuestTypeId }, tblGuestTypes);
        }

        // DELETE: api/GuestTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblGuestTypes>> DeleteTblGuestTypes(int id)
        {
            var tblGuestTypes = await _context.TblGuestTypes.FindAsync(id);
            if (tblGuestTypes == null)
            {
                return NotFound();
            }

            _context.TblGuestTypes.Remove(tblGuestTypes);
            await _context.SaveChangesAsync();

            return tblGuestTypes;
        }

        private bool TblGuestTypesExists(int id)
        {
            return _context.TblGuestTypes.Any(e => e.GuestTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblGuestTypes tblGuestTypes)
        {
            return _context.TblGuestTypes.Any(
                e => e.GuestTypeDesc == tblGuestTypes.GuestTypeDesc
                && e.GuestTypeId != tblGuestTypes.GuestTypeId
            );
        }
    }
}
