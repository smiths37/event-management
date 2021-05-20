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
    public class SpeakerTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public SpeakerTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/SpeakerTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblSpeakerTypes>>> GetTblSpeakerTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblSpeakerTypes>.CreateAsync(_context.TblSpeakerTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/SpeakerTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblSpeakerTypes>> GetTblSpeakerTypes(int id)
        {
            var tblSpeakerTypes = await _context.TblSpeakerTypes.FindAsync(id);

            if (tblSpeakerTypes == null)
            {
                return NotFound();
            }

            return tblSpeakerTypes;
        }

        // PUT: api/SpeakerTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblSpeakerTypes(int id, TblSpeakerTypes tblSpeakerTypes)
        {
            if (id != tblSpeakerTypes.SpeakerTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblSpeakerTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblSpeakerTypesExists(id))
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

        // POST: api/SpeakerTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblSpeakerTypes>> PostTblSpeakerTypes(TblSpeakerTypes tblSpeakerTypes)
        {
            _context.TblSpeakerTypes.Add(tblSpeakerTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblSpeakerTypes", new { id = tblSpeakerTypes.SpeakerTypeId }, tblSpeakerTypes);
        }

        // DELETE: api/SpeakerTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblSpeakerTypes>> DeleteTblSpeakerTypes(int id)
        {
            var tblSpeakerTypes = await _context.TblSpeakerTypes.FindAsync(id);
            if (tblSpeakerTypes == null)
            {
                return NotFound();
            }

            _context.TblSpeakerTypes.Remove(tblSpeakerTypes);
            await _context.SaveChangesAsync();

            return tblSpeakerTypes;
        }

        private bool TblSpeakerTypesExists(int id)
        {
            return _context.TblSpeakerTypes.Any(e => e.SpeakerTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblSpeakerTypes tblSpeakerTypes)
        {
            return _context.TblSpeakerTypes.Any(
                e => e.SpeakerTypeDesc == tblSpeakerTypes.SpeakerTypeDesc
                && e.SpeakerTypeId != tblSpeakerTypes.SpeakerTypeId
            );
        }
    }
}
