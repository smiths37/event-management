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
    public class CountriesController : ControllerBase
    {
        private readonly MeetingTrakTestNEWContext _context;

        public CountriesController(MeetingTrakTestNEWContext context)
        {
            _context = context;
        }

        // GET: api/Countries
        [HttpGet]
        public async Task<ActionResult<ApiResult<TblCountries>>> GetTblCountries(int pageIndex = 0, int pageSize = 10, string sortColumn = null, string sortOrder = null, string filterColumn = null, string filterQuery = null)
        {
            return await ApiResult<TblCountries>.CreateAsync(_context.TblCountries, pageIndex, pageSize, sortColumn, sortOrder, filterColumn, filterQuery);
        }

        // GET: api/Countries/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TblCountries>> GetTblCountries(int id)
        {
            var tblCountries = await _context.TblCountries.FindAsync(id);

            if (tblCountries == null)
            {
                return NotFound();
            }

            return tblCountries;
        }

        // PUT: api/Countries/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTblCountries(int id, TblCountries tblCountries)
        {
            if (id != tblCountries.CountryId)
            {
                return BadRequest();
            }

            _context.Entry(tblCountries).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TblCountriesExists(id))
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

        // POST: api/Countries
        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://go.microsoft.com/fwlink/?linkid=2123754.
        [HttpPost]
        public async Task<ActionResult<TblCountries>> PostTblCountries(TblCountries tblCountries)
        {
            _context.TblCountries.Add(tblCountries);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetTblCountries", new { id = tblCountries.CountryId }, tblCountries);
        }

        // DELETE: api/Countries/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<TblCountries>> DeleteTblCountries(int id)
        {
            var tblCountries = await _context.TblCountries.FindAsync(id);
            if (tblCountries == null)
            {
                return NotFound();
            }

            _context.TblCountries.Remove(tblCountries);
            await _context.SaveChangesAsync();

            return tblCountries;
        }

        private bool TblCountriesExists(int id)
        {
            return _context.TblCountries.Any(e => e.CountryId == id);
        }
    }
}
