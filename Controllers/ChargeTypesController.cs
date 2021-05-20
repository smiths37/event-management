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
    public class ChargeTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public ChargeTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/ChargeTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblChargeTypes>>> GetTblChargeTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblChargeTypes>.CreateAsync(_context.TblChargeTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/ChargeTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblChargeTypes>> GetTblChargeTypes(int id)
        {
            var tblChargeTypes = await _context.TblChargeTypes.FindAsync(id);

            if (tblChargeTypes == null)
            {
                return NotFound();
            }

            return tblChargeTypes;
        }

        // PUT: api/ChargeTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblChargeTypes(int id, TblChargeTypes tblChargeTypes)
        {
            if (id != tblChargeTypes.ChargeTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblChargeTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblChargeTypesExists(id))
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

        // POST: api/ChargeTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblChargeTypes>> PostTblChargeTypes(TblChargeTypes tblChargeTypes)
        {
            _context.TblChargeTypes.Add(tblChargeTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblChargeTypes", new { id = tblChargeTypes.ChargeTypeId }, tblChargeTypes);
        }

        // DELETE: api/ChargeTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblChargeTypes>> DeleteTblChargeTypes(int id)
        {
            var tblChargeTypes = await _context.TblChargeTypes.FindAsync(id);
            if (tblChargeTypes == null)
            {
                return NotFound();
            }

            _context.TblChargeTypes.Remove(tblChargeTypes);
            await _context.SaveChangesAsync();

            return tblChargeTypes;
        }

        private bool TblChargeTypesExists(int id)
        {
            return _context.TblChargeTypes.Any(e => e.ChargeTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblChargeTypes tblChargeTypes)
        {
            return _context.TblChargeTypes.Any(
                e => e.ChargeTypeDesc == tblChargeTypes.ChargeTypeDesc
                && e.ChargeTypeId != tblChargeTypes.ChargeTypeId
            );
        }
    }
}
