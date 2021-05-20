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
    public class ContactTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public ContactTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/ContactTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblContactTypes>>> GetTblContactTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblContactTypes>.CreateAsync(_context.TblContactTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/ContactTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblContactTypes>> GetTblContactTypes(int id)
        {
            var tblContactTypes = await _context.TblContactTypes.FindAsync(id);

            if (tblContactTypes == null)
            {
                return NotFound();
            }

            return tblContactTypes;
        }

        // PUT: api/ContactTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblContactTypes(int id, TblContactTypes tblContactTypes)
        {
            if (id != tblContactTypes.ContactTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblContactTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblContactTypesExists(id))
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

        // POST: api/ContactTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblContactTypes>> PostTblContactTypes(TblContactTypes tblContactTypes)
        {
            _context.TblContactTypes.Add(tblContactTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblContactTypes", new { id = tblContactTypes.ContactTypeId }, tblContactTypes);
        }

        // DELETE: api/ContactTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblContactTypes>> DeleteTblContactTypes(int id)
        {
            var tblContactTypes = await _context.TblContactTypes.FindAsync(id);
            if (tblContactTypes == null)
            {
                return NotFound();
            }

            _context.TblContactTypes.Remove(tblContactTypes);
            await _context.SaveChangesAsync();

            return tblContactTypes;
        }

        private bool TblContactTypesExists(int id)
        {
            return _context.TblContactTypes.Any(e => e.ContactTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblContactTypes tblContactTypes)
        {
            return _context.TblContactTypes.Any(
                e => e.ContactTypeDesc == tblContactTypes.ContactTypeDesc
                && e.ContactTypeId != tblContactTypes.ContactTypeId
            );
        }
    }
}
