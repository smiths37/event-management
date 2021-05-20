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
    public class EmailTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public EmailTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/EmailTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblEmailTypes>>> GetTblEmailTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblEmailTypes>.CreateAsync(_context.TblEmailTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/EmailTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblEmailTypes>> GetTblEmailTypes(int id)
        {
            var tblEmailTypes = await _context.TblEmailTypes.FindAsync(id);

            if (tblEmailTypes == null)
            {
                return NotFound();
            }

            return tblEmailTypes;
        }

        // PUT: api/EmailTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblEmailTypes(int id, TblEmailTypes tblEmailTypes)
        {
            if (id != tblEmailTypes.EmailTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblEmailTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblEmailTypesExists(id))
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

        // POST: api/EmailTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblEmailTypes>> PostTblEmailTypes(TblEmailTypes tblEmailTypes)
        {
            _context.TblEmailTypes.Add(tblEmailTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblEmailTypes", new { id = tblEmailTypes.EmailTypeId }, tblEmailTypes);
        }

        // DELETE: api/EmailTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblEmailTypes>> DeleteTblEmailTypes(int id)
        {
            var tblEmailTypes = await _context.TblEmailTypes.FindAsync(id);
            if (tblEmailTypes == null)
            {
                return NotFound();
            }

            _context.TblEmailTypes.Remove(tblEmailTypes);
            await _context.SaveChangesAsync();

            return tblEmailTypes;
        }

        private bool TblEmailTypesExists(int id)
        {
            return _context.TblEmailTypes.Any(e => e.EmailTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblEmailTypes tblEmailTypes)
        {
            return _context.TblEmailTypes.Any(
                e => e.EmailTypeDesc == tblEmailTypes.EmailTypeDesc
                && e.EmailTypeId != tblEmailTypes.EmailTypeId
            );
        }
    }
}
