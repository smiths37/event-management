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
    public class RoomSetupsController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public RoomSetupsController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/RoomSetups
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblRoomSetups>>> GetTblRoomSetups(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblRoomSetups>.CreateAsync(_context.TblRoomSetups, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/RoomSetups/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblRoomSetups>> GetTblRoomSetups(int id)
        {
            var tblRoomSetups = await _context.TblRoomSetups.FindAsync(id);

            if (tblRoomSetups == null)
            {
                return NotFound();
            }

            return tblRoomSetups;
        }

        // PUT: api/RoomSetups/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblRoomSetups(int id, TblRoomSetups tblRoomSetups)
        {
            if (id != tblRoomSetups.SetupId)
            {
                return BadRequest();
            }

            _context.Entry(tblRoomSetups).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblRoomSetupsExists(id))
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

        // POST: api/RoomSetups
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblRoomSetups>> PostTblRoomSetups(TblRoomSetups tblRoomSetups)
        {
            _context.TblRoomSetups.Add(tblRoomSetups);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblRoomSetups", new { id = tblRoomSetups.SetupId }, tblRoomSetups);
        }

        // DELETE: api/RoomSetups/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblRoomSetups>> DeleteTblRoomSetups(int id)
        {
            var tblRoomSetups = await _context.TblRoomSetups.FindAsync(id);
            if (tblRoomSetups == null)
            {
                return NotFound();
            }

            _context.TblRoomSetups.Remove(tblRoomSetups);
            await _context.SaveChangesAsync();

            return tblRoomSetups;
        }

        private bool TblRoomSetupsExists(int id)
        {
            return _context.TblRoomSetups.Any(e => e.SetupId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblRoomSetups tblRoomSetups)
        {
            return _context.TblRoomSetups.Any(
                e => e.SetupDesc == tblRoomSetups.SetupDesc
                && e.SetupId != tblRoomSetups.SetupId
            );
        }
    }
}
