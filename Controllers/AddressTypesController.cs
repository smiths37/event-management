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
    public class AddressTypesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public AddressTypesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/AddressTypes
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblAddressTypes>>> GetTblAddressTypes(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblAddressTypes>.CreateAsync(_context.TblAddressTypes, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/AddressTypes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblAddressTypes>> GetTblAddressTypes(int id)
        {
            var tblAddressTypes = await _context.TblAddressTypes.FindAsync(id);

            if (tblAddressTypes == null)
            {
                return NotFound();
            }

            return tblAddressTypes;
        }

        // PUT: api/AddressTypes/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblAddressTypes(int id, TblAddressTypes tblAddressTypes)
        {
            if (id != tblAddressTypes.AddressTypeId)
            {
                return BadRequest();
            }

            _context.Entry(tblAddressTypes).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblAddressTypesExists(id))
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

        // POST: api/AddressTypes
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblAddressTypes>> PostTblAddressTypes(TblAddressTypes tblAddressTypes)
        {
            _context.TblAddressTypes.Add(tblAddressTypes);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblAddressTypes", new { id = tblAddressTypes.AddressTypeId }, tblAddressTypes);
        }

        // DELETE: api/AddressTypes/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblAddressTypes>> DeleteTblAddressTypes(int id)
        {
            var tblAddressTypes = await _context.TblAddressTypes.FindAsync(id);
            if (tblAddressTypes == null)
            {
                return NotFound();
            }

            _context.TblAddressTypes.Remove(tblAddressTypes);
            await _context.SaveChangesAsync();

            return tblAddressTypes;
        }

        private bool TblAddressTypesExists(int id)
        {
            return _context.TblAddressTypes.Any(e => e.AddressTypeId == id);
        }

        [HttpPost]
        [Route("IsDuplicate")]
        public bool IsDuplicate(TblAddressTypes tblAddressTypes)
        {
            return _context.TblAddressTypes.Any(
                e => e.AddressTypeDesc == tblAddressTypes.AddressTypeDesc
                && e.AddressTypeId != tblAddressTypes.AddressTypeId
            );
        }
    }
}
