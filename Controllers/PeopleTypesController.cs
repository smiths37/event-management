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
    public class PeopleTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PeopleTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblPeopleTypes>>> GetTblPeopleTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblPeopleTypes>.CreateAsync(_context.TblPeopleTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PeopleTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeopleTypes>> GetTblPeopleTypes(int id)
        {
            var tblPeopleTypes = await _context.TblPeopleTypes.FindAsync(id);

            if (tblPeopleTypes == null)
            {
                return NotFound();
            }

            return tblPeopleTypes;
        }

        // PUT: api/PeopleTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeopleTypes(int id, TblPeopleTypes tblPeopleTypes)
        {
            if (id != tblPeopleTypes.PeopleTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblPeopleTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleTypesExists(id))
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

        // POST: api/PeopleTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblPeopleTypes>> PostTblPeopleTypes(TblPeopleTypes tblPeopleTypes)
        {
            _context.TblPeopleTypes.Add(tblPeopleTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPeopleTypes", new { id = tblPeopleTypes.PeopleTypeId }, tblPeopleTypes);
        }

        // DELETE: api/PeopleTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPeopleTypes>> DeleteTblPeopleTypes(int id)
        {
            var tblPeopleTypes = await _context.TblPeopleTypes.FindAsync(id);
            if (tblPeopleTypes == null)
            {
                return NotFound();
            }

            _context.TblPeopleTypes.Remove(tblPeopleTypes);
            await _context.SaveChangesAsync();

            return tblPeopleTypes;
        }

        private bool TblPeopleTypesExists(int id)
        {
            return _context.TblPeopleTypes.Any(e => e.PeopleTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblPeopleTypes tblPeopleTypes)
        {
            return _context.TblPeopleTypes.Any(
                e => e.PeopleTypeDesc == tblPeopleTypes.PeopleTypeDesc
                && e.PeopleTypeId != tblPeopleTypes.PeopleTypeId
            );
        }
    }
}
