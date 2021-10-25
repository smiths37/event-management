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
    public class PeopleCreditTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleCreditTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PeopleCreditTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblPeopleCreditTypes>>> GetTblPeopleCreditTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblPeopleCreditTypes>.CreateAsync(_context.TblPeopleCreditTypes.Include(e => e.CreditTypeCodeNavigation.CreditTypeDesc), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PeopleCreditTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeopleCreditTypes>> GetTblPeopleCreditTypes(int id)
        {
            var tblPeopleCreditTypes = await _context.TblPeopleCreditTypes.FindAsync(id);

            if (tblPeopleCreditTypes == null)
            {
                return NotFound();
            }

            return tblPeopleCreditTypes;
        }

        // PUT: api/PeopleCreditTypes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeopleCreditTypes(int id, TblPeopleCreditTypes tblPeopleCreditTypes)
        {
            if (id != tblPeopleCreditTypes.ID)
            {
                return BadRequest();
            }

            _context.Entry(tblPeopleCreditTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleCreditTypesExists(id))
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

        // POST: api/PeopleCreditTypes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<TblPeopleCreditTypes>> PostTblPeopleCreditTypes(TblPeopleCreditTypes tblPeopleCreditTypes)
        {
            _context.TblPeopleCreditTypes.Add(tblPeopleCreditTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPeopleCreditTypes", new { id = tblPeopleCreditTypes.ID }, tblPeopleCreditTypes);
        }

        // DELETE: api/PeopleCreditTypes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTblPeopleCreditTypes(int id)
        {
            var tblPeopleCreditTypes = await _context.TblPeopleCreditTypes.FindAsync(id);
            if (tblPeopleCreditTypes == null)
            {
                return NotFound();
            }

            _context.TblPeopleCreditTypes.Remove(tblPeopleCreditTypes);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TblPeopleCreditTypesExists(int id)
        {
            return _context.TblPeopleCreditTypes.Any(e => e.ID == id);
        }
    }
}
