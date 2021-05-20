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
    public class CreditTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public CreditTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/CreditTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblCreditTypes>>> GetTblCreditTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblCreditTypes>.CreateAsync(_context.TblCreditTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/CreditTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCreditTypes>> GetTblCreditTypes(string id)
        {
            var tblCreditTypes = await _context.TblCreditTypes.FindAsync(id);

            if (tblCreditTypes == null)
            {
                return NotFound();
            }

            return tblCreditTypes;
        }

        // PUT: api/CreditTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCreditTypes(string id, TblCreditTypes tblCreditTypes)
        {
            if (id != tblCreditTypes.CreditTypeCode)
            {
                return BadRequest();
            }

            _context.Entry(tblCreditTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCreditTypesExists(id))
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

        // POST: api/CreditTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCreditTypes>> PostTblCreditTypes(TblCreditTypes tblCreditTypes)
        {
            _context.TblCreditTypes.Add(tblCreditTypes);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (TblCreditTypesExists(tblCreditTypes.CreditTypeCode))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetTblCreditTypes", new { id = tblCreditTypes.CreditTypeCode }, tblCreditTypes);
        }

        // DELETE: api/CreditTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCreditTypes>> DeleteTblCreditTypes(string id)
        {
            var tblCreditTypes = await _context.TblCreditTypes.FindAsync(id);
            if (tblCreditTypes == null)
            {
                return NotFound();
            }

            _context.TblCreditTypes.Remove(tblCreditTypes);
            await _context.SaveChangesAsync();

            return tblCreditTypes;
        }

        private bool TblCreditTypesExists(string id)
        {
            return _context.TblCreditTypes.Any(e => e.CreditTypeCode == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblCreditTypes tblCreditTypes)
        {
            return _context.TblCreditTypes.Any(
                e => e.CreditTypeDesc == tblCreditTypes.CreditTypeDesc
                && e.CreditTypeCode == tblCreditTypes.CreditTypeCode
                && e.CreditTypeId != tblCreditTypes.CreditTypeId
            );
        }
    }
}
