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
    public class PeopleAddressesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public PeopleAddressesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/PeopleAddresses
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblPeopleAddresses>>> GetTblPeopleAddresses(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblPeopleAddresses>.CreateAsync(_context.TblPeopleAddresses.Include(x => x.AddressTypeNavigation), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/PeopleAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblPeopleAddresses>> GetTblPeopleAddresses(int id)
        {
            var tblPeopleAddresses = await _context.TblPeopleAddresses.FindAsync(id);

            if (tblPeopleAddresses == null)
            {
                return NotFound();
            }

            return tblPeopleAddresses;
        }

        // PUT: api/PeopleAddresses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblPeopleAddresses(int id, TblPeopleAddresses tblPeopleAddresses)
        {
            if (id != tblPeopleAddresses.AddressId)
            {
                return BadRequest();
            }

            _context.Entry(tblPeopleAddresses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblPeopleAddressesExists(id))
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

        // POST: api/PeopleAddresses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblPeopleAddresses>> PostTblPeopleAddresses(TblPeopleAddresses tblPeopleAddresses)
        {
            _context.TblPeopleAddresses.Add(tblPeopleAddresses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblPeopleAddresses", new { id = tblPeopleAddresses.AddressId }, tblPeopleAddresses);
        }

        // DELETE: api/PeopleAddresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblPeopleAddresses>> DeleteTblPeopleAddresses(int id)
        {
            var tblPeopleAddresses = await _context.TblPeopleAddresses.FindAsync(id);
            if (tblPeopleAddresses == null)
            {
                return NotFound();
            }

            _context.TblPeopleAddresses.Remove(tblPeopleAddresses);
            await _context.SaveChangesAsync();

            return tblPeopleAddresses;
        }

        private bool TblPeopleAddressesExists(int id)
        {
            return _context.TblPeopleAddresses.Any(e => e.AddressId == id);
        }
    }
}
