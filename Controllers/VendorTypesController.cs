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
    public class VendorTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public VendorTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/VendorTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblVendorTypes>>> GetTblVendorTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblVendorTypes>.CreateAsync(_context.TblVendorTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/VendorTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblVendorTypes>> GetTblVendorTypes(int id)
        {
            var tblVendorTypes = await _context.TblVendorTypes.FindAsync(id);

            if (tblVendorTypes == null)
            {
                return NotFound();
            }

            return tblVendorTypes;
        }

        // PUT: api/VendorTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblVendorTypes(int id, TblVendorTypes tblVendorTypes)
        {
            if (id != tblVendorTypes.VendorTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblVendorTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblVendorTypesExists(id))
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

        // POST: api/VendorTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblVendorTypes>> PostTblVendorTypes(TblVendorTypes tblVendorTypes)
        {
            _context.TblVendorTypes.Add(tblVendorTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblVendorTypes", new { id = tblVendorTypes.VendorTypeId }, tblVendorTypes);
        }

        // DELETE: api/VendorTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblVendorTypes>> DeleteTblVendorTypes(int id)
        {
            var tblVendorTypes = await _context.TblVendorTypes.FindAsync(id);
            if (tblVendorTypes == null)
            {
                return NotFound();
            }

            _context.TblVendorTypes.Remove(tblVendorTypes);
            await _context.SaveChangesAsync();

            return tblVendorTypes;
        }

        private bool TblVendorTypesExists(int id)
        {
            return _context.TblVendorTypes.Any(e => e.VendorTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblVendorTypes tblVendorTypes)
        {
            return _context.TblVendorTypes.Any(
                e => e.Description == tblVendorTypes.Description
                && e.VendorTypeId != tblVendorTypes.VendorTypeId
            );
        }
    }
}
