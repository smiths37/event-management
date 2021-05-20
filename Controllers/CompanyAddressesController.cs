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
    public class CompanyAddressesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public CompanyAddressesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/CompanyAddresses
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblCompanyAddresses>>> GetTblCompanyAddresses(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblCompanyAddresses>.CreateAsync(_context.TblCompanyAddresses.Include(x => x.AddressTypeNavigation), pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/CompanyAddresses/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCompanyAddresses>> GetTblCompanyAddresses(int id)
        {
            var tblCompanyAddresses = await _context.TblCompanyAddresses.FindAsync(id);

            if (tblCompanyAddresses == null)
            {
                return NotFound();
            }

            return tblCompanyAddresses;
        }

        // PUT: api/CompanyAddresses/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCompanyAddresses(int id, TblCompanyAddresses tblCompanyAddresses)
        {
            if (id != tblCompanyAddresses.AddressId)
            {
                return BadRequest();
            }

            _context.Entry(tblCompanyAddresses).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCompanyAddressesExists(id))
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

        // POST: api/CompanyAddresses
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCompanyAddresses>> PostTblCompanyAddresses(TblCompanyAddresses tblCompanyAddresses)
        {
            _context.TblCompanyAddresses.Add(tblCompanyAddresses);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCompanyAddresses", new { id = tblCompanyAddresses.AddressId }, tblCompanyAddresses);
        }

        // DELETE: api/CompanyAddresses/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCompanyAddresses>> DeleteTblCompanyAddresses(int id)
        {
            var tblCompanyAddresses = await _context.TblCompanyAddresses.FindAsync(id);
            if (tblCompanyAddresses == null)
            {
                return NotFound();
            }

            _context.TblCompanyAddresses.Remove(tblCompanyAddresses);
            await _context.SaveChangesAsync();

            return tblCompanyAddresses;
        }

        private bool TblCompanyAddressesExists(int id)
        {
            return _context.TblCompanyAddresses.Any(e => e.AddressId == id);
        }
    }
}
